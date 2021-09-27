using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BUS
{
    public static class GlobalCurrentUser
    {
        // parameterless constructor required for static class
        static GlobalCurrentUser() { } // default value

        // public get, and private set for strict access control
        public static string GlobalUserID { get; private set; }

        // GlobalInt can be changed only via this method
        public static void SetGlobalUser(string ID)
        {
            GlobalUserID = ID;
        }

    }
    public static class GlobalCurrentType
    {
        //TYPE
        static GlobalCurrentType() { } // default value

        // public get, and private set for strict access control
        public static string GlobalUserTYPE { get; private set; }

        // GlobalInt can be changed only via this method
        public static void SetGlobalUserTYPE(string type)
        {
            GlobalUserTYPE = type;
        }
    }
}
