using System;
using System.Collections.Generic;

namespace PizzaShop
{
    class MyShoppingCart
    {
        List<MyItems> shoppingcart;
        double total;

        public MyShoppingCart()
        {
            shoppingcart = new List<MyItems>();
            total = 0;
        }

        public double Total //paneme getter, et keegi ei saaks muuta esialgse total ja keegi ei saaks osta 0 hinnaga
        { 
            get { return total; }
        }

        public void AddToShoppingCart(Pizza pizza, int quantity)
        {
            MyItems newItem = new MyItems(pizza, quantity); //kasutaja valid tooded ja kogust, see on uus objekt
            shoppingcart.Add(newItem); //lisame valitud tooted ostukorvi
           
        }

        public void RemoveFromShoppingCart(int id)
        {
            
            for (int i = 0; i < shoppingcart.Count; i++)
            {
                if (shoppingcart[i].Pizza.Id == id)
                {
                    Console.WriteLine($"{shoppingcart[i].Pizza.Name} has been removed");
                    shoppingcart.Remove(shoppingcart[i]);
                }
            }
            PrintShoppingCart();
        }
        public void PrintShoppingCart()
        {
            if (shoppingcart.Count == 0) //vaatame kas shopping cart on tühi või mtite
            {
                Console.WriteLine("shopping Cart is empty.");
            }
            else
            {
                foreach (MyItems myitems in shoppingcart)
                {
                    myitems.PrintItem();
                    
                }
            }
        }

        public void PrintTotal()
        {
            foreach (MyItems myitems in shoppingcart)
            {
                total += myitems.CalculateItemTotal();
            }
        }
      /* public void AddPizzaDough() //uus
        {
            foreach (MyItems myitems in shoppingcart)
            {
                total += myitems.PizzaTypeTotal();
            }
        }*/
      


        public void PrintShoppingCartTotal()
        {
            if (shoppingcart.Count == 0) //vaatame kas shopping cart on tühi või mtite
            {
                Console.WriteLine("shopping Cart is empty.");
            }
            else
            {
                foreach (MyItems myitems in shoppingcart)
                {
                    myitems.PrintItemTotal();
                    /*Console.WriteLine($"{item.Article}"); //tagastab kogu getteri sisu, mis on pandud Item all
                                                          //Console.WriteLine($"{item.CalculateItemTotal()}");*/
                }
            }
        }


    }

}
