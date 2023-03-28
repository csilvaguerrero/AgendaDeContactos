using System.IO;
using System.Reflection.Metadata.Ecma335;
using static AgendaContactos2.Alta;

namespace AgendaContactos2
{
    public class Program
    {
        static void Main()
        {
            Program programa = new Program();       
          
            programa.Inicio();
        }

        public void Inicio()
        {
            Empaquetar guardar = new Empaquetar();
            Alta alta = new Alta();
            DatosPersona persona = new DatosPersona();
            Empresa empresa = new Empresa();

            Console.Clear();

            string[] datosContactos;
            string tipo;

            while (true)
            {

                int opcion = PantallaInicio();
          
                if (opcion > 4 || opcion < 1)
                {
                    Console.WriteLine("No existe esa opción, inténtalo de nuevo");
                }
                else
                {
                    switch (opcion)
                    {
                        case 1:
                        {
                            tipo = alta.AnadirContactos();
                                if (tipo == "1")
                                    datosContactos = persona.CrearPersona();
                                else
                                    datosContactos = empresa.datosEmpresa();
                                guardar.Empaquetacion(datosContactos);                                
                            break;
                        }
                        case 2:
                        {
                            guardar.MostrarDatos();
                            break;
                        }                           
                        case 3:
                        {
                           guardar.EliminarDatos();
                           break;
                        }
                        case 4:
                        {
                           guardar.BuscarContacto();
                           break;
                        }

                    }
                }
            }
            
        }

        public int PantallaInicio()
        {

            Console.WriteLine("\n1. Añadir Contactos");
            Console.WriteLine("2. Listar Contactos");
            Console.WriteLine("3. Eliminar Contactos");
            Console.WriteLine("4. Buscar Contactos");
            Console.WriteLine("5. Editar Contactos");

            return Int16.Parse(Console.ReadLine());

        }
    }
}