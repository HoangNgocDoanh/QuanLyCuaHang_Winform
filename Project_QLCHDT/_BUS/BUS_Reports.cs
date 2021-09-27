using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BUS
{
    public class BUS_Reports
    {
        private static BUS_Reports instance;

        public static BUS_Reports Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Reports();
                }
                return instance;
            }

        }
        public BUS_Reports() { }

        //chuc nang kiem tra du lieu input
        private bool verif(string mahd, string cus_name, string cus_id, float price, string tensp, int soluong, DateTime date, string masp)        {            if ((cus_name.Trim() == "") || (cus_id.Trim() == "")
                || (price.ToString().Trim() == "") || (tensp.Trim() == "")
                || (soluong.ToString().Trim() == "") || (mahd.Trim() == "")
                || (date == null) || (masp.Trim() == ""))            {                return false;            }            else            {                return true;            }        }
        public bool Them(string mahd, string cus_name, string cus_id, float price, string tensp, int soluong, DateTime date, string masp)
        {
            if (verif(mahd, cus_name, cus_id, price, tensp, soluong, date, masp))
            {
                return _DAL.DAL_Reports.Instance.Them(mahd, cus_name, cus_id, price, tensp, soluong, date,masp);
            }
            return false;
        }
        public DataTable getReports()
        {
            DataTable data;
            data = _DAL.DAL_Reports.Instance.getReports();
            return data;
        }
    }
}
