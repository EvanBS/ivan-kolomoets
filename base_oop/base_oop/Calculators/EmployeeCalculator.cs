using base_oop.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace base_oop.Calculators
{
    class EmployeeCalculator : ICalculator
    {
        public virtual decimal CalculateSalary(Employee employee)
        {
            if (employee.Experiance > 2)
            {
                employee.Salary += 200;
            }
            else if (employee.Experiance > 5)
            {
                employee.Salary *= 1.2m + 500;
            }

            return employee.Salary;
        }
    }
}
