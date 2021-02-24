using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening7
{
    class Program
    {
        static void Main(string[] args)
        { 
            // 7
            Console.Write("Getal 1:");
            double one = Convert.ToDouble(Console.ReadLine());
            Console.Write("Getal 2:");
            double two = Convert.ToDouble(Console.ReadLine());
            Console.Write("Getal 3:");
            double three = Convert.ToDouble(Console.ReadLine());


            
            Console.WriteLine($"{one} - {two} - {three}");
            Console.WriteLine($"{one} - {three} - {two}");
            Console.WriteLine($"{two} - {one} - {three}");
            Console.WriteLine($"{two} - {three} - {one}");
            Console.WriteLine($"{three} - {two} - {one}");
            Console.WriteLine($"{three} - {one} - {two}");

            Console.ReadLine();
        }
    }
}
