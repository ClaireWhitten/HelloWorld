using System; 
//using a packet - so you can write less code  
//- Console.readLine, writeLine belongs to this packet (System.Console.WriteLine)


namespace HelloWorld 
    //don't change this - name of project 
    //if you change the name doesn't change elsewhere
{
    class Program //class needed for static voidpackets with code in the 
    {
        static void Main(string[] args) //static void to call a method

        /*If you type Console. the console properties and methods come up in a list
        To github - add to source control*/

        { /*The code block
            Console.WriteLine("Hello World"); //class green, method yellow
            Console.WriteLine("Wie ben je?");

            string naam; //declare variable(string) - plaats in het geheugen
            naam = Console.ReadLine(); //naam is equal to your input

            Console.WriteLine("Hallo " + naam + ".");
            Console.WriteLine("Hoe gaat het met jouw?");
            string mood;
            mood = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Mat mij gaat het ook" + mood + ".");
            Console.WriteLine("Met mij gaat het ook {0}, {1}", mood, naam); //the position matches with the variable after the comma
            Console.WriteLine($"Met mij gaat het ook {mood}, {naam}."); //best method


            Console.Write("Met mij gaat"); // seperate lines (handy for colon:)
            Console.Write("het ook");
            Console.WriteLine("goed!");


            string begin = "Met mij gaat het ook ";
            string end = ".";
            Console.WriteLine(begin + mood + end);


            string helezin = $"Met mij gaat het ook {mood}.";*/




            string food;
            
         

            Console.WriteLine("What would you like to order?");
            food = Console.ReadLine();
            Console.Write("Sure ");
            Console.Write(food);
            Console.Write(" coming up! ");



            Console.WriteLine("Sure " + food + " coming up!");

            Console.WriteLine("What would you like to drink?");
            string drink;
            drink = Console.ReadLine();
            Console.WriteLine($"Ok, so that's {food} and {drink}. No problem. Your order is on its way");

          
            Console.WriteLine("Ok, so that's {0} and {1}. No problem. Your order is on its way", food, drink);

            Console.WriteLine("Ok, so that's {0} and {1}. No problem. Your order is on its way", food, drink);


            string begin = "Ok, so that's ";
            string middle = " and ";
            string end = ". Your order is on its way";
            Console.WriteLine(begin + food + middle + drink + end);





        }
    }
}
