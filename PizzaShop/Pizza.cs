using System;
using System.Collections.Generic;
namespace PizzaShop
{

    class Pizza
        {
            int id;
            string name;
            string ingredients;
            double price;

            public Pizza (int _id, string _name, string _ingredients, double _price) //konstruktor
            {
                id = _id;
                name = _name;
                ingredients = _ingredients;
                price = _price;
            }

            public int Id
            {
                get { return id; }
            }

            public string Name
            {
                get { return name; }
            }

            public string Ingredients
            {
            get { return ingredients; }
            }

          
            public double Price
            {
                get { return price; }
            }
        }
    
}
