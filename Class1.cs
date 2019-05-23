using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace calcularor_test
{
    [TestFixture]

    public class CalculatorTests
    {
        [Test]
        public void GetAddition_Input4point0and6point0_Returns10point0()
        {
            //Arrange
            double number1 = 4.0;
            double number2 = 6.0;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Input3point0and5point0_Returns1point0()
        {
            //Arrange
            double number1 = 3.0;
            double number2 = 5.0;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Input14point0and6point0_Returns20point0()
        {
            //Arrange
            double number1 = 14.0;
            double number2 = 6.0;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetMultiplication_Input10point0and6point0_Returns60point0()
        {
            //Arrange
            double number1 = 10.0;
            double number2 = 6.0;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetMultiplication_Input1point0and6point0_Returns6point0()
        {
            //Arrange
            double number1 = 1.0;
            double number2 = 6.0;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input15point0and16point0_Returns240point0()
        {
            //Arrange
            double number1 = 15.0;
            double number2 = 16.0;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input15point0and3point0_Returns5point0()
        {
            //Arrange
            double number1 = 15.0;
            double number2 = 3.0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input15point0and5point0_Returns3point0()
        {
            //Arrange
            double number1 = 15.0;
            double number2 = 5.0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input12point0and3point0_Returns4point0()
        {
            //Arrange
            double number1 = 12.0;
            double number2 = 3.0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input12point0and3point0_Returns9point0()
        {
            //Arrange
            double number1 = 12.0;
            double number2 = 3.0;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input10point0and3point0_Returns7point0()
        {
            //Arrange
            double number1 = 10.0;
            double number2 = 3.0;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input10point0and7point0_Returns3point0()
        {
            //Arrange
            double number1 = 10.0;
            double number2 = 7.0;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



    }
}