using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentklasse
{
    public enum KiesKlas { A1, B1, C1, D1 }

    class Klasse_Student
    {

        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public KiesKlas Klas { get; set; }
        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        public Klasse_Student(string naam, int leeftijd, KiesKlas klas,
            int communication, int webtech, int progprinc)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            Klas = klas;
            PuntenCommunicatie = communication;
            PuntenWebTech = webtech;
            PuntenProgrammingPrinciples = progprinc;
        }


        public double BerekenTotaalCijfer()
        {
            double gemiddelde = ((PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0);
            return gemiddelde;
        }

        public void GeefOverzicht()
        {
            Console.WriteLine($"{Naam}, {Leeftijd} jaar");
            Console.WriteLine($"Klas: {Klas}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Cijferrapport:");
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.WriteLine($"Communicatie:           {PuntenCommunicatie}");
            Console.WriteLine($"Programming Principles: {PuntenProgrammingPrinciples}");
            Console.WriteLine($"Web Technology:         {PuntenWebTech}");
            Console.Write($"Gemiddelde:             ");
            Console.Write($"{BerekenTotaalCijfer()}");
        }



    }
}
