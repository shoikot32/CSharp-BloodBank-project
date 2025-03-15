using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class loninOtp : Form
    {
        public loninOtp()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(otpBox.Text != "")
            {
                MessageBox.Show(" Registration Successful!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logIn logIn = new logIn();
                logIn.Show();
                this.Hide(); 
            }



            else
            {
                MessageBox.Show(" Enter valid Otp", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userRegistation dashboard = new userRegistation();
            dashboard.Show();
            this.Hide();
        }
    }
}
