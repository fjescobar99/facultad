using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.TD.DV
{
    public class Saludador
    {
        public static void Saludar(object entity)
        {

            //saludamos
            var iface = entity.GetType().GetInterfaces().Where(i => i.Name.Equals("ISaludable")).FirstOrDefault();
            if (iface != null)
            {
                //si el objeto implementa ISaludable

                var method = entity.GetType().GetMethod("Saludar");
                method.Invoke(entity,null);

            }
            else
            {
                Console.WriteLine("No se saluda");
            }
        }
    } 
}
