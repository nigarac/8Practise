using System.Windows;
using Shop_Сизов.Classes;

namespace Shop_Сизов
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<object> AllItems = RepoItems.AllItems();
        public MainWindow()
        {
            InitializeComponent();
            CreateUI();
        }
        public void CreateUI()
        {
            foreach (object item in AllItems)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }
    }
}