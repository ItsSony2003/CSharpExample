using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Enter your name: ");

            string yourName = Console.ReadLine();

            Console.WriteLine("Hello: " + yourName);

            Console.ReadKey();
        }
    }
}
