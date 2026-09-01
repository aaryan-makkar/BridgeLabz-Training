using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceAndOvertimeCalculator
{
    public  class AttendancePunch
    {
        public DateTime ClockIn { get; set; }
        public DateTime ClockOut { get; set; }

        public string EmployeeId { get; set; } 

        public AttendancePunch(DateTime clockIn, DateTime clockOut, string employeeId)
        {
            ClockIn = clockIn;
            ClockOut = clockOut;
            EmployeeId = employeeId;
        }
    }
}
