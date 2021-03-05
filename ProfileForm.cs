using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace National_Bank_of_Serbia
{
    public partial class ProfileForm : Form
    {
        /* Attributes */

        private readonly LoginForm f = new LoginForm();
        private readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CDQI3D6\SQLEXPRESS;Initial Catalog=NationalBank;Integrated Security=True;Pooling=False");

        /* Constructor */

        public ProfileForm()
        {
            InitializeComponent();
            guna2TextBox1.Text = null;
            firstName_lbl.Text = f.Namef;
            lastName_lbl.Text = f.Namel;
            balance_lbl.Text = f.Balance;
            timer1.Start();
        }

        /* ButtonClick Methods */ 

        private void Confirm_btn_Click(object sender, EventArgs e) => Connection();

        private void Back1_btn_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void Back2_btn_Click(object sender, EventArgs e)
        {
            Back();
        }
        /* CheckBox checked method */

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            _ = checkBox1.Checked ? (guna2TextBox1.Visible = label1.Visible = Confirm_btn.Visible = true)
                : (guna2TextBox1.Visible = label1.Visible = Confirm_btn.Visible = false);
        }

        /* Form load method */
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            guna2TextBox1.Text = null;
            KeyPreview = true;
        }

        /* KeyPress methods */
        private void Guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void ProfileForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Confirm_btn.PerformClick();
            }
        }

        /* TimerTick method */
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .05;
            if (Opacity == 1)
            {
                timer1.Stop();
            }
        }

        /* Auxiliary methods */
        private void Connection()
        {
            try
            {
                if (guna2TextBox1.TextLength > 0)
                {
                    con.Open();
                    int a = Int32.Parse(guna2TextBox1.Text);
                    string c = balance_lbl.Text;
                    c = c.Remove(c.Length - 1);
                    int balance = int.Parse(c);
                    int b = Int32.Parse(c);
                    if (b >= a)
                    {
                        int newBalance = b - a;

                        using (SqlCommand cmd = new SqlCommand("Update Users set Balance =@NewBalance" + " where pin=@Pass"))
                        {
                            SqlParameter param = new SqlParameter
                            {
                                ParameterName = "@NewBalance",
                                Value = newBalance.ToString()
                            };
                            cmd.Parameters.Add(param);

                            SqlParameter param1 = new SqlParameter
                            {
                                ParameterName = "@Pass",
                                Value = f.Pass
                            };
                            cmd.Parameters.Add(param1);

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                        }

                        balance_lbl.Text = newBalance.ToString() + "$";
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

        private void Back()
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
        }
    }
}