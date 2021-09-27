using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _DAL;

namespace _BUS
{
    public class BUS_Product
    {
        private static BUS_Product instance;

        public static BUS_Product Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Product();
                }
                return instance;
            }

        }
        public BUS_Product() { }

        //chuc nang kiem tra du lieu input
        private bool verif(string masp, string tensp, string loaisp, string thuonghieu, int soluong, string mausac, string kichthuoc, string noisanxuat, int namsanxuat, float dongia)        {            if ((masp.Trim() == "") || (tensp.Trim() == "")
                || (loaisp.Trim() == "") || (thuonghieu.Trim() == "")
                || (Convert.ToString(soluong).Trim() == "") || (mausac.Trim() == "")
                || (kichthuoc.Trim() == "") || (noisanxuat.Trim() == "")
                || (Convert.ToString(namsanxuat).Trim() == "") || (dongia.ToString().Trim() == ""))            {                return false;            }            else            {                return true;            }        }

        public void Xem(DataGridView data)
        {
            data.DataSource = _DAL.DAL_Product.Instance.Xem();
        }
        public void Xem_type(DataGridView data_type)
        {
            data_type.DataSource = _DAL.DAL_Product.Instance.Xem_type();
        }
        public void Search(DataGridView data_search,string search_asset)
        {
            data_search.DataSource = _DAL.DAL_Product.Instance.Search(search_asset);
        }
        public bool Them(string masp, string tensp, string loaisp, string thuonghieu, int soluong, string mausac, string kichthuoc, string noisanxuat, int namsanxuat, float dongia)
        {
            if (verif(masp,tensp,loaisp,thuonghieu,soluong,mausac,kichthuoc,noisanxuat,namsanxuat, dongia))
            {
                return _DAL.DAL_Product.Instance.Them(masp, tensp, loaisp, thuonghieu, soluong, mausac, kichthuoc, noisanxuat, namsanxuat, dongia);
            }
            return false;
        }
        public bool Sua(string masp, string tensp, string loaisp, string thuonghieu, int soluong, string mausac, string kichthuoc, string noisanxuat, int namsanxuat, float dongia)
        {
            if (verif(masp, tensp, loaisp, thuonghieu, soluong, mausac, kichthuoc, noisanxuat, namsanxuat, dongia))
            {
                return _DAL.DAL_Product.Instance.Sua(masp, tensp, loaisp, thuonghieu, soluong, mausac, kichthuoc, noisanxuat, namsanxuat, dongia);
            }
            return false;
        }
        public bool Xoa(string masp)
        {
            if (masp != "")
            {
                return _DAL.DAL_Product.Instance.Xoa(masp);
            }
            return false;
        }
        public int getSL(string id)
        {
            int final = -1;
            if (id != "")
            {
                final = _DAL.DAL_Product.Instance.getSL(id);
            }
            return final;
        }
    }
}
