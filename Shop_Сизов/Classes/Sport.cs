namespace Shop_Сизов.Classes
{
    public class Sport : Shop
    {
        public string Size;
        public Sport(string name, int price, string size) :
            base(name, price)
        {
            this.Size = size;
        }

    }
}
