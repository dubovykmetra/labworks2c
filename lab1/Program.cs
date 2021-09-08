using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a,b,c;
            
            Console.WriteLine("Input r1");
            a = Console.ReadLine();
            Console.WriteLine("Input r2");
            b = Console.ReadLine();
            Console.WriteLine("Input r3");
            c = Console.ReadLine();

            int r1 = Convert.ToInt32(a);
            int r2 = Convert.ToInt32(b);
            int r3 = Convert.ToInt32(c);

            int R = r1 + r2 + r3;



            Console.WriteLine("Resistance = " + R);

            Console.ReadLine();
        }
    }
}
