using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace _DAL
{
    public class DAL_Reports
    {
        private static DAL_Reports instance;

        public static DAL_Reports Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Reports();
                }
                return instance;
            }

        }
        public DAL_Reports() { }
        public bool Them(string mahd ,string cus_name, string cus_id, float price, string tensp, int soluong ,DateTime date, string MaSP)
        {
            string query = "insert into Reports (MaHD, TenKH, CMND, Tongtien, TenSP, Soluong, Ngayban, MaSP) values ( @mahd , @tenkh , @cmnd , @tongtien , @tensp , @soluong , @ngayban , @masp )";
            object[] para_insert = new object[] { mahd, cus_name, cus_id, price, tensp, soluong, date, MaSP};
            int result_insert = DataProvider.Instance.ExecuteNonQuery(query, para_insert);
            if (result_insert == 1) return true;
            return false;
        }
        public DataTable getReports()
        {
            DataTable report_data;
            report_data = DataProvider.Instance.ExecuteQuery("select * from Reports");
            return report_data;
        }
    }
}
