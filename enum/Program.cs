using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {

        enum Weekdag { Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag }; // put before static void but within the class - can use it for your whole project
        //this makes a new datatype 
        //maandag stands for 0, Dinsdag 1 and so forth - so we can calulate with them e.g. Weekdag.Vrijdag + 1
        // you can set this by doing = 1 = 2

        enum Keuze {Blad = 1, Steen = 2, Schaar = 3}; //values the same as what you ask the user to put in
                                                      //so that the user doesn't make a fault
                                                      //day - could spell it wrong 
                                                      //number  - confusing  - which day is 1

        enum BodyMassIndex {Ondergewicht, Normaal_gewicht, Overgewicht, Zwaarlijvig, Ernstige_obesitas};

        enum Antwoord { A , B , C , D , E };
        static void Main(string[] args)
        {
            /*  Random rnd = new Random(); //creates a new random object
              rnd.Next(7); //gives a number between 0 and 6 (not including the number itself)

              rnd.NextDouble(); //gives number between 0 -0.99999  
              rnd.NextDouble()*10; //gives number between 0 - 10 - never gives 0?
              Console.WriteLine(rnd.NextDouble() * 100);  //gives number between 0 - 100
              Console.WriteLine(50 + rnd.NextDouble() *50); // gives number 50-100
              Console.WriteLine(25 + rnd.NextDouble() * 75); //gives number 25-100

              int input = Convert.ToInt32(Console.ReadLine()); //input is a number
              Weekdag dag = (Weekdag)input;
              //Weekdag dag = (Weekdag)(rnd.Next(7) +1);

              // dag = Weekdag.Vrijdag +2;




              switch (dag)
              {
                  case Weekdag.Maandag:
                      Console.WriteLine("Maandag is de eerste dag");
                      break;
                  case Weekdag.Dinsdag:
                      Console.WriteLine("Dinsdag");
                      break;
                  case Weekdag.Woensdag:
                      Console.WriteLine("Woensdag");
                      break;
                  case Weekdag.Donderdag:
                      Console.WriteLine("Donderdag");
                      break;
                  case Weekdag.Vrijdag:
                      Console.WriteLine("Vrijdag");
                      break;
                  case Weekdag.Zaterdag:
                      break;
                  case Weekdag.Zondag:
                      break;
                  default:
                      break;
              }*/

            //Random oefeningen
            /*
            
            Random random = new Random();
            
            {
                //oefening 1
                int getal1 = random.Next(1,6); //if you don't put the bottom number it will choose a number 0-5, not 1-5
                Console.WriteLine(getal1);

                Console.WriteLine("Kies een nummer");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == getal1)
                {
                    Console.WriteLine("Proficiaat!");
                }
                else
                {
                    Console.WriteLine("Sorry fout nummer!");
                }
            }

            {
                //oefening 2

                int getal2 = random.Next(-5, 6); //not including 6 - the first number is included, the second isn't
                Console.WriteLine(getal2);
            }

            { 
                //oefening 3

                double getal3 = random.NextDouble() * 360;
                Console.WriteLine(getal3);
                if (getal3 >=0 && getal3 <= 90)
                {
                    Console.WriteLine("Kwadrant 1");
                } else if (getal3 > 90 && getal3 <= 180) {
                    Console.WriteLine("Kwadrant 2");
                } else if (getal3 > 180 && getal3 <= 270)
                {
                    Console.WriteLine("Kwadrant 3");
                } else 
                {
                    Console.WriteLine("Kwadrant 4");
                }
            }
                
            {
                //oefening 4  - //add switch and enum version underneath
                int tellerComputer = 0;
                int tellerSpeler = 0;

                //ROUND 1
                Console.WriteLine("Je gaat spelen tegen de computer. \n De beste van 3 wint.");
                Console.WriteLine("Kies een nummer: \n 1.Blad \n 2.Steen \n 3.Schaar");
                int userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1: Console.WriteLine("Jij: Blad"); break;
                    case 2: Console.WriteLine("Jij: Steen"); break;
                    case 3: Console.WriteLine("Jij: Schaar"); break;
                    default: Console.WriteLine("Foute nummer!"); break;
                }

                int computer = random.Next(1, 4);
                switch (computer)
                {
                    case 1: Console.WriteLine("Computer: Blad"); break;
                    case 2: Console.WriteLine("Computer: Steen"); break;
                    case 3: Console.WriteLine("Computer: Schaar"); break;
                }

                if (userInput == computer)
                {
                    Console.WriteLine("Gelijk! Niemand krijgt een punt!");
                } else if (computer == 1 && userInput == 2 || computer == 2 && userInput == 3 || computer == 3 && userInput == 1)
                {
                    Console.WriteLine("De computer krijgt 1 punt!");
                    tellerComputer++;
                }
                else if (userInput == 1 && computer == 2 || userInput == 2 && computer == 3 || userInput == 3 && computer == 1)
                {
                    Console.WriteLine("Jij krijgt 1 punt!");
                    tellerSpeler++;
                }

                Console.WriteLine($"De punten zijn nu:  Jij: {tellerSpeler} punten    Computer: {tellerComputer}");


                //ROUND 2
                Console.WriteLine("Kies een nummer: \n 1.Blad \n 2.Steen \n 3.Schaar");
                int userInput2 = Convert.ToInt32(Console.ReadLine());
                switch (userInput2)
                {
                    case 1: Console.WriteLine("Jij: Blad"); break;
                    case 2: Console.WriteLine("Jij: Steen"); break;
                    case 3: Console.WriteLine("Jij: Schaar"); break;
                    default: Console.WriteLine("Foute nummer!"); break;
                }

                int computer2 = random.Next(1, 4);
                switch (computer2)
                {
                    case 1: Console.WriteLine("Computer: Blad"); break;
                    case 2: Console.WriteLine("Computer: Steen"); break;
                    case 3: Console.WriteLine("Computer: Schaar"); break;
                }

                if (userInput2 == computer2)
                {
                    Console.WriteLine("Gelijk! Niemand krijgt een punt!");
                }
                else if (computer2 == 1 && userInput2 == 2 || computer2 == 2 && userInput2 == 3 || computer2 == 3 && userInput2 == 1)
                {
                    Console.WriteLine("De computer krijgt 1 punt!");
                    tellerComputer++;
                }
                else if (userInput2 == 1 && computer2 == 2 || userInput2 == 2 && computer2 == 3 || userInput2 == 3 && computer2 == 1)
                {
                    Console.WriteLine("Jij krijgt 1 punt!");
                    tellerSpeler++;
                }

                Console.WriteLine($"De punten zijn nu:  Jij: {tellerSpeler} punten    Computer: {tellerComputer}");

                //ROUND 3
                Console.WriteLine("Kies een nummer: \n 1.Blad \n 2.Steen \n 3.Schaar");
                int userInput3 = Convert.ToInt32(Console.ReadLine());
                switch (userInput3)
                {
                    case 1: Console.WriteLine("Jij: Blad"); break;
                    case 2: Console.WriteLine("Jij: Steen"); break;
                    case 3: Console.WriteLine("Jij: Schaar"); break;
                    default: Console.WriteLine("Foute nummer!"); break;
                }

                int computer3 = random.Next(1, 4);
                switch (computer3)
                {
                    case 1: Console.WriteLine("Computer: Blad"); break;
                    case 2: Console.WriteLine("Computer: Steen"); break;
                    case 3: Console.WriteLine("Computer: Schaar"); break;
                }

                if (userInput3 == computer3)
                {
                    Console.WriteLine("Gelijk! Niemand krijgt een punt!");
                }
                else if (computer3 == 1 && userInput3 == 2 || computer3 == 2 && userInput3 == 3 || computer3 == 3 && userInput3 == 1)
                {
                    Console.WriteLine("De computer krijgt 1 punt!");
                    tellerComputer++;
                }
                else if (userInput3 == 1 && computer3 == 2 || userInput3 == 2 && computer3 == 3 || userInput3 == 3 && computer3 == 1)
                {
                    Console.WriteLine("Jij krijgt 1 punt!");
                    tellerSpeler++;
                }

                Console.WriteLine($"De punten zijn nu:  Jij: {tellerSpeler} punten    Computer: {tellerComputer}");

                if (tellerComputer > tellerSpeler)
                {
                    Console.WriteLine("De computer heeft gewonnen!");
                } else if (tellerComputer == tellerSpeler)
                {
                    Console.WriteLine("Gelijk! Niemand heeft gewonnen!");
                }
                else
                {
                    Console.WriteLine("Proficiaat! Jij hebt gewonnen!");
                }


            }
            

            { //oefening 5.1 - change to lesson answer
               //a random objects starts will a nummber - scheet????
               // if you make two random objects at the same time they have the same result /number
               // you can hard code it random 
               // 

                int dobblesteen1;
                int dobblesteen2;

                
                dobblesteen1 = random.Next(1, 7);  // or random.Next(6) + 1;
                Console.WriteLine($"Je hebt een {dobblesteen1} gegooid");

                dobblesteen2 = random.Next(1, 7);
                Console.WriteLine($"Je hebt een {dobblesteen2} gegooid");
                if (dobblesteen1 == dobblesteen2)
                {
                    Console.WriteLine("Proficiaat, je wint! De nummers zijn gelijk");
                } else
                {
                    Console.WriteLine("jammer");
                }

                dobblesteen1 = random.Next(1, 7);
                dobblesteen2 = random.Next(1, 7);
                Console.WriteLine($"Je hebt een {dobblesteen1} en {dobblesteen2} gegooid");
                if (dobblesteen1 == dobblesteen2)
                {
                    Console.WriteLine("Proficiaat, je wint! De nummers zijn gelijk");
                }
                else
                {
                    Console.WriteLine("jammer");
                }
            }*/
            
            {
                //oefening 6

                Console.WriteLine("Jouw gewicht(kg):");
                double gewicht = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Jouw lengte(m):");
                double hoogte = Convert.ToDouble(Console.ReadLine());

                double BMI = gewicht / (hoogte * hoogte);  //or Math.Pow(hoogte,2)
                Console.WriteLine($"Jouw BMI is:{BMI}");
                BodyMassIndex feedback;

                if (BMI < 18.5)
                {
                    feedback = BodyMassIndex.Ondergewicht;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{feedback}");

                } else if (BMI <= 25)
                {
                    feedback = BodyMassIndex.Normaal_gewicht;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{feedback}");
                } else if (BMI <= 30)
                {
                    feedback = BodyMassIndex.Overgewicht;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{feedback}");
                } else if (BMI <= 40)
                {
                    feedback = BodyMassIndex.Zwaarlijvig;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{feedback}");
                } else
                {
                    feedback = BodyMassIndex.Ernstige_obesitas;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{feedback}");
                }
            }
            
            {
                //oefening 7

                Console.WriteLine("Hoeveel schoenen?");
                int aantalSchoenen = Convert.ToInt32(Console.ReadLine());
                int extraSchoenen;
                int totaalPrijs = 0;

                if (aantalSchoenen <= 9)
                {
                    totaalPrijs = aantalSchoenen * 20;
                }
                else if (aantalSchoenen > 9) //no brackets needed, just else
                {
                    extraSchoenen = aantalSchoenen - 9;
                    totaalPrijs = (9 * 20) + extraSchoenen * 10;
                }

                Console.WriteLine($"Totaal Prijs = {totaalPrijs}");
            }
            
            {
                //oefening 3 - how to do this with an enum?!
                /*attempt 1
                int totalPoints = 0;

                Console.WriteLine("1. What is de hoofdstad van Belgie?");
                Console.WriteLine("A. Gent");
                Console.WriteLine("B. Antwerpen");
                Console.WriteLine("C. Brussels");
                string userAntwoord = Console.ReadLine().ToUpper();
                if (userAntwoord == Antwoord.C.ToString())
                {
                    totalPoints += 2;
                } else
                {
                    totalPoints--;
                }

                Console.WriteLine("1. What is twee plus twee?");
                Console.WriteLine("A. een");
                Console.WriteLine("B. drie");
                Console.WriteLine("C. vier");
                string userAntwoord2 = Console.ReadLine();
                if (userAntwoord2 == Antwoord.B.ToString())
                {
                    totalPoints += 2;
                } else
                {
                    totalPoints--;
                }

                Console.WriteLine($"Total Points = {totalPoints}");*/

                //attempt 2
                int totalPoints = 0;

                Console.WriteLine("1. What is de hoofdstad van Belgie?");
                Console.WriteLine("A. Gent");
                Console.WriteLine("B. Antwerpen");
                Console.WriteLine("C. Brussels");
                string userAntwoord = Console.ReadLine().ToUpper();
                if (userAntwoord == "C")
                {
                    totalPoints += 2;
                    Console.WriteLine(totalPoints);
                }
                else
                {
                    totalPoints--;
                    Console.WriteLine(totalPoints);
                }

                Console.WriteLine("1. What is twee plus twee?");
                Console.WriteLine("A. een");
                Console.WriteLine("B. drie");
                Console.WriteLine("C. vier");
                string userAntwoord2 = Console.ReadLine().ToUpper();
                if (userAntwoord2 == "C")
                {
                    totalPoints += 2;
                    Console.WriteLine(totalPoints);
                }
                else
                {
                    totalPoints--;
                    Console.WriteLine(totalPoints);
                }

                Console.WriteLine($"Total Points = {totalPoints}");

            }



            Console.ReadLine();



            

            
        }
    }
}
