using System;
using System.Collections.Generic;
using System.Text;

namespace base_oop.Employees
{
    public class Designer : Employee
    {
        public Designer(string _FirstName, string _SecondName, decimal _Salary, int _Experiance, decimal _effCoeff, Manager _Manager = null)
            : base(_FirstName, _SecondName, _Salary, _Experiance, _Manager)
        {
            this._effCoeff = _effCoeff;
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
        
    }
}
