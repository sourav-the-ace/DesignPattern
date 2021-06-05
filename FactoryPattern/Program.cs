using System.Collections.Generic;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients=new List<string>();
            ingredients.Add("Cheese");
            ingredients.Add("Chilli");
            var NewYorkPizza= SimplePizzaFactory.CreatePizza(PizzaType.NewYork,ingredients);
            Console.WriteLine(NewYorkPizza.Toppings[1]+NewYorkPizza.Seasonings);
        }
    }
    
}
