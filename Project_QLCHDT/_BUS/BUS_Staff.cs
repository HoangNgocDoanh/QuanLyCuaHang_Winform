using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _DAL;

namespace _BUS
{
    public class BUS_Staff
    {
        private static BUS_Staff instance;

        public static BUS_Staff Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Staff();
                }
                return instance;
            }

        }
        public BUS_Staff() { }
        public void Xem(DataGridView data)
        {
          data.DataSource = _DAL.DAL_Staff.Instance.Xem();
        }

        public void Xem_supervisor(DataGridView data_supervisor)
        {
            data_supervisor.DataSource = _DAL.DAL_Staff.Instance.Xem_supervisor();
        }

        public void Xem_staff(DataGridView data_staff)
        {
            data_staff.DataSource = _DAL.DAL_Staff.Instance.Xem_staff();
        }

        public void Load_cbb(ComboBox data_cbb)
        {
            data_cbb.DataSource = new List<string> {"Supervisor","Staff" };
        }

        public void Search(DataGridView data_search, string search_asset)
        {
            data_search.DataSource = _DAL.DAL_Staff.Instance.Search(search_asset);
        }

        //Kiểm tra dữ liệu nhập vào
        private bool verif(string manv, string tennv, DateTime namsinh, int cmnd, int sdt, string diachi, string nguyenquan, int sotaikhoan, string chucvu)        {            if ((manv.Trim() == "") || (tennv.Trim() == "")
                || (namsinh.Year > DateTime.Now.Year) || (cmnd.ToString().Trim() == "")
                || (Convert.ToString(sdt).Trim() == "") || (diachi.Trim() == "")
                || (nguyenquan.Trim() == "" || (sotaikhoan.ToString().Trim() == "")
                || (chucvu.Trim() == "")))            {                return false;            }            else            {                return true;            }        }

        public bool Them(string manv, string tennv, DateTime namsinh, int cmnd, int sdt, string diachi, string nguyenquan, int sotaikhoan, string chucvu)
        {
            if (verif(manv,tennv,namsinh,cmnd,sdt,diachi,nguyenquan,sotaikhoan,chucvu))
            {
                return _DAL.DAL_Staff.Instance.Them(manv, tennv, namsinh, cmnd, sdt, diachi, nguyenquan, sotaikhoan, chucvu);
            }
            return false;
        }

        public bool Sua(string manv, string tennv, DateTime namsinh, int cmnd, int sdt, string diachi, string nguyenquan, int sotaikhoan, string chucvu)
        {
            if (verif(manv, tennv, namsinh, cmnd, sdt, diachi, nguyenquan, sotaikhoan, chucvu))
            {
                return _DAL.DAL_Staff.Instance.Sua(manv, tennv, namsinh, cmnd, sdt, diachi, nguyenquan, sotaikhoan, chucvu);
            }
            return false;
        }
        public bool Xoa(string manv)
        {
            if (manv != "")
            {
                return _DAL.DAL_Staff.Instance.Xoa(manv);
            }
            return false;
        }
    }
}
