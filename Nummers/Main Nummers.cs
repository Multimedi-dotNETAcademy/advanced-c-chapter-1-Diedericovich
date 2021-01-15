using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nummers
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            /*
                     * Nummers
            Maak een klasse Nummers. Deze klasse bevat 2 getallen (type int) die via een autoproperty kunnen aangepast worden. 
            Er zijn 4 methoden:

            Som: geeft de som van beide getallen terug
            Verschil: geeft het verschil van beide getallen terug
            Product: geeft het product van beide getallen terug
            Quotient: geeft de deling van beide getallen terug. Toon "Error" indien je zou moeten delen door 0.
            Toon in je main aan dat je code werkt.

            Volgende code zou bijvoorbeeld onderstaande output moeten geven:

                Nummers paar1 = new Nummers();
                paar1.Getal1 = 12;
                paar1.Getal2 = 34;

                Console.WriteLine("Paar:" + paar1.Getal1 + ", " + paar1.Getal2);
                Console.WriteLine("Som = " + paar1.Som());
                Console.WriteLine("Verschil = " + paar1.Verschil());
                Console.WriteLine("Product = " + paar1.Product());
                Console.WriteLine("Quotient = " + paar1.Quotient());
            Output:

            Paar: 12, 34
            Som = 46
            Verschil = -22
            Product = 408
            Quotient = 0,352941176470588
        */


            {
                Numbers paar1 = new Numbers(12, 34);
                paar1.Som();
                paar1.Verschil();
                paar1.Product();


            }

        }




    }
}
