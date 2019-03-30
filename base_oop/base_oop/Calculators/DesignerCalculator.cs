using base_oop.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace base_oop.Calculators
{
    public class DesignerCalculator : EmployeeCalculator
    {
        public override decimal CalculateSalary(Employee employee)
        {
            employee.Salary = base.CalculateSalary(employee) * ((Designer)employee).EffCoeff;

            return employee.Salary;
        }
    }
}
