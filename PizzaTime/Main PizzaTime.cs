using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaTime
{
    static class Program
    {
        static void Main()
        {
            /*
                * PizzaTime
            Maak een klasse Pizza. Deze klasse heeft een aantal private fields:

            toppings (string): bevat beschrijving van wat er op ligt, bv. ananas, pepperoni, etc.
            diameter (integer): doorsnede van de pizza in cm.
                price (double): prijs van de pizza in euro.
            Zorg ervoor dat je met behulp van full properties deze 3 velden kan uitlezen en aanpassen. 
            Bouw controle in zodat de fields geen foute waarden kunnen gegeven worden 
            (denk maar aan negatieve prijs en diameter, pizza zonder topping, etc.). 
            Maak in je main een aantal pizza-instanties aan en toon de werking van de properties aan.
            */

            Pizza pizza = new Pizza();

            pizza.ChooseTopping();


        }
    }
}
