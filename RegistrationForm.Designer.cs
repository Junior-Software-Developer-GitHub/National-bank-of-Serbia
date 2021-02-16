namespace National_Bank_of_Serbia
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstName_txt = new System.Windows.Forms.TextBox();
            this.lastName_txt = new System.Windows.Forms.TextBox();
            this.nationalID_txt = new System.Windows.Forms.TextBox();
            this.balance_txt = new System.Windows.Forms.TextBox();
            this.pin_txt = new System.Windows.Forms.TextBox();
            this.Back1_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Register_btn = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(89, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(89, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(89, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "National ID:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Location = new System.Drawing.Point(89, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(89, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "PIN:";
            // 
            // firstName_txt
            // 
            this.firstName_txt.Location = new System.Drawing.Point(198, 61);
            this.firstName_txt.MaxLength = 20;
            this.firstName_txt.Multiline = true;
            this.firstName_txt.Name = "firstName_txt";
            this.firstName_txt.Size = new System.Drawing.Size(100, 23);
            this.firstName_txt.TabIndex = 5;
            this.firstName_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstName_txt_KeyPress);
            // 
            // lastName_txt
            // 
            this.lastName_txt.Location = new System.Drawing.Point(198, 99);
            this.lastName_txt.MaxLength = 20;
            this.lastName_txt.Multiline = true;
            this.lastName_txt.Name = "lastName_txt";
            this.lastName_txt.Size = new System.Drawing.Size(100, 23);
            this.lastName_txt.TabIndex = 7;
            this.lastName_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastName_txt_KeyPress);
            // 
            // nationalID_txt
            // 
            this.nationalID_txt.Location = new System.Drawing.Point(198, 142);
            this.nationalID_txt.MaxLength = 13;
            this.nationalID_txt.Multiline = true;
            this.nationalID_txt.Name = "nationalID_txt";
            this.nationalID_txt.Size = new System.Drawing.Size(100, 23);
            this.nationalID_txt.TabIndex = 8;
            this.toolTip1.SetToolTip(this.nationalID_txt, "National ID must contain 13 numbers");
            this.nationalID_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NationalID_txt_KeyPress);
            // 
            // balance_txt
            // 
            this.balance_txt.Location = new System.Drawing.Point(198, 188);
            this.balance_txt.MaxLength = 8;
            this.balance_txt.Multiline = true;
            this.balance_txt.Name = "balance_txt";
            this.balance_txt.Size = new System.Drawing.Size(100, 23);
            this.balance_txt.TabIndex = 9;
            this.toolTip1.SetToolTip(this.balance_txt, "Maximum is 99999999");
            this.balance_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Balance_txt_KeyPress);
            // 
            // pin_txt
            // 
            this.pin_txt.Location = new System.Drawing.Point(198, 230);
            this.pin_txt.MaxLength = 4;
            this.pin_txt.Multiline = true;
            this.pin_txt.Name = "pin_txt";
            this.pin_txt.PasswordChar = '*';
            this.pin_txt.Size = new System.Drawing.Size(100, 23);
            this.pin_txt.TabIndex = 10;
            this.toolTip1.SetToolTip(this.pin_txt, "PIN must contain 4 numbers!");
            this.pin_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pin_txt_KeyPress);
            // 
            // Back1_btn
            // 
            this.Back1_btn.Animated = true;
            this.Back1_btn.CheckedState.Parent = this.Back1_btn;
            this.Back1_btn.CustomImages.Parent = this.Back1_btn;
            this.Back1_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.Back1_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Back1_btn.ForeColor = System.Drawing.Color.White;
            this.Back1_btn.HoverState.Parent = this.Back1_btn;
            this.Back1_btn.Image = global::National_Bank_of_Serbia.Properties.Resources._2;
            this.Back1_btn.ImageSize = new System.Drawing.Size(43, 43);
            this.Back1_btn.IndicateFocus = true;
            this.Back1_btn.Location = new System.Drawing.Point(12, 12);
            this.Back1_btn.Name = "Back1_btn";
            this.Back1_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Back1_btn.ShadowDecoration.Parent = this.Back1_btn;
            this.Back1_btn.Size = new System.Drawing.Size(45, 45);
            this.Back1_btn.TabIndex = 12;
            this.Back1_btn.Click += new System.EventHandler(this.Back1_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Animated = true;
            this.Back_btn.AutoRoundedCorners = true;
            this.Back_btn.BorderRadius = 19;
            this.Back_btn.BorderThickness = 2;
            this.Back_btn.CheckedState.Parent = this.Back_btn;
            this.Back_btn.CustomImages.Parent = this.Back_btn;
            this.Back_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.Back_btn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.Back_btn.ForeColor = System.Drawing.Color.Black;
            this.Back_btn.HoverState.Parent = this.Back_btn;
            this.Back_btn.Location = new System.Drawing.Point(149, 368);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.ShadowDecoration.Parent = this.Back_btn;
            this.Back_btn.Size = new System.Drawing.Size(100, 40);
            this.Back_btn.TabIndex = 12;
            this.Back_btn.Text = "BACK";
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Register_btn
            // 
            this.Register_btn.Animated = true;
            this.Register_btn.AutoRoundedCorners = true;
            this.Register_btn.BorderRadius = 19;
            this.Register_btn.BorderThickness = 2;
            this.Register_btn.CheckedState.Parent = this.Register_btn;
            this.Register_btn.CustomImages.Parent = this.Register_btn;
            this.Register_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.Register_btn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.Register_btn.ForeColor = System.Drawing.Color.Black;
            this.Register_btn.HoverState.Parent = this.Register_btn;
            this.Register_btn.Location = new System.Drawing.Point(129, 279);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.ShadowDecoration.Parent = this.Register_btn;
            this.Register_btn.Size = new System.Drawing.Size(140, 40);
            this.Register_btn.TabIndex = 12;
            this.Register_btn.Text = "REGISTER";
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(394, 416);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Back1_btn);
            this.Controls.Add(this.pin_txt);
            this.Controls.Add(this.balance_txt);
            this.Controls.Add(this.nationalID_txt);
            this.Controls.Add(this.lastName_txt);
            this.Controls.Add(this.firstName_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegistrationForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstName_txt;
        private System.Windows.Forms.TextBox lastName_txt;
        private System.Windows.Forms.TextBox nationalID_txt;
        private System.Windows.Forms.TextBox balance_txt;
        private System.Windows.Forms.TextBox pin_txt;
        private Guna.UI2.WinForms.Guna2CircleButton Back1_btn;
        private Guna.UI2.WinForms.Guna2Button Back_btn;
        private Guna.UI2.WinForms.Guna2Button Register_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}