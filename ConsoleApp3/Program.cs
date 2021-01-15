using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    * Studentklasse
           Maak een nieuwe klasse Student.

           Deze klasse heeft 6 autoproperties:

           Naam (string)
           Leeftijd (int)
           Klas (maak dit van een enum)
           PuntenCommunicatie (int)
           PuntenProgrammingPrinciples (int)
           PuntenWebTech (int)
           Voeg aan de klasse een methode BerekenTotaalCijfer toe. 
           Wanneer deze methode wordt aangeroepen dan wordt het gemiddelde van de 3 punten teruggegeven als double 
           zodat dit op het scherm kan getoond worden.

           Voeg aan de klasse ook de methode GeefOverzicht toe. 
           Deze methode zal een volledig "Rapport" van de student tonen (inclusief het gemiddelde m.b.v. de BerekenTotaalCijfer-methode).

           Test je programma door enkele studenten aan te maken en in te stellen. Volgende main zou dan de bijhorende output moeten krijgen:


               Student student1= new Student();
               student1.Klas = Klassen.EA2;
               student1.Leeftijd = 21;
               student1.Naam = "Joske Vermeulen";
               student1.PuntenCommunicatie = 12;
               student1.PuntenProgrammingPrinciples = 15;
               student1.PuntenWebTech = 13;

               student1.GeefOverzicht();
           Output:

           Joske Vermeulen, 21 jaar
           Klas: EA2

           Cijferrapport:
           **********
           Communicatie:             12
           Programming Principles:   15
           Web Technology:           13
           Gemiddelde:               13.3
       */


            
            Klasse_Student student1 = new Klasse_Student
                ("Diederik", 39, KiesKlas.A1, 12, 15, 13);


            student1.BerekenTotaalCijfer();
            student1.GeefOverzicht();

            

        }
    }
}
