using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace BloodBank
{
    public partial class ManagerLogin : Form
    {
        authorityAccess authaccess;


        private static string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=BloodBank;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();


        public ManagerLogin(authorityAccess authaccess)
        {
            InitializeComponent();

            //according custom userdashboard


            // Set the starting position of the form
            this.StartPosition = FormStartPosition.Manual; // You can change this to any other value mentioned above
            // Set the location of the form manually
            this.Location = new System.Drawing.Point(605, 180);  
            this.authaccess = authaccess;
        }

        private void loginBtn_Click(object sender, EventArgs e)

        {
            

                string username = userNameText.Text;
                string password = passwordText.Text;

                try
                {

                    string querry = "SELECT * from manager_info where m_username = '" + userNameText.Text + "' AND m_password = '" + passwordText.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        username = userNameText.Text;
                        password = passwordText.Text;

                        MessageBox.Show("Login Successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        managerPanel mp = new managerPanel();
                        mp.Show();
                        this.Hide();
                        authaccess.Hide();
                    }

                    else
                    { MessageBox.Show("Invalid login deatails", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Invalid login deatails", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
