namespace RestaurantManagementSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<MenuItem> menu = new List<MenuItem>
            {
                new StarterItem("Fries", 200),
                new StarterItem("Noodles", 150),
                new StarterItem("Manchurian", 200),
                new MainCourseItem("Paneer Butter Masala", 400),
                new MainCourseItem("Dal Makhani", 350),
                new MainCourseItem("Butter Naan", 50),
                new DesertItem("Ice Cream", 100),
                new DesertItem("Gulab jamun", 50)
            };

            Table table1 = new Table(1);
            Table table2 = new Table(2);
            Table table3 = new Table(3);

            table1.PlaceOrder();
            table2.PlaceOrder();

            Order order1 = new Order(1, 101);
            order1.AddItem(menu[1]);
            order1.AddItem(menu[3]);
            order1.AddItem(menu[7]);

            order1.CalculateTotal();

            Bill bill1 = new Bill(1, 101);
            bill1.DisplayItems();
            bill1.DisplayTotal();
        }
    }
}