using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BloodBank
{
    public partial class registerLogin : Form
    {
        authorityAccess authaccess;

        private static string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=BloodBank;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();


        public registerLogin(authorityAccess authaccess)
        {
            InitializeComponent();


            InitializeComponent();

            //according custom userdashboard


            // Set the starting position of the form
            this.StartPosition = FormStartPosition.Manual; // You can change this to any other value mentioned above
            // Set the location of the form manually
            this.Location = new System.Drawing.Point(605, 175);
            this.authaccess = authaccess;
        }

       

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mloginBtn_Click(object sender, EventArgs e)
        {

            if (userNameText.Text == "naimul12" && passwordText.Text == "1234")
            {
                MessageBox.Show("Login Successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Login Successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            registerPanel rp = new registerPanel();
            rp.Show();
            this.Hide();
            authaccess.Hide();
        }
    }
}

