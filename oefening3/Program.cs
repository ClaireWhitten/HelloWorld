using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3
            Console.Write("Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine()); //convert the string here instead of in the calculation

            double celcius = (fahrenheit - 32) * 5 / 9; //actual answer 
            Console.WriteLine(celcius);
            double celciusRounded = Math.Round(celcius); //answer rounded to whole number

            Console.WriteLine($"Celcius : {celciusRounded}");

            Console.ReadLine();

        }
    }
}
