using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime datatype
            //hh - 12 hour clock version
            //HH - 24 hour 
            //use .addDays(-30) to go back 
            // total dagen berekenen

            DateTime mijnDateTime = DateTime.Now;
            Console.WriteLine(mijnDateTime.ToString("dd/MM/yyyy"));
            Console.WriteLine("Alle datums spelen zich af tussen " + DateTime.MinValue.ToString() + " en " + DateTime.MaxValue.ToString());
​
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("ddd, dd MMM yyy HH:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("d"));
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss tt"));
​
            DateTime dag = DateTime.Now.AddDays(-5);
            Console.WriteLine(dag.ToString("dd/MM/yyyy HH:mm:ss"));
​
            Console.WriteLine((DateTime.Now.AddDays(5) - DateTime.Now).TotalMinutes);
            Console.ReadLine();
​
            DateTime heelLangGeleden = new DateTime(400, 1, 1);
            Console.WriteLine(heelLangGeleden.AddYears(-500));

            //
        }
    }
}
