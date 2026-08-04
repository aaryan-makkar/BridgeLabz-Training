using System.ComponentModel.DataAnnotations;

namespace Inheritance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Animal animal = new Animal();
            //animal.MakeSound();

            //Dog dog = new Dog();
            //dog.MakeSound();

            //Cat cat = new Cat();
            //cat.MakeSound();

            ////Animal dog2 = new Dog();
            ////dog2.MakeSound();

            ////Animal cat2 = new Cat();
            ////cat2.MakeSound();

            //Bird bird = new Bird();
            //bird.MakeSound();

            //Manager manager = new Manager("Aaryan", 101, 80000, 10);
            //Developer developer = new Developer("Rahul", 102, 60000, "C#");
            //Intern intern = new Intern("Priya", 103, 15000, "6 Months");

            //manager.DisplayDetails();
            //developer.DisplayDetails();
            //intern.DisplayDetails();

            //    Vehicle[] vehicles =
            //{
            //    new Car(220, "Petrol", 5),
            //    new Truck(140, "Diesel", 10000),
            //    new Motorcycle(180, "Petrol", false)
            //};

            //    foreach (Vehicle vehicle in vehicles)
            //    {
            //        vehicle.DisplayInfo();
            //    }

            //    Author author = new Author(
            //    "The Alchemist",
            //    1988,
            //    "Paulo Coelho",
            //    "Brazilian novelist known for inspirational fiction."
            //);

            //    author.DisplayInfo();

            //Thermostat thermostat = new Thermostat(101, "Active", 24.5);

            //thermostat.DisplayStatus();

            //Order order = new Order(1001, DateTime.Now);

            //ShippedOrder shippedOrder =
            //    new ShippedOrder(1002, DateTime.Now.AddDays(-2), "TRK12345");

            //DeliveredOrder deliveredOrder =
            //    new DeliveredOrder(
            //        1003,
            //        DateTime.Now.AddDays(-5),
            //        "TRK67890",
            //        DateTime.Now);

            //Console.WriteLine("\n--- Order Details ---");
            //order.DisplayInfo();

            //Console.WriteLine("\n--- Shipped Order Details ---");
            //shippedOrder.DisplayInfo();

            //Console.WriteLine("\n--- Delivered Order Details ---");
            //deliveredOrder.DisplayInfo();

            //    PaidOnlineCourse course = new PaidOnlineCourse(
            //    "Machine Learning",
            //    "12 Weeks",
            //    "Coursera",
            //    true,
            //    10000,
            //    20
            //);

            //    course.DisplayInfo();

            //SavingsAccount savings =
            //new SavingsAccount("SA1001", 50000, 4.5);

            //CheckingAccount checking =
            //    new CheckingAccount("CA2001", 25000, 10000);

            //FixedDepositAccount fixedDeposit =
            //    new FixedDepositAccount("FD3001", 100000, 24);

            //savings.DisplayDetails();

            //Console.WriteLine();

            //checking.DisplayDetails();

            //Console.WriteLine();

            //fixedDeposit.DisplayDetails();

            Teacher teacher = new Teacher("Amit Sharma", 40, "Mathematics");
            Student student = new Student("Priya Verma", 16, "10th Grade");
            Staff staff = new Staff("Rakesh Kumar", 35, "Administration");

            teacher.DisplayDetails();

            Console.WriteLine();

            student.DisplayDetails();

            Console.WriteLine();

            staff.DisplayDetails();

        }
    }
}