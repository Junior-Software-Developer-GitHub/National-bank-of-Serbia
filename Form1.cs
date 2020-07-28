using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace National_Bank_of_Serbia
{
    public partial class Form1 : Form
    {
       private int time = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ++time;
            if (time == 5) 
            {
                timer1.Stop();
                Form2 f = new Form2();
                this.Hide();
                f.Show();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Opacity += .05;
            if (Opacity == 1)
            {
                timer2.Stop();
            }
        }
    }
}