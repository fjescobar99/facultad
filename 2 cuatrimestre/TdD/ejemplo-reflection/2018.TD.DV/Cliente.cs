using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.TD.DV
{


    public interface ISaludable
    {
        void Saludar();
    }


    public class Entity
    {
        public Guid Id { get; set; }
    }



    public class Proveedor : Entity
    {
        public string RazonSocial {get;set;}
        public string CUIT { get; set; }

    }


    [Verificable("cliente")]
    public class Cliente : Entity, ISaludable
    {



        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public void Saludar()
        {
            Console.WriteLine($"Hola {Nombre} {Apellido}");
        }
    }
}
