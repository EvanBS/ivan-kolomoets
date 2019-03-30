using System;
using System.Collections.Generic;
using System.Text;

namespace base_oop.Employees
{
    class Designer : Employee
    {
        public Designer(string _FirstName, string _SecondName, decimal _Salary, int _Experiance, decimal _effCoef, Manager _Manager = null)
            : base(_FirstName, _SecondName, _Salary, _Experiance, _Manager)
        {
            this._effCoeff = _effCoef;
        }

        private decimal _effCoeff;

        public decimal EffCoeff
        {
            get
            {
                return _effCoeff;
            }
            set
            {
                _effCoeff = value > 1 ? 1 : value;
            }
        }

        public override decimal CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
