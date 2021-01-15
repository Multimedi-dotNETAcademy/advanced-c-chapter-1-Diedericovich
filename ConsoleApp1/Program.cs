using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Resultaat mijnpunten = new Resultaat(60);
         Console.WriteLine(mijnpunten.Percentage);

            mijnpunten.bepaalGraad();
        }
    }
}