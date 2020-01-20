using System;
using System.Collections.Generic;

namespace PizzaShop
{
    class MyItems
    {
        Pizza pizza;
        int quantity;

        public MyItems(Pizza _pizza, int _quantity)
        {
            pizza = _pizza;
            quantity = _quantity;
        }

        public Pizza Pizza
        {
            get { return pizza; }
        }

        public void PrintItem()
        {
            Console.WriteLine($"ID: {pizza.Id} \n Name: {pizza.Name} \n Price: {pizza.Price} \n Quantity: {quantity} \n Total: {CalculateItemTotal()}");
        }


        public double CalculateItemTotal() //tagasitab summat
        {
            return pizza.Price * quantity;

        }

        public void PrintItemTotal()
        {
            Console.WriteLine($" Pizza {pizza.Name}   |{pizza.Price}  |{quantity}");
        }




    }

}
