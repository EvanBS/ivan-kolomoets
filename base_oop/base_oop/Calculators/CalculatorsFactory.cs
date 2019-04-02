using base_oop.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace base_oop.Calculators
{
    public abstract class CalculatorsFactory
    {
        public abstract ICalculator GetCalculator(Employee employee);
    }
}
