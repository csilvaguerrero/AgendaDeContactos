using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/**
 * 
 * Clase que genera los contactos 
 * y los retorna a la clase Program.
 * 
 */

namespace AgendaContactos2
{
    public class Contacto
    {
        List<List<String>> datosTotales = new List<List<String>>();

        List<String> datos = new List<string>();
        List<String> notas = new List<string>();

        private string nombre;
        private string apellidos;
        private string dni;
        private string telefono;
        private string animal;

        private int c = 0;

        /**
         * 
         * Método que recoge por consola todos los datos
         * necesarios para crear una persona/empresa.
         * 
         */
        public List<List<string>> AnadirContactos()
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
            
            Console.Clear();

            Console.WriteLine("\n1. Perro");
            Console.WriteLine("2. Gato");

            if (Console.ReadLine() == "1")
            {
                InterfazAnimal interfaz = new Perro();
                animal = interfaz.GetAnimal();                
            }
            else
            {
                InterfazAnimal interfaz = new Gato();
                animal = interfaz.GetAnimal();                
            }

            datos.Add(nombre);
            datos.Add(apellidos);
            datos.Add(dni);
            datos.Add(telefono);
            datos.Add(animal);
            
            Console.Clear();

            if (opcion == "1")
            {
                DatosPersona persona = new DatosPersona();
                persona.CrearPersona();
                
                datos.Add(persona.edad);
                datos.Add(persona.sexo);
                datos.Add("P");
            }
            else
            {
                Empresa empresa = new Empresa();
                empresa.CrearEmpresa();
                
                datos.Add(empresa.sector);
                datos.Add(empresa.nEmpleados);
                datos.Add("E");
            }

            Console.Clear();
            Console.WriteLine("\n¿Quieres guardar anotaciones sobre el contacto? (S/N)");
            string decision = Console.ReadLine().ToUpper();

            if (decision == "S")
            {               
                do
                {                    
                    Console.Clear();
                    Console.WriteLine("\nNota "+c+": ");
                    Console.WriteLine("Introduce (S) para parar de guardar notas ");
                    string anotaciones = Console.ReadLine();                                
                    if (anotaciones != "S")
                    {
                       notas.Add(anotaciones);
                    }
                    else
                    {                                                
                        break;
                    }
                    c++;

                } while (true);            
            }

            Console.Clear();

            datosTotales.Add(datos);            
            datosTotales.Add(notas);
            
            return datosTotales;           
        }                
    }
}
