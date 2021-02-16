namespace National_Bank_of_Serbia
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.NewUser_btn = new Guna.UI2.WinForms.Guna2Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.blaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.existingUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WebSite_label = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 2500;
            this.toolTip1.InitialDelay = 400;
            this.toolTip1.ReshowDelay = 0;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 18;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.LightSlateGray;
            this.guna2Button2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(349, 239);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(137, 39);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "EXISTING USER";
            this.toolTip1.SetToolTip(this.guna2Button2, "If you have an account, click here");
            this.guna2Button2.Click += new System.EventHandler(this.ExistingUser_btn);
            // 
            // NewUser_btn
            // 
            this.NewUser_btn.Animated = true;
            this.NewUser_btn.AutoRoundedCorners = true;
            this.NewUser_btn.BackColor = System.Drawing.Color.Transparent;
            this.NewUser_btn.BorderRadius = 18;
            this.NewUser_btn.BorderThickness = 2;
            this.NewUser_btn.CheckedState.Parent = this.NewUser_btn;
            this.NewUser_btn.CustomImages.Parent = this.NewUser_btn;
            this.NewUser_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.NewUser_btn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.NewUser_btn.ForeColor = System.Drawing.Color.Black;
            this.NewUser_btn.HoverState.Parent = this.NewUser_btn;
            this.NewUser_btn.Location = new System.Drawing.Point(58, 239);
            this.NewUser_btn.Name = "NewUser_btn";
            this.NewUser_btn.ShadowDecoration.Parent = this.NewUser_btn;
            this.NewUser_btn.Size = new System.Drawing.Size(137, 39);
            this.NewUser_btn.TabIndex = 0;
            this.NewUser_btn.Text = "NEW USER";
            this.toolTip1.SetToolTip(this.NewUser_btn, "If you do not have an account, click here ");
            this.NewUser_btn.Click += new System.EventHandler(this.NewUser_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blaToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // blaToolStripMenuItem
            // 
            this.blaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blaToolStripMenuItem1,
            this.existingUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.blaToolStripMenuItem.Name = "blaToolStripMenuItem";
            this.blaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.blaToolStripMenuItem.Text = "Options";
            // 
            // blaToolStripMenuItem1
            // 
            this.blaToolStripMenuItem1.Name = "blaToolStripMenuItem1";
            this.blaToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.blaToolStripMenuItem1.Text = "New user";
            this.blaToolStripMenuItem1.Click += new System.EventHandler(this.NewUserToolStripMenuItem1_Click);
            // 
            // existingUserToolStripMenuItem
            // 
            this.existingUserToolStripMenuItem.Name = "existingUserToolStripMenuItem";
            this.existingUserToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.existingUserToolStripMenuItem.Text = "Existing user";
            this.existingUserToolStripMenuItem.Click += new System.EventHandler(this.ExistingUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox1.Controls.Add(this.WebSite_label);
            this.groupBox1.Controls.Add(this.guna2Button2);
            this.groupBox1.Controls.Add(this.NewUser_btn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // WebSite_label
            // 
            this.WebSite_label.AutoSize = true;
            this.WebSite_label.Location = new System.Drawing.Point(231, 214);
            this.WebSite_label.Name = "WebSite_label";
            this.WebSite_label.Size = new System.Drawing.Size(83, 13);
            this.WebSite_label.TabIndex = 2;
            this.WebSite_label.TabStop = true;
            this.WebSite_label.Text = "Visit our website";
            this.WebSite_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebSite_label_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(537, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "National Bank of Serbia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem blaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem existingUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button NewUser_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.LinkLabel WebSite_label;
    }
}

