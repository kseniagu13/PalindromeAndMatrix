using System;

namespace PizzaShop
{
    class Dough
    {
        string name= "pan";
        double price = 1;


        public Dough(string _name, double _price)
        {
            name = _name;
            price = _price;
        }

        public string Name
        {
            get { return name; }
        }

        public double Price
        {
            get { return price; }
        }
    }
}
