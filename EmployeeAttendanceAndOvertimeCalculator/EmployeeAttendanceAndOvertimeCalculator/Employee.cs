using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceAndOvertimeCalculator
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string PayGrade { get; set; }

        public double HourlyRate { get; set; }

        public Employee(string employeeId, string payGrade, double hourlyRate)
        {
            EmployeeId = employeeId;
            PayGrade = payGrade;
            HourlyRate = hourlyRate;
        }
    }
}
