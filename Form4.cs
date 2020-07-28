using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace National_Bank_of_Serbia
{
    public partial class Form4 : Form
    {
        private readonly MySqlConnection con = new MySqlConnection("server=192.168.1.11;database=bankDB;uid=luka;pwd=LUKA;");
        public Form4()
        {
            InitializeComponent();
            guna2TextBox1.Text = null;
            label7.Text = Form3.namef;
            label8.Text = Form3.namel;
            label9.Text = Form3.balance;
            timer1.Start();

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                guna2TextBox1.Visible = true;
                label1.Visible = true;
                guna2Button1.Visible = true;
            }
            else
            {
                guna2TextBox1.Visible = false;
                label1.Visible = false;
                guna2Button1.Visible = false;
            }
        }


        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            Connection();
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fm3 = new Form3();
            fm3.Show();
        }

        private void Guna1CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fm3 = new Form3();
            fm3.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            guna2TextBox1.Text = null;
            KeyPreview = true;
        }

        private void Guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .05;
            if (Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void Connection()
        {
            try
            {
                if (guna2TextBox1.TextLength > 0)
                {
                    con.Open();
                    int a = Int32.Parse(guna2TextBox1.Text);
                    string c = label9.Text;
                    c = c.Remove(c.Length - 1);
                    int balance = int.Parse(c);
                    int b = Int32.Parse(c);
                    if (b >= a)
                    {
                        MySqlCommand cmd = new MySqlCommand("Update korisnici set balance ='" + (b - a) + "'" + " where pin='" + Form3.pass + "'");
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        label9.Text = (b - a).ToString() + "$";
                        string message = "Successful withdrawal of money";
                        string title = "Payment";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                    }
                    else
                    {
                        string message = "The amount of money you entered is greater than your account balance";
                        string title = "Payment";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        guna2TextBox1.Text = null;
                    }
                    guna2TextBox1.Text = null;
                    con.Close();
                }
                else
                    MessageBox.Show("Error");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                con.Close();
            }
        }
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.PerformClick();
            }
        }
    }
}