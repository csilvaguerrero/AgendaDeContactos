using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace AgendaContactos2
{
    internal class Program
    {
        static void Main()
        {
            Program programa = new Program();
            
            programa.Inicio();
        }

        public void Inicio()
        {

            Console.Clear();

            string[] datosContactos;
            int opcion = PantallaInicio();

            if (opcion > 2 || opcion < 1)
            {
                Console.WriteLine("No existe esa opción, inténtalo de nuevo");
            }
            else
            {
                switch (opcion)
                {
                    case 1:
                        {
                            datosContactos = AnadirContactos();
                            AlmacenarDatos(datosContactos);
                            PantallaInicio();
                            break;
                        }
                    case 2:
                        // listarContactos();
                        break;
                }
            }
            
        }

        public int PantallaInicio()
        {

            //Console.Clear();

            Console.WriteLine("\n1. Añadir Contactos");
            Console.WriteLine("2. Listar Contactos");

            return Int16.Parse(Console.ReadLine());

        }
        public string[] AnadirContactos()
        {

            String[] datos = new string[4];

            String nombre;
            String apellidos;
            String dni;
            String telefono;

            Console.Clear();

            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Apellidos: ");
            apellidos = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("DNI: ");
            dni = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Telefono: ");
            telefono = Console.ReadLine();

            datos[0] = nombre;
            datos[1] = apellidos;
            datos[2] = dni;
            datos[3] = telefono;

            //Inicio();

            return datos;
            
        }
      
        public List<String> AlmacenarDatos(String[] datos)
        {

            List<String> list = new List<String>();
          
           /* list.Add(datos[0]);
            list.Add(datos[1]);
            list.Add(datos[2]);
            list.Add(datos[3]);*/


            //list.Add(nombre = "crank arm", dni = 1234);

            list.Add(datos[0], datos[1], datos[2]);

            return list;
            //Console.WriteLine(datos[0]);
        }        
    }
}