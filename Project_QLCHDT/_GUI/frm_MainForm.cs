using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna;
using _BUS;
using MySql.Data.MySqlClient;
using _DAL;

namespace _GUI
{
    public partial class frm_MainForm : Form
    {
        public frm_MainForm()
        {
            InitializeComponent();
        }
        private static frm_MainForm instance;
        public static frm_MainForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frm_MainForm();
                }
                return instance;
            }

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
        private void frm_MainForm_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel3, Color.Black, 30, 3, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel4, Color.Black, 30, 3, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);
        }

        private void abtnDATABASE_Click(object sender, EventArgs e)
        {
            openchildform(new frm_Database());      
        }

        private void abtnMANAGE_Click(object sender, EventArgs e)
        {
            openchildform(new frm_Manage());
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            openchildform(new frm_Payment());
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            openchildform(new frm_Reports());
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            openchildform(new frm_About());
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

        private void abtnCREATEASSET_Click(object sender, EventArgs e)
        {
            if (abtnDATABASE.Checked)
            {
                frm_DataInfo datafrm = new frm_DataInfo(new frm_Database());
                datafrm.Add_mode();
                datafrm.ShowDialog();
            }
            else if (abtnMANAGE.Checked)
            {
                frm_PerInfo perfrm = new frm_PerInfo(new frm_Manage());
                perfrm.Add_mode();
                perfrm.Load_cbb();
                perfrm.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (abtnDATABASE.Checked || abtnMANAGE.Checked) abtnCREATEASSET.Enabled = true;
            else abtnCREATEASSET.Enabled = false;
        }
        public void setPicture()
        {
            string username = GlobalCurrentUser.GlobalUserID;
            _BUS.BUS_User.Instance.getPicture(username, picava);
        }

        private void ccbOPTION_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ccbOPTION.Text == "Log Out")
            {
                frm_Login frml = new frm_Login();
                frml.Show();
                this.Close();
            }
            if (ccbOPTION.Text == "Add New Manager")
            {
                frm_Register frmreg = new frm_Register();
                frmreg.ShowDialog();
            }
        }
    }
}
