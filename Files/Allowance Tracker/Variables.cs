using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
namespace Allowance_Tracker { public static class Variables { 
        public static string password;
        public static string username;
        public static string name1;
        public static string name2;
        public static string name3;
        public static string name4;
        public static string name5;
        public static double money1;
        public static double money2;
        public static double money3;
        public static double money4;
        public static double money5;
        public static string key = "twhw-54da-dn67yt";
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
                sw.WriteLine(EncryptFile(u, key));
                sw.WriteLine(EncryptFile(p, key));
                sw.WriteLine(EncryptFile("Child", key));
                sw.WriteLine(EncryptFile("0", key));
                sw.WriteLine(EncryptFile("Child", key));
                sw.WriteLine(EncryptFile("0", key));
                sw.WriteLine(EncryptFile("Child", key));
                sw.WriteLine(EncryptFile("0", key));
                sw.WriteLine(EncryptFile("Child", key));
                sw.WriteLine(EncryptFile("0", key));
                sw.WriteLine(EncryptFile("Child", key));
                sw.WriteLine(EncryptFile("0", key));
                sw.Close();
            }
        }
        public static void GetVariables() {
            using (StreamReader sr = new StreamReader("AllowanceData.txt")) {
                username = sr.ReadLine();
                password = sr.ReadLine();
                name1 = sr.ReadLine();
                string temp1 = sr.ReadLine();
                name2 = sr.ReadLine();
                string temp2 = sr.ReadLine();
                name3 = sr.ReadLine();
                string temp3 = sr.ReadLine();
                name4 = sr.ReadLine();
                string temp4 = sr.ReadLine();
                name5 = sr.ReadLine();
                string temp5 = sr.ReadLine();
                username = DecryptFile(username, key);
                password = DecryptFile(password, key);
                name1 = DecryptFile(name1, key);
                name2 = DecryptFile(name2, key);
                name3 = DecryptFile(name3, key);
                name4 = DecryptFile(name4, key);
                name5 = DecryptFile(name5, key);
                money1 = Convert.ToDouble(DecryptFile(temp1, key));
                money2 = Convert.ToDouble(DecryptFile(temp2, key));
                money3 = Convert.ToDouble(DecryptFile(temp3, key));
                money4 = Convert.ToDouble(DecryptFile(temp4, key));
                money5 = Convert.ToDouble(DecryptFile(temp5, key));
                sr.Close();
            }
        }
        public static void ChangeVariables()
        {
            File.WriteAllText("AllowanceData.txt", "");
            using (StreamWriter sw = new StreamWriter("AllowanceData.txt"))
            {
                sw.WriteLine(EncryptFile(username, key));
                sw.WriteLine(EncryptFile(password, key));
                sw.WriteLine(EncryptFile(name1, key));
                sw.WriteLine(EncryptFile(Convert.ToString(money1), key));
                sw.WriteLine(EncryptFile(name2, key));
                sw.WriteLine(EncryptFile(Convert.ToString(money2), key));
                sw.WriteLine(EncryptFile(name3, key));
                sw.WriteLine(EncryptFile(Convert.ToString(money3), key));
                sw.WriteLine(EncryptFile(name4, key));
                sw.WriteLine(EncryptFile(Convert.ToString(money4), key));
                sw.WriteLine(EncryptFile(name5, key));
                sw.WriteLine(EncryptFile(Convert.ToString(money5), key));
                sw.Close();
            }
        }
        //Encryption/Decryption taken from: (cryptography isnt my strongsuit)
        //https://www.c-sharpcorner.com/UploadFile/f8fa6c/data-encryption-and-decryption-in-C-Sharp/
        public static string EncryptFile(string input, string key) {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public static string DecryptFile(string input, string key) { 
            byte[] inputArray = Convert.FromBase64String(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}
