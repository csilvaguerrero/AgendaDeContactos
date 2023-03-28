using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactos2
{
    public class Alta
    {
        public string[] datos = new string[7];

        public string nombre;
        public string apellidos;
        public string dni;
        public string telefono;            

        public string[] AnadirContactos()
        {
            Console.Clear();

            Console.WriteLine("\n1. Persona");
            Console.WriteLine("2. Empresa");

            string opcion = Console.ReadLine();

            Console.Clear();

            Console.Write("\nNombre: ");
            nombre = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\nApellidos:");
            apellidos = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\nDNI: ");
            dni = Console.ReadLine();
            
            Console.Clear();

            Console.WriteLine("\nTelefono: ");
            telefono = Console.ReadLine();

            datos[0] = nombre;
            datos[1] = apellidos;
            datos[2] = dni;
            datos[3] = telefono;

            Console.Clear();

            if (opcion == "1")
            {
                DatosPersona persona = new DatosPersona();
                persona.CrearPersona();
              
                datos[4] = persona.edad;
                datos[5] = persona.sexo;
                datos[6] = "P";
            }
            else
            {
                Empresa empresa = new Empresa();
                empresa.CrearEmpresa();

                datos[4] = empresa.sector;
                datos[5] = empresa.nEmpleados;
                datos[6] = "E";
            }

            
          
            return datos;

        }                
    }
}
