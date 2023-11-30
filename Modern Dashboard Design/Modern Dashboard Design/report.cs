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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();

        }

        public static implicit operator report(viewItem v)
        {
            throw new NotImplementedException();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Location = this.PnlFormLoader.Location;
            this.PnlFormLoader.Show();
            this.PnlFormLoader.BringToFront();

            this.PnlFormLoader.Controls.Clear();
            viewIssued FrmDashboard_Vrb = new viewIssued() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.PnlFormLoader.Location = this.PnlFormLoader.Location;
            this.PnlFormLoader.Show();
            this.PnlFormLoader.BringToFront();

            this.PnlFormLoader.Controls.Clear();
            inventoryData FrmDashboard_Vrb = new inventoryData() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Location = this.PnlFormLoader.Location;
            this.PnlFormLoader.Show();
            this.PnlFormLoader.BringToFront();

            this.PnlFormLoader.Controls.Clear();
            fullInventory FrmDashboard_Vrb = new fullInventory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Location = this.PnlFormLoader.Location;
            this.PnlFormLoader.Show();
            this.PnlFormLoader.BringToFront();

            this.PnlFormLoader.Controls.Clear();
            fullIssuedItems FrmDashboard_Vrb = new fullIssuedItems() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
    }
}
