using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scopes
{
    class Program
    {
        static void Main(string[] args)
        {
            //for the purpose of blocking code you can make your own scopes by using curly brackets around exercises

            //oefening 1
            Console.WriteLine("Op een schaal van 1-3, wat is je niveau?");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": Console.WriteLine("Je bent een Junior"); break;
                case "2": Console.WriteLine("Je bent een Medior"); break;
                case "3": Console.WriteLine("Je bent een Senior"); break;
                default: Console.WriteLine("Je hebt een foute nummer ingetypt"); break;
            }



            //oefening 2
            Console.WriteLine("Geef een getal van 1 tot en met 12");
            string nummer = Console.ReadLine();

            switch (nummer)
            {
                case "1": Console.WriteLine("Januari"); break;
                case "2": Console.WriteLine("Februari"); break;
                case "3": Console.WriteLine("Maart"); break;
                case "4": Console.WriteLine("April"); break;
                case "5": Console.WriteLine("Mei"); break;
                case "6": Console.WriteLine("Juni"); break;
                case "7": Console.WriteLine("Juli"); break;
                case "8": Console.WriteLine("Augustus"); break;
                case "9": Console.WriteLine("September"); break;
                case "10": Console.WriteLine("October"); break;
                case "11": Console.WriteLine("November"); break;
                case "12": Console.WriteLine("December"); break;
                default: Console.WriteLine("Je hebt een foute nummer ingetypt"); break;
            }


            //oefening 3
            Console.WriteLine("Geef een maand in:");
            string maand = Console.ReadLine().ToLower();

            switch (maand)
            {
                case "januari": Console.WriteLine("1"); break;
                case "februari": Console.WriteLine("2"); break;
                case "maart": Console.WriteLine("3"); break;
                case "april": Console.WriteLine("4"); break;
                case "mei": Console.WriteLine("5"); break;
                case "juni": Console.WriteLine("6"); break;
                case "juli": Console.WriteLine("7"); break;
                case "augustus": Console.WriteLine("8"); break;
                case "september": Console.WriteLine("9"); break;
                case "oktober": Console.WriteLine("10"); break;
                case "november": Console.WriteLine("11"); break;
                case "december": Console.WriteLine("12"); break;
                default: Console.WriteLine("Je hebt een foute maand ingetypt"); break;
            }

            //oefening 4
            Console.WriteLine("Geef een jaar in");
            string jaar = Console.ReadLine();

            switch (jaar)
            {
                case "1302": Console.WriteLine($"In 1302 starttethe battle of the golden spurs"); break;
                case "1492": Console.WriteLine("In 1492 is fall of Granada, the expulsion of the Jews, and Columbus's expedition gebeurd"); break;
                case "1830": Console.WriteLine("In 1830 startte de Belgian revolution"); break;
                case "1914": Console.WriteLine("In 1914 startte de eerste wereldoorloog"); break;
                case "1918": Console.WriteLine("In 1918 eindde de eerste wereldoorloog"); break;
                case "1939": Console.WriteLine("In 1939 startte de tweede wereldoorloog"); break;
                case "1945": Console.WriteLine("In 1945 eindde de tweede wereldoorloog"); break;
                default: Console.WriteLine($"In {jaar} is er niets interessant gebeurd"); break;

            }

            //oefening 5
            Console.WriteLine("Geef een letter in");
            char letter = Convert.ToChar(Console.ReadLine().ToLower());
            switch (letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u': Console.WriteLine("Dat is een klinker"); break;
                default: 
                if (letter >= 97 && letter <= 122)
                    {
                        Console.WriteLine("Dat is een medeklinker");
                    } else
                    {
                        Console.WriteLine("Dat is geen letter");
                    }
                    break;
            }


            
            //oefening 6


            //with switch case
            //How to work out a leap year?
            /*If the year is evenly divisible by 4, go to step 2. Otherwise, go to step 5.
                If the year is evenly divisible by 100, go to step 3.Otherwise, go to step 4.
                If the year is evenly divisible by 400, go to step 4.Otherwise, go to step 5.
                The year is a leap year(it has 366 days).
                The year is not a leap year(it has 365 days).*/

            Console.WriteLine("Geef een jaar in");
            double year = Convert.ToDouble(Console.ReadLine());
            

            //if statement 
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("schrikkeljaar");
                    }
                    else Console.WriteLine("geen schrikkeljaar");

                }
                else Console.WriteLine("schrikkeljaar");
            }
            else Console.WriteLine("geen schrikkeljaar");


            //switch statement with boolean
            bool remainder = ((year % 4 == 0) && ((year % 400 == 0) || (year % 100 != 0)));

            switch (remainder)
                {
                    case true : Console.WriteLine("Schrikkeljaar"); break;
                    case false : Console.WriteLine("geen schrikkeljaar"); break;
            }



            //oefening 7
            Console.WriteLine("Hallo! Ik ben een chatbot! Wat kan ik vandaag voor je doen? \n 1. Ik heb hulp nodig bij mijn programmeerlessen! \n 2. Ik verveel me. \n 3. Niets, toch bedankt");
            

            switch (Console.ReadLine())
            {
                case "1": Console.WriteLine("Oei. Heb je al geprobeerd om het op te zoeken op het internet? \n 1. Ja, tevergeefs. \n 2. Oh, slim! Ik zal het even proberen" ); break; // these breaks are causing the problem? How to solve
                    switch (Console.ReadLine())
                    {
                        case "1": Console.WriteLine("Anders moet je het eens aan je medecursisten vragen? \n 1. Die weten het antwoord ook niet..  \n 2. Ah ja, misschien weten zij het!"); break;
                            switch (Console.ReadLine())
                            {
                                case "1": Console.WriteLine("Probeer het zeker aan je leerkracht te vragen! Die zal zijn best doen om het je uit te leggen");break;
                                case "2": Console.WriteLine("Graag gedaan"); break;
                                    
                            }
                        case "2": Console.WriteLine("Graag gedaan!");break;
                    }


                case "2": Console.WriteLine("Oei, wil je iets doen? \n 1.Vertel me eens een mopje! \n 2.Ik zou graag de oefening afwerken. \n 3.Niet per see, tot later"); break; // these breaks are causing the problem - stops here
                    switch (Console.ReadLine())
                    {
                        case "1": Console.WriteLine("Hmm, ik ken er niet meteen eentje, sorry!"); break;
                        case "2": Console.WriteLine("Ok, dan laat ik je zeker doorwerken"); break;
                        case "3": Console.WriteLine("Dag!");break;



                    }
                case "3": Console.WriteLine("Graag Gedaan!"); break;

            }
        



            Console.ReadLine();




        }
    }
}
