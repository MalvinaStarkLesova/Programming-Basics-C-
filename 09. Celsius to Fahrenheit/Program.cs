using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double cels = double.Parse(Console.ReadLine());
            double faren = cels * 1.8 + 32;
            Console.WriteLine("{0:f2}", faren);
        }
    }
}
