﻿using base_oop.Calculators;
using base_oop.Employees;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace base_oop
{
    class Department
    {
        private ICalculator calculator;
        private List<Manager> managers = new List<Manager>();
        private ConcurrentDictionary<Type, ICalculator> dict = new ConcurrentDictionary<Type, ICalculator>();

        public void AddManager(Manager manager)
        {
            managers.Add(manager);
        }


        public void CalculateSalary()
        {
            // flatten employees?
            Parallel.ForEach(managers, m =>
            {
                Parallel.ForEach(m.Employees, emps => GiveSalary(emps));
                if (m != null)
                    GiveSalary(m);

            });

        }

        public void GiveSalary(Employee employee)
        {
            // check empl type
            // give to calculator emp

            if (!dict.ContainsKey(employee.GetType()))
            {
                dict[employee.GetType()] = CalculatorsFactory.GetCalculator(employee);
            }

            calculator = dict[employee.GetType()];

            calculator.CalculateSalary(employee);
        }

    }
}
