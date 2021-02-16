using System;
using System.Windows.Forms;

namespace National_Bank_of_Serbia
{
    public partial class WelcomeForm : Form
    {
        /* Attribute */

        private int time = 0;
        public WelcomeForm()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        /* TimerTick methods */

        private void Timer1_Tick(object sender, EventArgs e)/*Timer1 is used for the welcome animation*/
        {
            ++time;
            if (time == 5) 
            {
                timer1.Stop();
                UserForm f = new UserForm();
                this.Hide();
                f.Show();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)/*Timer1 is used for opacity*/
        {
            Opacity += .05;
            if (Opacity == 1)
            {
                timer2.Stop();
            }
        }
    }
}