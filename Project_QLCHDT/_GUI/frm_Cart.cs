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
    public partial class frm_Cart : Form
    {
        frm_Payment parentform;
        public frm_Cart(frm_Payment payf)
        {
            InitializeComponent();
            parentform = payf;
        }
        public void ShowData(BindingList<Entity.Entity_Product> list_paid)
        {
            dgvCART.DataSource = list_paid;
            dgvCART.Columns[9].DefaultCellStyle.Format = "N0";
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            parentform.set_cart_num(count_cart_num());
            this.Close();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (int.Parse(dgvCART.CurrentRow.Cells[4].Value.ToString()) > 1)
            {
                dgvCART.CurrentRow.Cells[4].Value = int.Parse(dgvCART.CurrentRow.Cells[4].Value.ToString()) - 1;
            }
            else if (int.Parse(dgvCART.CurrentRow.Cells[4].Value.ToString()) == 1)
            {
                dgvCART.Rows.Remove(dgvCART.CurrentRow);
            }
        }

        private void btnPAY_Click(object sender, EventArgs e)
        {
            frm_CustomerInfo cusinfo = new frm_CustomerInfo(this);
            cusinfo.ShowDialog();
        }
        public void getSourse(DataGridView des_sourse)
        {
            des_sourse.DataSource = dgvCART.DataSource;
        }
        public void clearSource()
        {
            foreach (DataGridViewRow row in dgvCART.Rows)
            {
                dgvCART.Rows.Remove(row);
            }
            parentform.set_cart_num(0);
        }
        public int count_cart_num()
        {
            int total = 0;
            foreach (DataGridViewRow row in dgvCART.Rows)
            {
                total += int.Parse(row.Cells[4].Value.ToString());
            }
            return total;
        }

        private void frm_Cart_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel1, Color.Black, 30, 3, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel1, Color.Black, 30, 3, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);

            var vscroolbar = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvCART, gunaVScrollBar1, true);
            hide_info();
            change_colname();
        }
        private void change_colname()
        {
            dgvCART.Columns[0].HeaderText = "ID";
            dgvCART.Columns[1].HeaderText = "Product";
            dgvCART.Columns[2].HeaderText = "Type";
            dgvCART.Columns[3].HeaderText = "Brand";
            dgvCART.Columns[4].HeaderText = "Amount";
            dgvCART.Columns[5].HeaderText = "Color";
            dgvCART.Columns[6].HeaderText = "Dimension";
            dgvCART.Columns[7].HeaderText = "Made in";
            dgvCART.Columns[8].HeaderText = "Year";
            dgvCART.Columns[9].HeaderText = "Unit Price";
        }
        private void hide_info()
        {
            dgvCART.Columns["MaSP"].Visible = true;
            dgvCART.Columns["TenSP"].Visible = true;
            dgvCART.Columns["LoaiSP"].Visible = false;
            dgvCART.Columns["SoLuong"].Visible = true;
            dgvCART.Columns["ThuongHIeu"].Visible = true;
            dgvCART.Columns["MauSac"].Visible = true;
            dgvCART.Columns["KichThuoc"].Visible = false;
            dgvCART.Columns["NoiSanXuat"].Visible = false;
            dgvCART.Columns["NamSanXuat"].Visible = true;
        }
    }
}
