
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeAttendanceAndOvertimeCalculator
{
    public class AttendanceProcessor
    {
        public event Action<Employee> OvertimeThresholdExceeded;

        public void ProcessAttendance(
            List<Employee> employees,
            List<AttendancePunch> punches,
            Func<double, double> overtimeRule)
        {
            Predicate<AttendancePunch> validator =
                p => p.ClockOut > p.ClockIn;

            Action<Employee> payrollNotifier =
                e => Console.WriteLine(
                    $"Payroll Notified for Employee {e.EmployeeId}");

            foreach (var punch in punches)
            {
                if (!validator(punch))
                {
                    throw new InvalidPunchException(
                        punch.EmployeeId,
                        punch.ClockOut);
                }
            }

            var groupedData = punches
                .GroupBy(p => p.EmployeeId)
                .Select(g => new
                {
                    EmployeeId = g.Key,

                    TotalHours = g.Sum(
                        p => (p.ClockOut - p.ClockIn).TotalHours)
                });

            foreach (var data in groupedData)
            {
                double overtime =
                    overtimeRule(data.TotalHours);

                if (overtime > 2)
                {
                    var emp = employees
                        .First(e => e.EmployeeId == data.EmployeeId);

                    OvertimeThresholdExceeded?.Invoke(emp);

                    payrollNotifier(emp);
                }
            }

            double averageHours = groupedData
                .Average(x => x.TotalHours);

            Console.WriteLine(
                $"Company Average Hours = {averageHours}");
        }
    }
}