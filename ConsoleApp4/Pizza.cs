using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    enum Topping { ananas, tomato, cheese, pepperoni, meat, olives, mushrooms, scampi, pesto }
    enum Diameter { S, M, L, XL, XXL }

    enum ChoiceOfPizza {margherita, calzone, quattrofromaggi, hawai, bbq, capprizona, fruitdemare}
    class Pizza
    {

        private Topping toppings { get; set; }

        public Topping Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        private Diameter diameter { get; set; }

        public Diameter Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        private ChoiceOfPizza choiceOfPizza { get; set; }

        public ChoiceOfPizza ChoiceOfPizza
        {
            get { return choiceOfPizza; }
            set { choiceOfPizza = value; }
        }

        private double price { get; set; }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public void GiveIntroPizzaOrder()
        {
            Console.WriteLine("Welcome to our online Pizza Program");
            Console.WriteLine();
            Console.WriteLine("Create the pizza of your own choice");
            Console.ReadKey();
            Console.Clear();
        }


        public void ChoosePizza()
        {
            Console.WriteLine("Which pizza do you want:");
            Console.WriteLine($"1. { ChoiceOfPizza.bbq}");
            Console.WriteLine($"2. { ChoiceOfPizza.calzone}");
            Console.WriteLine($"3. { ChoiceOfPizza.capprizona}");
            Console.WriteLine($"4. { ChoiceOfPizza.fruitdemare}");
            Console.WriteLine($"5. { ChoiceOfPizza.hawai}");
            Console.WriteLine($"6. { ChoiceOfPizza.margherita}");
            Console.WriteLine($"7. { ChoiceOfPizza.quattrofromaggi}");
            int DecisionPizza = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"Pizza {DecisionPizza} is an excellent choice!");
            Console.ReadKey();
            Console.Clear();
        }

        public void ChooseTopping()
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
            Console.WriteLine($"10. Enough/no toppings");
            int DecisionTopping = Convert.ToInt32(Console.ReadLine());

            while (DecisionTopping != 10)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"You wish {DecisionTopping} on top of your pizza");
                Console.WriteLine();
                Console.WriteLine("Prefer another topping? (y/n)");
                Console.ReadKey();
                char DecisionAnotherTopping = Convert.ToChar(Console.ReadLine());

                while (DecisionAnotherTopping != 'y' && DecisionAnotherTopping != 'n')
                {
                    Console.WriteLine("Choose one of 2 options: Yes(y) or No(n)");
                    DecisionAnotherTopping = Convert.ToChar(Console.ReadLine());
                }


                if (DecisionAnotherTopping == 'y')
                {
                    

                    
                }
                if (DecisionAnotherTopping == 'n')
                {
                    Console.Clear();
                    ChooseSize();
                }

            }
        }
        public void ChooseSize()
        {
            Console.WriteLine("Which size of pizza you want:");
            Console.WriteLine($"1. { Diameter.S}");
            Console.WriteLine($"2. { Diameter.M}");
            Console.WriteLine($"3. { Diameter.L}");
            Console.WriteLine($"4. { Diameter.XL}");
            Console.WriteLine($"5. { Diameter.XXL}");
            int DecisionSize = Convert.ToInt32(Console.ReadLine());

            if (DecisionSize == 1)
            {
                
            }


        }

        public void CalculatePrize()
        {

        }

        

                                                                                                                            
        

       

    }
}
