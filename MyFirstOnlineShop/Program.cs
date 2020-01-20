using System;

namespace MyFirstOnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a warehouse object
            Warehouse currentlyInStock = new Warehouse(); //objekti sees on list nimekirjaga
            //create a shopping cart object
            ShoppingCart shoppingCart = new ShoppingCart();
            //display the warehouse content
            currentlyInStock.PrinInStock(); //kutsume meetodi välja
            AddItemsToShoppingCart(currentlyInStock, shoppingCart); //kutsume funktsiooni välja. Kui kutsuks meetodi välja, siis seotud objektig, funktsioon ei ole.

            while (true)
            {
                Console.WriteLine("Add/Remove/Confirm");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "add")
                {
                    AddItemsToShoppingCart(currentlyInStock, shoppingCart);
                } else if (userInput == "remove")
                {
                    Console.WriteLine("Enter the id of product to remove from the shopping cart:");
                    int itemIdRemove = int.Parse(Console.ReadLine());
                    shoppingCart.RemoveFromShoppingCart(itemIdRemove);
                }else if (userInput =="confirm") //kui lisame confirm, siis nöitab meie ostukorvi Total
                {
                    shoppingCart.PrintTotal();
                    Console.WriteLine($"Shopping cart total: {shoppingCart.Total}");
                    break; //lähme programmist välja kui inimene confirmib

                }

            }
           

            Console.ReadLine();
        }


        public static void AddItemsToShoppingCart(Warehouse currentlyInStock, ShoppingCart shoppingCart) //see ei ole meetod, sest ei ole seotud objektiga
        {
            Console.WriteLine("Enter the id of the product to add it to the shopping cart: ");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of items to add to the shopping cart: ");
            int quantity = int.Parse(Console.ReadLine());

            Article articleToAdd = currentlyInStock.GetFromStock(productID);
            shoppingCart.AddToShoppingCart(articleToAdd, quantity);
            shoppingCart.PrintShoppingCart();

        }
    }
}
