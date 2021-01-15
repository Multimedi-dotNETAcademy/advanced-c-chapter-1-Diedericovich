using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nummers
{
    class Numbers
    {

        public int Getal1 { get; set; }
        public int Getal2 { get; set; }


        public Numbers(int getal1, int getal2)
        {
            Getal1 = getal1;
            Getal2 = getal2;
        }


        public void Som()
        {
            int result = Getal1 + Getal2;
            Console.WriteLine($"Som van {Getal1} en {Getal2} = {result}");
        }

        public void Verschil()
        {
            int result = Getal1 - Getal2;
            Console.WriteLine($"Verschil van {Getal1} en {Getal2} = {result}");
        }
        public void Product()
        {
            int result = Getal1 * Getal2;
            Console.WriteLine($"Product van {Getal1} en {Getal2} = {result}");
        }
        public void Quotient()
        {
            while (Getal2 == 0)
            {
                Console.WriteLine("ERROR - Het tweede getal mag niet 0 zijn!");
                Getal2 = Convert.ToInt32(Console.ReadLine());
            }

            double doubleGetal1 = Convert.ToDouble(Getal1);
            double doubleGetal2 = Convert.ToDouble(Getal2);

            double result = doubleGetal1 / doubleGetal2;
            Console.WriteLine($"Quotient van {Getal1} en {Getal2} = {result}");
        }
    }
}
