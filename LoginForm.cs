using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace National_Bank_of_Serbia
{
    public partial class LoginForm : Form
    {
        /* Attributes */

        private static string pass, namef, namel, balance;
        private static int i = 0;
        private readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CDQI3D6\SQLEXPRESS;Initial Catalog=NationalBank;Integrated Security=True;Pooling=False");

        /* Constructor */
        public LoginForm()
        {
            InitializeComponent();
            gunaCircleProgressBar1.Visible = false;
            timer2.Start(); //Progress bar
        }

        /* Properties */
        public string Pass => pass;
        public string Namef => namef;
        public string Namel => namel;
        public string Balance => balance;

        /* Load form method */
        private void LoginForm_Load(object sender, EventArgs e) => KeyPreview = true;

        
        /* ButtonClick methods */

        private void Enter_btn_Click(object sender, EventArgs e) => Connection();

        private void Back1_btn_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void Back2_btn_Click(object sender, EventArgs e)
        {
            Back();
        }

        /* LinkLabel click method */
        private void LinkLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm fm5 = new RegistrationForm();
            fm5.Show();
        }

        /* KeyPress methods */
        private void Pin_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                ++i;
                e.Handled = true;
                if (i > 2)
                    MessageBox.Show("PIN can only contain numbers from 0 to 9!");
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)//Enter clicked
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter_btn.PerformClick();
            }
        }
       
        /* TimerTick methods */
        private void Timer1_Tick(object sender, EventArgs e)
        {
            gunaCircleProgressBar1.Increment(2);
            if (gunaCircleProgressBar1.Value == 400)
            {
                timer1.Stop();
                ProfileForm f = new ProfileForm();
                this.Hide();
                f.Show();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Opacity += .05;
            if (Opacity == 1)
                timer2.Stop();
        }

        /* Auxiliary methods */
        private void Connection()
        {
            try
            {
                if(PinCorrectness())
                {
                    gunaCircleProgressBar1.Value = 0;
                    pass = pin_txtbox.Text;

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from Users where Pin=@pin", con)
                    {
                        Connection = con
                    })
                    {
                        SqlParameter param1 = new SqlParameter
                        {
                            ParameterName = "@pin",
                            Value = pin_txtbox.Text
                        };
                        cmd.Parameters.Add(param1);
                        cmd.ExecuteNonQuery();

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        i = Convert.ToInt32(dt.Rows.Count.ToString());

                        if (i == 0) /* There is no one with written pin */
                        {

                            pin_txtbox.Text = null;
                            string message = "Do you want to try again?";
                            string title = "Wrong password";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result = MessageBox.Show(message, title, buttons);
                            if (result.Equals(DialogResult.No))
                            {
                                UserForm fm2 = new UserForm();
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

                            SqlDataReader dr = cmd.ExecuteReader();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 404: " + ex);
            }
        }
        private bool PinCorrectness()
        {
            if (pin_txtbox.TextLength < 4)
            {
                string message = "Length of the pin must be four!";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                _ = MessageBox.Show(message, title, buttons);
                pin_txtbox.Text = null;
                return false;
            }
            return true;
        }
        private void Back()
        {
            UserForm f = new UserForm();
            f.Show();
            this.Hide();
        }
    }
}