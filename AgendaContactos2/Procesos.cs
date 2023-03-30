using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/**
 * 
 * Clase que gestiona todos los procesos principales
 * 
 */

namespace AgendaContactos2
{
    class Procesos
    {
        public string nombre;
        public string apellidos;
        public string dni;
        public string telefono;
        public string animal;
        public string tipo;
        
        public string adicional1;
        public string adicional2;        

        public List<String> notas = new List<String>();
    }

    public class Empaquetar
    {
        List<Procesos> guardarDatos = new List<Procesos>();        

        /**
         * 
         * Método que guarda los valores introducidos en el alta
         * en una lista.
         * 
         */
        public void Empaquetacion(List<List<string>> datosContacto)
        {            
            bool estado = true;

            var buscarDNI = guardarDatos.Where(x => x.dni == datosContacto[0][2]).ToList();

            foreach (var buscar in buscarDNI)
            {
                if (buscar.dni == datosContacto[0][2])
                    estado = false;                                    
            }

            if (estado)
                guardarDatos.Add(new Procesos() { nombre = datosContacto[0][0], apellidos = datosContacto[0][1], dni = datosContacto[0][2], telefono = datosContacto[0][3], animal = datosContacto[0][4], adicional1 = datosContacto[0][5], adicional2 = datosContacto[0][6], tipo = datosContacto[0][7], notas = datosContacto[1].ToList() });
            else
                Console.WriteLine("El DNI que has introducido ya existe, inténtalo de nuevo.");

            datosContacto[0].Clear();
            datosContacto[1].Clear();            

        }
        /**
         *         
         * Método que muestra por pantalla los contactos guardados en la lista
         * de la clase.
         * 
         */
        public void MostrarDatos()
        {
            Console.Clear();

            foreach (var datos in guardarDatos)
            {
                Console.WriteLine("----------------------");

                Console.WriteLine("Nombre: "+ datos.nombre);
                Console.WriteLine("Apellidos: "+ datos.apellidos);
                Console.WriteLine("DNI: "+ datos.dni);
                Console.WriteLine("Teléfono: "+ datos.telefono);
                Console.WriteLine("Animal: "+ datos.animal);
                Console.WriteLine("\nDatos adicionales");
                Console.WriteLine(datos.adicional1);
                Console.WriteLine(datos.adicional2);               
                
                if (datos.notas.Count != 0)
                {
                    Console.WriteLine("   Notas: ");                    
                    for (int i = 0; i < datos.notas.Count; i++)
                       Console.WriteLine("\t" + datos.notas[i]);
                }
                Console.WriteLine("----------------------\n");
            }
        }

        /**
         * 
         * Método que elimina los contactos de la lista.
         * 
         */
        public void EliminarDatos()
        {
            Console.Clear();

            Console.WriteLine("\nIntroduzca el DNI del contacto a eliminar: ");

            String dniBusqueda = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\n¿Estás seguro de que deseas eliminar el contacto? (S/N)");
            string opcion = Console.ReadLine().ToUpper();

            if (opcion == "S")
            {
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
            else
            {
                Console.Clear();
            }          
        }

        /**
         * 
         * Método que realiza la búsqueda de contactos
         * mediante los DNI
         * 
         */
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

                Console.WriteLine("Nombre: "+ datos.nombre);
                Console.WriteLine("Apellidos: "+ datos.apellidos);
                Console.WriteLine("DNI: " + datos.dni);
                Console.WriteLine("Teléfono: "+ datos.telefono);
                Console.WriteLine("Animal: " + datos.animal);
                Console.WriteLine("\nDatos adicionales");
                Console.WriteLine(datos.adicional1);
                Console.WriteLine(datos.adicional2);

                if (datos.notas.Count != 0)
                {
                    Console.WriteLine("   Notas: ");
                    for (int i = 0; i < datos.notas.Count; i++)
                        Console.WriteLine("\t" + datos.notas[i]);
                }

                Console.WriteLine("----------------------");
            }
        }

        /**
         * 
         * Método que modifica los contactos guardados en la lista
         * principal.
         * 
         */
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
                Console.WriteLine("5. Cambiar Animal");
                Console.WriteLine("8. Añadir Notas");
                if (guardarDatos[indice].tipo == "P")
                {
                    Console.WriteLine("6. Cambiar Sexo");
                    Console.WriteLine("7. Cambiar Edad");
                }
                else
                {
                    Console.WriteLine("6. Cambiar Sector");
                    Console.WriteLine("7. Cambiar Número de empleados");
                }

                Console.WriteLine("9. Salir");

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
                        Console.WriteLine("\nNuevo Animal: ");
                        string animal = Console.ReadLine();
                        guardarDatos[indice].animal = animal;
                        break;
                    }
                    case 6:
                    {
                        Console.Clear();                            
                        if (guardarDatos[indice].tipo == "P")
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
                    case 7:
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
                    case 8:
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Notas: ");
                                Console.WriteLine("Introduce (S) para parar de guardar notas ");
                                string anotacion = Console.ReadLine();
                                if (anotacion != "S")
                                {
                                    guardarDatos[indice].notas.Add(anotacion);
                                }
                                else
                                {
                                    break;
                                }
                            } while (true);
                            break;
                        }
                    case 9:
                    {
                        Console.Clear();
                        break;
                    }
                    
                }
            }                                          
        }        
    }
}
