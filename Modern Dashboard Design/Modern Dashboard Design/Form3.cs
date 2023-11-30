using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Modern_Dashboard_Design
{
    public partial class Form3 : Form

    {
        public object Content { get; private set; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
     (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
         int nHeightEllipse

      );

        public Form3()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;

            lblTitle.Text = "Report";
            this.PnlFormLoader.Controls.Clear();
            report FrmDashboard_Vrb = new report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void BtnCalander_Click(object sender, EventArgs e)
        {

        }

        private void BtnContactUs_Click(object sender, EventArgs e)
        {

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAddUser.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnCalander_Leave(object sender, EventArgs e)
        {
            btnAddItem.BackColor = Color.FromArgb(24, 30, 54);
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnAnalytics_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnCalander_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new login().ShowDialog();

        }

        private void setting_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAddUser.Height;
            pnlNav.Top = btnAddUser.Top;

            lblTitle.Text = "Setting";
            this.PnlFormLoader.Controls.Clear();
            empSetting FrmDashboard_Vrb = new empSetting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;

            lblTitle.Text = "Report";
            this.PnlFormLoader.Controls.Clear();
            report FrmDashboard_Vrb = new report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAddUser.Height;
            pnlNav.Top = btnAddUser.Top;

            lblTitle.Text = "User log";
            this.PnlFormLoader.Controls.Clear();
            userLog FrmDashboard_Vrb = new userLog() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAddItem.Height;
            pnlNav.Top = btnAddItem.Top;

            lblTitle.Text = "Add Item";
            this.PnlFormLoader.Controls.Clear();
            addItem FrmDashboard_Vrb = new addItem() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void setting_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = manage.Height;
            pnlNav.Top = manage.Top;

            lblTitle.Text = "Requested Items";
            this.PnlFormLoader.Controls.Clear();
            request FrmDashboard_Vrb = new request() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            new login().ShowDialog();
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button2.Height;
            pnlNav.Top = button2.Top;

            lblTitle.Text = "Setting";
            this.PnlFormLoader.Controls.Clear();
            empSetting FrmDashboard_Vrb = new empSetting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
    }
}
