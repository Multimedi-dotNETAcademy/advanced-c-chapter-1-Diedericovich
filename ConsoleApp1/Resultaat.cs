using System;

namespace ConsoleApp1
{
    internal class Resultaat
    {
        public double Percentage { get; set; }

        public Resultaat(double percentage)
        {
            Percentage = percentage;
        }

        public Resultaat()
        {
            Percentage = 49;
        }

        public void bepaalGraad()
        {
            if (Percentage < 50)
            {
                Console.WriteLine(" Niet geslaagd");
            }
            else if (Percentage <= 68)
            {
                Console.WriteLine(" Voldoende");
            }
            else if (Percentage <= 75)
            {
                Console.WriteLine(" Onderscheiding");
            }
            else if (Percentage <= 85)
            {
                Console.WriteLine(" Grote onderscheiding");
            }
            else if (Percentage >= 85)
            {
                Console.WriteLine(" Grootste onderscheiding");
            }
        }
    }
}