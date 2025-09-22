using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту треугольника N:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Треугольник высотой {n} строк:");

            for (int i=1; i<=n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
            Console.ReadLine();
        }
    }
}
