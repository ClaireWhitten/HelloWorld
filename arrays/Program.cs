using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string methodes 
            //reverse???   Array. - if you type this it brings a list
            //Array.Sort(array); -  some arrays have other syntax
            //Array.Clear
            //index ophalen
            //string is an array!
            //can change string to a char array
            // 2D arrays  int [,]    3d arrays {,,}


            int[] personenPerKlas;
            bool[] aanwezigheden;
            double[] gewichtHuisdieren;

            //add array notes here 

            {
                //Manier 1
                string[] kleuren;
                kleuren = new string[] { "Rood", "Oranje", "Geel", "Groen" };
            }
​
            {
                //Manier 2
                string[] kleuren = { "Rood", "Oranje", "Geel", "Groen" };
            }
​
            {
                //Manier 3
                string[] kleuren;
                kleuren = new string[4];
            }
​
            {
                //Lezen
                Console.WriteLine("Lezen:");
                string[] kleuren = { "Rood", "Oranje", "Geel", "Groen" };
                Console.WriteLine(kleuren[0]);
                Console.WriteLine(kleuren[1]);
                Console.WriteLine(kleuren[2]);
                Console.WriteLine(kleuren[3]);
                Console.WriteLine();
            }
​
            {
                //Schrijven
                Console.WriteLine("Schrijven:");
                string[] kleuren;
                kleuren = new string[4];
                kleuren[0] = "Rood";
                kleuren[1] = "Oranje";
                kleuren[2] = "Geel";
                kleuren[3] = "Groen";
​
                for (int i = 0; i < kleuren.Length; i++)
                {
                    Console.WriteLine(kleuren[i]);
                }
                Console.WriteLine();
            }
​
            {
                //Optellen
                Console.WriteLine("Optellen met 5:");
                int[] getallen = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
​
                for (int i = 0; i < getallen.Length; i++)
                {
                    getallen[i] += 5;
                    Console.WriteLine(getallen[i]);
                }
                Console.WriteLine();
            }
​
            {
                //References (slecht)
                int[] getallen1 = { 1, 2, 3 };
                int[] getallen2 = getallen1;
​
                for (int i = 0; i < getallen2.Length; i++)
                {
                    getallen2[i] += 3;
                }
​
                for (int i = 0; i < getallen1.Length; i++)
                {
                    Console.WriteLine(getallen1[i]);
                }
​
                for (int i = 0; i < getallen2.Length; i++)
                {
                    Console.WriteLine(getallen2[i]);
                }
            }
​
            {
                //References (Goed)
                Console.WriteLine("---");
                int[] getallen1 = { 1, 2, 3 };
                int[] getallen2 = new int[getallen1.Length];
​
                for (int i = 0; i < getallen2.Length; i++)
                {
                    getallen2[i] = getallen1[i] + 3;
                }
​
                for (int i = 0; i < getallen1.Length; i++)
                {
                    Console.WriteLine(getallen1[i]);
                }
​
                for (int i = 0; i < getallen2.Length; i++)
                {
                    Console.WriteLine(getallen2[i]);
                }
            }
​
            {
                //References
                int getal1 = 5;
                int getal2 = getal1;
                getal2 = 3;
                Console.WriteLine(getal1 + " " + getal2);
            }
​
            {
                //Array methodes
                Console.WriteLine("---");
                int[] getallen = { 2, 3, 5, 7, 11 };
                Console.WriteLine(getallen.Max());
                Console.WriteLine(getallen.Min());
                Console.WriteLine(getallen.Sum());
                Console.WriteLine(getallen.Average());
​
                string[] myColors = { "Rood", "Geel", "groen", "Oranje", "blauw" };
​
                Array.Sort(myColors);
​
                for (int i = 0; i < myColors.Length; i++)
                {
                    Console.WriteLine(myColors[i]);
                }
​
                Array.Clear(myColors, 0, myColors.Length);
            }
​
            {
                //Index ophalen
                string[] myColors = { "Rood", "Geel", "Groen", "Oranje", "Blauw" };
                Console.WriteLine(Array.BinarySearch(myColors, "Groen"));
            }
​
            
               {
                    string origineleZin = "Ik ben Tom";
                    //Naar characters
                    char[] karakters = origineleZin.ToCharArray();
                    karakters[8] = 'i';
                    //Naar string
                    string nieuweZin = new string(karakters);
                    Console.WriteLine(nieuweZin);
               }
​
                {
                    char[] arrayVanLetters = { 'h', 'a', 'l', 'l', 'o' };
                    arrayVanLetters[1] = 'e';
                    string nieuweZin = new string(arrayVanLetters);
                    Console.WriteLine(nieuweZin);
                }
​
                {
                    //String als array
                    Console.WriteLine("Hallo"[4]);
                }
​
                {
                    string zin1 = "Ik ben een array van characters";
                    string zin2 = zin1;
​
                    zin2 = "'t steekt hier tegen";
​
                    Console.WriteLine(zin1);
                    Console.WriteLine(zin2);
                }
​
                {
                    //2D ARRAY
                    int[,] schuifpuzzel;
                    schuifpuzzel = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };
​
                    Console.WriteLine(schuifpuzzel[1, 1]);
                    Console.WriteLine(schuifpuzzel[1, 0]);
​
                }
            
​
            Console.ReadLine();
        }
    }
}
