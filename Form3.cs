using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
 
namespace National_Bank_of_Serbia
{
    public partial class Form3 : Form
    {
        public static string pass, namef, namel, balance;
        private static int i = 0;
        private readonly MySqlConnection con = new MySqlConnection("server=192.168.1.11;database=bankDB;uid=luka;pwd=LUKA;");

        public Form3()
        {
            InitializeComponent();
            gunaCircleProgressBar1.Visible = false;
            timer2.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void Pin_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                ++i;
                e.Handled = true;
                if(i>2)
                    MessageBox.Show("PIN can only contain numbers from 0 to 9!");
            } 
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            Connection();
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void Guna1CircleButton2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Opacity += .05;
            if (Opacity == 1)
            {
                timer2.Stop();
            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.PerformClick();
            }
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void LinkLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 fm5 = new Form5();
            fm5.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            gunaCircleProgressBar1.Increment(2);
            if (gunaCircleProgressBar1.Value == 400)
            {
                timer1.Stop();
                Form4 f4 = new Form4();
                this.Hide();
                f4.Show();
            }
        }
        private void Connection()
        {
            try
            {
                if (pin_txtbox.TextLength < 4)
                {
                    string message = "Length of the pin must be four!";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    pin_txtbox.Text = null;
                }
                else
                {
                    gunaCircleProgressBar1.Value = 0;
                    pass = pin_txtbox.Text;

                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from korisnici where pin='" + pin_txtbox.Text + "'";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    i = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (i == 0)
                    {
                        pin_txtbox.Text = null;
                        string message = "Do you want to try again?";
                        string title = "Wrong password";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result.Equals(DialogResult.No))
                        {
                            Form2 fm2 = new Form2();
                            this.Hide();
                            fm2.Show();
                        }
                        label3.Text = null;
                        con.Close();
                    }

                    else
                    {
                        gunaCircleProgressBar1.Visible = true;
                        timer1.Start();

                        MySqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            namef = dr[1].ToString();
                            namel = dr[2].ToString();
                            balance = dr[3].ToString() + "$";
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 404: " + ex);
            }
        }
    }
}