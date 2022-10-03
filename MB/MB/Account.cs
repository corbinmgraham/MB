using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB
{
    public static class Account
    {
        // ID LIST
        private static List<String> id;
        private static bool userid = false;
        private static List<String> password;
        private static bool passid = false;

        private static void setId()
        {
            id.Add("guest");
            password.Add("guest");
        }
        private static void getId(String user)
        {
            user.ToLower();
            if (id.Contains(user) == true) userid = true;
        }
        private static void getPassword(String pass)
        {
            pass.ToLower();
            if (password.Contains(pass) == true) passid = true;
        }
        public static bool checkAccount(String user, String pass)
        {
            bool ac = true;
            getId(user);
            getPassword(pass);
            if (userid == false) ac = false;
            if (passid == false) ac = false;
            return ac;
        }
    }
}
