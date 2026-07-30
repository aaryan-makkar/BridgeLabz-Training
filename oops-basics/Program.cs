using ClassesAndObjects;

public class Program
{
    public static void Main(string[] args)
    {
        //string[] foodItems1 = { "Pizza", "Pasta", "Burger" };
        //string[] foodItems2 = { "Sushi", "Ramen", "Tempura" };

        //Restaurant restaurant1 = new Restaurant("Italian Delight", "Downtown", foodItems1);
        //Restaurant restaurant2 = new Restaurant("Tokyo Treats", "Uptown", foodItems2);


        //Console.WriteLine("=== Restaurant 1 ===");
        //restaurant1.DisplayDetails();
        //Console.WriteLine("\n=== Restaurant 2 ===");
        //restaurant2.DisplayDetails();

        //// Check food availability
        //Console.WriteLine("\nChecking Food Availability:");
        //Console.WriteLine("Is Pasta available in Italian Delight? " + restaurant1.IsFoodAvailable("Pasta"));
        //Console.WriteLine("Is Sushi available in Italian Delight? " + restaurant1.IsFoodAvailable("Sushi"));

        //Employee employee1 = new Employee("Rahul", 1, 15000);
        //Employee employee2 = new Employee("Satish", 2, 20000);

        //employee1.DisplayDetails();
        //employee2.DisplayDetails();

        //Circle circle1 = new Circle(5);
        //circle1.DisplayResult();

        Book atomicHabits = new Book("Atomic Habits", "James Clear", 150);
        atomicHabits.DisplayDetails();
    }
}
