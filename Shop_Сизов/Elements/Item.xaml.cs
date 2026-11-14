using Shop_Сизов.Classes;
using System.Windows.Controls;

namespace Shop_Сизов.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(object item)
        {
            InitializeComponent();
            Shop ShopData = item as Shop;
            lName.Content = ShopData.Name;
            lPrice.Content = "Цена" + ShopData.Price;

            if (item is Classes.Children)
            {
                Children ChildrenData = item as Children;
                lCharacketeristic.Content = "Возраст: " + ChildrenData.Age;
            }
            if (item is Sport)
            {
                Sport SportData = item as Sport;
                lCharacketeristic.Content = "Размер: " + SportData.Size;
            }
        }
    }
}
