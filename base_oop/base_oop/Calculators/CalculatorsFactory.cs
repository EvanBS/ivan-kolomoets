using base_oop.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace base_oop.Calculators
{
    static class CalculatorsFactory
    {
        public static ICalculator GetCalculator(Employee employee)
        {
            if (employee is Designer)
            {
                return new DesignerCalculator();
            }
            else if (employee is Manager)
            {
                return new ManagerCalculator();
            }
            else if (employee is Developer)
            {
                return new DeveloperCalculator();
            }

            throw new FormatException("Invalid employee");
        }
    }
}
