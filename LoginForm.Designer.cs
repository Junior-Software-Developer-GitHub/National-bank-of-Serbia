namespace National_Bank_of_Serbia
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pin_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Enter_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Back1_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back2_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gunaCircleProgressBar1 = new Guna.UI.WinForms.GunaCircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pin_txtbox
            // 
            this.pin_txtbox.BackColor = System.Drawing.Color.LightSlateGray;
            this.pin_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pin_txtbox.Font = new System.Drawing.Font("Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.pin_txtbox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.pin_txtbox.Location = new System.Drawing.Point(156, 109);
            this.pin_txtbox.MaxLength = 4;
            this.pin_txtbox.Name = "pin_txtbox";
            this.pin_txtbox.PasswordChar = '*';
            this.pin_txtbox.Size = new System.Drawing.Size(100, 24);
            this.pin_txtbox.TabIndex = 1;
            this.pin_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pin_txtbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkBlue;
            this.linkLabel1.Location = new System.Drawing.Point(151, 136);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have pin";
            this.linkLabel1.Click += new System.EventHandler(this.LinkLabel1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 34);
            this.label7.TabIndex = 10;
            this.label7.Text = "PLEASE ENTER PIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(119, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "PIN:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Enter_btn
            // 
            this.Enter_btn.Animated = true;
            this.Enter_btn.AutoRoundedCorners = true;
            this.Enter_btn.BorderRadius = 19;
            this.Enter_btn.BorderThickness = 2;
            this.Enter_btn.CheckedState.Parent = this.Enter_btn;
            this.Enter_btn.CustomImages.Parent = this.Enter_btn;
            this.Enter_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.Enter_btn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.Enter_btn.ForeColor = System.Drawing.Color.Black;
            this.Enter_btn.HoverState.Parent = this.Enter_btn;
            this.Enter_btn.Location = new System.Drawing.Point(132, 162);
            this.Enter_btn.Name = "Enter_btn";
            this.Enter_btn.ShadowDecoration.Parent = this.Enter_btn;
            this.Enter_btn.Size = new System.Drawing.Size(115, 41);
            this.Enter_btn.TabIndex = 18;
            this.Enter_btn.Text = "ENTER PIN";
            this.Enter_btn.Click += new System.EventHandler(this.Enter_btn_Click);
            // 
            // Back1_btn
            // 
            this.Back1_btn.Animated = true;
            this.Back1_btn.AutoRoundedCorners = true;
            this.Back1_btn.BackColor = System.Drawing.Color.Transparent;
            this.Back1_btn.BorderRadius = 19;
            this.Back1_btn.BorderThickness = 2;
            this.Back1_btn.CheckedState.Parent = this.Back1_btn;
            this.Back1_btn.CustomImages.Parent = this.Back1_btn;
            this.Back1_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.Back1_btn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.Back1_btn.ForeColor = System.Drawing.Color.Black;
            this.Back1_btn.HoverState.Parent = this.Back1_btn;
            this.Back1_btn.IndicateFocus = true;
            this.Back1_btn.Location = new System.Drawing.Point(132, 300);
            this.Back1_btn.Name = "Back1_btn";
            this.Back1_btn.ShadowDecoration.Parent = this.Back1_btn;
            this.Back1_btn.Size = new System.Drawing.Size(115, 41);
            this.Back1_btn.TabIndex = 19;
            this.Back1_btn.Text = "BACK";
            this.Back1_btn.Click += new System.EventHandler(this.Back1_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::National_Bank_of_Serbia.Properties.Resources.lock1;
            this.pictureBox1.Location = new System.Drawing.Point(81, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
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
            this.Back2_btn.Location = new System.Drawing.Point(5, 8);
            this.Back2_btn.Name = "Back2_btn";
            this.Back2_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Back2_btn.ShadowDecoration.Parent = this.Back2_btn;
            this.Back2_btn.Size = new System.Drawing.Size(45, 45);
            this.Back2_btn.TabIndex = 25;
            this.Back2_btn.Click += new System.EventHandler(this.Back2_btn_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 25;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // gunaCircleProgressBar1
            // 
            this.gunaCircleProgressBar1.Animated = true;
            this.gunaCircleProgressBar1.AnimationSpeed = 2F;
            this.gunaCircleProgressBar1.BaseColor = System.Drawing.Color.White;
            this.gunaCircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCircleProgressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.gunaCircleProgressBar1.IdleOffset = 20;
            this.gunaCircleProgressBar1.IdleThickness = 20;
            this.gunaCircleProgressBar1.Image = null;
            this.gunaCircleProgressBar1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleProgressBar1.LineEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.gunaCircleProgressBar1.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.gunaCircleProgressBar1.Location = new System.Drawing.Point(153, 209);
            this.gunaCircleProgressBar1.Maximum = 400;
            this.gunaCircleProgressBar1.Name = "gunaCircleProgressBar1";
            this.gunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.Black;
            this.gunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.DarkSlateGray;
            this.gunaCircleProgressBar1.ProgressOffset = 20;
            this.gunaCircleProgressBar1.ProgressThickness = 7;
            this.gunaCircleProgressBar1.Size = new System.Drawing.Size(75, 73);
            this.gunaCircleProgressBar1.TabIndex = 26;
            this.gunaCircleProgressBar1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.gunaCircleProgressBar1.UseProgressPercentText = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(376, 349);
            this.Controls.Add(this.gunaCircleProgressBar1);
            this.Controls.Add(this.Back2_btn);
            this.Controls.Add(this.Back1_btn);
            this.Controls.Add(this.Enter_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pin_txtbox);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pin_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button Enter_btn;
        private Guna.UI2.WinForms.Guna2Button Back1_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Back2_btn;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar1;
    }
}