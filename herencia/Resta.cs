using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    class Resta:Control
    {
        
        public void restaOP()
        {
            Resultado = Val1 - Val2;
            Console.WriteLine("La resta es: "+Resultado);
            Console.ReadKey();
        }
    }
}
