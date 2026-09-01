using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceAndOvertimeCalculator
{
    public class InvalidPunchException : Exception
    {
        public string EmployeeId { get; }
        public DateTime PunchIn { get; }

        public InvalidPunchException(string employeeId, DateTime punchIn ) : base($"Invalid Punch for Emplpoyee {employeeId} at {punchIn}")
        {
            EmployeeId = employeeId;
            PunchIn = punchIn;
        }
    }
}
