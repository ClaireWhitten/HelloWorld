using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodes
{
    class Program
    {
        static void Main(string[] args)
        {
            //methodes  - tidier code, safer code

            //static void main is a method which says start the program here 

            //always capital letters for names of methods

            //can change the order of the parameters when calling them if you name them eg. getal1: 4

            //can set a default value for a parameter when writing the method(only if the last parameter or both)
            //then if nothing is filled in for the 2nd parameter it takes that value use =


            //void is our return type - void - the defines the data type that is returned - if the function doesn't return 
            //anything then it should be type void e.g. if it console.writes something


            //method 1 called - writes the string
            HelloWorld();
            Console.WriteLine(HelloWorld()); // calls the helloworld method below and returns a string 


            //method 2 called - reads user input and converts to int
            int input = InputInt();


            //method 3
            Console.WriteLine(Kwadraat(input));


            //method 4 - computer can distinguish which method to call between 3 and 4 depending on whether you give a double or int 
            double input2 = 5.25;
            Console.WriteLine(Kwadraat(input2));



            //method 5
            Console.WriteLine(Macht(getal2: 3, getal: 5));
​
            Console.WriteLine(Macht());
            Console.WriteLine(Macht(5)); //default parameter used here
            Console.WriteLine(Macht(5, 3)); 
​
            Console.WriteLine();
​
            
           
​
            Console.ReadLine();
        }
​
        
​
        ​
       
        //method 1
        static string HelloWorld() // can call this method in your main
        {
            //Console.WriteLine("Hello World");
            return "hello world";
        }


        //method 2
        static int InputInt()
        {
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        //method 3
        static int Kwadraat(int getal)
        {
            return getal * getal;
        }

        //method 4
        static double Kwadraat(double getal)
        {
            return getal * getal;
        }

        //method 5
        static int Macht(int getal = 2, int getal2 = 2)
        {
            int maal = getal;
            for (int i = 1; i < getal2; i++)
            {
                getal *= maal;
            }
            return getal;
        }
    }
}
