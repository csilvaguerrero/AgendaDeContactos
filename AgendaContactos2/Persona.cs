using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactos2
{   
    class DatosPersona : Alta
    {

        public string edad;
        public string sexo;

        public string[] datosP = new String[6];

        /*public string nombrePersona;
        public string apellidosPersona;
        public string dniPersona;
        public string telefonoPersona;*/
        
        public string[] CrearPersona(){

            // Console.Clear();
            Alta alta = new Alta();
            
            Console.WriteLine(alta.Nombre);
            

            Console.WriteLine("\nSexo: ");
            sexo = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\nEdad: ");
            edad = Console.ReadLine();

            Console.Clear();

            /*datosP[0] = nombrePersona;
            datosP[1] = apellidosPersona;
            datosP[2] = dniPersona;
            datosP[3] = telefonoPersona;*/
            datosP[4] = sexo;
            datosP[5] = edad;

            Console.WriteLine(datosP[0]);

            foreach (var item in datosP)
            {
                Console.WriteLine(item);
            }

            return datosP;

        }
    }
}
