using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace _DAL
{
    public class DAL_Product
    {
        private static DAL_Product instance;

        public static DAL_Product Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Product();
                }
                return instance;
            }

        }
        private DAL_Product() { }

        public List<Entity_Product> Xem()
        {
            List<Entity_Product> products = new List<Entity_Product>();
            string query = "select * from Product";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string masp = item["MaSP"].ToString();
                string tensp = item["TenSP"].ToString();
                string loaisp = item["LoaiSP"].ToString();
                string thuonghieu = item["ThuongHieu"].ToString();
                int soluong = int.Parse(item["SoLuong"].ToString());
                string mausac = item["MauSac"].ToString();
                string kichthuoc = item["KichThuoc"].ToString();
                string noisanxuat = item["NoiSanXuat"].ToString();
                int namsanxuat = int.Parse(item["NamSanXuat"].ToString());
                float dongia = float.Parse(item["Dongia"].ToString());
                Entity_Product user = new Entity_Product(masp, tensp, loaisp, thuonghieu, soluong, mausac, kichthuoc, noisanxuat, namsanxuat, dongia);
                products.Add(user);
            }
            return products;
        }

        public List<Entity_Product> Xem_type()
        {
            List<Entity_Product> products_type = new List<Entity_Product>();
            string query = "select LoaiSP from Product";
            DataTable data_type = DataProvider.Instance.ExecuteQuery(query);
            //Lọc các sản phẩm cùng loại
            foreach (DataRow item in data_type.Rows)
            {
                string loaisp = item["LoaiSP"].ToString();
                int index = 0;
                while (index < products_type.Count)
                {
                    if (products_type[index].LoaiSP == loaisp) break;
                    index++;
                }
                if (index >= products_type.Count)
                {
                    Entity_Product user = new Entity_Product("", "", loaisp, "", 0, "", "", "", 0, 0);
                    products_type.Add(user);
                }
            }
            return products_type;
        }

        public List<Entity_Product> Search(string search_asset)
        {
            List<Entity_Product> products_search = new List<Entity_Product>();
            string query = "select * from Product where concat(MaSP, TenSP, SoLuong) like '%"+ search_asset +"%'";
            DataTable data_search = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data_search.Rows)
            {
                string masp = item["MaSP"].ToString();
                string tensp = item["TenSP"].ToString();
                string loaisp = item["LoaiSP"].ToString();
                string thuonghieu = item["ThuongHieu"].ToString();
                int soluong = int.Parse(item["SoLuong"].ToString());
                string mausac = item["MauSac"].ToString();
                string kichthuoc = item["KichThuoc"].ToString();
                string noisanxuat = item["NoiSanXuat"].ToString();
                int namsanxuat = int.Parse(item["NamSanXuat"].ToString());
                float dongia = float.Parse(item["Dongia"].ToString());
                Entity_Product user = new Entity_Product(masp, tensp, loaisp, thuonghieu, soluong, mausac, kichthuoc, noisanxuat, namsanxuat, dongia);
                products_search.Add(user);
            }
            return products_search;
        }

        public bool Them(string masp, string tensp, string loaisp, string thuonghieu, int soluong, string mausac, string kichthuoc, string noisanxuat, int namsanxuat, float dongia)
        {
            string query = "insert into Product (MaSP, TenSP, LoaiSP, ThuongHieu, SoLuong, MauSac, KichThuoc, NoiSanXuat, NamSanXuat, Dongia) values ( @masp , @tensp , @loaisp , @thuonghieu , @soluong , @mausac , @kichthuoc , @noisanxuat , @namsanxuat , @dongia )";
            object[] para_insert = new object[] { masp, tensp, loaisp, thuonghieu, soluong, mausac, kichthuoc, noisanxuat, namsanxuat, dongia };
            int result_insert = DataProvider.Instance.ExecuteNonQuery(query, para_insert);
            if (result_insert == 1) return true;
            return false;
        }

        public bool Sua(string masp, string tensp, string loaisp, string thuonghieu, int soluong, string mausac, string kichthuoc, string noisanxuat, int namsanxuat, float dongia)
        {
            string query = "update Product set TenSP= @tensp , LoaiSP= @loaisp , ThuongHieu= @thuonghieu , SoLuong= @soluong , MauSac= @mausac , KichThuoc= @kichthuoc , NoiSanXuat= @noisanxuat , NamSanXuat= @namsanxuat , Dongia= @dongia where MaSP = @masp ";
            object[] para_edit = new object[] { tensp, loaisp, thuonghieu, soluong, mausac, kichthuoc, noisanxuat, namsanxuat, dongia ,masp };
            int result_edit = DataProvider.Instance.ExecuteNonQuery(query, para_edit);
            if (result_edit == 1) return true;
            return false;
        }
        public bool Xoa(string masp)
        {
            string query = "delete from Product where MaSP = @masp ";
            object[] para_edit = new object[] { masp };
            int result_edit = DataProvider.Instance.ExecuteNonQuery(query, para_edit);
            if (result_edit == 1) return true;
            return false;
        }
        public int getSL(string id)
        {
            int soluong = 0;
            string query = "select * from Product where MaSP = @id ";
            object[] para = new object[] { id };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            DataRow item = null;
            item = data.Rows[0];
            if (item != null)
            {
                soluong = int.Parse(item["SoLuong"].ToString());
            }
            return soluong;
        }
    }
}
