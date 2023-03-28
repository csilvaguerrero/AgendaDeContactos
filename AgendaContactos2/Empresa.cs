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
        public string sector;
        public string nEmpleados;

        public string[] datosEmpresa()
        {  
            Console.WriteLine("\nSector:");
            sector = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\nNúmero de empleados: ");
            nEmpleados = Console.ReadLine();

            Console.Clear();

            /*datos[0] = nombre;
            datos[1] = apellidos;
            datos[2] = dni;
            datos[3] = telefono;
            datos[4] = sector;
            datos[5] = nEmpleados;*/

            return datos;
        }
    }
}
