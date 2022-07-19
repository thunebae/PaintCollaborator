using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whiteboard
{
    public class CustomPictureBox : PictureBox
    {
        //Set up mấy cái thuộc tính
        public CustomPictureBox()
        {
            this.Name = "pictureBox";
            this.Location = new Point(0, 0);
            this.Size = new Size(250, 250);
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public CustomPictureBox(IContainer container)
        {
            container.Add(this);
        }

        public static bool isImported = false;
        //Chỗ này là load picture
        public void loadPicture()
        {
            string imageL = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)|*.jpg";
                dialog.Title = "Import image";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    isImported = true;
                    imageL = dialog.FileName;
                    this.ImageLocation = imageL;
                    this.BringToFront();
                }
                else return;
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose *.jpg file!");
            }
        }

        Point point;
        //Move picture
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            point = e.Location;
            this.BringToFront();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }
    }
}
