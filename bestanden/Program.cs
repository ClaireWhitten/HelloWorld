using System;
using System.IO; //stands for input output - packet with methods/ classes etc that we can use to access files
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestanden
{
    class Program
    {
        static void Main(string[] args)
        {
            //note! need using system IO above
            // add code

            string gegevens = "Dit is een toffe les!";
            string bestandsnaam = "gegevens.txt";
​
            if (File.Exists(bestandsnaam))
            {
                //string inhoud;
                //using (StreamReader reader = new StreamReader(bestandsnaam))
                //{
                //    inhoud = reader.ReadToEnd();
                //}
​
                using (StreamReader reader = new StreamReader(bestandsnaam))
                {
                    while (!reader.EndOfStream)
                    {
​
                        Console.WriteLine(reader.ReadLine());
                    }
                }
​
                //Console.WriteLine(inhoud);
            }
            else
            {
                Console.WriteLine("Het bestand werd niet gevonden.");
​
                Console.WriteLine("We maken het bestand aan");
                using (StreamWriter writer = new StreamWriter(bestandsnaam))
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        writer.WriteLine(gegevens + "\n " + i.ToString());
                    }
                }
                Console.WriteLine("Gegevens zijn weggeschreven.");
            }
​
            Console.ReadLine();





        }
    }
}
