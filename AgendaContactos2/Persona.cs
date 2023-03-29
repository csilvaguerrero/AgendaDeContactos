using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/**
 * 
 * Clase Persona que hereda de Contacto
 * 
 */

namespace AgendaContactos2
{   
    class DatosPersona : Contacto
    {

        public string edad { get; set; }
        public string sexo { get; set; }  
        
        /**
         * 
         * Método que pide por consola el sexo y la edad de la persona a generar
         * de contacto.
         * 
         */
        public void CrearPersona(){                                                     

            Console.WriteLine("\nSexo: ");
            sexo = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\nEdad: ");
            edad = Console.ReadLine();          

            Console.Clear();

        }
    }
}
