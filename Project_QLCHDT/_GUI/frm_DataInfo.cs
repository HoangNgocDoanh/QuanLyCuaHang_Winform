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
    public partial class frm_DataInfo : Form
    {
        frm_Database maindb;
        public frm_DataInfo(frm_Database db)
        {
            maindb = db;
            InitializeComponent();
        }

        private void gunaPictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DataInfo_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaShadowPanel1, Color.Black, 30, 3, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaShadowPanel1, Color.Black, 30, 3, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);
        }
        public void ShowInfo(DataGridView data)
        {
            txtPRODUCTID.Text = data.CurrentRow.Cells[0].Value.ToString();
            txtPRODUCT.Text = data.CurrentRow.Cells[1].Value.ToString();
            txtTYPE.Text = data.CurrentRow.Cells[2].Value.ToString();
            txtBRAND.Text = data.CurrentRow.Cells[3].Value.ToString();
            txtAMOUNT.Text = data.CurrentRow.Cells[4].Value.ToString();
            txtCOLOR.Text = data.CurrentRow.Cells[5].Value.ToString();
            txtDIMENSIONS.Text = data.CurrentRow.Cells[6].Value.ToString();
            txtMADEIN.Text = data.CurrentRow.Cells[7].Value.ToString();
            txtYEAR.Text = data.CurrentRow.Cells[8].Value.ToString();
            txtUNITPRICE.Text = data.CurrentRow.Cells[9].Value.ToString();
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
            this.txtPRODUCTID.ReadOnly = true;
            this.ptbXOA.Show();
        }
        public void Cashier_mode()
        {
            this.gpbSAVE.Hide();
            this.gbtnADD.Hide();
            this.ptbXOA.Hide();
        }
        private void gpbSAVE_Click(object sender, EventArgs e)
        {
            if (_BUS.BUS_Product.Instance.Sua(txtPRODUCTID.Text, txtPRODUCT.Text, txtTYPE.Text, txtBRAND.Text, int.Parse(txtAMOUNT.Text), txtCOLOR.Text, txtDIMENSIONS.Text, txtMADEIN.Text, int.Parse(txtYEAR.Text), float.Parse(txtUNITPRICE.Text)))
            {
                MessageBox.Show("Product Updated", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Error", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gbtnADD_Click(object sender, EventArgs e)
        {
            if (_BUS.BUS_Product.Instance.Them(txtPRODUCTID.Text, txtPRODUCT.Text, txtTYPE.Text, txtBRAND.Text, int.Parse(txtAMOUNT.Text), txtCOLOR.Text, txtDIMENSIONS.Text, txtMADEIN.Text, int.Parse(txtYEAR.Text), float.Parse(txtUNITPRICE.Text)))
            {
                MessageBox.Show("New Product Added", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Error", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ptbXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (_BUS.BUS_Product.Instance.Xoa(txtPRODUCTID.Text))
                {
                    //reload form
                    maindb.frm_Database_Load(sender, e);
                    MessageBox.Show("Product Deleted", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Error", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
