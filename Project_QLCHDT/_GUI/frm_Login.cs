using _DAL;
using _BUS;
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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void lblNEWUSER_Click(object sender, EventArgs e)
        {
            frm_Register frm = new frm_Register();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void ptbCLOSE_Click(object sender, EventArgs e)
        {
            _DAL.DataProvider.Instance.connection().Close();
            Application.Exit();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            if (_BUS.BUS_User.Instance.Login(txtUSERNAME.Text, txtPASSWORD.Text))
            {
                string type = BUS_User.Instance.getType(txtUSERNAME.Text);
                GlobalCurrentType.SetGlobalUserTYPE(type);
                if (type == rbtnCASHIER.Text && rbtnMANAGER.Checked)
                {
                    MessageBox.Show("You don't have permission to access this mode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (rbtnMANAGER.Checked)
                {
                    GlobalCurrentUser.SetGlobalUser(txtUSERNAME.Text);
                    frm_MainForm mainf = new frm_MainForm();
                    this.Hide();
                    MySqlConnection connect = DataProvider.Instance.connection();
                    frm_Splashscreen splash = new frm_Splashscreen();
                    splash.Show();
                    connect.Open();
                    mainf.setPicture();
                    splash.Close();
                    mainf.ShowDialog();
                }
                else if (rbtnCASHIER.Checked)
                {
                    GlobalCurrentUser.SetGlobalUser(txtUSERNAME.Text);
                    frm_MainMenuCashier mainf = new frm_MainMenuCashier();
                    this.Hide();
                    MySqlConnection connect = DataProvider.Instance.connection();
                    frm_Splashscreen splash = new frm_Splashscreen();
                    splash.Show();
                    connect.Open();
                    mainf.setPicture();
                    splash.Close();
                    mainf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please choose your account type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void setTooltip()
        {
            //Tooltip
            ToolTip tool = new ToolTip();
            tool.IsBalloon = true;
            //xuất hiện trong 5s
            tool.AutoPopDelay = 5000;
            //hiện trong 1s
            tool.InitialDelay = 1000;
            //mở lại sau 0.5s
            tool.ReshowDelay = 500;
            tool.ToolTipIcon = ToolTipIcon.Info;
            tool.ToolTipTitle = "Login";
            tool.SetToolTip(txtUSERNAME, "Username is not blank!");
            tool.SetToolTip(txtPASSWORD, "Password must be 6 to 10 characters!");

            //help provider
            HelpProvider help = new HelpProvider();
            help.SetShowHelp(txtUSERNAME, true);
            help.SetHelpString(txtUSERNAME, "Enter your username!");
            help.SetShowHelp(txtPASSWORD, true);
            help.SetHelpString(txtPASSWORD, "Enter your password!");
        }

        private void txtUSERNAME_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUSERNAME.Text))
            {
                errorProvider1.SetError(txtUSERNAME, "Please enter your user name!");
            }
            else
            {
                errorProvider1.SetError(txtUSERNAME, null);
            }
        }

        private void txtPASSWORD_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPASSWORD.Text))
            {
                errorProvider1.SetError(txtPASSWORD, "Password is required!");
            }
            else
            {
                errorProvider1.SetError(txtPASSWORD, null);
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            setTooltip();
        }

        private void txtUSERNAME_Enter(object sender, EventArgs e)
        {
            if (txtUSERNAME.Text == "Username") txtUSERNAME.Text = "";
            txtUSERNAME.ForeColor = Color.White;
        }

        private void txtUSERNAME_Leave(object sender, EventArgs e)
        {
            if (txtUSERNAME.Text == "") txtUSERNAME.Text = "Username";
            txtUSERNAME.ForeColor = Color.Silver;
        }

        private void txtPASSWORD_Leave(object sender, EventArgs e)
        {
            if (txtPASSWORD.Text == "")
            {
                txtPASSWORD.PasswordChar = '\0';
                txtPASSWORD.Text = "Password";
            }
            txtPASSWORD.ForeColor = Color.Silver;
        }

        private void txtPASSWORD_Enter(object sender, EventArgs e)
        {
            if (txtPASSWORD.Text == "Password")
            {
                txtPASSWORD.PasswordChar = '*';
                txtPASSWORD.Text = "";
            }
            txtPASSWORD.ForeColor = Color.White;
        }
    }
}
