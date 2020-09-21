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
            int a = 45;
            int b = 52;
            Suma(a, b);
            Atimtis(a, b);
            Daugyba(a, b);

        }

        static void Suma(int a, int b)
        {
            Console.WriteLine($"Suma = {a + b}");
        }

        static void Atimtis(int a, int b)
        {
            Console.WriteLine($"Atimtis = {a - b}");
        }
        static void Daugyba(int a, int b)
        {
            Console.WriteLine($"Daugyba = {a * b}");
        }

    }
}
