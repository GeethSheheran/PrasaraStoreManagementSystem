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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            string id = textBox1.Text;
            string pass = textBox2.Text;

            if(id == "1")
            {
                new Form1().ShowDialog();
            }
            else if(id == "2")
            {
                new Form2().ShowDialog();
            }
            else if(id == "3")
            {
                new Form3().Show();
            }
            else if(id == "4")
            {
                new Form4().ShowDialog();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
