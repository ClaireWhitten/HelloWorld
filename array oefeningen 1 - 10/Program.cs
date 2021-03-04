using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_oefeningen_1___10
{
    class Program
    {
        static void Main(string[] args)
        { /*
            {
                //oefening 1
                int[] getallen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            }



            {
                //oefening 2
                int[] getallen = new int[100];
                int teller = 100;
                for (int i = 0; i < getallen.Length; i++)
                {
                    getallen[i] = teller--;  //first assigns teller and then does teller--
                    Console.WriteLine(getallen[i]);
                }
                Console.WriteLine(getallen); // can you print the actual array?
            }

            
            {
                //oefening 3 - char 97-122

                char[] letters = new char[26];
                char letter = 'a';

                for (int i = 0; i < letters.Length; i++)
                {
                    letters[i] = letter++; //first assigns current letter and then does teller++
                    Console.WriteLine(letters[i]);
                }
                
            }
            

            {
                //oefening 4

                double[] randomGetallen = new double[20];
                Random randomGenerator = new Random();  //creates random generator
                for (int i = 0; i < randomGetallen.Length; i++)
                {
                    randomGetallen[i] = randomGenerator.Next(1,101);
                    Console.WriteLine(randomGetallen[i]);
                }
            } 
            

            {
                //oefening 5
                bool[] trueOrFalse = new bool[30];
                for (int i = 0; i < trueOrFalse.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        trueOrFalse[i] = true;
                    } else
                    {
                        trueOrFalse[i] = false;
                    }
                    Console.WriteLine(trueOrFalse[i]);
                }

            } 

            {
                //oefening 6

                int[] getallen = new int[10];

                for (int i = 0; i < getallen.Length; i++)
                {
                    Console.WriteLine("Geef een getal in:");
                    getallen[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine($" De som is {getallen.Sum()}. \n Het gemiddelste is {getallen.Max()} \n Het grootste is {getallen.Min()}.");

                Console.WriteLine("Geef een taal in:");
                int getal = Convert.ToInt32(Console.ReadLine());
                int teller = 0;


                for (int i = 0; i < getallen.Length; i++)
                {
                    if (getallen[i] >= getal)
                    {
                        Console.WriteLine(getallen[i]);

                        if (getallen[i] > getal)
                        {
                            teller++;
                        }
                    } 
                }
                if (teller == 0)
                {
                    Console.WriteLine("Niets is groter");
                }
              
            }
            */

            {
                //oefening 7

                //int[] getallen1 = new int[5];
                Console.WriteLine("Geef 5 getallen in:");
                string[] numbers1 = Console.ReadLine().Split(' ');

                Console.WriteLine("Geef 5 getallen in:");
                string[] numbers2 = Console.ReadLine().Split(' ');

                int[] sumOfNumbers = new int[5];
                for (int i = 0; i < numbers1.Length; i++)
                {
                    sumOfNumbers[i] = Convert.ToInt32(numbers1[i]) + Convert.ToInt32(numbers2[i]);
                    Console.WriteLine(sumOfNumbers[i]);
                }
                    
                
            }

            {
                //oefening 8


            }







            Console.ReadLine();
        }
    }
}
