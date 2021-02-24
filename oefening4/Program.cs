using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4

            Console.Write("Voornaam: ");
            string voornaam = Console.ReadLine();

            Console.Write("Achternaam: ");
            string achternaam = Console.ReadLine();

            Console.Write("Adres: ");
            string adres = Console.ReadLine();

            Console.Write("Postcode: ");
            string postcode = Console.ReadLine();

            Console.Write("Hobby's: ");
            string hobbies = Console.ReadLine();


            Console.WriteLine($"Dag {voornaam} {achternaam}! Jij woont op {adres}, {postcode}.\n Jouw hobby's zijn {hobbies}");
                                                                                                // \n is new line
            Console.ReadLine();
        }
    }
}
