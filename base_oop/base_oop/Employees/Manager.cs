using System;
using System.Collections.Generic;
using System.Text;

namespace base_oop.Employees
{
    class Manager : Employee
    {
        private List<Employee> employees = new List<Employee>();

        public List<Employee> Employees
        {
            get { return employees; }
            private set { }
        }

        public Manager(string _FirstName, string _SecondName, decimal _Salary, int _Experiance, Manager _Manager = null)
            : base(_FirstName, _SecondName, _Salary, _Experiance, _Manager)
        {

        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }



        public override decimal CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
