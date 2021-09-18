using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Allowance_Tracker 
{ 
    public class Variables 
    {
        public static string key = "twhw-54da-dn67yt";
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string Name5 { get; set; }
        public double Money1 { get; set; }
        public double Money2 { get; set; }
        public double Money3 { get; set; }
        public double Money4 { get; set; }
        public double Money5 { get; set; }
        public string Date1 { get; set; }
        public string Date2 { get; set; }
        public string Date3 { get; set; }
        public string Comment1 { get; set; }
        public string Comment2 { get; set; }
        public string Comment3 { get; set; }
        public void SetVariables(string p, string u) 
        {
            using (StreamWriter sw = new StreamWriter("AllowanceData.txt")) 
            {
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
                sw.WriteLine(EncryptFile("9/17/21", key));
                sw.WriteLine(EncryptFile("test", key));
                sw.WriteLine(EncryptFile("9/17/21", key));
                sw.WriteLine(EncryptFile("test", key));
                sw.WriteLine(EncryptFile("9/17/21", key));
                sw.WriteLine(EncryptFile("test", key));
                sw.Close();
            }
        }
        public void GetVariables() 
        {
            using (StreamReader sr = new StreamReader("AllowanceData.txt")) 
            {
                UserName = DecryptFile(sr.ReadLine(), key);
                Password = DecryptFile(sr.ReadLine(), key);
                Name1 = DecryptFile(sr.ReadLine(), key);
                Money1 = Convert.ToDouble(DecryptFile(sr.ReadLine(), key));
                Name2 = DecryptFile(sr.ReadLine(), key);
                Money2 = Convert.ToDouble(DecryptFile(sr.ReadLine(), key));
                Name3 = DecryptFile(sr.ReadLine(), key);
                Money3 = Convert.ToDouble(DecryptFile(sr.ReadLine(), key));
                Name4 = DecryptFile(sr.ReadLine(), key);
                Money4 = Convert.ToDouble(DecryptFile(sr.ReadLine(), key));
                Name5 = DecryptFile(sr.ReadLine(), key);
                Money5 = Convert.ToDouble(DecryptFile(sr.ReadLine(), key));
                Date1 = DecryptFile(sr.ReadLine(), key);
                Comment1 = DecryptFile(sr.ReadLine(), key);
                Date2 = DecryptFile(sr.ReadLine(), key);
                Comment2 = DecryptFile(sr.ReadLine(), key);
                Date3 = DecryptFile(sr.ReadLine(), key);
                Comment3 = DecryptFile(sr.ReadLine(), key);
                sr.Close();
            }
        }
        public void ChangeVariables() 
        {
            File.WriteAllText("AllowanceData.txt", "");
            using (StreamWriter sw = new StreamWriter("AllowanceData.txt")) 
            {
                sw.WriteLine(EncryptFile(UserName, key));
                sw.WriteLine(EncryptFile(Password, key));
                sw.WriteLine(EncryptFile(Name1, key));
                sw.WriteLine(EncryptFile(Convert.ToString(Money1), key));
                sw.WriteLine(EncryptFile(Name2, key));
                sw.WriteLine(EncryptFile(Convert.ToString(Money2), key));
                sw.WriteLine(EncryptFile(Name3, key));
                sw.WriteLine(EncryptFile(Convert.ToString(Money3), key));
                sw.WriteLine(EncryptFile(Name4, key));
                sw.WriteLine(EncryptFile(Convert.ToString(Money4), key));
                sw.WriteLine(EncryptFile(Name5, key));
                sw.WriteLine(EncryptFile(Convert.ToString(Money5), key));
                sw.WriteLine(EncryptFile(Date1, key));
                sw.WriteLine(EncryptFile(Comment1, key));
                sw.WriteLine(EncryptFile(Date2, key));
                sw.WriteLine(EncryptFile(Comment2, key));
                sw.WriteLine(EncryptFile(Date3, key));
                sw.WriteLine(EncryptFile(Comment3, key));
                sw.Close();
            }
        }
        //Encryption/Decryption taken from: (cryptography isnt my strongsuit)
        //https://www.c-sharpcorner.com/UploadFile/f8fa6c/data-encryption-and-decryption-in-C-Sharp/
        public static string EncryptFile(string input, string key) 
        {
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
        public static string DecryptFile(string input, string key) 
        { 
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
