namespace National_Bank_of_Serbia
{
    partial class ProfileForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.firstName_lbl = new System.Windows.Forms.Label();
            this.lastName_lbl = new System.Windows.Forms.Label();
            this.balance_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Confirm_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Back1_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Back2_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // firstName_lbl
            // 
            this.firstName_lbl.AutoSize = true;
            this.firstName_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_lbl.Location = new System.Drawing.Point(175, 57);
            this.firstName_lbl.Name = "firstName_lbl";
            this.firstName_lbl.Size = new System.Drawing.Size(0, 21);
            this.firstName_lbl.TabIndex = 0;
            // 
            // lastName_lbl
            // 
            this.lastName_lbl.AutoSize = true;
            this.lastName_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_lbl.Location = new System.Drawing.Point(175, 98);
            this.lastName_lbl.Name = "lastName_lbl";
            this.lastName_lbl.Size = new System.Drawing.Size(0, 21);
            this.lastName_lbl.TabIndex = 1;
            // 
            // balance_lbl
            // 
            this.balance_lbl.AutoSize = true;
            this.balance_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_lbl.Location = new System.Drawing.Point(175, 141);
            this.balance_lbl.Name = "balance_lbl";
            this.balance_lbl.Size = new System.Drawing.Size(0, 21);
            this.balance_lbl.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "First name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Balance:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.checkBox1.Location = new System.Drawing.Point(70, 196);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 25);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Withdraw money";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.label1.Location = new System.Drawing.Point(87, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter amount:";
            this.label1.Visible = false;
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Animated = true;
            this.Confirm_btn.AutoRoundedCorners = true;
            this.Confirm_btn.BorderRadius = 15;
            this.Confirm_btn.BorderThickness = 2;
            this.Confirm_btn.CheckedState.Parent = this.Confirm_btn;
            this.Confirm_btn.CustomImages.Parent = this.Confirm_btn;
            this.Confirm_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.Confirm_btn.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.ForeColor = System.Drawing.Color.Black;
            this.Confirm_btn.HoverState.Parent = this.Confirm_btn;
            this.Confirm_btn.Location = new System.Drawing.Point(232, 249);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.ShadowDecoration.Parent = this.Confirm_btn;
            this.Confirm_btn.Size = new System.Drawing.Size(114, 33);
            this.Confirm_btn.TabIndex = 11;
            this.Confirm_btn.Text = "CONFIRM";
            this.Confirm_btn.Visible = false;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(91, 249);
            this.guna2TextBox1.MaxLength = 8;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Red;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(99, 36);
            this.guna2TextBox1.TabIndex = 12;
            this.guna2TextBox1.Visible = false;
            this.guna2TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guna2TextBox1_KeyPress);
            // 
            // Back1_btn
            // 
            this.Back1_btn.Animated = true;
            this.Back1_btn.AutoRoundedCorners = true;
            this.Back1_btn.BorderRadius = 19;
            this.Back1_btn.BorderThickness = 2;
            this.Back1_btn.CheckedState.Parent = this.Back1_btn;
            this.Back1_btn.CustomImages.Parent = this.Back1_btn;
            this.Back1_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.Back1_btn.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back1_btn.ForeColor = System.Drawing.Color.Black;
            this.Back1_btn.HoverState.Parent = this.Back1_btn;
            this.Back1_btn.Location = new System.Drawing.Point(139, 342);
            this.Back1_btn.Name = "Back1_btn";
            this.Back1_btn.ShadowDecoration.Parent = this.Back1_btn;
            this.Back1_btn.Size = new System.Drawing.Size(115, 41);
            this.Back1_btn.TabIndex = 20;
            this.Back1_btn.Text = "BACK";
            this.Back1_btn.Click += new System.EventHandler(this.Back1_btn_Click);
            // 
            // Back2_btn
            // 
            this.Back2_btn.Animated = true;
            this.Back2_btn.CheckedState.Parent = this.Back2_btn;
            this.Back2_btn.CustomImages.Parent = this.Back2_btn;
            this.Back2_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.Back2_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Back2_btn.ForeColor = System.Drawing.Color.White;
            this.Back2_btn.HoverState.Parent = this.Back2_btn;
            this.Back2_btn.Image = global::National_Bank_of_Serbia.Properties.Resources._2;
            this.Back2_btn.ImageSize = new System.Drawing.Size(43, 43);
            this.Back2_btn.IndicateFocus = true;
            this.Back2_btn.Location = new System.Drawing.Point(6, 6);
            this.Back2_btn.Name = "Back2_btn";
            this.Back2_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Back2_btn.ShadowDecoration.Parent = this.Back2_btn;
            this.Back2_btn.Size = new System.Drawing.Size(45, 45);
            this.Back2_btn.TabIndex = 26;
            this.Back2_btn.Click += new System.EventHandler(this.Back2_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(397, 393);
            this.Controls.Add(this.Back2_btn);
            this.Controls.Add(this.Back1_btn);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.balance_lbl);
            this.Controls.Add(this.lastName_lbl);
            this.Controls.Add(this.firstName_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProfileForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName_lbl;
        private System.Windows.Forms.Label lastName_lbl;
        private System.Windows.Forms.Label balance_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Confirm_btn;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button Back1_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Back2_btn;
        private System.Windows.Forms.Timer timer1;
    }
}