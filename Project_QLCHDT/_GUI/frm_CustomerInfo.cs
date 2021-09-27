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
    public partial class frm_CustomerInfo : Form
    {
        frm_Cart cartmain;
        public frm_CustomerInfo(frm_Cart cartf)
        {
            cartmain = cartf;
            InitializeComponent();
        }

        private void frm_CustomerInfo_Load(object sender, EventArgs e)
        {
            cartmain.getSourse(dgvPAY);
            change_colname();
            Hide_info();
            txtTOTALPRICE.Text = totalprice_consume();
            var vscroolbar = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvPAY, gunaVScrollBar1, true);
            var hscroolbar = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvPAY, gunaHScrollBar1, true);
           
            dgvPAY.Columns[9].DefaultCellStyle.Format = "N0";

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel1, Color.Black, 30, 3, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel1, Color.Black, 30, 3, Guna.UI.WinForms.VerHorAlign.HorizontalBottom);
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gpbSAVE_Click(object sender, EventArgs e)
        {
            string billid = txtBILLID.Text;
            string cus_name = txtCUSTOMER.Text;
            string cus_id = txtCMND.Text;
            DateTime date = dtpDATE.Value;
            bool check = true;
            foreach (DataGridViewRow row in dgvPAY.Rows)
            {
               check = _BUS.BUS_Reports.Instance.Them(billid, cus_name, cus_id, float.Parse(row.Cells[9].Value.ToString()), row.Cells[1].Value.ToString(), int.Parse(row.Cells[4].Value.ToString()), date, row.Cells[0].Value.ToString());
                if (!check) break;
            }
            if (check)
            {
                updatepaid_product();
                if (MessageBox.Show("Done", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    cartmain.clearSource();
                    cartmain.Close();
                    this.Close();
                }
            }
            else MessageBox.Show("Error");
        }
        private string totalprice_consume()
        {
            float total = 0;
            foreach (DataGridViewRow row in dgvPAY.Rows)
            {
                total += float.Parse(row.Cells[4].Value.ToString()) * float.Parse(row.Cells[9].Value.ToString());
                //total = amount * unit price
            }
            int final_price = Convert.ToInt32(total);
            return final_price.ToString("#,##0");
        }
        private void updatepaid_product()
        {
            foreach (DataGridViewRow row in dgvPAY.Rows)
            {  
                string masp = row.Cells[0].Value.ToString();
                string tensp = row.Cells[1].Value.ToString();
                string loaisp = row.Cells[2].Value.ToString();
                string thuonghieu = row.Cells[3].Value.ToString();

                //xử lý số lượng còn lại sau khi bán
                int old_amount = _BUS.BUS_Product.Instance.getSL(masp);
                int paid_amount = int.Parse(row.Cells[4].Value.ToString());
                int soluong = old_amount - paid_amount;

                string mausac = row.Cells[5].Value.ToString();
                string kichthuoc = row.Cells[6].Value.ToString();
                string noisanxuat = row.Cells[7].Value.ToString();
                int namsanxuat = int.Parse(row.Cells[8].Value.ToString());
                float dongia = float.Parse(row.Cells[9].Value.ToString());
                _BUS.BUS_Product.Instance.Sua(masp,tensp,loaisp,thuonghieu,soluong,mausac,kichthuoc,noisanxuat,namsanxuat,dongia);
            }
        }
        public void setData(DataGridView data, DataTable data_product)
        {
            txtBILLID.Text = data.CurrentRow.Cells[1].Value.ToString();
            txtCUSTOMER.Text = data.CurrentRow.Cells[2].Value.ToString();
            txtCMND.Text = data.CurrentRow.Cells[3].Value.ToString();
            float dongia = float.Parse(data.CurrentRow.Cells[5].Value.ToString());
            float soluong = float.Parse(data.CurrentRow.Cells[8].Value.ToString());
            txtTOTALPRICE.Text = (Convert.ToInt32(dongia * soluong)).ToString("#,##0");
            DataTable data_his = new DataTable();
            foreach (DataRow row in data_product.Rows)
            {
                if (row["MaHD"].ToString() == txtBILLID.Text) data_his.ImportRow(row);
            }
            data_his.Columns.Add("STT");
            data_his.Columns.Add("MaHD");
            data_his.Columns.Add("TenKH");
            data_his.Columns.Add("CMND");
            data_his.Columns.Add("Ngayban");
            data_his.Columns.Add("Tongtien");
            data_his.Columns.Add("TenSP");
            data_his.Columns.Add("MaSP");
            data_his.Columns.Add("Soluong");
            dgvPAY.DataSource = data_his;
            Hide_history_data();
        }
        private void change_colname()
        {
            dgvPAY.Columns[0].HeaderText = "ID";
            dgvPAY.Columns[1].HeaderText = "Product";
            dgvPAY.Columns[2].HeaderText = "Type";
            dgvPAY.Columns[3].HeaderText = "Brand";
            dgvPAY.Columns[4].HeaderText = "Amount";
            dgvPAY.Columns[5].HeaderText = "Color";
            dgvPAY.Columns[6].HeaderText = "Dimension";
            dgvPAY.Columns[7].HeaderText = "Made in";
            dgvPAY.Columns[8].HeaderText = "Year";
            dgvPAY.Columns[9].HeaderText = "Unit Price";
        }
        private void Hide_info()
        {
            dgvPAY.Columns["MaSP"].Visible = true;
            dgvPAY.Columns["TenSP"].Visible = true;
            dgvPAY.Columns["LoaiSP"].Visible = false;
            dgvPAY.Columns["SoLuong"].Visible = true;
            dgvPAY.Columns["ThuongHIeu"].Visible = false;
            dgvPAY.Columns["MauSac"].Visible = false;
            dgvPAY.Columns["KichThuoc"].Visible = false;
            dgvPAY.Columns["NoiSanXuat"].Visible = false;
            dgvPAY.Columns["NamSanXuat"].Visible = true;
        }
        private void Hide_history_data()
        {
            dgvPAY.Columns["STT"].Visible = false;
            dgvPAY.Columns["MaHD"].Visible = false;
            dgvPAY.Columns["TenKH"].Visible = false;
            dgvPAY.Columns["CMND"].Visible = false;
            dgvPAY.Columns["Ngayban"].Visible = false;
            dgvPAY.Columns["Tongtien"].Visible = true;
            dgvPAY.Columns["TenSP"].Visible = true;
            dgvPAY.Columns["MaSP"].Visible = true;
            dgvPAY.Columns["Soluong"].Visible = true;
        }
    }
}
