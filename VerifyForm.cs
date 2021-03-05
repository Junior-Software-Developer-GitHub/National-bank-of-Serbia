using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Patagames.Ocr;
using Emgu.CV;
using Emgu.CV.Structure;

namespace National_Bank_of_Serbia
{

    public partial class VerifyForm : Form
    {
        /* Attribute */
        private Capture _capture;

        /* Constructor */
        public VerifyForm()
        {
            InitializeComponent();
        }

        /* ButtonClick methods */
        private void Start_btn_Click(object sender, EventArgs e)
        {
            if (_capture == null)
            {
                _capture = new Emgu.CV.Capture();
            }
            _capture.ImageGrabbed += Capture_ImageGrabbed;
            _capture.Start();
        }

        /* Auxiliary methods */
        private void TakeImage_btn_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox2.Image.Save(@"C:\Users\lukaa\Desktop\l.jpg");
            }
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                string x = objOcr.GetTextFromImage(@"C:\Users\lukaa\Desktop\l.jpg");
                x = new string((from c in x
                                where char.IsNumber(c)
                                select c
       ).ToArray());

                int balance = int.Parse(x);
                if (balance == 206) balance = 200;
                else if (balance == 1005) balance = 1000;
                RegistrationForm rf = (RegistrationForm)Application.OpenForms["RegistrationForm"];
                rf.balance_txt.Text = balance.ToString();
            }
        }
        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                _capture.Retrieve(m);
                pictureBox1.Image = m.ToImage<Bgr, byte>().Bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
        }
        
    }
}
