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
    public partial class HospitalStock : Form
    {
        public HospitalStock()
        {
            InitializeComponent();
        }

        private void HospitalStock_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            managerPanel managerPanel = new managerPanel();
            managerPanel.Show();
            this.Hide();
        }
    }
}
