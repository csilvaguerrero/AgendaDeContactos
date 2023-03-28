using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactos2
{
    class Empresa : Alta
    {
        public string sector { get; set; }
        public string nEmpleados { get; set; }

        public void CrearEmpresa()
        {  
            Console.WriteLine("\nSector:");
            sector = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\nNúmero de empleados: ");
            nEmpleados = Console.ReadLine();
            
        }
    }
}
