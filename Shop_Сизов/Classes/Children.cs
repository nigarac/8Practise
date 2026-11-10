namespace Shop_Сизов.Classes
{
    public class Children:Shop
    {
        public int Age;
        public Children(string name, int price,int age) 
            : base(name, price)
        {
            this.Age = age;
        }
    }
}
