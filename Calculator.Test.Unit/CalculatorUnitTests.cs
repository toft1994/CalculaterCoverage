using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    class CalculatorUnitTests
    {
        [SetUp]
        public void SetUp()
        {
            //Calculator is static, and doesn't need to be instantiated
        }

        #region Add Tests
        [Test]
        public void Add_PositiveNumbers_Returns4()
        {
            //Act
            double res = CalculatorClass.Add(2, 2);

            //Assert
            Assert.That(res, Is.EqualTo(4));
        }
        [Test]
        public void Add_NegativeNumbers_ReturnsNegative4()
        {
            //Act
            double res = CalculatorClass.Add(-2, -2);

            //Assert
            Assert.That(res, Is.EqualTo(-4));
        }
        [Test]
        public void Add_PositiveAndNegativeNumbers_Returns0()
        {
            //Act
            double res = CalculatorClass.Add(2, -2);

            //Assert
            Assert.That(res, Is.EqualTo(0));
        }
        [Test]
        public void Add_NegativeAndPositiveNumbers_Returns0()
        {
            //Act
            double res = CalculatorClass.Add(-2, 2);

            //Assert
            Assert.That(res, Is.EqualTo(0));
        }


        #endregion

        #region Subtract Tests

        //Using a test case to simplify running of many similar tests
        [TestCase(2,2,0)]
        [TestCase(-2,-2,0)]
        [TestCase(2,-2,4)]
        [TestCase(-2,2,-4)]
        [TestCase(2,3,-1)]
        [TestCase(0,0,0)]
        public void SubtractTest(double a, double b, double expected)
        {
            //Act
            double res = CalculatorClass.Subtract(a, b);

            //Assert
            Assert.That(res, Is.EqualTo(expected));
        }


        #endregion

        #region Multiply Tests

        [Test]
        public void Multiply_PositiveNumbers_Return9()
        {
            //Act
            double res = CalculatorClass.Multiply(3, 3);

            //Assert
            Assert.That(res, Is.EqualTo(9));
        }
        public void Multiply_NegativeNumbers_Return9()
        {
            //Act
            double res = CalculatorClass.Multiply(-3, -3);

            //Assert
            Assert.That(res, Is.EqualTo(9));
        }
        public void Multiply_PositiveAndNegativeNumbers_ReturnNegative9()
        {
            //Act
            double res = CalculatorClass.Multiply(3, -3);

            //Assert
            Assert.That(res, Is.EqualTo(9));
        }
        public void Multiply_NegativeAndPositiveNumbers_ReturnNegative9()
        {
            //Act
            double res = CalculatorClass.Multiply(-3, 3);

            //Assert
            Assert.That(res, Is.EqualTo(9));
        }

        #endregion

        #region Power Tests

        [Test]
        public void Power_PositiveNumbers_Returns4()
        {
            //Act
            double res = CalculatorClass.Power(2, 2);

            //Assert
            Assert.That(res,Is.EqualTo(4));
        }
        [Test]
        public void Power_NegativeNumbers_ReturnsPoint25()
        {
            //Act
            double res = CalculatorClass.Power(-2, -2);

            //Assert
            Assert.That(res, Is.EqualTo(0.25));
        }
        [Test]
        public void Power_PositiveAndNegativeNumbers_ReturnsPoint25()
        {
            //Act
            double res = CalculatorClass.Power(2, -2);

            //Assert
            Assert.That(res, Is.EqualTo(0.25));
        }
        [Test]
        public void Power_NegativeAndPositiveNumbers_Returns4()
        {
            //Act
            double res = CalculatorClass.Power(-2, 2);

            //Assert
            Assert.That(res, Is.EqualTo(4));
        }
        [Test]
        //Test if the edge case of raising something to the 0th power returns 1
        public void Power_0thPower_Returns1()
        {
            //Act
            double res = CalculatorClass.Power(2, 0);

            //Assert
            Assert.That(res, Is.EqualTo(1));
        }

        #endregion


    }
}
