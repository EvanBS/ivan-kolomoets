using base_oop.Employees;
using System;

namespace base_oop
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Department department = new Department();

            Manager manager1 = new Manager("Manager1", "Manager1", 1000, 7);

            Developer developer1 = new Developer("dev1", "dev1", 700, 1, manager1);
            Developer developer2 = new Developer("dev2", "dev2", 500, 0, manager1);
            Developer developer3 = new Developer("dev3", "dev3", 800, 7, manager1);
            Designer designer1 = new Designer("designer1", "designer1", 800, 4, 0.7m, manager1);

            manager1.AddEmployee(developer1);
            manager1.AddEmployee(developer2);
            manager1.AddEmployee(developer3);
            manager1.AddEmployee(designer1);


            Manager manager2 = new Manager("Manager2", "Manager2", 1100, 7);


            department.AddManager(manager1);
            department.AddManager(manager2);


            department.CalculateSalary();
        }
    }
}
