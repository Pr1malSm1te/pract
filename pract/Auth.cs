using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract
{
    public partial class Auth : Form
    {
        Timer MyTimer = new Timer();

        public Auth()
        {
            InitializeComponent();
        }
        private int enterCount = 0;
        private void TryEnter(object sender, EventArgs e)
        {
            DataBaseController.SetLogin = Login.Text;
            DataBaseController.SetPassword = Password.Text;
            enterCount++;

            if (DataBaseController.CanOpen()) {
                DataBaseController.AddLog(Login.Text, DateTime.Now, true);
                MainForm form = new MainForm(); 
                form.ShowDialog();
                enterCount = 0;
            }
            else
                DataBaseController.AddLog(Login.Text, DateTime.Now, false);
            if (enterCount > 4)
            {
                Login.Enabled = false;
                Password.Enabled = false;
                EnterButton.Enabled = false;
            }
            else if(enterCount > 3)
            {
                MyTimer.Interval = (3 * 60 * 1000);
                MyTimer.Tick += new EventHandler(timer1_Tick);
                Login.Enabled = false;
                Password.Enabled = false;
                EnterButton.Enabled = false;
                this.FormBorderStyle = FormBorderStyle.None;
                MyTimer.Start();
            }
            else if(enterCount > 0)
            {
                Captcha captchaForm = new Captcha();
                captchaForm.ShowDialog();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MyTimer.Stop();
            Login.Enabled = true;
            Password.Enabled = true;
            EnterButton.Enabled = true;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
    }

}
