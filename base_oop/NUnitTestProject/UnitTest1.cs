using base_oop;
using base_oop.Employees;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DesignerSalaryIs700()
        {
            Department department = new Department();

            Manager manager1 = new Manager("Manager1", "Manager1", 1000, 7);
            // Add manager to designer in ctor
            Designer designer1 = new Designer("designer1", "designer1", 800, 4, 0.7m, manager1);

            department.AddManager(manager1);

            department.CalculateSalary();

            Assert.AreEqual(700m, designer1.Salary);
        }

        [Test]
        public void ManagerSalaryIs1700()
        {
            Department department = new Department();

            Manager manager1 = new Manager("Manager1", "Manager1", 1000, 7);

            department.AddManager(manager1);

            department.CalculateSalary();

            Assert.AreEqual(1700m, manager1.Salary);
        }


    }
}