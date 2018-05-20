using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double tobgn = 1.79549;
            double result = usd * tobgn;
            Console.WriteLine(Math.Round(result, 2) + " BGN");
        }
    }
}
