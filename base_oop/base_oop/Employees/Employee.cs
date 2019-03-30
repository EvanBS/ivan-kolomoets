using System;
using System.Collections.Generic;
using System.Text;

namespace base_oop.Employees
{
    abstract class Employee : IEmployee
    {
        protected string _FirstName;
        protected string _SecondName;
        protected decimal _Salary;
        protected int _Experiance;
        protected Manager _Manager;

        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string SecondName { get => _SecondName; set => _SecondName = value; }
        public decimal Salary { get => _Salary; set => _Salary = value; }
        public int Experiance { get => _Experiance; set => _Experiance = value; }
        public Manager Manager { get => _Manager; set => _Manager = value; }

        public abstract decimal CalculateSalary();

        public Employee(string _FirstName, string _SecondName, decimal _Salary, int _Experiance, Manager _Manager = null)
        {
            this._FirstName = _FirstName;
            this._SecondName = _SecondName;
            this._Salary = _Salary;
            this._Experiance = _Experiance;
            this._Manager = _Manager;
        }
    }
}
