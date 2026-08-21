using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem
{
    internal class Restaurant
    {
        public string Name { get; set; }

        public List<Table> Tables { get; set; }
        public List<MenuItem> Menu { get; set; }

        public Restaurant(string name)
        {
            Name = name;
            Tables = new List<Table>();
            Menu = new List<MenuItem>();
        }

        public void AddTable(Table table)
        {
            Tables.Add(table);
        }

        public void AddMenuItem(MenuItem item)
        {
            Menu.Add(item);
        }
    }

    abstract class MenuItem
    {
        private string name;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public double Price
        {
            get { return price; }
            set
            {
                if(value > 0)
                {
                    price = value;
                }
            }
        }
        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Preparation();
    }

    internal class StarterItem : MenuItem
    {
        public StarterItem(string name, double price) : base(name, price)
        {

        }

        public override void Preparation()
        {
            Console.WriteLine($"{Name} will be prepared in 10 minutes");
        }
    }

    internal class MainCourseItem : MenuItem
    {
        public MainCourseItem(string name, double price) : base(name, price)
        {

        }

        public override void Preparation()
        {
            Console.WriteLine($"{Name} will be prepared in 20 minutes");
        }
    }

    internal class DessertItem : MenuItem
    {
        public DessertItem(string name, double price) : base(name, price)
        {

        }

        public override void Preparation()
        {
            Console.WriteLine($"{Name} will be prepared in 5 minutes");
        }
    }

    internal class Table
    {
        private int tableNumber;
        private bool activeOrder;

        public int TableNumber
        {
            get { return tableNumber; }
            set { tableNumber = value; }
        }

        public bool ActiveOrder
        {
            get { return activeOrder; }
            set { activeOrder = value; }
        }

        public Table(int tableNumber)
        {
            TableNumber = tableNumber;
        }

        public void PlaceOrder(Order order)
        {

            ActiveOrder = true;
            Console.WriteLine($" Order no. {order.OrderId} has been placed by table number {TableNumber}");
        }
    }

    internal class Waiter
    {
        private string name;
        private string shift;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Shift
        {
            get { return shift; }
            set { shift = value; }
        }

        public Waiter(string name, string shift)
        {
            Shift = shift;
            Name = name;
        }

        public void TakeOrder(Order order)
        {
            Console.WriteLine(
                $"Waiter {Name} has taken order {order.OrderId}.");
        }
    }

    internal class Chef
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Chef(string name)
        {
            Name = name;
        }

        public void PrepareOrder(Order order)
        {
            Console.WriteLine($"Chef {Name} is preparing order {order.OrderId}.");

            foreach (var item in order.Items)
            {
                item.Preparation();
            }
        }
    }

    internal class Order
    {
        public int OrderId { get; set; }
        public Table Table { get; set; }
        public List<MenuItem> Items { get; set; }

        public bool IsCompleted { get; set; }

        public Order(int orderId, Table table)
        {
            OrderId = orderId;
            Table = table;
            Items = new List<MenuItem>();
        }
        public void AddItem(MenuItem item)
        {
            Items.Add(item);
        }
        public void CompleteOrder()
        {
            IsCompleted = true;
            Console.WriteLine("The order has been completed.");
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.Price;
            }
            return total;
        }
    }

  internal class Bill 
        {
        public int BillId { get; set; }
        public Order Order { get; set; }
            public Bill(int billId, Order order)
            {
            BillId = billId;
            Order = order;
            }
        public void DisplayBill()
            {
            Console.WriteLine($"Bill ID: {BillId}");
            Console.WriteLine($"Table: {Order.Table.TableNumber}");

            foreach (var item in Order.Items)
            {
                Console.WriteLine($"{item.Name} - {item.Price}");
            }

            Console.WriteLine($"Total Amount: {Order.CalculateTotal()}");
        }
        }
}
