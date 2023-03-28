using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactos2
{   
    class DatosPersona : Alta
    {

        public string edad { get; set; }
        public string sexo { get; set; }      
        public void CrearPersona(){

            // Console.Clear();
            Alta alta = new Alta();                                   

            Console.WriteLine("\nSexo: ");
            sexo = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\nEdad: ");
            edad = Console.ReadLine();          

            Console.Clear();

        }
    }
}
