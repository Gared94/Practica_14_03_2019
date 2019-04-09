using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    class Suma:Control
    {

        
        public void sumOp()
        {
            Resultado = Val1 + Val2;
            Console.WriteLine("La suma es: " + Resultado );
          
        }
        
    }
}
