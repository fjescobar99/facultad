using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2018.TD.DV
{
    public static class Encriptador
    {
        public static string GetMd5Hash(string input)
        {
            StringBuilder sBuilder = new StringBuilder();
            using (var md5 = MD5.Create())
            {


                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

                
                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
             
            }

            return sBuilder.ToString();
        }

    }
}
