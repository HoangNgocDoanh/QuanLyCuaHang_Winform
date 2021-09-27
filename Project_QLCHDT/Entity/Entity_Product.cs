using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entity_Product
    {
        //Basic Information
        private string sMaSP;
        private string sTenSP;
        private string sLoaiSP;
        private string sThuongHieu;
        //Details
        private int sSoluong;
        private string smausac;
        private string skichthuoc;
        private string snoisanxuat;
        private int snamsanxuat;
        private float sdongia;

        public string MaSP
        {
            get
            {
                return sMaSP;
            }

            set
            {
                sMaSP = value;
            }
        }
        public string TenSP
        {
            get
            {
                return sTenSP;
            }

            set
            {
                sTenSP = value;
            }
        }
        public string LoaiSP
        {
            get
            {
                return sLoaiSP;
            }

            set
            {
                sLoaiSP = value;
            }
        }
        public string ThuongHieu
        {
            get
            {
                return sThuongHieu;
            }

            set
            {
                sThuongHieu = value;
            }
        }
        public int Soluong
        {
            get
            {
                return sSoluong;
            }

            set
            {
                sSoluong = value;
            }
        }
        public string mausac
        {
            get
            {
                return smausac;
            }

            set
            {
                smausac = value;
            }
        }
        public string kichthuoc
        {
            get
            {
                return skichthuoc;
            }

            set
            {
                skichthuoc = value;
            }
        }
        public string noisanxuat
        {
            get
            {
                return snoisanxuat;
            }

            set
            {
                snoisanxuat = value;
            }
        }
        public int namsanxuat
        {
            get
            {
                return snamsanxuat;
            }

            set
            {
                snamsanxuat = value;
            }
        }
        public float Dongia
        {
            get
            {
                return sdongia;
            }

            set
            {
                sdongia = value;
            }
        }

        public Entity_Product(string masp, string tensp, string loaisp, string thuonghieu,int soluong, string mausac, string kichthuoc, string noisanxuat,int namsanxuat, float dongia)
        {
            this.MaSP = masp;
            this.TenSP = tensp;
            this.LoaiSP = loaisp;
            this.ThuongHieu = thuonghieu;
            this.Soluong = soluong;
            this.mausac = mausac;
            this.kichthuoc = kichthuoc;
            this.noisanxuat = noisanxuat;
            this.namsanxuat = namsanxuat;
            this.Dongia = dongia;
        }
    }
}
