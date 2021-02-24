using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());

           //in for loop and answer check
            for (int i = 1; i <= 10; i++)  //loop 10 times and each time print getal x i
            {
                Console.Write($"{getal} x {i} =");
                int answer = Convert.ToInt32(Console.ReadLine());     //checks if answer is correct
                if (answer == getal * i)
                {
                    Console.WriteLine("correct!");
                }
                else
                {
                    Console.WriteLine("wrong!");
                }
            }


          



            Console.ReadLine();
        }
    }
}
