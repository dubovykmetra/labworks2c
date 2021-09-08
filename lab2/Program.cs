using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nn;
            Console.WriteLine("Введiть nn");
            nn = Console.ReadLine();
            while (Convert.ToInt32(nn) <= 0.0)
            {
                Console.WriteLine("nn має бути бiльше або = 0");
                nn = Console.ReadLine();

            }

            string nk;
            Console.WriteLine("Введiть nk");
            nk = Console.ReadLine();
            while (Convert.ToInt32(nk) < 0.0 && Convert.ToInt32(nk) <= Convert.ToInt32(nn))
            {
                Console.WriteLine("nk має бути бiльше або = 0 та більше або = nn");
                nk = Console.ReadLine();

            }



            Console.WriteLine(nn);
            Console.WriteLine(nk);

            double a = 0.0;
            double sum = 0.0;

            for (double k = Convert.ToInt32(nn); k <= Convert.ToInt32(nk); k++)
            {
                Console.WriteLine("nn = " + nn);
                Console.WriteLine("nk = " + nk);
                Console.WriteLine("k = " + k);
                a = ((Math.Pow(-1.0, k)) * (Math.Pow(k, 2.0)) - 1.0) / ((Math.Pow(k, 2.0)) + 3.0);
                Console.WriteLine("a = " + a);
                sum += a;//check
            }




            Console.WriteLine("sum = " + sum);

            Console.ReadLine();
        }
    }
}
