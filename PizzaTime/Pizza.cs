using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    enum Topping {ananas, tomato, cheese, pepperoni, meat, olives, mushrooms, scampi, pesto}
    enum Diameter { S, M, L, XL, XXL}
    class Pizza
    {
        private Topping toppings { get; set; }

        public Topping Toppings 
        {
            get { return toppings; }
            set {toppings = value; } 
        }

        private Diameter diameter { get; set; }

        public Diameter Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        private double price { get; set; }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public void ChooseTopping ()
        {
            Console.WriteLine("Which toppings you want:");
            Console.WriteLine($"1. { Topping.ananas}");
            Console.WriteLine($"2. { Topping.cheese}");
            Console.WriteLine($"3. { Topping.meat}");
            Console.WriteLine($"4. { Topping.mushrooms}");
            Console.WriteLine($"5. { Topping.olives}");
            Console.WriteLine($"6. { Topping.pepperoni}");
            Console.WriteLine($"7. { Topping.pesto}");
            Console.WriteLine($"8. { Topping.scampi}");
            Console.WriteLine($"9. { Topping.tomato}");
        }

        public void ChooseSize ()
        {
            Console.WriteLine("Which size of pizza you want:");
            
            
        }



    }
}
