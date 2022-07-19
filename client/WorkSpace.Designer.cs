
namespace Whiteboard
{
    partial class WorkSpace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkSpace));
            this.panelShape = new System.Windows.Forms.Panel();
            this.circle = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.recangle = new System.Windows.Forms.Button();
            this.shape = new System.Windows.Forms.Button();
            this.sizeButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            this.penButton = new System.Windows.Forms.Button();
            this.importPicture = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.panelTool = new System.Windows.Forms.Panel();
            this.colorButton = new System.Windows.Forms.Button();
            this.fillButton = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelMoreColor = new System.Windows.Forms.Label();
            this.colorWhite = new System.Windows.Forms.Button();
            this.colorBlack = new System.Windows.Forms.Button();
            this.colorPurple = new System.Windows.Forms.Button();
            this.colorGreen = new System.Windows.Forms.Button();
            this.colorBlue = new System.Windows.Forms.Button();
            this.colorPink = new System.Windows.Forms.Button();
            this.colorYellow = new System.Windows.Forms.Button();
            this.colorOrange = new System.Windows.Forms.Button();
            this.colorRed = new System.Windows.Forms.Button();
            this.panelSize = new System.Windows.Forms.Panel();
            this.size4 = new System.Windows.Forms.Button();
            this.size3 = new System.Windows.Forms.Button();
            this.size2 = new System.Windows.Forms.Button();
            this.size1 = new System.Windows.Forms.Button();
            this.tablePanelCode = new System.Windows.Forms.TableLayoutPanel();
            this.labelNickname = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.nickname = new System.Windows.Forms.Label();
            this.panelCopyright = new System.Windows.Forms.Panel();
            this.cleanBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.editWS = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxPaint = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panelShape.SuspendLayout();
            this.panelTool.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.panelSize.SuspendLayout();
            this.tablePanelCode.SuspendLayout();
            this.panelCopyright.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).BeginInit();
            this.SuspendLayout();
            // 
            // panelShape
            // 
            this.panelShape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelShape.Controls.Add(this.circle);
            this.panelShape.Controls.Add(this.triangle);
            this.panelShape.Controls.Add(this.recangle);
            this.panelShape.Location = new System.Drawing.Point(93, 211);
            this.panelShape.Margin = new System.Windows.Forms.Padding(2);
            this.panelShape.Name = "panelShape";
            this.panelShape.Size = new System.Drawing.Size(50, 147);
            this.panelShape.TabIndex = 11;
            this.panelShape.Visible = false;
            // 
            // circle
            // 
            this.circle.BackgroundImage = global::Whiteboard.Properties.Resources.circle;
            this.circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circle.ForeColor = System.Drawing.Color.Black;
            this.circle.Location = new System.Drawing.Point(0, 101);
            this.circle.Margin = new System.Windows.Forms.Padding(2);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(46, 46);
            this.circle.TabIndex = 11;
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // triangle
            // 
            this.triangle.BackgroundImage = global::Whiteboard.Properties.Resources.size3;
            this.triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.triangle.ForeColor = System.Drawing.Color.Black;
            this.triangle.Location = new System.Drawing.Point(0, 1);
            this.triangle.Margin = new System.Windows.Forms.Padding(2);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(46, 46);
            this.triangle.TabIndex = 10;
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // recangle
            // 
            this.recangle.BackgroundImage = global::Whiteboard.Properties.Resources.rec;
            this.recangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.recangle.ForeColor = System.Drawing.Color.Black;
            this.recangle.Location = new System.Drawing.Point(0, 50);
            this.recangle.Name = "recangle";
            this.recangle.Size = new System.Drawing.Size(46, 46);
            this.recangle.TabIndex = 9;
            this.recangle.UseVisualStyleBackColor = true;
            this.recangle.Click += new System.EventHandler(this.recangle_Click);
            // 
            // shape
            // 
            this.shape.BackgroundImage = global::Whiteboard.Properties.Resources.shapes;
            this.shape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.shape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shape.Location = new System.Drawing.Point(39, 259);
            this.shape.Margin = new System.Windows.Forms.Padding(2);
            this.shape.Name = "shape";
            this.shape.Size = new System.Drawing.Size(50, 50);
            this.shape.TabIndex = 8;
            this.shape.UseVisualStyleBackColor = true;
            this.shape.Click += new System.EventHandler(this.shape_Click);
            // 
            // sizeButton
            // 
            this.sizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sizeButton.ForeColor = System.Drawing.Color.Black;
            this.sizeButton.Image = global::Whiteboard.Properties.Resources.size;
            this.sizeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sizeButton.Location = new System.Drawing.Point(39, 205);
            this.sizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.sizeButton.Name = "sizeButton";
            this.sizeButton.Size = new System.Drawing.Size(50, 50);
            this.sizeButton.TabIndex = 3;
            this.sizeButton.Text = "Size";
            this.sizeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sizeButton.UseVisualStyleBackColor = true;
            this.sizeButton.Click += new System.EventHandler(this.sizeButton_Click);
            // 
            // eraserButton
            // 
            this.eraserButton.BackgroundImage = global::Whiteboard.Properties.Resources.eraser;
            this.eraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.eraserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraserButton.Location = new System.Drawing.Point(39, 151);
            this.eraserButton.Margin = new System.Windows.Forms.Padding(2);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(50, 50);
            this.eraserButton.TabIndex = 2;
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // saveImage
            // 
            this.saveImage.AllowDrop = true;
            this.saveImage.AutoSize = true;
            this.saveImage.BackgroundImage = global::Whiteboard.Properties.Resources.save;
            this.saveImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveImage.ForeColor = System.Drawing.SystemColors.Control;
            this.saveImage.Location = new System.Drawing.Point(38, 423);
            this.saveImage.Margin = new System.Windows.Forms.Padding(2);
            this.saveImage.MinimumSize = new System.Drawing.Size(38, 38);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(50, 50);
            this.saveImage.TabIndex = 14;
            this.saveImage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // penButton
            // 
            this.penButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.penButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.penButton.Image = global::Whiteboard.Properties.Resources.pencil;
            this.penButton.Location = new System.Drawing.Point(39, 97);
            this.penButton.Margin = new System.Windows.Forms.Padding(2);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(50, 50);
            this.penButton.TabIndex = 1;
            this.penButton.UseVisualStyleBackColor = true;
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // importPicture
            // 
            this.importPicture.BackgroundImage = global::Whiteboard.Properties.Resources.picture;
            this.importPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.importPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importPicture.Location = new System.Drawing.Point(38, 369);
            this.importPicture.Margin = new System.Windows.Forms.Padding(2);
            this.importPicture.Name = "importPicture";
            this.importPicture.Size = new System.Drawing.Size(50, 50);
            this.importPicture.TabIndex = 13;
            this.importPicture.UseVisualStyleBackColor = true;
            this.importPicture.Click += new System.EventHandler(this.importPicture_Click);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quitButton.BackColor = System.Drawing.SystemColors.Control;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.quitButton.Image = global::Whiteboard.Properties.Resources.quit;
            this.quitButton.Location = new System.Drawing.Point(26, 927);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(72, 71);
            this.quitButton.TabIndex = 17;
            this.quitButton.Text = "Quit";
            this.quitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.quitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // labelCopyright
            // 
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCopyright.Location = new System.Drawing.Point(0, 0);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(124, 22);
            this.labelCopyright.TabIndex = 7;
            this.labelCopyright.Text = "Made by 54010n";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTool
            // 
            this.panelTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelTool.Controls.Add(this.colorButton);
            this.panelTool.Controls.Add(this.fillButton);
            this.panelTool.Controls.Add(this.panelShape);
            this.panelTool.Controls.Add(this.panelColor);
            this.panelTool.Controls.Add(this.panelSize);
            this.panelTool.Controls.Add(this.tablePanelCode);
            this.panelTool.Controls.Add(this.panelCopyright);
            this.panelTool.Controls.Add(this.importPicture);
            this.panelTool.Controls.Add(this.quitButton);
            this.panelTool.Controls.Add(this.penButton);
            this.panelTool.Controls.Add(this.eraserButton);
            this.panelTool.Controls.Add(this.sizeButton);
            this.panelTool.Controls.Add(this.shape);
            this.panelTool.Controls.Add(this.saveImage);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.Margin = new System.Windows.Forms.Padding(2);
            this.panelTool.MinimumSize = new System.Drawing.Size(124, 853);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(124, 1042);
            this.panelTool.TabIndex = 13;
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.White;
            this.colorButton.BackgroundImage = global::Whiteboard.Properties.Resources.color;
            this.colorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.colorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton.Location = new System.Drawing.Point(38, 478);
            this.colorButton.Margin = new System.Windows.Forms.Padding(0);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(51, 50);
            this.colorButton.TabIndex = 15;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // fillButton
            // 
            this.fillButton.BackgroundImage = global::Whiteboard.Properties.Resources.fill;
            this.fillButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fillButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fillButton.Location = new System.Drawing.Point(38, 314);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(50, 50);
            this.fillButton.TabIndex = 12;
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelColor.Controls.Add(this.labelMoreColor);
            this.panelColor.Controls.Add(this.colorWhite);
            this.panelColor.Controls.Add(this.colorBlack);
            this.panelColor.Controls.Add(this.colorPurple);
            this.panelColor.Controls.Add(this.colorGreen);
            this.panelColor.Controls.Add(this.colorBlue);
            this.panelColor.Controls.Add(this.colorPink);
            this.panelColor.Controls.Add(this.colorYellow);
            this.panelColor.Controls.Add(this.colorOrange);
            this.panelColor.Controls.Add(this.colorRed);
            this.panelColor.Location = new System.Drawing.Point(94, 451);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(81, 106);
            this.panelColor.TabIndex = 16;
            this.panelColor.Visible = false;
            // 
            // labelMoreColor
            // 
            this.labelMoreColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMoreColor.Location = new System.Drawing.Point(0, 81);
            this.labelMoreColor.Name = "labelMoreColor";
            this.labelMoreColor.Size = new System.Drawing.Size(78, 21);
            this.labelMoreColor.TabIndex = 16;
            this.labelMoreColor.Text = "More...";
            this.labelMoreColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMoreColor.Click += new System.EventHandler(this.labelMoreColor_Click);
            // 
            // colorWhite
            // 
            this.colorWhite.BackColor = System.Drawing.Color.White;
            this.colorWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorWhite.ForeColor = System.Drawing.Color.Red;
            this.colorWhite.Location = new System.Drawing.Point(28, 55);
            this.colorWhite.Name = "colorWhite";
            this.colorWhite.Size = new System.Drawing.Size(25, 25);
            this.colorWhite.TabIndex = 15;
            this.colorWhite.UseCompatibleTextRendering = true;
            this.colorWhite.UseVisualStyleBackColor = false;
            this.colorWhite.Click += new System.EventHandler(this.colorWhite_Click);
            // 
            // colorBlack
            // 
            this.colorBlack.BackColor = System.Drawing.Color.Black;
            this.colorBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBlack.ForeColor = System.Drawing.Color.Red;
            this.colorBlack.Location = new System.Drawing.Point(53, 55);
            this.colorBlack.Name = "colorBlack";
            this.colorBlack.Size = new System.Drawing.Size(25, 25);
            this.colorBlack.TabIndex = 15;
            this.colorBlack.UseCompatibleTextRendering = true;
            this.colorBlack.UseVisualStyleBackColor = false;
            this.colorBlack.Click += new System.EventHandler(this.colorBlack_Click);
            // 
            // colorPurple
            // 
            this.colorPurple.BackColor = System.Drawing.Color.Purple;
            this.colorPurple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPurple.ForeColor = System.Drawing.Color.Red;
            this.colorPurple.Location = new System.Drawing.Point(53, 30);
            this.colorPurple.Name = "colorPurple";
            this.colorPurple.Size = new System.Drawing.Size(25, 25);
            this.colorPurple.TabIndex = 15;
            this.colorPurple.UseCompatibleTextRendering = true;
            this.colorPurple.UseVisualStyleBackColor = false;
            this.colorPurple.Click += new System.EventHandler(this.colorPurple_Click);
            // 
            // colorGreen
            // 
            this.colorGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.colorGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorGreen.ForeColor = System.Drawing.Color.Red;
            this.colorGreen.Location = new System.Drawing.Point(28, 30);
            this.colorGreen.Name = "colorGreen";
            this.colorGreen.Size = new System.Drawing.Size(25, 25);
            this.colorGreen.TabIndex = 15;
            this.colorGreen.UseCompatibleTextRendering = true;
            this.colorGreen.UseVisualStyleBackColor = false;
            this.colorGreen.Click += new System.EventHandler(this.colorGreen_Click);
            // 
            // colorBlue
            // 
            this.colorBlue.BackColor = System.Drawing.SystemColors.Highlight;
            this.colorBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBlue.ForeColor = System.Drawing.Color.Red;
            this.colorBlue.Location = new System.Drawing.Point(3, 30);
            this.colorBlue.Name = "colorBlue";
            this.colorBlue.Size = new System.Drawing.Size(25, 25);
            this.colorBlue.TabIndex = 15;
            this.colorBlue.UseCompatibleTextRendering = true;
            this.colorBlue.UseVisualStyleBackColor = false;
            this.colorBlue.Click += new System.EventHandler(this.colorBlue_Click);
            // 
            // colorPink
            // 
            this.colorPink.BackColor = System.Drawing.Color.Violet;
            this.colorPink.Location = new System.Drawing.Point(3, 55);
            this.colorPink.Margin = new System.Windows.Forms.Padding(2);
            this.colorPink.Name = "colorPink";
            this.colorPink.Size = new System.Drawing.Size(25, 25);
            this.colorPink.TabIndex = 15;
            this.colorPink.UseCompatibleTextRendering = true;
            this.colorPink.UseVisualStyleBackColor = false;
            this.colorPink.Click += new System.EventHandler(this.colorPink_Click);
            // 
            // colorYellow
            // 
            this.colorYellow.BackColor = System.Drawing.Color.Yellow;
            this.colorYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorYellow.ForeColor = System.Drawing.Color.Red;
            this.colorYellow.Location = new System.Drawing.Point(53, 5);
            this.colorYellow.Name = "colorYellow";
            this.colorYellow.Size = new System.Drawing.Size(25, 25);
            this.colorYellow.TabIndex = 15;
            this.colorYellow.UseCompatibleTextRendering = true;
            this.colorYellow.UseVisualStyleBackColor = false;
            this.colorYellow.Click += new System.EventHandler(this.colorYellow_Click);
            // 
            // colorOrange
            // 
            this.colorOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorOrange.ForeColor = System.Drawing.Color.Red;
            this.colorOrange.Location = new System.Drawing.Point(28, 5);
            this.colorOrange.Name = "colorOrange";
            this.colorOrange.Size = new System.Drawing.Size(25, 25);
            this.colorOrange.TabIndex = 15;
            this.colorOrange.UseCompatibleTextRendering = true;
            this.colorOrange.UseVisualStyleBackColor = false;
            this.colorOrange.Click += new System.EventHandler(this.colorOrange_Click);
            // 
            // colorRed
            // 
            this.colorRed.BackColor = System.Drawing.Color.Red;
            this.colorRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorRed.ForeColor = System.Drawing.Color.Red;
            this.colorRed.Location = new System.Drawing.Point(3, 5);
            this.colorRed.Name = "colorRed";
            this.colorRed.Size = new System.Drawing.Size(25, 25);
            this.colorRed.TabIndex = 15;
            this.colorRed.UseCompatibleTextRendering = true;
            this.colorRed.UseVisualStyleBackColor = false;
            this.colorRed.Click += new System.EventHandler(this.colorRed_Click);
            // 
            // panelSize
            // 
            this.panelSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelSize.Controls.Add(this.size4);
            this.panelSize.Controls.Add(this.size3);
            this.panelSize.Controls.Add(this.size2);
            this.panelSize.Controls.Add(this.size1);
            this.panelSize.Location = new System.Drawing.Point(94, 196);
            this.panelSize.MinimumSize = new System.Drawing.Size(46, 68);
            this.panelSize.Name = "panelSize";
            this.panelSize.Size = new System.Drawing.Size(48, 68);
            this.panelSize.TabIndex = 16;
            this.panelSize.Visible = false;
            // 
            // size4
            // 
            this.size4.BackgroundImage = global::Whiteboard.Properties.Resources.size4;
            this.size4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.size4.ForeColor = System.Drawing.Color.Black;
            this.size4.Location = new System.Drawing.Point(0, 51);
            this.size4.Name = "size4";
            this.size4.Size = new System.Drawing.Size(44, 17);
            this.size4.TabIndex = 4;
            this.size4.UseVisualStyleBackColor = true;
            this.size4.Click += new System.EventHandler(this.size4_Click);
            // 
            // size3
            // 
            this.size3.BackgroundImage = global::Whiteboard.Properties.Resources.size3;
            this.size3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.size3.ForeColor = System.Drawing.Color.Black;
            this.size3.Location = new System.Drawing.Point(0, 34);
            this.size3.Name = "size3";
            this.size3.Size = new System.Drawing.Size(44, 17);
            this.size3.TabIndex = 6;
            this.size3.UseVisualStyleBackColor = true;
            this.size3.Click += new System.EventHandler(this.size3_Click);
            // 
            // size2
            // 
            this.size2.BackgroundImage = global::Whiteboard.Properties.Resources.size2;
            this.size2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.size2.ForeColor = System.Drawing.Color.Black;
            this.size2.Location = new System.Drawing.Point(0, 17);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(44, 17);
            this.size2.TabIndex = 5;
            this.size2.UseVisualStyleBackColor = true;
            this.size2.Click += new System.EventHandler(this.size2_Click);
            // 
            // size1
            // 
            this.size1.BackgroundImage = global::Whiteboard.Properties.Resources.size1;
            this.size1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.size1.ForeColor = System.Drawing.Color.Black;
            this.size1.Location = new System.Drawing.Point(0, 0);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(44, 17);
            this.size1.TabIndex = 4;
            this.size1.UseVisualStyleBackColor = true;
            this.size1.Click += new System.EventHandler(this.size1_Click);
            // 
            // tablePanelCode
            // 
            this.tablePanelCode.ColumnCount = 1;
            this.tablePanelCode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tablePanelCode.Controls.Add(this.labelNickname, 0, 2);
            this.tablePanelCode.Controls.Add(this.labelCode, 0, 0);
            this.tablePanelCode.Controls.Add(this.code, 0, 1);
            this.tablePanelCode.Controls.Add(this.nickname, 0, 3);
            this.tablePanelCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelCode.Location = new System.Drawing.Point(0, 0);
            this.tablePanelCode.Margin = new System.Windows.Forms.Padding(2);
            this.tablePanelCode.Name = "tablePanelCode";
            this.tablePanelCode.Padding = new System.Windows.Forms.Padding(6);
            this.tablePanelCode.RowCount = 4;
            this.tablePanelCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelCode.Size = new System.Drawing.Size(124, 93);
            this.tablePanelCode.TabIndex = 15;
            // 
            // labelNickname
            // 
            this.labelNickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNickname.AutoSize = true;
            this.labelNickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.labelNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNickname.Location = new System.Drawing.Point(9, 47);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(106, 18);
            this.labelNickname.TabIndex = 0;
            this.labelNickname.Text = "&Nickname";
            this.labelNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCode
            // 
            this.labelCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCode.AutoSize = true;
            this.labelCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCode.Location = new System.Drawing.Point(9, 7);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(106, 18);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "&Code";
            this.labelCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.code.HideSelection = false;
            this.code.Location = new System.Drawing.Point(9, 29);
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Size = new System.Drawing.Size(106, 17);
            this.code.TabIndex = 0;
            this.code.TabStop = false;
            this.code.Text = "#code#";
            this.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nickname
            // 
            this.nickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nickname.AutoEllipsis = true;
            this.nickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nickname.Location = new System.Drawing.Point(9, 67);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(106, 18);
            this.nickname.TabIndex = 2;
            this.nickname.Text = "#nickne#";
            this.nickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCopyright
            // 
            this.panelCopyright.Controls.Add(this.labelCopyright);
            this.panelCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCopyright.Location = new System.Drawing.Point(0, 1020);
            this.panelCopyright.Margin = new System.Windows.Forms.Padding(2);
            this.panelCopyright.Name = "panelCopyright";
            this.panelCopyright.Size = new System.Drawing.Size(124, 22);
            this.panelCopyright.TabIndex = 15;
            // 
            // cleanBoard
            // 
            this.cleanBoard.Name = "cleanBoard";
            this.cleanBoard.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.cleanBoard.Size = new System.Drawing.Size(104, 24);
            this.cleanBoard.Text = "Clean Board";
            this.cleanBoard.Click += new System.EventHandler(this.cleanBoard_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(64, 24);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanBoard,
            this.editWS,
            this.about,
            this.saveImageMI,
            this.exit});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip.Location = new System.Drawing.Point(124, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(2012, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // editWS
            // 
            this.editWS.Name = "editWS";
            this.editWS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.editWS.Size = new System.Drawing.Size(125, 24);
            this.editWS.Text = "Edit Workspace";
            this.editWS.Click += new System.EventHandler(this.editWS_Click);
            // 
            // saveImageMI
            // 
            this.saveImageMI.Name = "saveImageMI";
            this.saveImageMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveImageMI.Size = new System.Drawing.Size(14, 4);
            this.saveImageMI.Visible = false;
            this.saveImageMI.Click += new System.EventHandler(this.saveImageMI_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit.Size = new System.Drawing.Size(14, 4);
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBoxPaint
            // 
            this.pictureBoxPaint.BackColor = System.Drawing.Color.White;
            this.pictureBoxPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPaint.Location = new System.Drawing.Point(136, 42);
            this.pictureBoxPaint.Name = "pictureBoxPaint";
            this.pictureBoxPaint.Size = new System.Drawing.Size(2000, 1000);
            this.pictureBoxPaint.TabIndex = 14;
            this.pictureBoxPaint.TabStop = false;
            this.pictureBoxPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseDown);
            this.pictureBoxPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseMove);
            this.pictureBoxPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseUp);
            // 
            // WorkSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panelTool);
            this.Controls.Add(this.pictureBoxPaint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "WorkSpace";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Whiteboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkSpace_FormClosing);
            this.Load += new System.EventHandler(this.WorkSpace_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WorkSpace_KeyDown);
            this.panelShape.ResumeLayout(false);
            this.panelTool.ResumeLayout(false);
            this.panelTool.PerformLayout();
            this.panelColor.ResumeLayout(false);
            this.panelSize.ResumeLayout(false);
            this.tablePanelCode.ResumeLayout(false);
            this.tablePanelCode.PerformLayout();
            this.panelCopyright.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button shape;
        private System.Windows.Forms.Button importPicture;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button sizeButton;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button penButton;
        private System.Windows.Forms.Panel panelShape;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button recangle;
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.TableLayoutPanel tablePanelCode;
        private System.Windows.Forms.Panel panelSize;
        private System.Windows.Forms.Button size4;
        private System.Windows.Forms.Button size3;
        private System.Windows.Forms.Button size2;
        private System.Windows.Forms.Button size1;
        private System.Windows.Forms.Panel panelCopyright;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button colorWhite;
        private System.Windows.Forms.Button colorBlack;
        private System.Windows.Forms.Button colorPurple;
        private System.Windows.Forms.Button colorGreen;
        private System.Windows.Forms.Button colorBlue;
        private System.Windows.Forms.Button colorPink;
        private System.Windows.Forms.Button colorYellow;
        private System.Windows.Forms.Button colorOrange;
        private System.Windows.Forms.Button colorRed;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.Label nickname;
        public System.Windows.Forms.ToolStripMenuItem cleanBoard;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.PictureBox pictureBoxPaint;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label labelMoreColor;
        private System.Windows.Forms.ToolStripMenuItem editWS;
        private System.Windows.Forms.ToolStripMenuItem saveImageMI;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.TextBox code;
    }
}