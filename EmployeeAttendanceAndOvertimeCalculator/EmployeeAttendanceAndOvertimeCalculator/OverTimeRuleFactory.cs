using System;
using System.Collections.Generic;
using System.Text;


namespace EmployeeAttendanceAndOvertimeCalculator
{
    public static class OverTimeRuleFactory
    {
        public static Func<double, double> CreateOverTimeRule(double regularHours)
        {
            return totalHours =>
            {
                return totalHours > regularHours ? totalHours - regularHours : 0;
            };
        }
    }
}
