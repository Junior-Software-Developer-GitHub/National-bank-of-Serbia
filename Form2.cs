using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace National_Bank_of_Serbia
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void NewUserToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            Form5 fm5 = new Form5();
            this.Hide();
            fm5.Show();
        }

        private void ExistingUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            this.Hide();
            fm3.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            this.Hide();
            fm5.Show();
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            Hide();
            f.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .05;
            if (Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creator: Luka Antic");
        }
    }
}