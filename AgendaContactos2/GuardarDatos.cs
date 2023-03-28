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
        public string adicional1;
        public string adicional2;
    }

    public class Empaquetar
    {
        List<GuardarDatos> guardarDatos = new List<GuardarDatos>();

        public void Empaquetacion(String[] datosContacto)
        {
            Console.WriteLine(datosContacto[3]);

            var buscarDNI = guardarDatos.Where(x => x.dni == datosContacto[2]).ToList();

            if (buscarDNI.Count == 0)
                guardarDatos.Add(new GuardarDatos() { nombre = datosContacto[0], apellidos = datosContacto[1], dni = datosContacto[2], telefono = datosContacto[3], adicional1 = datosContacto[4], adicional2 = datosContacto[5] });
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
    }
}
