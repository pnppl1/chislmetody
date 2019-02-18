using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double  a, q, x;
            double e = Math.Pow(10, -6);
            x = 0;
            a = Math.Pow(-1, 0) * Math.Pow(Math.PI / 2, 2 * 0) * Math.Pow(x, 4 * 0 + 1);
            for (int n = 0; (a > e) && (x < 1.5); n++)
            {
                q = -Math.Pow(Math.PI / 2, 2) * Math.Pow(x, 4) * (4 * n + 1) / ((2 * n + 1) * (2 * n + 2) * (4 * n + 5));
                a = a * q;
                x = x + n * 0.15;
                Console.WriteLine(Convert.ToString(x), a);
            }
        }
    }
}
