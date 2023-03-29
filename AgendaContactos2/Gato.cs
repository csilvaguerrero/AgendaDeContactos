using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactos2
{
    public class Gato : InterfazAnimal
    {
        string InterfazAnimal.GetAnimal()
        {
            return "Gato";
            
        }
    }
}
