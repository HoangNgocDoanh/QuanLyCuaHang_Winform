using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entity_Reports
    {
        private string sMaHD;
        private string sTenKH;
        private int sCMND;
        private DateTime sNgayban;
        private float sTongtien;
        private string sTenSP;
        private int sSoluong;

        public string MaHD
        {
            get
            {
                return sMaHD;
            }

            set
            {
                sMaHD = value;
            }
        }
        public string TenKH
        {
            get
            {
                return sTenKH;
            }

            set
            {
                sTenKH = value;
            }
        }
        public DateTime Ngayban
        {
            get
            {
                return sNgayban;
            }

            set
            {
                sNgayban = value;
            }
        }
        public float Tongtien
        {
            get
            {
                return sTongtien;
            }

            set
            {
                sTongtien = value;
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
        public Entity_Reports(string mahd, string tenkh, int cmnd, DateTime ngayban, float tongtien, string tensp, int soluong)
        {
            this.MaHD = mahd;
            this.TenKH = tenkh;
            this.CMND = cmnd;
            this.Ngayban = ngayban;
            this.Tongtien = tongtien;
            this.TenSP = tensp;
            this.Soluong = soluong;
        }
    }
}
