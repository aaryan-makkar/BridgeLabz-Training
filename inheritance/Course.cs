using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Course
    {
        public string CourseName { get; set; }
        public string Duration { get; set; }

        public Course(string courseName, string duration)
        {
            CourseName = courseName;
            Duration = duration;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Duration: {Duration}");
        }
    }

    class OnlineCourse : Course
    {
        public string Platform { get; set; }
        public bool IsRecorded { get; set; }

        public OnlineCourse(string courseName, string duration,
                            string platform, bool isRecorded)
            : base(courseName, duration)
        {
            Platform = platform;
            IsRecorded = isRecorded;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Platform: {Platform}");
            Console.WriteLine($"Recorded Course: {IsRecorded}");
        }
    }

    
    class PaidOnlineCourse : OnlineCourse
    {
        public double Fee { get; set; }
        public double Discount { get; set; }

        public PaidOnlineCourse(string courseName, string duration,
                                string platform, bool isRecorded,
                                double fee, double discount)
            : base(courseName, duration, platform, isRecorded)
        {
            Fee = fee;
            Discount = discount;
        }

        public double GetFinalFee()
        {
            return Fee - (Fee * Discount / 100);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n--- Paid Online Course Details ---");
            base.DisplayInfo();
            Console.WriteLine($"Fee: ₹{Fee}");
            Console.WriteLine($"Discount: {Discount}%");
            Console.WriteLine($"Final Fee: ₹{GetFinalFee()}");
        }
    }
}
