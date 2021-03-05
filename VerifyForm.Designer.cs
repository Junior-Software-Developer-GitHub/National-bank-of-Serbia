namespace National_Bank_of_Serbia
{
    partial class VerifyForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Start_btn = new Guna.UI2.WinForms.Guna2Button();
            this.TakeImage_btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Start_btn
            // 
            this.Start_btn.Animated = true;
            this.Start_btn.AutoRoundedCorners = true;
            this.Start_btn.BorderRadius = 20;
            this.Start_btn.BorderThickness = 2;
            this.Start_btn.CheckedState.Parent = this.Start_btn;
            this.Start_btn.CustomImages.Parent = this.Start_btn;
            this.Start_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.Start_btn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.Start_btn.ForeColor = System.Drawing.Color.Black;
            this.Start_btn.HoverState.Parent = this.Start_btn;
            this.Start_btn.Location = new System.Drawing.Point(53, 292);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.ShadowDecoration.Parent = this.Start_btn;
            this.Start_btn.Size = new System.Drawing.Size(124, 42);
            this.Start_btn.TabIndex = 15;
            this.Start_btn.Text = "Start";
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // TakeImage_btn
            // 
            this.TakeImage_btn.Animated = true;
            this.TakeImage_btn.AutoRoundedCorners = true;
            this.TakeImage_btn.BorderRadius = 20;
            this.TakeImage_btn.BorderThickness = 2;
            this.TakeImage_btn.CheckedState.Parent = this.TakeImage_btn;
            this.TakeImage_btn.CustomImages.Parent = this.TakeImage_btn;
            this.TakeImage_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.TakeImage_btn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.TakeImage_btn.ForeColor = System.Drawing.Color.Black;
            this.TakeImage_btn.HoverState.Parent = this.TakeImage_btn;
            this.TakeImage_btn.Location = new System.Drawing.Point(298, 292);
            this.TakeImage_btn.Name = "TakeImage_btn";
            this.TakeImage_btn.ShadowDecoration.Parent = this.TakeImage_btn;
            this.TakeImage_btn.Size = new System.Drawing.Size(124, 42);
            this.TakeImage_btn.TabIndex = 16;
            this.TakeImage_btn.Text = "Take image";
            this.TakeImage_btn.Click += new System.EventHandler(this.TakeImage_btn_Click);
            // 
            // VerifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(464, 353);
            this.Controls.Add(this.TakeImage_btn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VerifyForm";
            this.Text = "AI Verification";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button Start_btn;
        private Guna.UI2.WinForms.Guna2Button TakeImage_btn;
    }
}