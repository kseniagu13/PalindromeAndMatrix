using System;
using System.Collections.Generic;
namespace PizzaShop
{
    class ExtrasShoppingCart
    {
        List<MyItemsExtra> extraShoppingcart;
        double total;

        public ExtrasShoppingCart()
        {
            extraShoppingcart = new List<MyItemsExtra>();
            total = 0;
        }

        public double Total //paneme getter, et keegi ei saaks muuta esialgse total ja keegi ei saaks osta 0 hinnaga
        {
            get { return total; }
        }

        public void AddToShoppingCartExtra(Extras extras, int quantity)
        {
            MyItemsExtra newItem = new MyItemsExtra(extras, quantity); //kasutaja valid tooded ja kogust, see on uus objekt
            extraShoppingcart.Add(newItem); //lisame valitud tooted ostukorvi

        }

        public void RemoveFromShoppingCart(int id)
        {
            for (int i = 0; i < extraShoppingcart.Count; i++)
            {
                if (extraShoppingcart[i].Extras.Id == id)
                {
                    Console.WriteLine($"{extraShoppingcart[i].Extras.Name} has been removed");
                    extraShoppingcart.Remove(extraShoppingcart[i]);
                }
            }
            PrintShoppingCartExtras();
        }
        public void PrintShoppingCartExtras()
        {
           /* if (extraShoppingcart.Count == 0) //vaatame kas shopping cart on tühi või mtite
            {
                Console.WriteLine("shopping Cart is empty.");
            }
            else
            {*/
                foreach (MyItemsExtra myitemsextra in extraShoppingcart)
                {
                    myitemsextra.PrintItemExtras();
                 
                }
            //}
        }

        public void PrintTotal()
        {
            foreach (MyItemsExtra myitemsextra in extraShoppingcart)
            {
                total += myitemsextra.CalculateItemTotalExtras();
            }
        }

        public void PrintShoppingCartExtrasTotal()
        {
           /* if (extraShoppingcart.Count == 0) //vaatame kas shopping cart on tühi või mtite
            {
                Console.WriteLine("shopping Cart is empty.");
            }
            else
            {*/
                foreach (MyItemsExtra myitemsextra in extraShoppingcart)
                {
                    myitemsextra.PrintItemTotalExtras();
                    
                }
            //}
        }

    }

}
