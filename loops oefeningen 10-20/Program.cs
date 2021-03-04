using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_oefeningen_10_20
{
    class Program
    {
        static void Main(string[] args)
        {
            {/*
                //oefening 11
                Console.WriteLine("Input:");
                int input = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= input; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
            
            
            {

                //oefening 12
                Console.Write("Input:");
                int input = Convert.ToInt32(Console.ReadLine());


                for (int i = 1; i <= input; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }

            }
            
            {
                //oefening 13

                Console.Write("Input:");
                int input = Convert.ToInt32(Console.ReadLine());


                for (int i = 1; i <= input; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }



            }

            {
                //oefening 14

                Console.Write("Input:");
                int input = Convert.ToInt32(Console.ReadLine());
                int opteller = 1;

                for (int i = 1; i <= input; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($" {opteller++}");
                    }
                    Console.WriteLine();
                }

            }

            {
                //oefening 15
                // This creates 4 lines 
                int opteller = 1;

                for (int i = 1; i <= 4; i++) //3 lines
                {
                    for (int j = 1; j <= i; j++) 
                    {
                        if (j == 1) {

                            for (int k = 4; k >= i; k--) //i = 1
                            {

                                Console.Write(" "); //does 4 (number of lines) spaces on first line, 4-1 number of spaces on second line, 4-2 spaces on third line etc
                                
                            }
                        }

                            Console.Write($"{opteller++}");
                            Console.Write(" ");
                    }

                    Console.WriteLine();
                }
                
            }

            {
                //oefening 16 
                // This creates 4 lines 

                Console.Write("Aantal:");
                int aantal = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= aantal; i++) 
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (j == 1)
                        {

                            for (int k = aantal; k >= i; k--) //i = 1
                            {

                                Console.Write(" "); //does 4 (number of lines) spaces on first line, 4-1 number of spaces on second line, 4-2 spaces on third line etc

                            }
                        }

                        Console.Write($"*");
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                }

            }
            
            


                

                {
                    //oefening 17 

                    Console.WriteLine("Getal:");
                    int getal = Convert.ToInt32(Console.ReadLine()); //4
                    int total = getal; //4

                    //3                  //Runs3 times i=3...i=2...i=1
                    for (int i = 1; i < getal; i++)
                    {
                        total = total * i;     // 4 x 3 = 12.... 12 x 2 = 24....... 24 x 1 = 24
                    }
                    Console.WriteLine($"Faculteit: {total}");
                }

                



                // oefening 18 - converting to binary
                {
                    for (int i = 0; i <= 15; i++)
                    {
                        int binary = Convert.ToInt32(Convert.ToString(i, 2));
                        Console.WriteLine(binary.ToString("D4")); //The base number  - base 2 = binary, base 8 = octal base 10 = decimal base 16 = haxadecimal 

                    }

                }*/



                //oefening 19 - prime numbers 1-100

                
                {
                    Console.WriteLine("Priemgetallen tot 100: ");

                    bool isPrimeNumber;

                    for (int i = 1; i <= 100; i++)
                    {
                        isPrimeNumber = true;

                        for (int j = 2; j < i; j++) //i = 2
                        {
                            if (i % j == 0) // catches numbers which are not prime
                            {
                                isPrimeNumber = false;
                                break; /// makes it quicker if the program has to find the prime numbers to 100000 for example - test out
                            }
                        }
                        if (isPrimeNumber == true && i > 1)
                        {
                            Console.WriteLine(i);
                        }
                        
                    }

                }


                //oefening 20 - ??


                Console.ReadLine();
            }

        }




    }
}
