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
    public partial class frm_Payment : Form
    {
        public frm_Payment()
        {
            InitializeComponent();
        }
        BindingList<Entity.Entity_Product> list_paid_product = new BindingList<Entity.Entity_Product>();
        int paid_product_count = 0;
        private void frm_Payment_Load(object sender, EventArgs e)
        {
            _BUS.BUS_Product.Instance.Xem(dgv);
            change_colname();
            Hide_info();
            var vscroolbar = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgv, gunaVScrollBar1, true);
            var hscroolbar = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgv, gunaHScrollBar1, true);
            //hiển thị số chữ số sau dấu phẩy
            dgv.Columns[9].DefaultCellStyle.Format = "N0";
            dgv.AutoResizeColumns();
        }

        private void gbtnADDTOCART_Click(object sender, EventArgs e)
        {
            //Xử lý trước khi thêm vào list mua tạm(cart)
            string productID = dgv.CurrentRow.Cells[0].Value.ToString();
            string product = dgv.CurrentRow.Cells[1].Value.ToString();
            string type = dgv.CurrentRow.Cells[2].Value.ToString();
            string brand = dgv.CurrentRow.Cells[3].Value.ToString();
            string color = dgv.CurrentRow.Cells[5].Value.ToString();
            string dimension = dgv.CurrentRow.Cells[6].Value.ToString();
            string madein = dgv.CurrentRow.Cells[7].Value.ToString();
            string year = dgv.CurrentRow.Cells[8].Value.ToString();
            string unitprice = dgv.CurrentRow.Cells[9].Value.ToString();

            Entity.Entity_Product paid_product = new Entity.Entity_Product(productID, product, type, brand, 1, color, dimension, madein, int.Parse(year),float.Parse(unitprice));
            int index = 0;
            while (index < list_paid_product.Count)
            {
                if (list_paid_product[index].MaSP == paid_product.MaSP) break;
                index++;
            }
            if (index >= list_paid_product.Count) list_paid_product.Add(paid_product);
            else list_paid_product[index].Soluong++;
            paid_product_count++;

            //Thay đổi cart
            gbtnCART.Text = "Cart: " + paid_product_count.ToString();
        }

        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            _BUS.BUS_Product.Instance.Search(dgv, txtSEARCH.Text);
        }

        private void gbtnCART_Click(object sender, EventArgs e)
        {
            frm_Cart cartf = new frm_Cart(this);
            cartf.ShowData(list_paid_product);
            cartf.ShowDialog();

            //reload form
            frm_Payment_Load(sender, e);
        }
        internal void set_cart_num(int number)
        {
            gbtnCART.Text = "Cart: " + number.ToString();
            paid_product_count = number;
        }
        private void change_colname()
        {
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "Product";
            dgv.Columns[2].HeaderText = "Type";
            dgv.Columns[3].HeaderText = "Brand";
            dgv.Columns[4].HeaderText = "Amount";
            dgv.Columns[5].HeaderText = "Color";
            dgv.Columns[6].HeaderText = "Dimension";
            dgv.Columns[7].HeaderText = "Made in";
            dgv.Columns[8].HeaderText = "Year";
            dgv.Columns[9].HeaderText = "Unit Price";
        }
        private void Hide_info()
        {
            dgv.Columns["MaSP"].Visible = true;
            dgv.Columns["TenSP"].Visible = true;
            dgv.Columns["LoaiSP"].Visible = false;
            dgv.Columns["SoLuong"].Visible = true;
            dgv.Columns["ThuongHIeu"].Visible = false;
            dgv.Columns["MauSac"].Visible = false;
            dgv.Columns["KichThuoc"].Visible = false;
            dgv.Columns["NoiSanXuat"].Visible = false;
            dgv.Columns["NamSanXuat"].Visible = true;
        }

        private void btnHISTORY_Click(object sender, EventArgs e)
        {
            frm_History history = new frm_History();
            history.ShowDialog();
        }
    }
}
