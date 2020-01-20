using System;
using System.Collections.Generic;

namespace PizzaShop
{
    class ExtraMenu
    {
        List<Extras> Choice;
        

        public ExtraMenu()
        {
            Choice = new List<Extras>();
            Extras olives = new Extras(1,"olives", 0.5);
            Choice.Add(olives);
            Extras cheese = new Extras(2, "cheese", 0.3);
            Choice.Add(cheese);
            Extras mushrooms = new Extras(3, "mushrooms", 0.6);
            Choice.Add(mushrooms);
            Extras ham = new Extras(4, "ham", 0.7);
            Choice.Add(ham);
            Extras bacon = new Extras(5, "bacon", 0.7);
            Choice.Add(bacon);
            Extras mozzarella = new Extras(6, "mozzarella", 0.5);
            Choice.Add(mozzarella);

        }

        public void PrintExtraMenu()
        {
            foreach (Extras extras in Choice)
            {
                Console.WriteLine($"ID: {extras.Id}");
                Console.WriteLine($"Extra ingredient name: {extras.Name}");
                Console.WriteLine($"Price: {extras.Price}");
                Console.WriteLine();
            }
        }

        public Extras GetFromChoice(int id)
        {
            return Choice[id - 1];  //kuna arvuti jaoks 1 on 0 , 1 on 2 jne.
        }


    }

}
