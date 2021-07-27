using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allowance_Tracker
{
    public static class Variables
    {
        public static string password;
        public static string username;
        /// <summary>
        /// Signup form.
        /// </summary>
        public static SignUp signup = new SignUp();
        /// <summary>
        /// Login form.
        /// </summary>
        public static Login login = new Login();
        /// <summary>
        /// Main page form.
        /// </summary>
        public static Mainpage mainpage = new Mainpage();
        public static void SetVariables(string p, string u)
        {
            p = password;
            u = username;
            //write password to text file
            //write username to text file
        }
        public static void GetVariables()
        {
            //password = read password on text file
            //username = read username on text file
        }
    }
}
