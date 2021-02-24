using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Data types

            //string = tekst
            string naam = "A";

            //char = teken
            char eersteLetter = 'A';
​
            //int is geheel getal
            int getal = -4894;
​
            //bool is aan/uit
            bool computerAan = true;
            computerAan = false;
​
            //double = kommagetal
            double kommaGetal = 123.456;


            //datatype  //identifier    //Begin value
            string        lastName     =  "Whitten";

          
            /* Important Notes on calculating with datatypes :
             
             - dividing 2 decimal numbers works correctly 
             - But one integer divided by another doesn't - if decimal answer rounds to the bottom number - not correct
             - to solve this convert one of the integers to a double Convert.ToDouble(integerName) 
             - if the numbers are strings you have to convert both in order to divide
             - the value of a char is the value of the letter's decimal value in the ascii table 
             - if you do char+char it will result in a number (adds their decimal values from the ascii table)
             - change one to string mijnLeter.toString() to stop addition and get AA - even when adding several chars the string overrides and none are added, but concatenated

           
    
            //Order calculation are carried out in brackets ()
            //* / %
            // + -
            */


            Console.ReadLine();

        }
    }
}
