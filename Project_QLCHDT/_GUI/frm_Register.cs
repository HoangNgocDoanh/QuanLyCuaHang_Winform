using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _BUS;

namespace _GUI
{
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string type = "";
            if (GlobalCurrentType.GlobalUserTYPE == "Manager")
            {
                type = "Manager";
            }
            else type = "Cashier";
            MemoryStream picture = new MemoryStream();
            gunaPictureBox1.Image.Save(picture, gunaPictureBox1.Image.RawFormat);
            if (_BUS.BUS_User.Instance.Register(txtUSER.Text, txtPASS.Text, txtCONFIRM.Text, type, picture))
            {
                MessageBox.Show("Register Successfully!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Failed to register your account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ptbEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUPLOAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                gunaPictureBox1.Image = Image.FromFile(open.FileName);
                
            }
        }

        private void txtUSER_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUSER.Text))
            {
                errorProvider1.SetError(txtUSER, "Please enter your user name!");
            }
            else
            {
                errorProvider1.SetError(txtUSER, null);
            }
        }

        private void txtPASS_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPASS.Text))
            {
                errorProvider1.SetError(txtPASS, "Password is required!");
            }
            else
            {
                errorProvider1.SetError(txtPASS, null);
            }
        }

        private void txtCONFIRM_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCONFIRM.Text))
            {
                errorProvider1.SetError(txtCONFIRM, "Confirm your password!");
            }
            else
            {
                errorProvider1.SetError(txtCONFIRM, null);
            }
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
            tool.ToolTipTitle = "Register";
            tool.SetToolTip(txtUSER, "Username is not blank!");
            tool.SetToolTip(txtPASS, "Password must be 6 to 10 characters!");
            tool.SetToolTip(txtCONFIRM, "Password and confirm must be the same!");

            //help provider
            HelpProvider help = new HelpProvider();
            help.SetShowHelp(txtUSER, true);
            help.SetHelpString(txtUSER, "Enter your username!");

            help.SetShowHelp(txtPASS, true);
            help.SetHelpString(txtPASS, "Enter your password!");

            help.SetShowHelp(txtCONFIRM, true);
            help.SetHelpString(txtCONFIRM, "Confirm your password!");
        }

        private void frm_Register_Load(object sender, EventArgs e)
        {
            setTooltip();
        }

        private void txtUSER_Leave(object sender, EventArgs e)
        {
            if (txtUSER.Text == "") txtUSER.Text = "Username";
            txtUSER.ForeColor = Color.Silver;
        }

        private void txtUSER_Enter(object sender, EventArgs e)
        {
            if (txtUSER.Text == "Username") txtUSER.Text = "";
            txtUSER.ForeColor = Color.White;
        }

        private void txtPASS_Enter(object sender, EventArgs e)
        {
            if (txtPASS.Text == "Password")
            {
                txtPASS.PasswordChar = '*';
                txtPASS.Text = "";
            }
            txtPASS.ForeColor = Color.White;
        }

        private void txtPASS_Leave(object sender, EventArgs e)
        {
            if (txtPASS.Text == "")
            {
                txtPASS.PasswordChar = '\0';
                txtPASS.Text = "Password";
            }
            txtPASS.ForeColor = Color.Silver;
        }

        private void txtCONFIRM_Leave(object sender, EventArgs e)
        {
            if (txtCONFIRM.Text == "")
            {
                txtCONFIRM.PasswordChar = '\0';
                txtCONFIRM.Text = "Confirm";
            }
            txtCONFIRM.ForeColor = Color.Silver;
        }

        private void txtCONFIRM_Enter(object sender, EventArgs e)
        {
            if (txtCONFIRM.Text == "Confirm")
            {
                txtCONFIRM.PasswordChar = '*';
                txtCONFIRM.Text = "";
            }
            txtCONFIRM.ForeColor = Color.White;
        }
    }
}
