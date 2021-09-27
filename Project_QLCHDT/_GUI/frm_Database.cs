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
    public partial class frm_Database : Form
    {
        public frm_Database()
        {
            InitializeComponent();
        }
        //Chỉnh các columns hiển thị của datagridview
        private void Show_view()
        {
            gdgvDATABASE.Columns["MaSP"].Visible = true;
            gdgvDATABASE.Columns["TenSP"].Visible = true;
            gdgvDATABASE.Columns["LoaiSP"].Visible = true;
            gdgvDATABASE.Columns["SoLuong"].Visible = true;
            gdgvDATABASE.Columns["ThuongHIeu"].Visible = false;
            gdgvDATABASE.Columns["MauSac"].Visible = false;
            gdgvDATABASE.Columns["KichThuoc"].Visible = false;
            gdgvDATABASE.Columns["NoiSanXuat"].Visible = false;
            gdgvDATABASE.Columns["NamSanXuat"].Visible = false;
        }
        private void Show_type()
        {
            gdgvDATABASE.Columns["MaSP"].Visible = false;
            gdgvDATABASE.Columns["TenSP"].Visible = false;
            gdgvDATABASE.Columns["LoaiSP"].Visible = true;
            gdgvDATABASE.Columns["SoLuong"].Visible = false;
            gdgvDATABASE.Columns["ThuongHieu"].Visible = false;
            gdgvDATABASE.Columns["MauSac"].Visible = false;
            gdgvDATABASE.Columns["KichThuoc"].Visible = false;
            gdgvDATABASE.Columns["NoiSanXuat"].Visible = false;
            gdgvDATABASE.Columns["NamSanXuat"].Visible = false;
            gdgvDATABASE.Columns["Dongia"].Visible = false;
        }

        public void frm_Database_Load(object sender, EventArgs e)
        {
           if (gbtnVIEW.Checked)
            {
                BUS_Product.Instance.Xem(gdgvDATABASE);
                change_colname();
                Show_view();
            }
            var hscroolbar = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(gdgvDATABASE, gunaHScrollBar1, true);
            var vscroolbar = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(gdgvDATABASE, gunaVScrollBar1, true);
            gdgvDATABASE.Columns[9].DefaultCellStyle.Format = "N0";
        }

        private void gdgvDATABASE_DoubleClick(object sender, EventArgs e)
        {
            frm_DataInfo frm = new frm_DataInfo(this);
            frm.ShowInfo(gdgvDATABASE);
            frm.Edit_mode();
            if (GlobalCurrentType.GlobalUserTYPE == "Cashier") frm.Cashier_mode();
            frm.ShowDialog();
        }

        private void gbtnTYPE_Click(object sender, EventArgs e)
        {
            BUS_Product.Instance.Xem_type(gdgvDATABASE);
            Show_type();
        }

        private void gbtnVIEW_Click(object sender, EventArgs e)
        {
            frm_Database_Load(sender, e);
            Show_view();
        }

        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            gbtnVIEW.Checked = true;
            BUS_Product.Instance.Search(gdgvDATABASE, txtSEARCHASSETS.Text);
            Show_view();
        }
        private void change_colname()
        {
            gdgvDATABASE.Columns[0].HeaderText = "ID";
            gdgvDATABASE.Columns[1].HeaderText = "Product";
            gdgvDATABASE.Columns[2].HeaderText = "Type";
            gdgvDATABASE.Columns[3].HeaderText = "Brand";
            gdgvDATABASE.Columns[4].HeaderText = "Amount";
            gdgvDATABASE.Columns[5].HeaderText = "Color";
            gdgvDATABASE.Columns[6].HeaderText = "Dimension";
            gdgvDATABASE.Columns[7].HeaderText = "Made in";
            gdgvDATABASE.Columns[8].HeaderText = "Year";
            gdgvDATABASE.Columns[9].HeaderText = "Unit Price";
        }
    }
}
