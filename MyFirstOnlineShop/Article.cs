using System;
using System.Collections.Generic;


namespace MyFirstOnlineShop
{
    enum Category
    {
        PASTRY,
        DAIRY,
        CONFECTIONERY,
        CANNED_FOOD,
        MEAT,
        FISH,
        FRUIT,
        VEGGIE,
        TOILETRIES,
        BEVERAGES
    }
    class Article //olemas toode, millel on nimi, kategooria ja hind
    {
        int id;
        string name;
        Category category; //enum tüüpi property
        double price;

        public Article (int _id, string _name, Category _category, double _price) //konstruktor
        {
            id = _id;
            name = _name;
            category = _category;
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

        public string Category
        {
            get { return category.ToString(); } //konverteerime stringiks, et saaks kasutada ainult sõna Kategooria
        }

        public double Price
        {
            get { return price; }
        }
    }

}
