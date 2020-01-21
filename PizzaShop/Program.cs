using System;
using System.Collections.Generic;

namespace PizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu currentlyInStock = new Menu();//uus objekt pizza stocki jaoks
            ExtraMenu inStockExtras = new ExtraMenu(); // uus objekt extra stocki jaoks
            MyShoppingCart myShoppingCart = new MyShoppingCart();//uus objekt ostukorvi jaoks
            ExtrasShoppingCart extrasShoppingCart = new ExtrasShoppingCart();//uus objekt ostukorvi lisandite jaoks


            currentlyInStock.PrintInStockMenu();
            AddItemsToShoppingCart(currentlyInStock, myShoppingCart, inStockExtras, extrasShoppingCart);
            Console.WriteLine();

            Console.WriteLine("Do you want to add any extra? Yes/No");
            string userAnswer = Console.ReadLine().ToLower();
            if (userAnswer=="yes")
            {
                inStockExtras.PrintExtraMenu();
                Console.WriteLine("Choose your extras: ");
                AddExtrasToShoppingCart(inStockExtras, extrasShoppingCart);
                Console.WriteLine();
            }
            else if (userAnswer=="no")
            {
                Console.WriteLine();
            }
            

          /*Console.WriteLine("Choose pizza: thin or pan?");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice == "thin")
            {
                Console.WriteLine("Your price has'nt changed");
            }
            else if (userChoice == "pan")
            {
                myShoppingCart.AddPizzaDough();
            }*/

            while (true)
            {
                Console.WriteLine("Add/Remove/Confirm");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "add") //tahab lisada
                {
                    Console.WriteLine("add: pizza or extra?");
                    string userInputChoice = Console.ReadLine().ToLower();
                    if(userInputChoice=="pizza") //valib pizza
                    {
                        currentlyInStock.PrintInStockMenu();
                        AddItemsToShoppingCart(currentlyInStock, myShoppingCart, inStockExtras, extrasShoppingCart);

                    }
                    else if(userInputChoice=="extra") // valib lisandid
                    {
                        inStockExtras.PrintExtraMenu();
                        AddExtrasToShoppingCart(inStockExtras, extrasShoppingCart);
                    }
                }
                else if (userInput == "remove") // tahab midagi kustutada
                {
                    Console.WriteLine("remove: pizza or extra?");
                    string itemRemove = Console.ReadLine().ToLower();
                    if (itemRemove == "pizza")
                    {
                        Console.WriteLine("Id of Pizza to remove:");
                        int idRemove = int.Parse(Console.ReadLine());
                        myShoppingCart.RemoveFromShoppingCart(idRemove);
                    }
                    else if (itemRemove == "extra")
                    {
                        Console.WriteLine("Id of Extra to remove:");
                        int idExtraRemove = int.Parse(Console.ReadLine());
                        extrasShoppingCart.RemoveFromShoppingCart(idExtraRemove);
                    }
                }
                else if (userInput == "confirm") //kui lisame confirm, siis nöitab meie ostukorvi Total
                {
                    myShoppingCart.PrintTotal();
                    extrasShoppingCart.PrintTotal();
                    Console.WriteLine($" Item Name: Price: Quantity:");
                    myShoppingCart.PrintShoppingCartTotal();
                    extrasShoppingCart.PrintShoppingCartExtrasTotal();
                    Console.WriteLine($"Shopping cart total: {myShoppingCart.Total+extrasShoppingCart.Total}");
                    break; //lähme programmist välja kui inimene confirmib

                }

            }

            Console.ReadLine();
            


        }

        public static void AddItemsToShoppingCart(Menu currentlyInStock, MyShoppingCart shoppingcart, ExtraMenu extraMenu, ExtrasShoppingCart extrasShoppingCart) //see ei ole meetod, sest ei ole seotud objektiga
        {
            Console.WriteLine("Enter the id of the pizza to add it to the shopping cart: ");
            int productID = int.Parse(Console.ReadLine());
            if (productID == 6)
            {
                Console.WriteLine("Enter the number of items to add to the shopping cart: ");
                int quantity = int.Parse(Console.ReadLine());

                Pizza articleToAdd = currentlyInStock.GetFromStock(productID);
                shoppingcart.AddToShoppingCart(articleToAdd, quantity);

                Console.WriteLine("Add extras to your pizza:");
                extraMenu.PrintExtraMenu();
                AddExtrasToShoppingCart(extraMenu, extrasShoppingCart);


            }
            else
            {
                Console.WriteLine("Enter the number of items to add to the shopping cart: ");
                int quantity = int.Parse(Console.ReadLine());

                Pizza articleToAdd = currentlyInStock.GetFromStock(productID);
                shoppingcart.AddToShoppingCart(articleToAdd, quantity);
                shoppingcart.PrintShoppingCart();
            }

        }
        public static void AddExtrasToShoppingCart(ExtraMenu currentlyInStock, ExtrasShoppingCart shoppingcart) //see ei ole meetod, sest ei ole seotud objektiga
        {
            Console.WriteLine("Enter the id of the extra to add it to the shopping cart: ");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of items to add to the shopping cart: ");
            int quantity = int.Parse(Console.ReadLine());

            Extras extraToAdd = currentlyInStock.GetFromChoice(productID);
            shoppingcart.AddToShoppingCartExtra(extraToAdd, quantity);
            shoppingcart.PrintShoppingCartExtras();


        }
    }
}
