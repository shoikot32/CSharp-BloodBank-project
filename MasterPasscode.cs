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
    public partial class masterPasswcode : Form
    {
        public masterPasswcode()
        {
            InitializeComponent();
        }

        private void masterCode_TextChanged(object sender, EventArgs e)
        {
         

            }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (masterCode.Text == "R78789898")
            {
                MessageBox.Show("Valid Mastercode !!!Register Access Successful", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                registerPanel rp = new registerPanel();
                rp.Show();
                this.Hide();
            }

            else if (masterCode.Text == "M78789898")
            {
                MessageBox.Show("Valid Mastercode!!! Manager Access Successful", "Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                managerPanel mp = new managerPanel();
                mp.Show();
                this.Hide();
            }

            else if (masterCode.Text == "" || masterCode.Text == "M78789898")
            {
                MessageBox.Show("Please enter PassCode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { MessageBox.Show("Incorrect passcode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }
    }
    }

