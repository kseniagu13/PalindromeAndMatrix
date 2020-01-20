﻿using System;
using System.Collections.Generic;
namespace MyFirstOnlineShop
{
   
    
        class ShoppingCart
        {
            List<Item> shoppingCart;
        double total;

        public ShoppingCart() //konstruktor
        {
            shoppingCart = new List<Item>();
            total = 0; //esialgu ostukorv on 0
        }
        public double Total //paneme getter, et keegi ei saaks muuta esialgse total ja keegi ei saaks osta 0 hinnaga, häkkerid
        {
            get { return total; }
        }

        public void AddToShoppingCart (Article article, int quantity)
        {
            Item newItem = new Item(article, quantity); //kasutaja valid tooded ja kogust, see on uus objekt
            shoppingCart.Add(newItem); //lisame valitud tooted ostukorvi
        }

        public void RemoveFromShoppingCart(int id)
        {
            for (int i =0; i<shoppingCart.Count; i++)
            {
                if (shoppingCart[i].Article.Id==id)
                {
                    Console.WriteLine($"{shoppingCart[i].Article.Name} has been removed");
                    shoppingCart.Remove(shoppingCart[i]);
                }
            }
            PrintShoppingCart();
        }

        public void PrintShoppingCart()
        {
            if (shoppingCart.Count == 0) //vaatame kas shopping cart on tühi või mtite
            {
                Console.WriteLine("shopping Cart is empty.");
            }
            else
            {
                foreach (Item item in shoppingCart)
                {
                    item.PrintItem();
                    /*Console.WriteLine($"{item.Article}"); //tagastab kogu getteri sisu, mis on pandud Item all
                                                          //Console.WriteLine($"{item.CalculateItemTotal()}");*/
                }
            }
        }

        //calculate shopping cart total

        public void PrintTotal() 
        {
            foreach(Item item in shoppingCart)
            {
                total += item.CalculateItemTotal();
            }
        }

        }
    
}
