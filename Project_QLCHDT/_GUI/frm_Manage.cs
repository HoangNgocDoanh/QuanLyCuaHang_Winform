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
    public partial class frm_Manage : Form
    {
        public frm_Manage()
        {
            InitializeComponent();
            
        }
        private static frm_Manage instance;

        public static frm_Manage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frm_Manage();
                }
                return instance;
            }

        }
        private void Hide_info()
        {
            gdgvMANAGE.Columns["Namsinh"].Visible = false;
            gdgvMANAGE.Columns["SDT"].Visible = false;
            gdgvMANAGE.Columns["Diachi"].Visible = false;
            gdgvMANAGE.Columns["NguyenQuan"].Visible = false;
            gdgvMANAGE.Columns["Sotaikhoan"].Visible = false;
        }
        public void frm_Manage_Load(object sender, EventArgs e)
        {
            BUS_Staff.Instance.Xem(gdgvMANAGE);
            change_colname();
            Hide_info();
        }

        private void gdgvMANAGE_DoubleClick(object sender, EventArgs e)
        {
            frm_PerInfo frmper = new frm_PerInfo(this);
            if (GlobalCurrentType.GlobalUserTYPE == "Cashier") frmper.Cashier_mode();
            frmper.Load_cbb();
            frmper.ShowInfo(gdgvMANAGE);
            frmper.Edit_mode();
            frmper.ShowDialog();
        }

        private void gbtnSUPERVISOR_Click(object sender, EventArgs e)
        {
            BUS_Staff.Instance.Xem_supervisor(gdgvMANAGE);
            Hide_info();
        }

        private void gbtnSTAFF_Click(object sender, EventArgs e)
        {
            BUS_Staff.Instance.Xem_staff(gdgvMANAGE);
            Hide_info();
        }

        private void gbtnALL_Click(object sender, EventArgs e)
        {
            frm_Manage_Load(sender, e);
        }

        private void cbtnSEARCH_Click(object sender, EventArgs e)
        {
            gbtnALL.Checked = true;
            _BUS.BUS_Staff.Instance.Search(gdgvMANAGE, txtSEARCHASSETS.Text);
            Hide_info();
        }
        private void change_colname()
        {
            gdgvMANAGE.Columns[0].HeaderText = "ID";
            gdgvMANAGE.Columns[1].HeaderText = "Staff";
            gdgvMANAGE.Columns[2].HeaderText = "DOB";
            gdgvMANAGE.Columns[3].HeaderText = "ID Card";
            gdgvMANAGE.Columns[4].HeaderText = "Phone";
            gdgvMANAGE.Columns[5].HeaderText = "Address";
            gdgvMANAGE.Columns[6].HeaderText = "Domicile";
            gdgvMANAGE.Columns[7].HeaderText = "Account";
            gdgvMANAGE.Columns[8].HeaderText = "Position";
        }
    }
}
