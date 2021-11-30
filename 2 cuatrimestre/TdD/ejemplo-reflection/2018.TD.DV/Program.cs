using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.TD.DV
{
    class Program
    {
        static void Main(string[] args)
        {


            Proveedor p = new Proveedor()
            {
                RazonSocial = "Los Sauces S.A.",
                CUIT = "12345678"
            };

            Cliente c = new Cliente()
            {
                Nombre = "Luis",
                Apellido = "Majul",
                FechaNacimiento = new DateTime(1981, 09, 22)

            };


            var dvh_cliente = c.GenerarDVHExtension();// GestorDVH.GenerarDVH(c);

            var dvh_proveedor = GestorDVH.GenerarDVH(p);







            //saludando...
            Saludador.Saludar(c);
            Saludador.Saludar(p);
            Console.ReadLine();


        }
    }
}
