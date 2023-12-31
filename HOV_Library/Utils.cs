using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HOV_Library
{
    class Utils
    {
    }

    class Hash
    {
        //public static string make(string s)
        //{
        //    SHA256Managed manage = new SHA256Managed();
        //    return Convert.ToBase64String(manage.ComputeHash(Encoding.UTF8.GetBytes(s)));
        //}

        public static string make(string input)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }

            return builder.ToString();
        }

    }
}
