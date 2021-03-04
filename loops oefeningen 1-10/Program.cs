using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_oefeningen_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
            //oefening 1

                Console.WriteLine("Getal:");
                int number = Convert.ToInt32(Console.ReadLine());

                while (number < 20)
                {
                    number++;
                    Console.WriteLine(number);
                }
            }


            {
                //oefening 2
                Console.WriteLine("Getal:");
                int number = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 5;  i++)
                {
                    number++;
                    Console.WriteLine(number);
                }
               

        
            }
            

            {
                //oefening 3

                string input;
                do
                {
                    Console.Write("Input:");
                    input = Console.ReadLine().ToLower();
                } while (input != "stop");

                Console.WriteLine("De applicatie is stopt.");
                
            }
            
            {
                //oefening 4 -                  -3 + 5 pattern every other number - run 20 times 

                Console.Write("Getal:");
                int number = Convert.ToInt32(Console.ReadLine());
                bool everySecondNumber = false;
                int teller = 0;
                do
                {

                    if (everySecondNumber)
                    {
                        number -= 3;
                    }
                    else
                    {
                        number += 5;
                    }
                       
                    everySecondNumber = !everySecondNumber;
                    Console.WriteLine(number);
                    teller++;

                } while (teller < 20);

            }
            
            {
                //oefening 5

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($" {i}");
                }



            }
            

            {
                //oefening 6
                Console.Write("Getal:");
                int number = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 10 ; i++)
                {
                    Console.Write($"{number *i} ");
                }

            }
            
            {
                //oefening 7
                Console.Write("Getal:");
                int number = Convert.ToInt32(Console.ReadLine());
                int total = 0;
                for (int i = 1; i <= number; i++)
                {
                    Console.Write($"{i} ");
                    total += i;
                }
                Console.WriteLine($"\n{total}"); // is there a way to print this onto the next line without using this?

            }
            
            {
                //oefening 8
                Console.Write("Aantal:");
                int aantal = Convert.ToInt32(Console.ReadLine());
                double total = 0; //double because can't divide 2 ints - one needs to be a double 

                for (int i = 1; i <= aantal; i++)
                {
                    Console.Write($"Getal {i}:");
                    total += Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine($"Gemiddelde:{total/aantal}");

            }
            


            {
                //oefening 9
                Console.Write("Getal:");
                int number = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine($"Het kwadraat van {i} is {Math.Pow(i,2)}"); //i x i
                }

            }
            
            {
                //oefening 10

                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write($"{i * j}\t");  
                    }
                    Console.WriteLine(); //new line after each group of tables 
                }

            }
            

            Console.ReadLine();
        }
    }
}
