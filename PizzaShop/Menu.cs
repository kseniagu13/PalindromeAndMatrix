using System;
using System.Collections.Generic;

namespace PizzaShop
{
    class Menu
    {
        List<Pizza> InStock;

        public Menu() //konstruktor
        {
            InStock = new List<Pizza>();
            Pizza hawaij = new Pizza(1, "hawaij", "cheese, tomato, onion, chicken", 7.6);
            InStock.Add(hawaij);
            Pizza americana = new Pizza(2, "americana", "cheese, salami, tomato, olives", 7.4);
            InStock.Add(americana);
            Pizza bolognese = new Pizza(3, "bolognese", "cheese, tomato, meat, jalapeno", 7.4);
            InStock.Add(bolognese);
            Pizza mafioso = new Pizza(4, "mafioso", "bacon, cheese, tomato, mushrooms", 7.6);
            InStock.Add(mafioso);
            Pizza romana = new Pizza(5, "romana", "tomato, cheese, bacon, pineapple", 7.6);
            InStock.Add(romana);
            Pizza fantasyPizza = new Pizza (6,"fantasy Pizza", " ", 3);
            InStock.Add(fantasyPizza);

        }

        public void PrintInStockMenu()
        {
            foreach (Pizza pizza in InStock)
            {
                Console.WriteLine($"ID: {pizza.Id}");
                Console.WriteLine($"Product name: {pizza.Name}");
                Console.WriteLine($"Ingredients: {pizza.Ingredients}");
                Console.WriteLine($"Price: {pizza.Price}");
                Console.WriteLine();
            }
        }

        public Pizza GetFromStock (int id)
        {
            return InStock[id - 1];  //kuna arvuti jaoks 1 on 0 , 1 on 2 jne.
        }

        


    }

}
