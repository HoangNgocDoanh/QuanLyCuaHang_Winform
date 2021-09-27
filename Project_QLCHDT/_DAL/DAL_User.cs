using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace _DAL
{
    public class DAL_User
    {
        private static DAL_User instance;

        public static DAL_User Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_User();
                }
                return instance;
            }

        }
        private DAL_User() { }

        public bool Register(string user, string pass, string type, MemoryStream picture)
        {
            object[] paras_register = new object[] { user, pass, type, picture.ToArray() };
            string query = "insert into User (user, password, type, picture) values ( @user , @pass , @type , @pic )";
            int result_register = DataProvider.Instance.ExecuteNonQuery(query, paras_register);
            if (result_register == 1) return true;
            return false;
        }
        public bool Login(string user, string pass)
        {
            object[] paras_login = new object[] { user, pass };
            string query = "select * from User where user = @user and password = @pass";
            bool result_login = DataProvider.Instance.ExecuteReader(query, paras_login);
            return result_login;
        }
        public bool getPicture(string id, Guna.UI.WinForms.GunaCirclePictureBox avatar)
        {
            object[] para = new object[] { id };
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from User where user = @id ", para);
            if (data.Rows.Count > 0)
            {
                byte[] pic = (byte[])data.Rows[0][3];
                MemoryStream picture = new MemoryStream(pic);
                avatar.Image = Image.FromStream(picture);
                return true;
            }
            return false;
        }
        public string getType(string id)
        {
            object[] para = new object[] { id };
            string type = "";
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from User where user = @id ", para);
            if (data.Rows.Count > 0)
            {
                type = data.Rows[0][2].ToString();
            }
            return type;
        }
    }
}
