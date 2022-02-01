using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            Console.WriteLine("Unesi vrijednost za x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi vrijednost za y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi vrijednost za z: ");
            z = Convert.ToInt32(Console.ReadLine());


            if (x > 0)
                Console.WriteLine("Vrijednost x je: " + x);
            else
                Console.WriteLine("Vrijednost mora biti veca od nule.");
            if (y > 0)
                Console.WriteLine("Vrijednost y je: " + y);
            else
                Console.WriteLine("Vrijednost mora biti veca od nule.");
            if (z > 0)
                Console.WriteLine("Vrijednost z je. " + z);
            else
                Console.WriteLine("Vrijednost mora biti veca od nule.");

            Console.ReadKey();
        }
    }
}
