using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            a = 40;b = 10;c = 20;d = 30;e = 40;
            if (a < 15)
            {
                Console.WriteLine("a is less than 15");
            }
            else
            {
                Console.WriteLine("a is not less than 15");
            }
            Console.WriteLine("value of a is :" + a);

            

            Console.WriteLine(a * 50);
            Console.WriteLine(5 * a * 50);
            Console.WriteLine(5 * a * 50 +b -c +d +e);
            Console.WriteLine(b + c * d / e);
            Console.WriteLine(a * 50 / c);


            Console.ReadKey();












        }
    }
}
