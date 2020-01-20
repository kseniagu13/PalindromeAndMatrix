namespace PizzaShop
{
    class Extras
    {
        int id;
        string name;
        double price;

        public Extras(int _id,  string _name, double _price)
        {
            id = _id;
            name = _name;
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

        public double Price
        {
            get { return price; }
        }
    }

}
