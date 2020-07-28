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
   
    public partial class Form5 : Form
    {
        private readonly MySqlConnection con = new MySqlConnection("server=192.168.1.11;database=bankDB;uid=luka;pwd=LUKA;");
        public Form5()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {      
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Guna1CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm1 = new Form2();
            fm1.Show();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            Connection();
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm1 = new Form2();
            fm1.Show();
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
            int k = 0;
            string[] arr = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text };
            foreach (string data in arr)
                if (data == "")
                    k++;
            if (k > 0)
            {
                MessageBox.Show("Fill in each field");
            }

            else if (textBox3.TextLength != 13)
            {
                MessageBox.Show("National ID must contain 13 numbers"); ;
            }

            else if (int.Parse(textBox4.Text) < 1)
            {
                MessageBox.Show("Minimum value of balance is 1$");
            }
            else if (textBox5.TextLength < 4)
            {
                MessageBox.Show("PIN must contain 4 numbers!"); ;
            }
            else
            {
                try

                {
                    con.Open();
                    MySqlCommand cmd1 = new MySqlCommand("select * from korisnici where pin='" + textBox5.Text + "'");
                    MySqlCommand cmd2 = new MySqlCommand("select * from korisnici where nationalID='" + textBox3.Text + "'");
                    DataTable dt = new DataTable();
                    DataTable dt1 = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd2);

                    cmd1.Connection = con;
                    cmd2.Connection = con;

                    da.Fill(dt);
                    da1.Fill(dt1);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("That pin already exist");
                        dt.Clear();
                        textBox5.Text = null;
                        con.Close();
                    }


                    else if (dt1.Rows.Count > 0)
                    {
                        MessageBox.Show("That National ID already exist");
                        dt.Clear();
                        textBox3.Text = null;
                        con.Close();
                    }
                    else
                    {
                        MySqlCommand cmd3 = new MySqlCommand("insert into korisnici(pin,firstName,lastName,balance,nationalID)Values('" + textBox5.Text + "','" +
                        textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')", con)
                        {
                            Connection = con
                        };
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Registered");

                        textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = null;
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.PerformClick();
            }
        }
    }
}