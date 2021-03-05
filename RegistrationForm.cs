using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace National_Bank_of_Serbia
{

    public partial class RegistrationForm : Form
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CDQI3D6\SQLEXPRESS;Initial Catalog=NationalBank;Integrated Security=True;Pooling=False");

        public RegistrationForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void RegistrationForm_Load(object sender, EventArgs e) => KeyPreview = true;

        /* ButtonClick methods */
        private void Register_btn_Click(object sender, EventArgs e) => Connection();

        private void Back_btn_Click(object sender, EventArgs e) => Back();

        private void Back1_btn_Click(object sender, EventArgs e) => Back();

        private void Verify_btn_Click(object sender, EventArgs e)
        {
            VerifyForm vf = new VerifyForm();
            vf.Show();
        }

        /* KeyPress methods */
        private void FirstName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LastName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NationalID_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Balance_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Pin_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /* Enter click */
        private void RegistrationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register_btn.PerformClick();
            }
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
       

        /* Auxiliary methods */
        private void Connection()
        {
            if (!FieldOccupancy() && !FieldCorrectness())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd1 = new SqlCommand("select * from Users where Pin=@pin"))
                    {
                        using (SqlCommand cmd2 = new SqlCommand("select * from Users where NationalID=@id"))
                        {
                            SqlParameter param1 = new SqlParameter
                            {
                                ParameterName = "@pin",
                                Value = pin_txt.Text
                            };
                            cmd1.Parameters.Add(param1);

                            SqlParameter param2 = new SqlParameter
                            {
                                ParameterName = "@id",
                                Value = nationalID_txt.Text
                            };
                            cmd2.Parameters.Add(param2);

                            DataTable dt = new DataTable();
                            DataTable dt1 = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(cmd1);
                            SqlDataAdapter da1 = new SqlDataAdapter(cmd2);

                            cmd1.Connection = con;
                            cmd2.Connection = con;

                            da.Fill(dt);
                            da1.Fill(dt1);
                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show("That pin already exist");
                                dt.Clear();
                                pin_txt.Text = null;
                                con.Close();
                            }

                            else if (dt1.Rows.Count > 0)
                            {
                                MessageBox.Show("That National ID already exist");
                                dt.Clear();
                                nationalID_txt.Text = null;
                                con.Close();
                            }
                            else
                            {
                                /* First letter uppercase */
                                firstName_txt.Text = firstName_txt.Text.Substring(0, 1).ToUpper() + firstName_txt.Text.Substring(1);
                                lastName_txt.Text = lastName_txt.Text.Substring(0, 1).ToUpper() + lastName_txt.Text.Substring(1);
                                using (SqlCommand cmd3 = new SqlCommand("insert into Users(Pin,FirstName,LastName,Balance,NationalID)" +
                                    "Values(@Pin,@FirstName,@LastName,@Balance,@NationaliD)", con)
                                {
                                    Connection = con
                                })
                                {
                                    SqlParameter param3 = new SqlParameter
                                    {
                                        ParameterName = "@Pin",
                                        Value = pin_txt.Text
                                    };
                                    cmd3.Parameters.Add(param3);

                                    SqlParameter param4 = new SqlParameter
                                    {
                                        ParameterName = "@FirstName",
                                        Value = firstName_txt.Text
                                    };
                                    cmd3.Parameters.Add(param4);

                                    SqlParameter param5 = new SqlParameter
                                    {
                                        ParameterName = "@LastName",
                                        Value = lastName_txt.Text
                                    };
                                    cmd3.Parameters.Add(param5);

                                    SqlParameter param6 = new SqlParameter
                                    {
                                        ParameterName = "@Balance",
                                        Value = balance_txt.Text
                                    };
                                    cmd3.Parameters.Add(param6);

                                    SqlParameter param7 = new SqlParameter
                                    {
                                        ParameterName = "@NationalId",
                                        Value = nationalID_txt.Text
                                    };
                                    cmd3.Parameters.Add(param7);
                                    cmd3.ExecuteNonQuery();
                                }
                                MessageBox.Show("Registered");

                                firstName_txt.Text = lastName_txt.Text = nationalID_txt.Text = balance_txt.Text = pin_txt.Text = null;
                                con.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }
        private bool FieldOccupancy()
        {
            bool tmp = false;
            string[] arr = { firstName_txt.Text, lastName_txt.Text, nationalID_txt.Text, balance_txt.Text, pin_txt.Text };
            foreach (string data in arr)
                if (data.Equals(""))
                    tmp = true;
            if (tmp)
            {
                MessageBox.Show("Fill in each field");
                return tmp;
            }

            return tmp;
        }
        private bool FieldCorrectness()
        {
            bool correctness = false;
            if (nationalID_txt.TextLength != 13)
            {
                MessageBox.Show("National ID must contain 13 numbers");
                correctness = true;
            }

            else if (int.TryParse(balance_txt.Text, out _))
            {
                int balance = int.Parse(balance_txt.Text);
                if (balance < 1)
                {
                    MessageBox.Show("Minimum value of balance is 1$");
                    correctness = true;
                }
            }

            if (pin_txt.TextLength < 4)
            {
                MessageBox.Show("PIN must contain 4 numbers!");
                correctness = true;

            }
            return correctness;
        }
        private void Back()
        {
            this.Hide();
            UserForm fm1 = new UserForm();
            fm1.Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            _ = checkBox1.Checked ? (Verify_btn.Visible = true, balance_txt.Enabled = false) :
                (Verify_btn.Visible = false, balance_txt.Enabled = true);   
        }
    }
}