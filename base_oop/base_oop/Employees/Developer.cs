using System;
using System.Collections.Generic;
using System.Text;

namespace base_oop.Employees
{
    class Developer : Employee
    {
        public Developer(string _FirstName, string _SecondName, decimal _Salary, int _Experiance, Manager _Manager = null)
            : base(_FirstName, _SecondName, _Salary, _Experiance, _Manager)
        {

        }


        public override decimal CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
