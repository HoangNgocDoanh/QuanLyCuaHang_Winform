using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace _DAL
{
    public class DAL_Staff
    {
        private static DAL_Staff instance;

        public static DAL_Staff Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Staff();
                }
                return instance;
            }

        }
        private DAL_Staff() { }

        public List<Entity_Staff> Xem()
        {
            List<Entity_Staff> users = new List<Entity_Staff>();
            string query = "select * from Staff";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string manv = item["MaNV"].ToString();
                string tennv = item["TenNV"].ToString();
                DateTime namsinh = (DateTime)item["Namsinh"];
                int cmnd = Convert.ToInt32(item["CMND"].ToString());
                int sdt = Convert.ToInt32(item["SDT"].ToString());
                string diachi = item["Diachi"].ToString();
                string nguyenquan = item["NguyenQuan"].ToString();
                int sotaikhoan = Convert.ToInt32(item["Sotaikhoan"].ToString());
                string chucvu = item["Chucvu"].ToString();
                Entity_Staff user = new Entity_Staff(manv, tennv, namsinh, cmnd, sdt, diachi, nguyenquan, sotaikhoan, chucvu);
                users.Add(user);
            }
            return users;
        }

        public List<Entity_Staff> Xem_supervisor()
        {
            List<Entity_Staff> users = new List<Entity_Staff>();
            string query = "select * from Staff where Chucvu = 'Supervisor'";
            DataTable data_supervisor = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data_supervisor.Rows)
            {
                string manv = item["MaNV"].ToString();
                string tennv = item["TenNV"].ToString();
                DateTime namsinh = (DateTime)item["Namsinh"];
                int cmnd = Convert.ToInt32(item["CMND"].ToString());
                int sdt = Convert.ToInt32(item["SDT"].ToString());
                string diachi = item["Diachi"].ToString();
                string nguyenquan = item["NguyenQuan"].ToString();
                int sotaikhoan = Convert.ToInt32(item["Sotaikhoan"].ToString());
                string chucvu = item["Chucvu"].ToString();
                Entity_Staff user = new Entity_Staff(manv, tennv, namsinh, cmnd, sdt, diachi, nguyenquan, sotaikhoan, chucvu);
                users.Add(user);
            }
            return users;
        }

        public List<Entity_Staff> Xem_staff()
        {
            List<Entity_Staff> users = new List<Entity_Staff>();
            string query = "select * from Staff where Chucvu= 'Staff'";
            DataTable data_staff = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data_staff.Rows)
            {
                string manv = item["MaNV"].ToString();
                string tennv = item["TenNV"].ToString();
                DateTime namsinh = (DateTime)item["Namsinh"];
                int cmnd = Convert.ToInt32(item["CMND"].ToString());
                int sdt = Convert.ToInt32(item["SDT"].ToString());
                string diachi = item["Diachi"].ToString();
                string nguyenquan = item["NguyenQuan"].ToString();
                int sotaikhoan = Convert.ToInt32(item["Sotaikhoan"].ToString());
                string chucvu = item["Chucvu"].ToString();
                Entity_Staff user = new Entity_Staff(manv, tennv, namsinh, cmnd, sdt, diachi, nguyenquan, sotaikhoan, chucvu);
                users.Add(user);
            }
            return users;
        }

        public List<Entity_Staff> Search(string search_asset)
        {
            List<Entity_Staff> staff_search = new List<Entity_Staff>();
            string query = "select * from Staff where concat(MaNV, TenNV, Namsinh) like '%" + search_asset + "%'";
            DataTable data_search = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data_search.Rows)
            {
                string manv = item["MaNV"].ToString();
                string tennv = item["TenNV"].ToString();
                DateTime namsinh = (DateTime)item["Namsinh"];
                int cmnd = int.Parse(item["CMND"].ToString());
                int sdt = int.Parse(item["SDT"].ToString());
                string diachi = item["Diachi"].ToString();
                string nguyenquan = item["NguyenQuan"].ToString();
                int sotaikhoan = int.Parse(item["Sotaikhoan"].ToString());
                string chucvu = item["Chucvu"].ToString();
                Entity_Staff user = new Entity_Staff(manv, tennv, namsinh, cmnd, sdt, diachi, nguyenquan, sotaikhoan, chucvu);
                staff_search.Add(user);
            }
            return staff_search;
        }

        public bool Them(string manv, string tennv, DateTime namsinh, int cmnd, int sdt, string diachi, string nguyenquan, int sotaikhoan, string chucvu)
        {
            string query = "insert into Staff (MaNV, TenNV, Namsinh, CMND, SDT, Diachi, NguyenQuan, Sotaikhoan, Chucvu) values ( @manv , @tennv , @namsinh , @cmnd , @sdt , @diachi , @nguyenquan , @sotaikhoan , @chucvu )";
            object[] para_insert = new object[] { manv, tennv, namsinh, cmnd, sdt, diachi, nguyenquan, sotaikhoan, chucvu };
            int result_insert = DataProvider.Instance.ExecuteNonQuery(query, para_insert);
            if (result_insert == 1) return true;
            return false;
        }

        public bool Sua(string manv, string tennv, DateTime namsinh, int cmnd, int sdt, string diachi, string nguyenquan, int sotaikhoan, string chucvu)
        {
            string query = "update Staff set Tennv= @tennv , Namsinh= @namsinh , CMND= @cmnd , SDT= @sdt , Diachi= @diachi , NguyenQuan= @nguyenquan , Sotaikhoan= @sotaikhoan , Chucvu= @chucvu where MaNV = @manv ";
            object[] para_edit = new object[] { tennv, namsinh, cmnd, sdt, diachi, nguyenquan, sotaikhoan, chucvu, manv };
            int result_edit = DataProvider.Instance.ExecuteNonQuery(query, para_edit);
            if (result_edit == 1) return true;
            return false;
        }
        public bool Xoa(string manv)
        {
            string query = "delete from Staff where MaNV = @manv ";
            object[] para_edit = new object[] { manv };
            int result_edit = DataProvider.Instance.ExecuteNonQuery(query, para_edit);
            if (result_edit == 1) return true;
            return false;
        }
    }
}
