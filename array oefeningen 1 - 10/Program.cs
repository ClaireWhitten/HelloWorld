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
        { 
           int oefening = Input(); - see method and add switch 
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
                string[] questions = { "Do you like chocolate?", "Can you swim?", "Are you older than 30?", "Do you eat meat?", "Do you enjoy walking?", "Do you live in Antwerp?" };
                int[] answers = new int[6];
                int answer = 0;


                Console.WriteLine("Kies een nummer voor elke vraag:\n 1. Yes \n 2.No");

                for (int i = 0; i < questions.Length; i++)
                {
                    Console.WriteLine(questions[i]);
                    answer = Convert.ToInt32(Console.ReadLine());
                    if ( answer == 1 || answer == 2)
                    {
                        answers[i] = answer;

                    } else
                    {
                        Console.WriteLine("invalid number");
                    }
                }

                Console.WriteLine("Your answers:");

                for (int i = 0; i < answers.Length; i++)
                {
                    Console.WriteLine(questions[i]);
                    switch(answers[i])
                    {
                        case 0: Console.WriteLine("Invalid answer");break;
                        case 1: Console.WriteLine("Yes"); break;
                        case 2: Console.WriteLine("No"); break;
                    }
                }
            }
            

            {
                //oefening 9

                string[] values = new string[10];

                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine("Geef een getal");
                    values[i] = Console.ReadLine();
                }

                Console.WriteLine("Welke getal wil je verwijderen?");
                string keuze = Console.ReadLine();
                int index = Array.IndexOf(values, keuze);
                //Console.WriteLine(index);


                //shift everything after the number to the left 
                             //3
                for (int i = index; i < values.Length-1; i++) //must be values.length-1 otherwise the last doesn't work!!!!
                {
                    values[i] = values[i + 1];  //moves all numbers after the number that needs to be removed therefore deleting it

                    if (i == 9)
                    {
                        values[i] = "-1";
                    }
                }

                values.SetValue("-1", 9); //change or set a number using .setValue(new value, index)

                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine(values[i]);
                }

            

            }

            {
                //oefening 10
                string[] postcodes = {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009"};
                double[] prijzen = {1.50, 2.50, 3.50, 4.50, 5.50, 6.50, 7.50, 8.50, 9.50, 10.50};
                double totaal = 0;

                Console.WriteLine("Geef een postcode:");
                string postcode = Console.ReadLine();
                Console.WriteLine("Geef een gewicht:");
                double gewicht = Convert.ToDouble(Console.ReadLine());

                int keuze = Array.IndexOf(postcodes, postcode);

                if (keuze == -1)
                {
                    Console.WriteLine("Wij leveren hier niet!");
                } else
                {
                    double prijs = prijzen[keuze];
                    totaal = prijs * gewicht;
                    Console.WriteLine($"Dat kost:{totaal} euros.");
                }
               

            }
            {
                //oefening 11 - from lesson 
                string familieNaam = InputStr("Wat is je achternaam/familienaam?: ");
                string telefoonNr = InputStr("Wat is uw telefoonNr?: ");
                string postcode = InputStr("Wat is jou postcode?: ");
                telefoonNr = telefoonNr.TrimStart('0');
                char tweedeLetter = Char.ToUpper(familieNaam[1]);
                char eersteLetter = Char.ToLower(familieNaam[0]);
                string wachtwoord = Char.ToString(Char.ToLower(familieNaam[1])) +
                                    Char.ToString(Char.ToUpper(familieNaam[0])) +
                                    Char.ToString(telefoonNr[0]) +
                                    Convert.ToString(Math.Pow(Convert.ToInt32(postcode.Substring(0, 1)), 2));
                Console.WriteLine($"Wachtwoord: {wachtwoord}");


            }

            {
                //oefening 12 - Tom's solution

                //https://github.com/TomDilen/2021_03_04_Arrays


            }





            Console.ReadLine();
        }

        static int Input()
        {
            Console.WriteLine("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
