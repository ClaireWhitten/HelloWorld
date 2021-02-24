using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening2
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2
            Console.Write("Prijs Drankje:");
            double prijs = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("Aantal Drankjes:");
            int aantal = Convert.ToInt32(Console.ReadLine());

            double total = prijs * aantal;
            Console.WriteLine($"Prijs zonder btw: {total} euros");

            double totalPlusBtw = total * 1.21; //adds 21%
            
            Console.WriteLine($"Prijs met 21% btw: {totalPlusBtw.ToString("0.00")} euros"); //forces last zero and changes 2.1 to 2.10 


           

            Console.ReadLine();

        }
    }
}
