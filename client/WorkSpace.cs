using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;

namespace Whiteboard
{
    public partial class WorkSpace : Form
    {
        #region stuff
        public static bool isClose = new Boolean();
        public Color currentColor;
        public Bitmap canvas;
        public Graphics g;
        private Point lastPoint = Point.Empty;
        private bool isMouseDown = new Boolean();
        private List<Image> undoRedoList = new List<Image>();
        protected int counter = 0;
        private int size;
        public string _code;
        public string _name;
        public string _port = "9090";
        private int isSelect = 0; //1. Pen; 2.Eraser; 3. Fill Tool; 4. Resize workspace; 5. Draw rectangular; 6. Draw Ellipse; 7. Draw triangular
        
        Control draggedPictureBoxPaint = null;
        bool resizing = false;
        private Point startDraggingPoint;
        private Size startSize;
        Rectangle rectProposedSize = Rectangle.Empty;
        int resizingMargin = 5;
        bool isDragged = false; //control drag the object
        #endregion

        public WorkSpace()
        {
            InitializeComponent();
            canvas = new Bitmap(pictureBoxPaint.Width, pictureBoxPaint.Height);
            pictureBoxPaint.Image = canvas;
            g = Graphics.FromImage(pictureBoxPaint.Image);
            isClose = false;
            pictureBoxPaint.Size = new Size(1434, 799);
        }
        //Database
        #region Database
        public void funData(string str, string text, string port)
        {
            _code = str;
            _name = text;
            _port = port;
            Connect();
        }
        #endregion
        #region Mouse Controls/Pen Tool/Eraser Tool
        private void pictureBoxPaint_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastPoint = e.Location;        
            switch (isSelect)
            {
                case 4: //resize and move workspace
                    {
                        draggedPictureBoxPaint = sender as Control;

                        if ((e.X <= resizingMargin) || (e.X >= draggedPictureBoxPaint.Width - resizingMargin) ||
                            (e.Y <= resizingMargin) || (e.Y >= draggedPictureBoxPaint.Height - resizingMargin))
                        {
                            resizing = true;
                            this.Cursor = Cursors.SizeNWSE;
                            // indicate resizing
                            this.startSize = pictureBoxPaint.Size;
                            // get the location of the picture box
                            Point pt = this.PointToScreen(pictureBoxPaint.Location);
                            rectProposedSize = new Rectangle(pt, startSize);
                            // draw reversible frame
                            ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
                        }
                        else
                        {
                            resizing = false;
                            // indicate moving
                            this.Cursor = Cursors.SizeAll;
                        }                   
                        break;
                    }
                case 3: //Fill tool
                    {
                        Fill(canvas, e.Location, canvas.GetPixel(e.X, e.Y), currentColor);
                        break;
                    }
                case 5:
                case 6:
                    {
                        isDragged = false;
                        startSize = new Size(1, 1);
                        Point pt = new Point(MousePosition.X, MousePosition.Y);
                        rectProposedSize = new Rectangle(pt, startSize);
                        break;
                    }
                case 7:
                    {
                        isDragged = false;                        
                        break;
                    }
                default: return; break;
            }

            // start point location
            this.startDraggingPoint = e.Location;
        }

        private void pictureBoxPaint_MouseUp(object sender, MouseEventArgs e)
        {
            Point endP = new Point(Convert.ToInt32(e.X), Convert.ToInt32(e.Y));
            g.InterpolationMode = InterpolationMode.High;
            g.SmoothingMode = SmoothingMode.HighQuality;
            isMouseDown = false;
            switch (isSelect)
            {
                case 1:
                case 2:
                case 3:
                    {
                        lastPoint = e.Location;
                        Send();
                        break;
                    }
                case 4:
                    {
                        if (resizing)
                        {
                            if (rectProposedSize.Width > 0 && rectProposedSize.Height > 0)
                            {
                                // erase reversible frame
                                ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
                            }
                            // compare to min width and size ?
                            if (rectProposedSize.Width > 10 && rectProposedSize.Height > 10)
                            {
                                // set size 
                                this.draggedPictureBoxPaint.Size = rectProposedSize.Size;
                            }
                            else
                            {
                                // you might want to set some minimal size here
                                this.draggedPictureBoxPaint.Size = new Size((int)Math.Max(10, rectProposedSize.Width), Math.Max(10, rectProposedSize.Height));
                            }
                        }
                        this.pictureBoxPaint.ClientSize = draggedPictureBoxPaint.Size;
                        this.draggedPictureBoxPaint = null;
                        this.Cursor = Cursors.Default;
                        break;
                    }
                case 5:
                    {
                        isDragged = true;
                        g.DrawRectangle(new Pen(currentColor, size), new Rectangle(lastPoint.X, lastPoint.Y, endP.X - lastPoint.X, endP.Y - lastPoint.Y));
                        undoRedoList.Add(canvas);
                        
                        Send();
                        break;
                    }
                case 6:
                    {
                        isDragged = true;
                        g.DrawEllipse(new Pen(currentColor, size), new Rectangle(lastPoint.X, lastPoint.Y, endP.X - lastPoint.X, endP.Y - lastPoint.Y));
                        undoRedoList.Add(canvas);
                        
                        Send();
                        break;
                    }
                case 7:
                    {
                        isDragged = true;                     
                        g.DrawLine(new Pen(currentColor, size), lastPoint, endP);
                        undoRedoList.Add(canvas);
                        
                        Send();
                        break;
                    }
                default: return; break;
            }
            this.startDraggingPoint = Point.Empty;
            this.pictureBoxPaint.Invalidate();
        }

        private void pictureBoxPaint_MouseMove(object sender, MouseEventArgs e)
        {
            switch (isSelect)
            {
                case 1:
                    {
                        if (isMouseDown == true)
                        {
                            if (lastPoint != null)
                            {
                                Pen p = new Pen(currentColor, size);
                                g = Graphics.FromImage(pictureBoxPaint.Image);
                                g.SmoothingMode = SmoothingMode.AntiAlias;
                                p.StartCap = LineCap.Round;
                                p.EndCap = LineCap.Round;
                                g.DrawLine(p, lastPoint, e.Location);
                                lastPoint = e.Location;
                                p.Dispose();
                            }
                        }
                        break;
                    };
                case 2:
                    {
                        if (isMouseDown == true)
                        {
                            if (lastPoint != null)
                            {
                                Pen eraser = new Pen(Color.White, size + 2);
                                g.SmoothingMode = SmoothingMode.AntiAlias;
                                eraser.StartCap = LineCap.Square;
                                eraser.EndCap = LineCap.Square;
                                g.DrawLine(eraser, lastPoint, e.Location);
                                lastPoint = e.Location;
                                eraser.Dispose();
                            }
                        }
                        break;
                    }
                case 4: //Resize workspace
                    {
                        if (draggedPictureBoxPaint != null)
                        {
                            if (resizing)
                            {
                                // erase rect
                                if (rectProposedSize.Width > 0 && rectProposedSize.Height > 0)
                                    ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
                                // calculate rect new size
                                rectProposedSize.Width = e.X - this.startDraggingPoint.X + this.startSize.Width;
                                rectProposedSize.Height = e.Y - this.startDraggingPoint.Y + this.startSize.Height;
                                // draw rect
                                if (rectProposedSize.Width > 0 && rectProposedSize.Height > 0)
                                    ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);                      
                            }
                            else
                            {
                                Point pt;
                                if (draggedPictureBoxPaint == sender)
                                    pt = new Point(e.X, e.Y);
                                else
                                    pt = draggedPictureBoxPaint.PointToClient((sender as Control).PointToScreen(new Point(e.X, e.Y)));

                                draggedPictureBoxPaint.Left += pt.X - this.startDraggingPoint.X;
                                draggedPictureBoxPaint.Top += pt.Y - this.startDraggingPoint.Y;
                            }                           
                        }
                        break;
                    }
                case 5:
                case 6:
                    {
                        if (!isDragged && isMouseDown)
                        {
                            // erase rect
                            if (rectProposedSize.Width > 0 && rectProposedSize.Height > 0)
                                ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
                            // calculate rect new size
                            rectProposedSize.Width = e.X - this.startDraggingPoint.X + this.startSize.Width;
                            rectProposedSize.Height = e.Y - this.startDraggingPoint.Y + this.startSize.Height;
                            // draw rect
                            if (rectProposedSize.Width > 0 && rectProposedSize.Height > 0)
                                ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
                        }
                        break;
                    }              
                default: break;
            }
            pictureBoxPaint.Refresh();
        }
        #endregion
        //All tool
        #region Tool
        //Pen Click and Eraser Click
        #region Pen/Eraser
        private void penButton_Click(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(GetType(), "pencil.cur");
            this.Cursor = Cursor.Current;
            isSelect = 1;
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(GetType(), "pencil.cur");
            this.Cursor = Cursor.Current;
            isSelect = 2;
        }
        #endregion
        //Size Tool
        #region Size Tool
        private void sizeButton_Click(object sender, EventArgs e)
        {
            if (panelSize.Visible == false)
            {
                if (panelShape.Visible || panelColor.Visible)
                {
                    panelShape.Visible = false;
                    panelColor.Visible = false;
                }
                panelSize.Visible = true;
                //grow left panel (menu tool panel)
                panelTool.Size = panelTool.MinimumSize;
                panelTool.Width += 22;
            }
            else
            {
                panelSize.Visible = false;
                //shrink the left panel (menu tool panel)
                panelTool.Size = panelTool.MinimumSize;
            }
        }
        private void size1_Click(object sender, EventArgs e)
        {
            panelSize.Visible = false;
            panelTool.Size = panelTool.MinimumSize;
            size = 2;
        }
        private void size2_Click(object sender, EventArgs e)
        {
            panelSize.Visible = false;
            panelTool.Size = panelTool.MinimumSize;
            size = 5;
        }
        private void size3_Click(object sender, EventArgs e)
        {
            panelSize.Visible = false;
            panelTool.Size = panelTool.MinimumSize;
            size = 8;
        }
        private void size4_Click(object sender, EventArgs e)
        {
            panelSize.Visible = false;
            panelTool.Size = panelTool.MinimumSize;
            size = 11;
        }
        #endregion
        //Save Image Tool
        #region Save Image
        private void saveImage_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.Cursor = Cursor.Current;
            captureScreen();
        }
        //saveImage by tool box menu item with shortcut key
        private void saveImageMI_Click(object sender, EventArgs e)
        {
            captureScreen();
        }

        private void captureScreen()
        {
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = "JPEG Files | *.jpg";
            sfDialog.DefaultExt = "jpg";
            try
            {
                if (sfDialog.ShowDialog() == DialogResult.OK)
                {                   
                    Bitmap bmp = new Bitmap(pictureBoxPaint.Width, pictureBoxPaint.Height);
                    Rectangle rect = new Rectangle(0, 0, pictureBoxPaint.Width, pictureBoxPaint.Height);
                    pictureBoxPaint.DrawToBitmap(bmp, rect);
                    bmp.Save(sfDialog.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("Save done!", "Message", MessageBoxButtons.OK);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }
        #endregion
        //Import Picture Tool     
        #region Import Picture
        List<CustomPictureBox> picList = new List<CustomPictureBox>();
        private void importPicture_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            CustomPictureBox picture = new CustomPictureBox();
            picture.loadPicture();
            if (CustomPictureBox.isImported == true)
            {
                picList.Add(picture);
                pictureBoxPaint.Controls.Add(picture);
                pictureBoxPaint.Invalidate();
                Send();
            }                     
        }
        //Delete
        private void WorkSpace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                picList[picList.Count - 1].Dispose();
                picList.Remove(picList[picList.Count - 1]);
            }
        }
        #endregion        
        //Shape Tool
        #region Shape Tool
        private void shape_Click(object sender, EventArgs e)
        {
            if (panelShape.Visible == false)
            {
                if (panelSize.Visible || panelColor.Visible)
                {
                    panelSize.Visible = false;
                    panelColor.Visible = false;
                }
                panelShape.Visible = true;
                //grow left panel (menu tool panel)
                panelTool.Size = panelTool.MinimumSize;
                panelTool.Width += 22;
            }
            else
            {
                panelShape.Visible = false;
                //shrink left panel (menu tool panel)
                panelTool.Size = panelTool.MinimumSize;
            }
        }
        private void recangle_Click(object sender, EventArgs e)
        {
            //shrink the panel size
            panelShape.Visible = false;
            panelTool.Size = panelTool.MinimumSize;
            isSelect = 5;
        }
        private void triangle_Click(object sender, EventArgs e)
        {
            //shrink the panel size
            isSelect = 7;
            panelShape.Visible = false;
            panelTool.Size = panelTool.MinimumSize;
        }
        private void circle_Click(object sender, EventArgs e)
        {
            isSelect = 6;
            //shrink the panel size
            panelShape.Visible = false;
            panelTool.Size = panelTool.MinimumSize;
        }
        #endregion
        //Fill Tool
        #region Fill Tool
        private void fillButton_Click(object sender, EventArgs e)
        {
            isSelect = 3;
            this.Cursor = new Cursor(GetType(), "fill.cur");
            this.Cursor = Cursor.Current;
            pictureBoxPaint.Refresh();
        }
        private void Fill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            Stack<Point> pixels = new Stack<Point>();
            targetColor = bmp.GetPixel(pt.X, pt.Y);
            int y1;
            bool spanLeft, spanRight;
            pixels.Push(pt);
            while (pixels.Count != 0)
            {
                Point temp = pixels.Pop();
                y1 = temp.Y;
                while (y1 > 0 && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    y1--;
                }
                y1++;
                spanLeft = false;
                spanRight = false;
                while (y1 < bmp.Height && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    bmp.SetPixel(temp.X, y1, replacementColor);

                    if (!spanLeft && temp.X > 0 && bmp.GetPixel(temp.X - 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X - 1, y1));
                        spanLeft = true;
                    }
                    else if (spanLeft && temp.X - 1 == 0 && bmp.GetPixel(temp.X - 1, y1) != targetColor)
                    {
                        spanLeft = false;
                    }
                    if (!spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X + 1, y1));
                        spanRight = true;
                    }
                    else if (spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) != targetColor)
                    {
                        spanRight = false;
                    }
                    y1++;
                }
            }
            Send();
        }
        #endregion  
        //Color Button
        #region Color
        private void colorButton_Click(object sender, EventArgs e)
        {
            if (panelColor.Visible == false)
            {
                if (panelSize.Visible || panelShape.Visible)
                {
                    panelSize.Visible = false;
                    panelShape.Visible = false;
                }
                panelColor.Visible = true;
                //grow left panel (menu tool panel)
                panelTool.Size = panelTool.MinimumSize;
                panelTool.Width += 54;
            }
            else
            {
                panelColor.Visible = false;
                //shrink left panel (menu tool panel)
                panelTool.Size = panelTool.MinimumSize;
            }
        }
        private void labelMoreColor_Click(object sender, EventArgs e)
        {
            ColorDialog cdl = new ColorDialog();
            cdl.AllowFullOpen = true;
            cdl.AnyColor = true;
            cdl.SolidColorOnly = true;
            cdl.Color = Color.Black;
            if (cdl.ShowDialog() == DialogResult.OK)
            {
                Button b = new Button();
                b.BackColor = cdl.Color;
                colorSelect(b);
            }
        }
        private void colorSelect(Button b)
        {
            currentColor = b.BackColor;
            colorButton.BackColor = currentColor;
            panelColor.Visible = false;
            panelTool.Size = panelTool.MinimumSize;
        }
        private void colorRed_Click(object sender, EventArgs e)
        {
            colorSelect(colorRed);
        }
        private void colorOrange_Click(object sender, EventArgs e)
        {
            colorSelect(colorOrange);
        }
        private void colorYellow_Click(object sender, EventArgs e)
        {
            colorSelect(colorYellow);
        }
        private void colorBlue_Click(object sender, EventArgs e)
        {
            colorSelect(colorBlue);
        }
        private void colorGreen_Click(object sender, EventArgs e)
        {
            colorSelect(colorGreen);
        }
        private void colorPurple_Click(object sender, EventArgs e)
        {
            colorSelect(colorPurple);
        }
        private void colorPink_Click(object sender, EventArgs e)
        {
            colorSelect(colorPink);
        }
        private void colorWhite_Click(object sender, EventArgs e)
        {
            colorSelect(colorWhite);
        }
        private void colorBlack_Click(object sender, EventArgs e)
        {
            colorSelect(colorBlack);
        }
        #endregion
        //Tool Strip Menu Items (CleanBoard, About)
        #region Tool Strip Menu Items
        private void cleanBoard_Click(object sender, EventArgs e)
        {
            MessageBoxButtons bt = MessageBoxButtons.OKCancel;
            DialogResult rs = MessageBox.Show("Clean the board?", "Message", bt, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                g.Clear(Color.White);
                foreach(CustomPictureBox i in picList)
                {
                    i.Dispose();
                }
                picList.Clear();
                Send();
            }          
        }

        private void editWS_Click(object sender, EventArgs e)
        {
            isSelect = 4;
            this.Cursor = Cursors.SizeAll;
            this.Cursor = Cursor.Current;
        }

        private void about_Click(object sender, EventArgs e)
        {
            string message = "Project 'REAL TIME COLLABORATION BOARD'\nThis product is made by 54010N team\n";
            MessageBox.Show(message, "About product", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        //Quit Button
        #endregion
        //LAN Connection - THis is base on Server Code
        #region Connect LAN
        IPEndPoint IP;
        Socket Client;

        void Connect()
        {
            //IP: server address
            int Port = Int32.Parse(_port);
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"),Port);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                Client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Can't connect", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                return;
            }

            Thread listener = new Thread(Receive);
            listener.IsBackground = true;
            listener.Start();
        }
        void Send()
        {
            Client.Send(Serialize(pictureBoxPaint.Image));
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    Client.Receive(data);

                    Image x = (Image)Deserialize(data);
                    ShowImage(x);
                }
            }
            catch
            {
                
            }
        }
        void ShowImage(Image x)
        {
            pictureBoxPaint.Image = x;
            undoRedoList.Add(pictureBoxPaint.Image);
            g = Graphics.FromImage(pictureBoxPaint.Image);
        }
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatterr = new BinaryFormatter();
            formatterr.Serialize(stream, obj);
            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatterr = new BinaryFormatter();

            return formatterr.Deserialize(stream);
        }
        #endregion        
        //WorkSpace_Load
        private void WorkSpace_Load(object sender, EventArgs e)
        {
            currentColor = Color.Black; //default color
            code.Text = _code;
            nickname.Text = _name;
            code.TextAlign = HorizontalAlignment.Center;
            nickname.TextAlign = ContentAlignment.MiddleCenter;
        }
        //exit a program
        #region exit
        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkSpace_FormClosing(object sender, FormClosingEventArgs e)
        {
            string content, title;
            content = "Disconnect and leave the room?";
            title = "Message";
            MessageBoxButtons quitButton = MessageBoxButtons.YesNo;
            DialogResult quit = MessageBox.Show(content, title, quitButton, MessageBoxIcon.Question);
            if (quit == DialogResult.No) e.Cancel = true;
            else
            {
                Client.Close();
                isClose = true;
            }
        }
        #endregion //exit the program //exit 
        
    }
}

