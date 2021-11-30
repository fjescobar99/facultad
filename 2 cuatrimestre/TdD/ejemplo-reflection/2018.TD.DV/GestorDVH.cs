using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2018.TD.DV
{
    public static class GestorDVH
    {
        public static string GenerarDVH(Entity entity)
        {

            Type t = entity.GetType();
            string dvh = string.Empty;
            var props = t.GetProperties();


            var attrs = t.GetCustomAttributes(false);

            var verificable = (VerificableAttribute) attrs.Where(i => i.GetType().Equals(typeof(VerificableAttribute))).FirstOrDefault();

            if (verificable != null)
                dvh += $"{verificable.Prefix}_";


            foreach (var item in props)
            {
                

                if (item.PropertyType.FullName.Equals(typeof(DateTime).FullName))
                {
                    DateTime a = (DateTime)item.GetValue(entity);
                    dvh+=a.ToString("ddmmyyyyhhmmss");
                }   
                else
                {
                    dvh += item.GetValue(entity).ToString();

                }
            }

            return Encriptador.GetMd5Hash(dvh);
        }

        public static string GenerarDVHExtension(this Entity entity)
        {

            Type t = entity.GetType();
            string dvh = string.Empty;
            var props = t.GetProperties();


            var attrs = t.GetCustomAttributes(false);

            var verificable = (VerificableAttribute)attrs.Where(i => i.GetType().Equals(typeof(VerificableAttribute))).FirstOrDefault();

            if (verificable != null)
                dvh += $"{verificable.Prefix}_";


            foreach (var item in props)
            {


                if (item.PropertyType.FullName.Equals(typeof(DateTime).FullName))
                {
                    DateTime a = (DateTime)item.GetValue(entity);
                    dvh += a.ToString("ddmmyyyyhhmmss");
                }
                else
                {
                    dvh += item.GetValue(entity).ToString();

                }
            }

            return Encriptador.GetMd5Hash(dvh);
        }
    }
}
