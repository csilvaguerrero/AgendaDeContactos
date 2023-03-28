using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactos2
{
    public class GuardarDatos
    {
        public string nombre;
        public string apellidos;
        public string dni;
        public string telefono;
        public string tipo;

        public string adicional1;
        public string adicional2;
    }

    public class Empaquetar
    {
        List<GuardarDatos> guardarDatos = new List<GuardarDatos>();

        public void Empaquetacion(String[] datosContacto)
        {

            var buscarDNI = guardarDatos.Where(x => x.dni == datosContacto[2]).ToList();

            if (buscarDNI.Count == 0)
                guardarDatos.Add(new GuardarDatos() { nombre = datosContacto[0], apellidos = datosContacto[1], dni = datosContacto[2], telefono = datosContacto[3], adicional1 = datosContacto[4], adicional2 = datosContacto[5], tipo = datosContacto[6] });
            else
                Console.WriteLine("El DNI que has introducido ya existe, inténtalo de nuevo");

            
        }
        public void MostrarDatos()
        {
            Console.Clear();


            foreach (var datos in guardarDatos)
            {

                Console.WriteLine("----------------------");

                Console.WriteLine(datos.nombre);
                Console.WriteLine(datos.apellidos);
                Console.WriteLine(datos.dni);
                Console.WriteLine(datos.telefono);
                Console.WriteLine(datos.adicional1);
                Console.WriteLine(datos.adicional2);

                Console.WriteLine("----------------------\n");
            }
        }

        public void EliminarDatos()
        {
            Console.Clear();

            Console.WriteLine("\nIntroduzca el DNI del contacto a eliminar: ");

            String dniBusqueda = Console.ReadLine();            

            var borrarContacto = guardarDatos.Where(x => x.dni == dniBusqueda).ToList();

            if (borrarContacto.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("\nNo existe ningún contacto con ese DNI, vuelve a intentarlo.");
            }
            else
            {
                foreach (var datos in borrarContacto)
                {
                    guardarDatos.Remove(datos);
                }

                Console.Clear();
                Console.WriteLine("\nSe ha eliminado correctamente");

            }

        }
        public void BuscarContacto()
        {
            Console.Clear();

            Console.WriteLine("\nIntroduce el DNI del contacto a buscar: ");
            
            string dniBuscar = Console.ReadLine();

            var buscarContacto = guardarDatos.Where(x => x.dni == dniBuscar);

            Console.Clear();

            foreach(var datos in buscarContacto)
            {
                Console.WriteLine("----------------------");

                Console.WriteLine(datos.nombre);
                Console.WriteLine(datos.apellidos);
                Console.WriteLine(datos.dni);
                Console.WriteLine(datos.telefono);

                Console.WriteLine("----------------------");
            }
        }
        public void ModificarContacto()
        {
            Console.Clear();

            Console.WriteLine("\nIntroduce el DNI del contacto que desea modificar: ");

            string DNI = Console.ReadLine();

            Console.Clear();

            var buscar = guardarDatos.Where(x => x.dni == DNI);

            if (!buscar.Any())
            {
                Console.Clear();
                Console.WriteLine("\nNo existe ningún contacto con ese DNI, vuelve a intentarlo.");
            }
            else 
            {
                int indice = guardarDatos.IndexOf(guardarDatos.FirstOrDefault(x => x.dni == DNI));                

                Console.WriteLine("\n1. Cambiar Nombre");
                Console.WriteLine("2. Cambiar Apellidos");
                Console.WriteLine("3. Cambiar DNI");
                Console.WriteLine("4. Cambiar Teléfono");     
                if (guardarDatos[indice].tipo == "C")
                {
                    Console.WriteLine("5. Cambiar Sexo");
                    Console.WriteLine("6. Cambiar Edad");
                }
                else
                {
                    Console.WriteLine("5. Cambiar Sector");
                    Console.WriteLine("5. Cambiar Número de empleados");
                }

                Console.WriteLine("7. Salir");

                int opcion = Int16.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("\nNuevo Nombre: ");
                        string nombre = Console.ReadLine();
                        guardarDatos[indice].nombre = nombre;
                        break;
                    }
                    case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("\nNuevos Apellidos: ");
                        string apellidos = Console.ReadLine();
                        guardarDatos[indice].apellidos = apellidos;
                        break;
                    }
                    case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("\nNuevo DNI: ");
                        string dni = Console.ReadLine();
                        guardarDatos[indice].dni = dni;
                        break;
                    }
                    case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("\nNuevo Teléfono: ");
                        string telefono = Console.ReadLine();
                        guardarDatos[indice].telefono = telefono;
                        break;
                    }
                    case 5:
                    {
                        Console.Clear();
                        if (guardarDatos[indice].tipo == "C")
                        {
                            Console.WriteLine("\nNuevo Sexo: ");
                            string sexo = Console.ReadLine();
                            guardarDatos[indice].adicional1 = sexo;
                        }
                        else
                        {
                            Console.WriteLine("\nNuevo Sector: ");
                            string sector = Console.ReadLine();
                            guardarDatos[indice].adicional1 = sector;
                        }
                        break;
                    }
                    case 6:
                    {
                        Console.Clear();
                        if (guardarDatos[indice].tipo == "C")
                        {
                            Console.WriteLine("\nNueva Edad: ");
                            string edad = Console.ReadLine();
                            guardarDatos[indice].adicional2 = edad;
                        }
                        else
                        {
                            Console.WriteLine("\nNuevo Número de empleados: ");
                            string empleados = Console.ReadLine();
                            guardarDatos[indice].adicional2 = empleados;
                        }
                        break;
                        }
                    case 7:
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
                                 
            
        }
    }
}
