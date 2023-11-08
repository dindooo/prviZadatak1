using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviZadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a=2, b=4, c=6, d=8;
            double x = (a*a+b*b+c*c+d*d)/(a+b)*(a+b)+(c+d)*(c+d);
            Console.WriteLine(x);
            Console.ReadKey();
        }

    }
    
}
