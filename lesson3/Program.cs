using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {

            /* int getal1 = 5;
              int getal2 = 7;
              int temp;

              temp = getal1;
              getal1 = getal2;
              getal2 = temp;

              Console.WriteLine(getal1);
              Console.WriteLine(getal2);

              // if you put quotes marks inside a string must put a backslash before it 
              // for a path in quotes put @ before the path so that back slash is included in the path and not seen as a backslash


              //Jan zei: "Dit is echt tof"
              Console.WriteLine("Jan zei: \"Dit is echt tof\".\nJoepie!");
              Console.ReadLine();
  ​
              //C:\Program Files (x86)\Zoom
              Console.WriteLine($@"C:\Program Files (x86)\Zoom {getal1}");

              //mijnString.subString(beginindex,howmany) //extracts this part
              //mijnString.toUpper()
              //mijnString.toLower()
              //mijnString.length    //
              //mijnString.Replace('old','new') //replace all cases of it //cap letter sensitive - uses char decimal

              ///Environment.MachineName
              ///Environment.UserName
              ///etc.
              ///
             
              //Math.Floor()
              //Math.Ceiling() - rounds up
              //Math.Max(5,7) - gives the biggest number
              //Math.Max(num1,7) - gives the biggest number
              //Math.Min
              //Math.PI
              //Math.Abs // the absolute value
              //Math.Pow(9,3) 9x9x9
              //Math.Sqrt(81) //9
              //Math.Sign(number) // 1 if pos number, -1 if neg num, 0 if 0

            
           //oefening1
            Console.WriteLine(@"C:\Users\Field\Documents\Oefening");

            //oefening2
            Console.WriteLine("Ken zei \"Dit is een toffe les!\"");


            //oefening3
            int getal1 = 5;
            int getal2 = 6;
            int temp;

            temp = getal1;
            getal1 = getal2;
            getal2 = temp;

            Console.WriteLine(getal1);
            Console.WriteLine(getal2);

            //oefening4
            Console.WriteLine("Scrijf een string:");
            string myString = Console.ReadLine();
            Console.WriteLine(myString.Length);

            //oefening5
            Console.WriteLine("Scrijf een string:");
            string myString2 = Console.ReadLine();
            Console.WriteLine(myString2.ToUpper());
            Console.WriteLine(myString2.ToLower());

            //oefening6 - is there an easier way??
            Console.WriteLine("Scrijf een string:");
            string myString3 = Console.ReadLine();
            string inUpper = myString3.ToUpper().Substring(0, 1);
            string inLower = myString3.ToLower().Substring(1, myString3.Length-1);
            Console.WriteLine(inUpper + inLower);


            //oefening7 - 
            Console.WriteLine("Scrijf een zin:");
            string myString4 = Console.ReadLine();
            Console.WriteLine(myString4.Replace(" ", "_"));

            //oefening8 - 
            Console.WriteLine("Scrijf een zin:");
            string mijnZin = Console.ReadLine();
            Console.WriteLine(mijnZin[4]);

            //oefening9 - all cases of letter e?
            Console.WriteLine("Scrijf een zin:");
            string mijnZin2 = Console.ReadLine();
            Console.WriteLine(mijnZin2.IndexOf('e'));

            //oefening10 
            Console.WriteLine("Scrijf een letter in:");
            char letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(letter+1);

            //oefening11
            Console.WriteLine(Environment.MachineName);

            //oefening12
            Console.Write("Getal:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"De vierkantswortel van {Math.Pow(number, 3)} is {Math.Sqrt(Math.Pow(number, 3))}"); //fi


            //oefening13

            Console.Write("Getal 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal 2:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal 3:");
            int c = Convert.ToInt32(Console.ReadLine());

            int middleNumber = Math.Max(Math.Min(a, b), Math.Min(Math.Max(a, b), c));




            /*int smallest = (Math.Min(Math.Min(number1, number2), number3));
            Console.WriteLine(smallest);*/

            /*int[] myArray = new int[3];
            myArray.Sort(myArray);
            Console.Write(myArray[myArray.Length / 2]);



            //oefening14
            Console.Write("Number:");
            int number4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number4 * -1); //or -number4 also works
            /*if (number4 > 0)
            {
                Console.WriteLine(number4 * -1);
            }
            else
            {
                Console.WriteLine(Math.Abs(number4));
            }

            //oefening15
            Console.Write("Number:");
            int number5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(number4));

            /*THEORY - afternoon - if statements 
            == is equal to
            != not equal to
            bool rijbewijs = true;
            if(rijbewijs == true) same as if(rijbewijs), if(!rijbewijs) would be if 
            !true = false
            && - and 
            || - or

            Own examples:

            int n1 = 10;
            int n2 = 20;
            int n3 = 30;

            if (n1 < n2 && (n2 > n1 || n3 < n2))
            {
                Console.WriteLine("True");
            } else
            {
                Console.WriteLine("False");
            }

            */

             //Oefening 1

             Console.WriteLine("Getal 1:");
             int num1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Getal 2:");
             int num2 = Convert.ToInt32(Console.ReadLine());

             if (num1 > num2)
             {
                 Console.WriteLine($"Het grrotste getal is: {num1}");
             } else 
             {
                 Console.WriteLine($"Het grrotste getal is: {num2}");
             }

             //oefening 2

             Console.WriteLine("Getal 1:");
             int num3 = Convert.ToInt32(Console.ReadLine());


             if (num3 >= 5)
             {
                 Console.WriteLine("Geslaagd!");
             }
             else
             {
                 Console.WriteLine("Gebuisd!");
             }


             //oefening 3
             Console.WriteLine("Geef een getal tussen 0 en 9:");
             int num4 = Convert.ToInt32(Console.ReadLine());


             if (num4 < 0 || num4 > 9)
             {
                 Console.WriteLine("Jouw nummer is fout");
             }
             else if (num4 % 2 == 0)
             {
                 Console.WriteLine("Dat is een even getal");
             }
             else if (num4 % 2 != 0)
             {
                 Console.WriteLine("Dat is een oneven getal");
             }


             //oefening 4
             Console.WriteLine("Prijs fiets:");
             double prijs = Convert.ToInt32(Console.ReadLine());


             if (prijs >= 400)
             {
                 Console.WriteLine($"Prijs na 20% korting: {prijs * 0.8}");
             }
             else
             {
                 Console.WriteLine($"Prijs: {prijs}");
             }

             //oefening 5
             Console.WriteLine("Het brandalarm gaat af! \n Is er ieman thuis? (Y/N)");
             string answer = Console.ReadLine();
             string answer2;


             if (answer == "Y")
             {
                 Console.WriteLine("Heeft u de situatie onder controle? (Y/N)");
                 answer2 = Console.ReadLine();

                 if (answer2 == "Y")
                 {
                     Console.WriteLine("Het alarm wordt uitgeschakeld");
                 }
                 else
                 {
                     Console.WriteLine("De brandweer wordt verwittigd");
                 }
             }
             else
             {
                 Console.WriteLine("De brandweer wordt verwittigd");
             }


             //oefening 6

             int teller = 0;
             Console.WriteLine("Heb je vandaag moeten lachen? (Y/N)");
             string antwoord1 = Console.ReadLine();
             if (antwoord1 == "Y")
             {
                 teller = teller+1;
             }
             Console.WriteLine("Heb je vandaag iets productief gedaan? (Y/N)");
             string antwoord2 = Console.ReadLine();
             if (antwoord2 == "Y")
             {
                 teller = teller+1;
             }
             Console.WriteLine("Scheen de zon vandaag? (Y/N)");
             string antwoord3 = Console.ReadLine();
             if (antwoord3 == "Y")
             {
                 teller = teller+1;
             }
             Console.WriteLine("Heb je iets leker gegeten vandaag? (Y/N)");
             string antwoord4 = Console.ReadLine();
             if (antwoord4 == "Y")
             {
                 teller = teller+1;
             }
             Console.WriteLine("Kijk je uit naar morgen? (Y/N)");
             string antwoord5 = Console.ReadLine();
             if (antwoord5 == "Y")
             {
                 teller = teller+1;
             }


             if (teller >= 3)
             {
                 Console.WriteLine("Super! :)");
             }
             else
             {
                 Console.WriteLine("Jammer kan gebeuren");
             }

             Console.WriteLine(teller); 


            //Oefening 7

            Console.WriteLine("Getal 1:");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Getal 2:");
            int num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Getal 3:");
            int num7 = Convert.ToInt32(Console.ReadLine());

            int smallest = 0;
            int middle = 0;
            int biggest = 0;


            if (num5 > num6 && num5 > num7)
            {
                biggest = num5;
            } else if (num5 < num6 && num5 < num7)
            {
                smallest = num5;
            } else
            {
                middle = num5;
            }



            if (num6 > num5 && num6 > num7)
            {
                biggest = num6;
            }
            else if (num6 < num5 && num6 < num7)
            {
                smallest = num6;
            }
            else
            {
                middle = num6;
            }




            if (num7 > num6 && num7 > num5)
            {
                biggest = num7;
            }
            else if (num7 < num6 && num7 < num5)
            {
                smallest = num7;
            }
            else
            {
                middle = num7;
            }


            Console.WriteLine($"{smallest} - {middle} - {biggest}"); 


            //oefening 8 - should do with an array and for loop!
            //long way

            int totalScore = 0;
            double gemiddelde;
            int opteller = 0;



            Console.Write("Wiskunde: ");
            int vakje1 = Convert.ToInt32(Console.ReadLine());
            totalScore = totalScore + vakje1;
            if (vakje1 < 50)
            {
                opteller++;
            }

            Console.Write("Aardrijkskunde: ");
            int vakje2 = Convert.ToInt32(Console.ReadLine());
            totalScore = totalScore + vakje2;
            if (vakje1 < 50)
            {
                opteller++;
            }

            Console.Write("Economie: ");
            int vakje3 = Convert.ToInt32(Console.ReadLine());
            totalScore = totalScore + vakje3;
            if (vakje3 < 50)
            {
                opteller++;
            }

            Console.Write("Geschiedenis: ");
            int vakje4 = Convert.ToInt32(Console.ReadLine());
            totalScore = totalScore + vakje4;
            if (vakje4 < 50)
            {
                opteller++;
            }

            Console.Write("Frans: ");
            int vakje5 = Convert.ToInt32(Console.ReadLine());
            totalScore = totalScore + vakje5;
            if (vakje5 < 50)
            {
                opteller++;
            }

            Console.Write("Nederlands: ");
            int vakje6 = Convert.ToInt32(Console.ReadLine());
            totalScore = totalScore + vakje6;
            if (vakje6 < 50)
            {
                opteller++;
            }

            Console.Write("Engels: ");
            int vakje7 = Convert.ToInt32(Console.ReadLine());
            totalScore = totalScore + vakje7;
            if (vakje7 < 50)
            {
                opteller++;
            }

            Console.Write("ICT: ");
            int vakje8 = Convert.ToInt32(Console.ReadLine());
            totalScore = totalScore + vakje8;
            if (vakje8 < 50)
            {
                opteller++;
            }

            Console.WriteLine($"Je hebt {opteller} buizen"); 


            gemiddelde = (totalScore / 8);
            Console.WriteLine($"Jouw gemiddelde score is {gemiddelde}"); 


            //oefening 9

            Console.WriteLine("Geef een letter in:");
            char letterInput = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Na {letterInput} komt {Convert.ToChar(letterInput+1)}"); 


            //oefening 10
            string a1;
            string a2;
            string a3;

            Console.WriteLine("Hoe gaat het met je?\n 1.Goed   2.Niet goed");
            a1 = Console.ReadLine();
            if (a1 == "1")
            {
                Console.WriteLine("Waarom voel je zo goed?\n 1.Het is mijn verjaardag \n 2.Ik heb goed geslapen");
                a2 = Console.ReadLine();
                if (a2 == "1")
                {
                    Console.WriteLine("Happy Birthday! Hoe oud ben je? \n 1.Don't ask me my age!   \n 2. Feeling 22!");
                    a3 = Console.ReadLine();
                    if (a3 == "1")
                    {
                        Console.WriteLine("Oops, sorry!");
                    } else if (a3 == "2")
                    {
                        Console.WriteLine("Proficiat!");
                    }

                }
                else if (a2 == "2")
                {
                    Console.WriteLine("Hoeveel uren? 1. 8 uren  2. 14 uren ");
                    a3 = Console.ReadLine();
                    if (a3 == "1")
                    {
                        Console.WriteLine("Perfectly rested!");
                    }
                    else if (a3 == "2")
                    {
                        Console.WriteLine("Lazy!");
                    }
                }
              

            }
            else if (a1 == "2")
            {
                Console.WriteLine("Waarom voel je niet zo goed?\n 1.Ik heb honger \n 2.Ik voel me ziek");
                a2 = Console.ReadLine();
                if (a2 == "1")
                {
                    Console.WriteLine("Eat something! Wat wil je?  1. Chips   2. ijs");
                    a3 = Console.ReadLine();
                    if (a3 == "1")
                    {
                        Console.WriteLine("Smaakelijk!");
                    }
                    else if (a3 == "2")
                    {
                        Console.WriteLine("Goede keuze!");
                    }
                }
                else if (a2 == "2")
                {
                    Console.WriteLine("Hoofdpijn?  1. Ja    2.Nee");
                    a3 = Console.ReadLine();
                    if (a3 == "1")
                    {
                        Console.WriteLine("Veel beterschap");
                    }
                    else if (a3 == "2")
                    {
                        Console.WriteLine("Ocharme!");
                    }
                }


            } 









            Console.ReadLine();

        }
    }
}
