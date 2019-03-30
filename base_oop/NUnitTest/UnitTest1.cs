using Microsoft.VisualStudio.TestPlatform.TestHost;
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
        public void DesignerSalaryMustBe1150()
        {
            Department department = new Department();

            Assert.Pass();
        }
    }
}