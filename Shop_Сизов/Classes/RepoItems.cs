namespace Shop_Сизов.Classes
{
    public class RepoItems
    {
        public static List<object> AllItems()
        {
            List<object> allItems = new List<object>();
            allItems.Add(new Children("Игрушка интерактивная", 2200, 3));
            allItems.Add(new Children("Кактус танцующий", 894, 6));
            allItems.Add(new Children("Мягкая игрушка - кошка подушка", 1754, 6));
            allItems.Add(new Sport("Спортивный мужской костюм", 4913, "S"));
            allItems.Add(new Sport("Мяч для водного поло", 4913, "61-63см"));
            allItems.Add(new Sport("Набор для гольфа Partida", 3950, "600-800"));
            allItems.Add(new Electronics("Радио", 4500, "1450 MaH"));
            allItems.Add(new Electronics("ЭлектроМопед", 4500, "12000 MaH", 43));
            allItems.Add(new Electronics("Tecno SPARC 10C", 4500, "5600 MaH"));


            return allItems;
        }
    }
}
