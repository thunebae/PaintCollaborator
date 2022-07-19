
namespace Whiteboard
{
    partial class Create
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
            this.nickname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createARoom = new Whiteboard.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // nickname
            // 
            this.nickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nickname.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nickname.Location = new System.Drawing.Point(444, 393);
            this.nickname.Name = "nickname";
            this.nickname.PlaceholderText = "nickname";
            this.nickname.Size = new System.Drawing.Size(345, 28);
            this.nickname.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Whiteboard.Properties.Resources.Whiteboard_Background;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1176, 786);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // createARoom
            // 
            this.createARoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createARoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.createARoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.createARoom.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.createARoom.BorderRadius = 40;
            this.createARoom.BorderSize = 0;
            this.createARoom.FlatAppearance.BorderSize = 0;
            this.createARoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createARoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createARoom.ForeColor = System.Drawing.Color.White;
            this.createARoom.Location = new System.Drawing.Point(488, 468);
            this.createARoom.Name = "createARoom";
            this.createARoom.Size = new System.Drawing.Size(228, 79);
            this.createARoom.TabIndex = 8;
            this.createARoom.Text = "CREATE";
            this.createARoom.TextColor = System.Drawing.Color.White;
            this.createARoom.UseVisualStyleBackColor = false;
            this.createARoom.Click += new System.EventHandler(this.createARoom_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Whiteboard.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(343, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(513, 227);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Whiteboard.Properties.Resources.username;
            this.pictureBox3.Location = new System.Drawing.Point(389, 376);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(422, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.createARoom);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("UTM Helve", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(1218, 847);
            this.MinimumSize = new System.Drawing.Size(1218, 847);
            this.Name = "Create";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Create_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJButton createARoom;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}