using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening9
{
    class Program
    {
        static void Main(string[] args)

        {

            // 9 
            Console.Write("Af te leggen afstand in km: ");
            double km = Convert.ToDouble(Console.ReadLine());

            Console.Write("Af te leggen afstand in km: ");
            double snelHeid = Convert.ToDouble(Console.ReadLine());

            double timeHours = km /snelHeid; //gives time in hours as decimal e.g. 2.25

            Console.WriteLine($"De vrachtwagen zal nog {timeHours} uur moeten rijden");


            //Bonus  - Split into minutes and hours
            double timeMinutes = (timeHours * 60) % 60; //gives minutes left over - 15 min
           


            Console.Write($"De vrachtwagen zal nog {Math.Floor(timeHours)} uur en {Math.Floor(timeMinutes)} minuten moeten rijden");
                                    // Math.Floor rounds down leaving hours only   //leaves minutes only 


       
            Console.ReadLine();


        }
    }
}
