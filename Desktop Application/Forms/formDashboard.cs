using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop_Application.Forms
{
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
            dashboarduc1.BringToFront();
            labelTitle.Text = "Dashboard";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboarduc1.BringToFront();
            labelTitle.Text = "Dashboard";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            donersuc1.BringToFront();
            labelTitle.Text = "Add or Update Doner's Record";
        }
    }
}
