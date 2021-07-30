using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Allowance_Tracker { public static class Variables { 
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
        public static void SetVariables(string p, string u) {
            using (StreamWriter sw = new StreamWriter("AllowanceData.txt")) {
                sw.WriteLine($"{u}{Environment.NewLine}{p}");
                sw.Close();
            }
            EncryptFile();
        }
        public static void GetVariables() {
            DecryptFile();
            using (StreamReader sr = new StreamReader("AllowanceData.txt")) {
                username = sr.ReadLine();
                password = sr.ReadLine();
                sr.Close();
            }
            EncryptFile();
        }
        public static void EncryptFile() { 
            //add encryption
        }
        public static void DecryptFile() { 
            //add decryption
        }
    }
}
