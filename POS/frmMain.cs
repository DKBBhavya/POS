﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            frmNew f = new frmNew();
            f.TopLevel = false;
            panelMain.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            frmItem f = new frmItem();
            f.TopLevel = false;
            panelMain.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            frmInvoice f = new frmInvoice();
            f.TopLevel = false;
            panelMain.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }
    }
}
