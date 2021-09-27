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
    public partial class frm_History : Form
    {
        public frm_History()
        {
            InitializeComponent();
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataTable getHistory()
        {
            DataTable data = null;
            DataTable data_history = new DataTable();
            data = _BUS.BUS_Reports.Instance.getReports();
            data_history.Columns.Add("STT");
            data_history.Columns.Add("MaHD");
            data_history.Columns.Add("TenKH");
            data_history.Columns.Add("CMND");
            data_history.Columns.Add("Ngayban");
            data_history.Columns.Add("Tongtien");
            data_history.Columns.Add("TenSP");
            data_history.Columns.Add("MaSP");
            data_history.Columns.Add("Soluong");
            if (data.Rows.Count > 0)
            {
                string previous_id = data.Rows[0]["MaHD"].ToString();
                DataRow row_toadd = data.Rows[0];
                data_history.ImportRow(row_toadd);
                foreach (DataRow row in data.Rows)
                {
                    if (row["MaHD"].ToString() != previous_id)
                    {
                        data_history.ImportRow(row);
                        previous_id = row["MaHD"].ToString();
                    }
                }
            }
            return data_history;
        }

        private void frm_History_Load(object sender, EventArgs e)
        {
            DataTable data = getHistory();
            dgvHISTORY.DataSource = data;
            dgvHISTORY.Columns[5].DefaultCellStyle.Format = "N0";
        }

        //private void dgvHISTORY_DoubleClick(object sender, EventArgs e)
        //{
        //    frm_CustomerInfo frmcusinfo = new frm_CustomerInfo(new frm_Cart(new frm_Payment()));

        //    frmcusinfo.setData(dgvHISTORY, _BUS.BUS_Reports.Instance.getReports());
        //    frmcusinfo.ShowDialog();
        //}
    }
}
