using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation;
using NUnit.Framework;
namespace UnitTestCalculation
{
    [TestFixture]
    class TestCalculSimple
    {
         [Test]
        public void Addition_OperandesZero_Zero()
        {
             //Arrange
            CalculSimple Cs = new CalculSimple();

             //Act
            int TestResultat= Cs.Addition(0, 0);

             //Assert
            Assert.AreEqual(TestResultat, 0);
        }
        
    }
}
