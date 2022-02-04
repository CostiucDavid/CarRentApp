using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentApp
{
    public static class Utils
    {
        public static bool FormIsOpen(string name)
        {
            //check if window is already open

            var openForms = Application.OpenForms.Cast<Form>();
            var isopen = openForms.Any(x => x.Name == name);
            return isopen;
        }
        public static string HashPassword(string password)
        {
            //to do re info about sincron cripting
            SHA256 sha = SHA256.Create();
            // convert string to byte array add compute hash
            Byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            var stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
        public static string DefsultHashPassword()
        {
            var defaultHash = HashPassword("password@123");
            return defaultHash;
        }
    }
}
