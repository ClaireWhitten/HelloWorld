using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentAnswer = 0;
            string operation;


            Console.Write("Getal:");
            double getal1 = InputToDouble();
            currentAnswer = getal1;


            do
            {
                Console.Write("Operator:");
                operation = Console.ReadLine();

               if (operation != "=")
                {

                   Console.Write("Getal:");
                   double getal = InputToDouble();
   

                    switch (operation)
                    {
                        case "+":
                            currentAnswer = add(currentAnswer, getal);
                            Console.WriteLine(currentAnswer);
                            break;
                        case "-":
                            currentAnswer = subtract(currentAnswer, getal);
                            Console.WriteLine(currentAnswer);
                            break;
                        case "x":
                            currentAnswer = multiply(currentAnswer, getal);
                            Console.WriteLine(currentAnswer);
                            break;
                        case "/":
                            currentAnswer = divide(currentAnswer, getal);
                            Console.WriteLine(currentAnswer);
                            break;
                    }
                }
               
            } while (operation != "=");

            

            Console.WriteLine($"Total: {currentAnswer}");




            Console.ReadLine();
        }





        static double InputToDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }


        static double multiply(double a, double b)
        {
            return a * b;
        }

        static double divide(double a, double b)
        {
            return a / b;
        }

        static double subtract(double a, double b)
        {
            return a - b;
        }

        static double add(double a, double b)
        {
            return a + b;
        }

        static string toString(double number)
        {
            return Convert.ToString(number);
            
        }
    }
}
