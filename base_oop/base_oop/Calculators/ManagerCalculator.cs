using base_oop.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace base_oop.Calculators
{
    class ManagerCalculator : EmployeeCalculator
    {
        public override decimal CalculateSalary(Employee employee)
        {
            employee.Salary = base.CalculateSalary(employee);

            int employeesNumber = ((Manager)employee).Employees.Count;
            int developersInTeam = ((Manager)employee).Employees.Count(e => e is Developer);


            if (employeesNumber > 10)
            {
                employee.Salary += 300;
            }
            else if (employeesNumber > 5)
            {
                employee.Salary += 200;
            }
            else if (developersInTeam > employeesNumber / 2)
            {
                employee.Salary *= 1.1m;
            }


            return employee.Salary;
        }
    }
}
