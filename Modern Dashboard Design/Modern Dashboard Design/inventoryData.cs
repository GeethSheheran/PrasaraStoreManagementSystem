using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Dashboard_Design
{
    public partial class inventoryData : Form
    {
        public inventoryData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Location = this.PnlFormLoader.Location;
            this.PnlFormLoader.Show();
            this.PnlFormLoader.BringToFront();

            this.PnlFormLoader.Controls.Clear();
            addItem FrmDashboard_Vrb = new addItem() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
    }
}
