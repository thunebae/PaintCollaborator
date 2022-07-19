
namespace Whiteboard
{
    partial class Join
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
            this.code = new System.Windows.Forms.TextBox();
            this.joinARoom = new Whiteboard.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // nickname
            // 
            this.nickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nickname.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nickname.Location = new System.Drawing.Point(444, 376);
            this.nickname.Name = "nickname";
            this.nickname.PlaceholderText = "nickname";
            this.nickname.Size = new System.Drawing.Size(348, 28);
            this.nickname.TabIndex = 1;
            // 
            // code
            // 
            this.code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.code.Location = new System.Drawing.Point(444, 447);
            this.code.Name = "code";
            this.code.PlaceholderText = "code";
            this.code.Size = new System.Drawing.Size(348, 28);
            this.code.TabIndex = 1;
            // 
            // joinARoom
            // 
            this.joinARoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.joinARoom.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.joinARoom.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.joinARoom.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.joinARoom.BorderRadius = 40;
            this.joinARoom.BorderSize = 0;
            this.joinARoom.FlatAppearance.BorderSize = 0;
            this.joinARoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinARoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.joinARoom.ForeColor = System.Drawing.Color.White;
            this.joinARoom.Location = new System.Drawing.Point(490, 522);
            this.joinARoom.Name = "joinARoom";
            this.joinARoom.Size = new System.Drawing.Size(228, 79);
            this.joinARoom.TabIndex = 9;
            this.joinARoom.Text = "JOIN";
            this.joinARoom.TextColor = System.Drawing.Color.White;
            this.joinARoom.UseVisualStyleBackColor = false;
            this.joinARoom.Click += new System.EventHandler(this.joinARoom_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Whiteboard.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(343, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(513, 227);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Whiteboard.Properties.Resources.Whiteboard_Background;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1176, 786);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Whiteboard.Properties.Resources.username;
            this.pictureBox3.Location = new System.Drawing.Point(392, 360);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(422, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::Whiteboard.Properties.Resources.code;
            this.pictureBox4.Location = new System.Drawing.Point(392, 430);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(422, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.code);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.joinARoom);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(1218, 847);
            this.MinimumSize = new System.Drawing.Size(1218, 847);
            this.Name = "Join";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Join";
            this.Load += new System.EventHandler(this.Join_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.TextBox code;
        private RJButton joinARoom;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}