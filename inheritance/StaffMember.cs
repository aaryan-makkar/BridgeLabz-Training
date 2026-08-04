using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    interface Worker
    {
        void PerformDuties();
    }
    internal class StaffMember
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public StaffMember(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
        }
    }

    class Chef : StaffMember, Worker
    {
        public string Specialization { get; set; }

        public Chef(string name, int id, string specialization)
            : base(name, id)
        {
            Specialization = specialization;
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is preparing {Specialization} dishes.");
        }
    }

    class Waiter : StaffMember, Worker
    {
        public int AssignedTables { get; set; }

        public Waiter(string name, int id, int assignedTables)
            : base(name, id)
        {
            AssignedTables = assignedTables;
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is serving customers at {AssignedTables} tables.");
        }
    }
}
