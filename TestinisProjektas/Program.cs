using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestinisProjektas
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 5;
            Suma(a, b);

        }

        static void Suma(int a, int b)
        {
            Console.WriteLine($"Suma = {a + b}");
        }

    }
}
