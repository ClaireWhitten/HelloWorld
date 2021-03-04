using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops


            //DO WHILE

            //if you ask for value from the user/they need to type something in e.g. a user name 
            //of a certain length(3-10) - user has to try it at least once 
            //do .....enter user name and readLine.....while the username is smaller than 3 or bigger than 10
            //They have to do it at least once first before you check
            //problem  - for an error message you need to check the error by adding a boolean 
            //which is true at the end of the do part (shows that is looped once) then at the top of the  do part do an
            //if within an if - if (loopedOnce==true) then check if(username is wrong) do ..... else ....

            //FOR LOOP

            // shortcut - for tab tab
            //declaratie---voorwaarde---iteratie


            //NESTED LOOPS

            //second teller j
            //loop within loop (both will run 8 times)  - the inner loop will run 64 times 8 x 8

            //\t 8 spaces
            Console.WriteLine("1\t2\t3"); // prints 


            //A-Z
            for (int i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine((char)i);
            }
            Console.ReadLine();
​
            //NESTED LOOPS
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    Console.WriteLine($"Teller i: {i} - Teller j: {j}");
                }
            }
            Console.ReadLine();
​
            //WHILE
            int teller = 0;
            Console.Write("Maaltafel van: ");
            int maaltafel = Convert.ToInt32(Console.ReadLine());
​
            while (teller < 10)
            {
                teller++;
                Console.WriteLine(teller * maaltafel);
            }
​
            //DO WHILE
            string username = string.Empty;
            bool loopedOnce = false;
            Console.WriteLine("Geef een username in (langer dan 3 en korter dan 10 tekens)");
            do
            {
                if (loopedOnce)
                {
                    if (username.Length < 3)
                    {
                        Console.WriteLine("Username is te kort.");
                    }
                    else
                    {
                        Console.WriteLine("Username is te lang.");
                    }
                }
                else
                {
                    loopedOnce = true;
                }
​
                Console.Write("Username: ");
                username = Console.ReadLine();
            }
            while (username.Length < 3 || username.Length > 10);
​
            //FOR LOOP
            Console.Write("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            //DECLARATIE //VOORWAARDE //ITERATIE
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * getal);
            }

           
​
            Console.ReadLine();
        }
    }
}
