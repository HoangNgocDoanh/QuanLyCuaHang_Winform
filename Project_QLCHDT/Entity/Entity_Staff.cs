using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entity_Staff
    {
        //Personal Information
        private string sMaNV;
        private string sTenNV;
        private DateTime sNamsinh;
        private int sCMND;
        //Contact Information
        private int sSDT;
        private string sDiachi;
        private string sNguyenQuan;
        //Other Information
        private int sSotaikhoan;
        private string sChucvu;

        public string MaNV
        {
            get
            {
                return sMaNV;
            }

            set
            {
                sMaNV = value;
            }
        }
        public string TenNV
        {
            get
            {
                return sTenNV;
            }

            set
            {
                sTenNV = value;
            }
        }
        public DateTime Namsinh
        {
            get
            {
                return sNamsinh;
            }

            set
            {
                sNamsinh = value;
            }
        }
        public int CMND
        {
            get
            {
                return sCMND;
            }

            set
            {
                sCMND = value;
            }
        }
        public int SDT
        {
            get
            {
                return sSDT;
            }

            set
            {
                sSDT = value;
            }
        }
        public string Diachi
        {
            get
            {
                return sDiachi;
            }

            set
            {
                sDiachi = value;
            }
        }
        public string NguyenQuan
        {
            get
            {
                return sNguyenQuan;
            }

            set
            {
                sNguyenQuan = value;
            }
        }
        public int Sotaikhoan
        {
            get
            {
                return sSotaikhoan;
            }

            set
            {
                sSotaikhoan = value;
            }
        }
        public string Chucvu
        {
            get
            {
                return sChucvu;
            }

            set
            {
                sChucvu = value;
            }
        }

        public Entity_Staff(string manv, string tennv, DateTime namsinh, int cmnd, int sdt, string diachi, string nguyenquan, int sotaikhoan, string chucvu)
        {
            this.MaNV = manv;
            this.TenNV = tennv;
            this.Namsinh = namsinh;
            this.CMND = cmnd;
            this.SDT = sdt;
            this.Diachi = diachi;
            this.NguyenQuan = nguyenquan;
            this.Sotaikhoan = sotaikhoan;
            this.Chucvu = chucvu;
        }
    }
}
