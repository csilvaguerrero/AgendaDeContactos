using System.IO;
using System.Reflection.Metadata.Ecma335;
using static AgendaContactos2.Contacto;

/**
 * 
 * Clase Main de la aplicación
 * 
 */

namespace AgendaContactos2
{
    public class Program
    {
        static void Main()
        {
            Program programa = new Program();                 
            programa.Inicio();
        }
        /**
        * 
        * Método que inicia la aplicación y gestiona
        * las acciones que se llevarán a cabo sobre la misma
        * 
        */
        public void Inicio()
        {
            Empaquetar procesos = new Empaquetar();
            Contacto contacto = new Contacto();

            List<List<string>> datosContactos = new List<List<string>>();

            Console.Clear();                        

            while (true)
            {
                int opcion = PantallaInicio();                
          
                if (opcion > 6 || opcion < 1)
                {
                    Console.WriteLine("No existe esa opción, inténtalo de nuevo");
                }
                else
                {
                    switch (opcion)
                    {
                        case 1:
                        {
                            datosContactos = contacto.AnadirContactos();                            
                            procesos.Empaquetacion(datosContactos);                             
                            break;
                        }
                        case 2:
                        {
                            procesos.MostrarDatos();
                            break;
                        }                           
                        case 3:
                        {
                           procesos.EliminarDatos();
                           break;
                        }
                        case 4:
                        {
                           procesos.BuscarContacto();
                           break;
                        }
                        case 5:
                        {
                           procesos.ModificarContacto();
                           break;
                        }
                        case 6:
                        {
                            Environment.Exit(1);
                            break;
                        }
                    }
                }
            }
            
        }
        /**
         * 
         * Método que se ejecuta al iniciar la aplicación
         * por defecto. Genera la interfaz inicial.
         * 
         */
        public int PantallaInicio()
        {

            Console.WriteLine("\n1. Añadir Contactos");
            Console.WriteLine("2. Listar Contactos");
            Console.WriteLine("3. Eliminar Contactos");
            Console.WriteLine("4. Buscar Contactos");
            Console.WriteLine("5. Editar Contactos");
            Console.WriteLine("6. Cerrar programa");

            return Int16.Parse(Console.ReadLine());

        }
    }
}