using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/**
 * 
 * Clase Empresa que hereda de Contacto
 * 
 */

namespace AgendaContactos2
{
    class Empresa : Contacto
    {
        public string sector { get; set; }
        public string nEmpleados { get; set; }

        /**
         * 
         * Método que pide por consola el sector y el número de empleados de la empresa a generar
         * de contacto.
         * 
         */
        public void CrearEmpresa()
        {  
            Console.WriteLine("\nSector:");
            sector = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\nNúmero de empleados: ");
            nEmpleados = Console.ReadLine();

            Console.Clear();
            
        }
    }
}
