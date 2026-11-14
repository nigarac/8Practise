namespace Shop_Сизов.Classes
{
    public class Electronics : Shop
    {
        public string BatteryСapacity;
        public int DrivingSpeed;
        public Electronics(string name, int price, string batteryСapacity, int drivingSpeed = 0) :
            base(name, price)
        {
            this.BatteryСapacity = batteryСapacity;
            this.DrivingSpeed = drivingSpeed;
        }
    }
}
