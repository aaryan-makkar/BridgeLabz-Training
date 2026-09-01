using NUnit.Framework;
using System;
using System.Collections.Generic;
using EmployeeAttendanceAndOverTimeCalculator;

namespace EmployeeAttendanceAndOverTimeCalculatorTests
{
    [TestFixture]
    public class AttendanceProcessorTests
    {
        private AttendanceProcessor processor;
        private List<Employee> employees;

        [SetUp]
        public void Setup()
        {
            processor = new AttendanceProcessor();

            employees = new List<Employee>
            {
                new Employee
                {
                    EmployeeId = 1,
                    PayGrade = "Senior",
                    HourlyRate = 500
                },

                new Employee
                {
                    EmployeeId = 2,
                    PayGrade = "Junior",
                    HourlyRate = 300
                }
            };
        }

        
        [Test]
        public void CreateOvertimeRule_WhenHoursExceedLimit_ReturnsOvertime()
        {
            var rule = OvertimeRuleFactory.CreateOvertimeRule(8);

            double result = rule(10);

            Assert.That(result, Is.EqualTo(2));
        }

        
        [Test]
        public void CreateOvertimeRule_WhenHoursEqualLimit_ReturnsZero()
        {
            var rule = OvertimeRuleFactory.CreateOvertimeRule(8);

            double result = rule(8);

            Assert.That(result, Is.EqualTo(0));
        }

        
        [Test]
        public void CreateOvertimeRule_WhenHoursBelowLimit_ReturnsZero()
        {
            var rule = OvertimeRuleFactory.CreateOvertimeRule(8);

            double result = rule(6);

            Assert.That(result, Is.EqualTo(0));
        }

        
        [Test]
        public void ProcessAttendance_WithValidPunches_DoesNotThrowException()
        {
            var punches = new List<AttendancePunch>
            {
                new AttendancePunch
                {
                    EmployeeId = 1,
                    ClockIn = DateTime.Parse("09:00"),
                    ClockOut = DateTime.Parse("18:00")
                }
            };

            var rule = OvertimeRuleFactory.CreateOvertimeRule(8);

            Assert.DoesNotThrow(() =>
            {
                processor.ProcessAttendance(
                    employees,
                    punches,
                    rule);
            });
        }

        
        [Test]
        public void ProcessAttendance_InvalidPunch_ThrowsInvalidPunchException()
        {
            var punches = new List<AttendancePunch>
            {
                new AttendancePunch
                {
                    EmployeeId = 1,
                    ClockIn = DateTime.Parse("18:00"),
                    ClockOut = DateTime.Parse("09:00")
                }
            };

            var rule = OvertimeRuleFactory.CreateOvertimeRule(8);

            Assert.Throws<InvalidPunchException>(() =>
            {
                processor.ProcessAttendance(
                    employees,
                    punches,
                    rule);
            });
        }

        
        [Test]
        public void OvertimeThresholdExceeded_ShouldFire_WhenOvertimeGreaterThanTwoHours()
        {
            bool eventRaised = false;

            processor.OvertimeThresholdExceeded += emp =>
            {
                eventRaised = true;
            };

            var punches = new List<AttendancePunch>
            {
                new AttendancePunch
                {
                    EmployeeId = 1,
                    ClockIn = DateTime.Parse("09:00"),
                    ClockOut = DateTime.Parse("20:00")
                }
            };

            var rule = OvertimeRuleFactory.CreateOvertimeRule(8);

            processor.ProcessAttendance(
                employees,
                punches,
                rule);

            Assert.That(eventRaised, Is.True);
        }

        
        [Test]
        public void OvertimeThresholdExceeded_ShouldNotFire_WhenOvertimeIsTwoHoursOrLess()
        {
            bool eventRaised = false;

            processor.OvertimeThresholdExceeded += emp =>
            {
                eventRaised = true;
            };

            var punches = new List<AttendancePunch>
            {
                new AttendancePunch
                {
                    EmployeeId = 1,
                    ClockIn = DateTime.Parse("09:00"),
                    ClockOut = DateTime.Parse("18:00")
                }
            };

            var rule = OvertimeRuleFactory.CreateOvertimeRule(8);

            processor.ProcessAttendance(
                employees,
                punches,
                rule);

            Assert.That(eventRaised, Is.False);
        }

        
        [Test]
        public void EventSubscriber_ShouldReceiveCorrectEmployee()
        {
            Employee receivedEmployee = null;

            processor.OvertimeThresholdExceeded += emp =>
            {
                receivedEmployee = emp;
            };

            var punches = new List<AttendancePunch>
            {
                new AttendancePunch
                {
                    EmployeeId = 1,
                    ClockIn = DateTime.Parse("09:00"),
                    ClockOut = DateTime.Parse("20:00")
                }
            };

            var rule = OvertimeRuleFactory.CreateOvertimeRule(8);

            processor.ProcessAttendance(
                employees,
                punches,
                rule);

            Assert.That(receivedEmployee.EmployeeId, Is.EqualTo(1));
        }

        
        [Test]
        public void OvertimeEmployeesList_ShouldAccumulateEmployeesCrossingThreshold()
        {
            List<Employee> overtimeEmployees = new();

            processor.OvertimeThresholdExceeded += emp =>
            {
                overtimeEmployees.Add(emp);
            };

            var punches = new List<AttendancePunch>
            {
                new AttendancePunch
                {
                    EmployeeId = 1,
                    ClockIn = DateTime.Parse("09:00"),
                    ClockOut = DateTime.Parse("20:00")
                },

                new AttendancePunch
                {
                    EmployeeId = 2,
                    ClockIn = DateTime.Parse("09:00"),
                    ClockOut = DateTime.Parse("21:00")
                }
            };

            var rule = OvertimeRuleFactory.CreateOvertimeRule(8);

            processor.ProcessAttendance(
                employees,
                punches,
                rule);

            Assert.That(overtimeEmployees.Count, Is.EqualTo(2));
        }
    }
}
```
