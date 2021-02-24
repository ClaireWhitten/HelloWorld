using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening 6.1

           Console.WriteLine("Welkom in Kenland! Het tofste pretpark van de Benelux!");
            Console.Write("Aantal volwassenen: ");
            int volwassenen = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aantal tieners: ");
            int tieners = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aantal kinderen: ");
            int kinderen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prijs per volwassene: 35 euro ");
            Console.WriteLine("Prijs per volwassene: 25 euro");
            Console.WriteLine("Prijs per volwassene: 20 euro");

            int totaal = volwassenen * 35 + tieners * 25 + kinderen * 20;

            Console.WriteLine($"Total: {totaal}");





            //Oefening 6.1 BONUS - 10% discount (completed for volwassenen tickets only)

           
            //1. declare variables  - things that will change
            double totalPrice = 0;
            double ticketPrice = 35;
            int aantalTickets;


            //2. read number of tickets user puts in
            Console.Write("Aantal volwassenen: ");  
            aantalTickets = Convert.ToInt32(Console.ReadLine());

            /*
            //3. Method 1
            //Loop number of times of tickets (ticket1, ticket2, ticket3) and each time calculate price of the ticket and add it to the total
                /*for (int i = 1; i <= aantalTickets; i++) //
                {
                if (i == 1)  // will run for the first ticket (no discount added here)
                {
                    totalPrice = ticketPrice;
                    Console.WriteLine(ticketPrice);//so can visually see first ticket price/base price
                }
                else
                    {

                    ticketPrice = Math.Round(ticketPrice * 0.9, 2);  //calculates 10% of previous ticketprice and assigns as the new ticketprice
                    totalPrice = totalPrice + ticketPrice; //adds the new ticketprice to the total ticket price
                    Console.WriteLine($" + {ticketPrice}"); //so can visually see addition calculation
                    }
                }
           

            Console.WriteLine($"Total Price: {totalPrice}");  //logs total */


            //3. Method 2 
            //Create an empty array and assign each new ticket price to the array. Add the sum of all prices in the array at end.

            double[] myArray = new double[aantalTickets]; //creates new array, must define length and type in c#

            for (int i = 0; i < aantalTickets; i++)  //when looping start i at 0 so can assign to index 0 in array
            {
                if (i == 0)     //This is same as method 1
                {
                    myArray[i] = ticketPrice;
                    Console.WriteLine(ticketPrice); //so can visually see first ticket price/base price
                } 
                else 
                {
                    ticketPrice = Math.Round(ticketPrice * 0.9, 2);
                    myArray[i] = ticketPrice;
                    Console.WriteLine($" + {ticketPrice}"); //so can visually see addition calculation
                }
            }
   

            for (int i = 0; i < myArray.Length; i++)   // loop over each element in array and add to total price variable 
            {                                           // could use an equivelant to JS reduce method here instead?
                totalPrice += myArray[i];
            }

            Console.WriteLine($"Total price:{totalPrice}");





            //Oefening 6.2
            if (totaal > 200)
            {
                Console.WriteLine($"Total na korting: {totaal * 0.9}");
            }
            else
            {
                Console.WriteLine($"Total na korting: {totaal}");
            }




            Console.ReadLine();

        }
    }
}
