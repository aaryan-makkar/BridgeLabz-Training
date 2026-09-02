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

        
    }
}
```
