using _BUS;
using _DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _GUI
{
    public partial class frm_MainMenuCashier : Form
    {
        public frm_MainMenuCashier()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        public void openchildform(Form childform)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            gpnMAIN.Controls.Add(childform);
            gpnMAIN.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void abtnDATABASE_Click(object sender, EventArgs e)
        {
            openchildform(new frm_Database());
        }

        private void abtnPAYMENT_Click(object sender, EventArgs e)
        {
            openchildform(new frm_Payment());
        }

        private void abtnABOUT_Click(object sender, EventArgs e)
        {
            openchildform(new frm_About());
        }

        private void frm_MainMenuCashier_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel3, Color.Black, 30, 3, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel4, Color.Black, 30, 3, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection connect = DataProvider.Instance.connection();
                connect.Close();
                Application.Exit();
            }
        }
        public void setPicture()
        {
            string username = GlobalCurrentUser.GlobalUserID;
            _BUS.BUS_User.Instance.getPicture(username, picava);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cbbOPTION.Text == "Log Out")
            {
                frm_Login frml = new frm_Login();
                frml.Show();
                this.Close();
            }
        }
    }
}
