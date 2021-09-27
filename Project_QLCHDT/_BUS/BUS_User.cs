using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _BUS
{
    public class BUS_User
    {
        private static BUS_User instance;

        public static BUS_User Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_User();
                }
                return instance;
            }

        }
        public BUS_User() { }
        public bool Register(string user, string pass, string confirm, string type, MemoryStream pic)
        {
            if (pass == confirm)
            {
                string hash_pass = hash(pass);
                return _DAL.DAL_User.Instance.Register(user, hash_pass, type, pic);
            }
            return false;
        }
        public bool Login(string user,string pass)
        {
            string hash_login = hash(pass);
            return _DAL.DAL_User.Instance.Login(user, hash_login);
        }
        public bool getPicture(string id, Guna.UI.WinForms.GunaCirclePictureBox pic)
        {
            return _DAL.DAL_User.Instance.getPicture(id, pic);
        }
        public string getType(string id)
        {
            return _DAL.DAL_User.Instance.getType(id);
        }
        //mã hóa mật khẩu trước khi lưu
        private string hash(string pass)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(pass);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }
    }
}
