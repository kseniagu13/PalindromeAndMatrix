using System;

namespace PizzaShop
{
    class MyItemsExtra
    {
        Extras extras;
        int quantity;

        public MyItemsExtra (Extras _extras, int _quantity)
        {
            
            extras = _extras;
            quantity = _quantity;
        }

       

        public Extras Extras
        {
            get { return extras; }
        }

        public void PrintItemExtras()
        {
            Console.WriteLine($"ID: {extras.Id} \n Name: {extras.Name} \n Price: {extras.Price} \n Quantity: {quantity} \n Total: {CalculateItemTotalExtras()}");
        }
            
            
        public double CalculateItemTotalExtras() //tagasitab summat
        {
            return  extras.Price * quantity;

        }

        public void PrintItemTotalExtras()
        {
            Console.WriteLine($" Extra {extras.Name}   |{extras.Price}  |{quantity}"); 
        }

    }

}
