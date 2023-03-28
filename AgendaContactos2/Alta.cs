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
        public string[] datos = new string[6];

        public string Nombre;
        public string Apellidos;
        public string DNI;
        public string Telefono;

        public string dato1;
        public string dato2;
        
        /*public Alta() { }
        public Alta(string nombre, string apellidos, string dni, string telefono)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            DNI = dni;
            Telefono = telefono;
            
        }*/
        

        public string AnadirContactos()
        {
            Console.Clear();

            Console.WriteLine("\n1. Persona");
            Console.WriteLine("2. Empresa");

            string opcion = Console.ReadLine();

            //Console.Clear();

            Console.Write("\nNombre: ");
            Nombre = Console.ReadLine();

            //Console.Clear();

            Console.WriteLine("\nApellidos: ");
            Apellidos = Console.ReadLine();

            //Console.Clear();

            Console.WriteLine("\nDNI: ");
            DNI = Console.ReadLine();
            
            //Console.Clear();

            Console.WriteLine("\nTelefono: ");
            Telefono = Console.ReadLine();

            

            //Console.Clear();
          
            return opcion;

        }                
    }
}
