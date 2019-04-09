using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma sum = new Suma();
            Console.WriteLine("Ingrese valor 1 ");
            sum.Val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor 2 ");
            sum.Val2 = double.Parse(Console.ReadLine());

            sum.sumOp();
          
            Resta res = new Resta();
            Console.WriteLine("Ingrese valor 1 ");
            res.Val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor 2 ");
            res.Val2 = double.Parse(Console.ReadLine());

            
            res.restaOP();
        
            
        }
    }
}
