using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening01
{
    class Program
    {
        static void Main(string[] args)
        {

           //1.1
            double nummer1 = 7; //use double if need to divide
            double nummer2 = 5;

            Console.WriteLine($"{nummer1} + {nummer2} = {nummer1 + nummer2}");
            Console.WriteLine($"{nummer1} - {nummer2} = {nummer1 - nummer2}");
            Console.WriteLine($"{nummer1} * {nummer2} = {nummer1 * nummer2}");
            Console.WriteLine($"{nummer1} / {nummer2} = {nummer1 / nummer2}");

            //1.2 
            Console.Write("Getal 1:");      
            double getal1 = Convert.ToDouble(Console.ReadLine()); //convert here 
            Console.Write("Getal 2:");
            double getal2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(getal1 + getal2); //don't convert here 
            Console.WriteLine(getal1 - getal2);
            Console.WriteLine(getal1 * getal2);
            Console.WriteLine(Math.Round(getal1 / getal2,2));



            //1.3 
            Console.Write("Getal 1:");
            double getalEen = Convert.ToDouble(Console.ReadLine());
            Console.Write("Getal 2:");
            double getalTwee = Convert.ToDouble(Console.ReadLine());

            double answer1 = getalEen + getalTwee;  
            double answer2 = getalEen - getalTwee;
            double answer3 = getalEen * getalTwee;
            double answer4 = getalEen / getalTwee; 
            
           
            Console.WriteLine($"{answer1} + {answer2} + { answer3} + {Math.Round(answer4,2)} = {answer1 + answer2 + answer3 + Math.Round(answer4,2)}");
            Console.WriteLine($"{answer1} x {answer2} x { answer3} x {Math.Round(answer4,2)} = {answer1 * answer2 * answer3 * Math.Round(answer4,2)}");

            // Decimals Note: only round in the place where you will show the variable NOT in the memory/variable self - otherwise can result in inaccurate calculations
            // Alternative to Math.Round(theNumber, numberofDecimalPlaces) is theNumber.toString("0.##")*/

            double number = 2.1;
            Console.WriteLine(number.ToString("0.00")); //forces a zero to make up 2 decimal places

            double number2 = 2;
            Console.WriteLine(number2.ToString("0.00")); //forces 2 zeros to make up 2 decimal places

            double number3 = 2.1274567;
            Console.WriteLine(number3.ToString("0.###")); //rounds to 3 decimal places

            Console.WriteLine(number3.ToString("0.##")); //rounds to 2 decimal places



            //1.4

            //answer 4 afgerond  - see above



            Console.ReadLine();
        }
    }
}
