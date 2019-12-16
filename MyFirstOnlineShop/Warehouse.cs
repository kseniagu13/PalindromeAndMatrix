using System;
using System.Collections.Generic;

namespace MyFirstOnlineShop
{


    class Warehouse
    {
        List<Article> InStock;

        public Warehouse() //konstruktor
        {
            InStock = new List<Article>(); //kutsume siin välja, et mälu j aega säästa
            Article cinnamonBun = new Article(1,"cinnamon bun", Category.PASTRY, 0.39); //pole faili kust võta, seega loome käsitsi
            InStock.Add(cinnamonBun);
            Article ciabatta = new Article(2,"ciabatta", Category.PASTRY, 0.59);
            InStock.Add(ciabatta);
            Article milk = new Article(3,"milk", Category.DAIRY, 0.59);
            InStock.Add(milk);
            Article yogurt = new Article(4,"yogurt", Category.DAIRY, 0.99);
            InStock.Add(yogurt);
            Article kalevChocolate = new Article(5,"Kalev chocolate", Category.CONFECTIONERY, 1.99);
            InStock.Add(kalevChocolate);
            Article gummyBears = new Article(6,"Gummy Bears", Category.CONFECTIONERY, 1.99);
            InStock.Add(gummyBears);
            Article cocaCola = new Article(7,"Coca Cola", Category.BEVERAGES, 0.99);
            InStock.Add(cocaCola);
            Article crafterBeer = new Article(8,"Crafted Beer", Category.BEVERAGES, 6);
            InStock.Add(crafterBeer);
            Article orange = new Article(9,"orange", Category.FRUIT, 0.4);
            InStock.Add(orange);
            Article apple = new Article(10,"apple", Category.FRUIT, 0.2);
            InStock.Add(apple);
            Article potato = new Article(11,"potato", Category.VEGGIE, 0.29);
            InStock.Add(potato);
            Article tomato = new Article(12,"tomato", Category.VEGGIE, 1.29);
            InStock.Add(tomato);
            Article cannedBeans = new Article(13,"Kidney beans in tomato sauce", Category.CANNED_FOOD, 0.69);
            InStock.Add(cannedBeans);
            Article turistiEine = new Article(14,"Turisti eine", Category.CANNED_FOOD, 2);
            InStock.Add(turistiEine);
            Article salmon = new Article(15,"salmon", Category.FISH, 1.69);
            InStock.Add(salmon);
            Article fishFingers = new Article(16,"Fish Fingers", Category.FISH, 1.69);
            InStock.Add(fishFingers);
            Article pork = new Article(17,"pork", Category.MEAT, 4.99);
            InStock.Add(pork);
            Article beef = new Article(18,"beef", Category.MEAT, 10);
            InStock.Add(beef);
            Article shampoo = new Article(19,"shampoo", Category.TOILETRIES, 4);
            InStock.Add(shampoo);
            Article conditioner = new Article(20,"conditioner", Category.TOILETRIES, 4);
            InStock.Add(conditioner);

        }

        public void PrinInStock()
        {
            foreach(Article article in InStock)
            {
                Console.WriteLine($"ID: {article.Id}");
                Console.WriteLine($"Product: {article.Name}");
                Console.WriteLine($"Category: {article.Category}");
                Console.WriteLine($"Price: {article.Price}");
                Console.WriteLine();

            }
        }

        //Get an article object from the list

        public Article GetFromStock(int id) //tagastab selle objekti listist id koodi järgi
        {
            return InStock[id - 1]; //kui kasutaja tahab cinnamon bun, siis ta paned id 1 aga arvuti jaoks ta on 0 kohal.
        }

        
    }
    
}
