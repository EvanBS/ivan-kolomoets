using base_oop.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace base_oop.Calculators
{
    public class DeveloperCalculator : EmployeeCalculator
    {
        // just return base
        public override decimal CalculateSalary(Employee employee)
        {
            employee.Salary = base.CalculateSalary(employee);

            return employee.Salary;
        }
    }
}
