using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            double BGN, USD, EUR, GBP;

            while (input == "BGN")
            {
                if (output == "USD")
                {
                    USD = number / 1.79549;
                    Console.WriteLine("{0} {1}", Math.Round(USD, 2), output);
                    break;
                }
                else if (output == "EUR")
                {
                    EUR = number / 1.95583;
                    Console.WriteLine("{0} {1}", Math.Round(EUR, 2), output);
                    break;
                }
                else if (output == "GBP")
                {
                    GBP = number / 2.53405;
                    Console.WriteLine("{0} {1}", Math.Round(GBP, 2), output);
                    break;
                }
            }
            while (input == "USD")
            {
                if (output == "BGN")
                {
                    BGN = number * 1.79549;
                    Console.WriteLine("{0} {1}", Math.Round(BGN, 2), output);
                    break;
                }
                else if (output == "EUR")
                {
                    EUR = (number * 1.79549) / 1.95583;
                    Console.WriteLine("{0} {1}", Math.Round(EUR, 2), output);
                    break;
                }
                else if (output == "GBP")
                {
                    GBP = (number * 1.79549) / 2.53405;
                    Console.WriteLine("{0} {1}", Math.Round(GBP, 2), output);
                    break;
                }
            }
            while (input == "EUR")
            {
                if (output == "USD")
                {
                    USD = (number * 1.95583) / 1.79549;
                    Console.WriteLine("{0} {1}", Math.Round(USD, 2), output);
                    break;
                }
                else if (output == "BGN")
                {
                    BGN = number * 1.95583;
                    Console.WriteLine("{0} {1}", Math.Round(BGN, 2), output);
                    break;
                }
                else if (output == "GBP")
                {
                    GBP = (number * 1.95583) / 2.53405;
                    Console.WriteLine("{0} {1}", Math.Round(GBP, 2), output);
                    break;
                }
            }
            while (input == "GBP")
            {
                if (output == "USD")
                {
                    USD = (number * 2.53405) / 1.79549;
                    Console.WriteLine("{0} {1}", Math.Round(USD, 2), output);
                    break;
                }
                else if (output == "EUR")
                {
                    EUR = (number * 2.53405) / 1.95583;
                    Console.WriteLine("{0} {1}", Math.Round(EUR, 2), output);
                    break;
                }
                else if (output == "BGN")
                {
                    BGN = (number * 2.53405) / 1.95583;
                    Console.WriteLine("{0} {1}", Math.Round(BGN, 2), output);
                    break;
                }
            }
        }
    }
}
