using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _BUS;
namespace _GUI
{
    public partial class frm_PerInfo : Form
    {
        frm_Manage mainmanage;
        public frm_PerInfo(frm_Manage manage)
        {
            mainmanage = manage;
            InitializeComponent();
        }

        private void frm_PerInfo_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel1, Color.Black, 30, 3, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel1, Color.Black, 30, 3, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);
        }

        public void Add_mode()
        {
            this.gpbSAVE.Hide();
            this.gbtnADD.Show();
            this.ptbXOA.Hide();
        }
        public void Edit_mode()
        {
            this.gpbSAVE.Show();
            this.gbtnADD.Hide();
            this.ptbXOA.Show();
            this.txtSTAFFID.ReadOnly = true;
        }
        public void Cashier_mode()
        {
            this.gpbSAVE.Hide();
            this.gbtnADD.Hide();
            this.ptbXOA.Hide();
        }
        public void Load_cbb()
        {
            _BUS.BUS_Staff.Instance.Load_cbb(cbbPOSITION);
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ShowInfo(DataGridView data)
        {
            txtSTAFFID.Text = data.CurrentRow.Cells[0].Value.ToString();
            txtFULLNAME.Text = data.CurrentRow.Cells[1].Value.ToString();
            gunaDateTimePicker1.Value = (DateTime)data.CurrentRow.Cells[2].Value;
            txtID.Text = data.CurrentRow.Cells[3].Value.ToString();
            txtPHONE.Text = data.CurrentRow.Cells[4].Value.ToString();
            txtADDRESS.Text = data.CurrentRow.Cells[5].Value.ToString();
            txtDOMICILE.Text = data.CurrentRow.Cells[6].Value.ToString();
            txtACCOUNTNUM.Text = data.CurrentRow.Cells[7].Value.ToString();
            cbbPOSITION.Text = data.CurrentRow.Cells[8].Value.ToString();

        }

        private void gpbSAVE_Click(object sender, EventArgs e)
        {
            if (_BUS.BUS_Staff.Instance.Sua(txtSTAFFID.Text,txtFULLNAME.Text, gunaDateTimePicker1.Value,int.Parse(txtID.Text), int.Parse(txtPHONE.Text), txtADDRESS.Text, txtDOMICILE.Text, int.Parse(txtACCOUNTNUM.Text), cbbPOSITION.Text))
            {
                MessageBox.Show("Staff Updated", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Error", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gbtnADD_Click(object sender, EventArgs e)
        {
            if (_BUS.BUS_Staff.Instance.Them(txtSTAFFID.Text, txtFULLNAME.Text, gunaDateTimePicker1.Value, int.Parse(txtID.Text), int.Parse(txtPHONE.Text), txtADDRESS.Text, txtDOMICILE.Text, int.Parse(txtACCOUNTNUM.Text), cbbPOSITION.Text))
            {
                MessageBox.Show("New Staff Added", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Error", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ptbXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Staff", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (_BUS.BUS_Staff.Instance.Xoa(txtSTAFFID.Text))
                {
                    //reload form
                    mainmanage.frm_Manage_Load(sender, e);
                    MessageBox.Show("Staff Deleted", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Error", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
