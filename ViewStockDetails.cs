using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BloodBank
{
    public partial class ViewStockDetails : Form
    {

        private static string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=BloodBank;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();
        public ViewStockDetails()
        {
            InitializeComponent();
        }

        private void hsearchBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT hospital_name, h_stock , h_phone, h_email, h_city, h_address from hospital_info where h_id = '" + hText.Text + "' ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void hallBtn_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *  from hospital_info";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void bbsearchBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT bb_name, bb_stock , bb_phone, bb_email, bb_city, bb_address from bb_info where bb_id = '" + bbText.Text + "' ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void bballBtn_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *  from bb_info";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            managerPanel managerPanel = new managerPanel();
            managerPanel.Show();
            this.Hide();
        }
    }
}
