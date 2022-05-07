
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CalculatorProject.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Test_Constructor_DoesNotThrowException()
        {
            Mock<IParser> mockParser = new Mock<IParser>();
            Calculator calculator = new Calculator(mockParser.Object);
        }

        [TestMethod]
        public void Test_CalculateExpression_Addition_ReturnsCorrectResult()
        {
            // Arrange
            BinaryOperation operation = new BinaryOperation
            {
                Left = 6,
                Operator = "+",
                Right = 7
            };
            Mock<IParser> mockParser = new Mock<IParser>();
            mockParser
                .Setup(p => p.Parse(It.IsAny<string>()))
                .Returns(operation);

            Calculator target = new Calculator(mockParser.Object);

            int expected = 13;

            // Act
            int actual = target.CalculateExpression("DUMMY ARGUMENT");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Add_ValidParameters_ReturnsCorrectResult()
        {
            // Arrange
            Calculator target = new Calculator(new Mock<IParser>().Object);
            int argument0 = 6;
            int argument1 = 7;
            int expected = 13;

            // Act
            int actual = target.Add(argument0, argument1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ManyAsserts()
        {

            Assert.IsTrue(true);

            //Assert.IsFalse(true);
            //Assert.AreEqual(3, 3);
            //Assert.AreEqual(3, 5);


        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void Test_CalculateExpression_DivideByZero_ThrowsException()
        {
            // Arrange
            BinaryOperation operation = new BinaryOperation
            {
                Left = 0,
                Operator = "/",
                Right = 0
            };
            Mock<IParser> mockParser = new Mock<IParser>();
            mockParser
                .Setup(p => p.Parse(It.IsAny<string>()))
                .Returns(operation);

            Calculator target = new Calculator(mockParser.Object);
            


            // Act
            target.CalculateExpression("DUMMY VALUE");

            // Assert handled by ExpectedException
        }

        [TestMethod]
        public void Test_Divide_ValidParameters_ReturnsCorrectResult()
        {
            // Arrange
            Mock<IParser> mockParser = new Mock<IParser>();
            Calculator target = new Calculator(mockParser.Object);
            int argument0 = 50;
            int argument1 = 5;
            int expected = 10;

            // Act
            int actual = target.Divide(argument0, argument1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CalculateExpression_Division_ReturnsCorrectResult()
        {
            // Arrange
            BinaryOperation operation = new BinaryOperation
            {
                Left = 50,
                Operator = "/",
                Right = 5
            };
            Mock<IParser> mockParser = new Mock<IParser>();
            mockParser
                .Setup(p => p.Parse(It.IsAny<string>()))
                .Returns(operation);

            Calculator target = new Calculator(mockParser.Object);
            int expected = 10;

            // Act
            int actual = target.CalculateExpression("DUMMY VALUE");

            // Assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod] 
        public void MockParserTest()
        {
            BinaryOperation operation = new BinaryOperation
            {
                Left = 3,
                Operator = "+",
                Right = 7
            };

            Mock<IParser> mockParser = new Mock<IParser>();
            mockParser
                .Setup(p => p.Parse(It.IsAny<string>()))
                .Returns(operation);

            BinaryOperation op1 = mockParser.Object.Parse("9 * 12");
            BinaryOperation op2 = mockParser.Object.Parse("72-34");
            BinaryOperation op3 = mockParser.Object.Parse("HELLO WORLD");
        }
    }
}