using System;
using System.Windows.Forms;

namespace National_Bank_of_Serbia
{
    public partial class UserForm : Form
    {
        /* Constructor */
        public UserForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        /* ToolStripMenuItems click */
        private void NewUserToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            RegistrationForm fm5 = new RegistrationForm();
            this.Hide();
            fm5.Show();
        }

        private void ExistingUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm fm3 = new LoginForm();
            this.Hide();
            fm3.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creator: Luka Antic");
        }

        /* ButtonClick methods */
        private void NewUser_btn_Click(object sender, EventArgs e)
        {
            RegistrationForm fm5 = new RegistrationForm();
            this.Hide();
            fm5.Show();
        }

        private void ExistingUser_btn(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            Hide();
            f.Show();
        }

        /* Timer tick method */

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .05;
            if (Opacity == 1)
            {
                timer1.Stop();
            }
        }

        /* LinkLabel click method */

        private void WebSite_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://nbs.rs/en/indeks/index.html");
        }
    }
}