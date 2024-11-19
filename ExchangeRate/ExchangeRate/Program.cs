using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float usd;
            Console.Write("Input USD: ");
            usd = float.Parse(Console.ReadLine());

            float rate = usd * 23000;
            Console.WriteLine("VND is: " + rate);
            Console.ReadKey();
        }
    }
}
