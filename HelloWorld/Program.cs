
using System; //using a packet - Console.readLine/ writeLine belongs to this packet (System.Console.WriteLine)


namespace HelloWorld //don't change this 
{
    class Program //class needed for static void packets 
    {
        static void Main(string[] args) // The class Program has a method called main + main is the entry point of the app - pc knows where to start

        //The code block goes within these brackets

        {

          

            // DEMONSTRATION CODE DURING LESSON

           //Vraag naar persoon zijn naam
            Console.WriteLine("Hello world!");     //class is green(console), method  is yellow(WriteLine)
            Console.WriteLine("Wie ben jij?");
           
            //Persoon vult naam in
            Console.Write("Naam: ");
            string naam; //must specify type 
            naam = Console.ReadLine();  //read the input and assign it to the variable name
            
            //Computer zegt hallo
            Console.WriteLine("Hallo " + naam + ".");
            
            //Vraag hoe het gaat
            Console.WriteLine("Hoe gaat het me jou?");
          
            //Persoon zegt hoe het gaat
            string mood;
            mood = Console.ReadLine();
            
            //Antwoord 1
            Console.WriteLine("Met mij gaat het ook " + mood + ".");
         
            //Antwoord 2
            Console.Write("Met mij gaat het ook "); //write() means next piece of text will be beside it  - handy for colon e.g. naam: usertypeshere
            Console.Write(mood);
            Console.WriteLine(".");    //WriteLine() means next piece of text will be below it

            //Antwoord 3
            Console.WriteLine("Met mij gaat het ook {0}, {1}.", mood, naam);  //the position matches with the variable after the comma
            
            //Antwoord 4
            Console.WriteLine($"Met mij gaat het ook {mood}, {naam}.");   //best method - like string template literal in JS
          
            //Antwoord 5
            string beginZin = "Met mij gaat het ook ";
            string eindZin = ".";
            Console.WriteLine(beginZin + mood + eindZin);

            //Console.ReadLine(); // This ReadLine ensures the console stays open and doesn't close, because pc waiting for users input. If you don't add it console closes very quickly after calling the writeline methods. This allows us to see the writeLine output.







            //TASK 1

            string food;

            Console.WriteLine("What would you like to order?");
            food = Console.ReadLine(); //read the input and assign it to variable name

            // Method 1
            Console.Write("Sure "); //write means next piece of text will be beside it 
            Console.Write(food);
            Console.WriteLine(" coming up! "); // writeLine means next piece of text will be below it


            //Method 2
            Console.WriteLine("Sure " + food + " coming up!");



            Console.WriteLine("What would you like to drink?");
            string drink;
            drink = Console.ReadLine();


            //method 3
            Console.WriteLine($"Ok, so that's {food} and {drink}. No problem. Your order is on its way");

            //method 4
            Console.WriteLine("Ok, so that's {0} and {1}. No problem. Your order is on its way", food, drink);


            //Method 5
            string begin = "Ok, so that's ";
            string middle = " and ";
            string end = ". Your order is on its way";
            Console.WriteLine(begin + food + middle + drink + end);

            //Console.ReadLine();  // This ReadLine ensures the console stays open and doesn't close.





            //TASK 2

            string eersteNaam, tweedeNaam, straat, huisNummer, woonPlaats, postCode; //can decalre variables all at once 

            Console.Write("Voornaam:");
            eersteNaam = Console.ReadLine();

            Console.Write("Naam:");
            tweedeNaam = Console.ReadLine();

            Console.Write("Straat:");
            straat = Console.ReadLine();

            Console.Write("Huisnummer:");
            huisNummer = Console.ReadLine();

            Console.Write("Woonplaats:");
            woonPlaats = Console.ReadLine();

            Console.Write("Postcode:");
            postCode = Console.ReadLine();


            Console.WriteLine($"Naam: {eersteNaam} {tweedeNaam}");
            Console.WriteLine("Adress: {0}, {1} {2}", straat, postCode, woonPlaats);


            Console.ReadLine();  // This ReadLine ensures the console stays open and doesn't close.















        }
    }
}
