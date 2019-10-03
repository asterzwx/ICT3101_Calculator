using ICT3101_Calculator;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act         
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            // Act         
            double result = _calculator.Subtract(10, 3);
            // Assert
            Assert.That(result, Is.EqualTo(7));
        }
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
        {
            // Act         
            double result = _calculator.Multiply(10, 10);
            // Assert
            Assert.That(result, Is.EqualTo(100));
        }
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToQuotient()
        {
            // Act         
            double result = _calculator.Divide(10, 2);
            // Assert
            Assert.That(result, Is.EqualTo(5));


        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithNegativeInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }


        [Test]
        public void Factorial_ResultEqualToFactorial()
        {
            // Act         
            double result = _calculator.Factorial(6,0);
            // Assert
            Assert.That(result, Is.EqualTo(720));
        }
        [Test]
        [TestCase(-1,0)]
        [TestCase(70,0)]
        public void Factorial_WithNegativeOrMaxInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Factorial(a,b), Throws.ArgumentException);
        }



        [Test]
        public void AreaOfTriangle()
        {
            // Act         
            double result = _calculator.AreaOfTriangle(7, 6);
            // Assert
            Assert.That(result, Is.EqualTo(21));
        }

        [Test]
        public void AreaOfCircle()
        {
            // Act         
            double result = _calculator.AreaOfCircle(2);
            // Assert
            Assert.That(result, Is.EqualTo(12.57));
        }

        [Test]
        [TestCase(-2, 5)]
        [TestCase(5, -4)]
        public void AreaOfTriangle_WithNegativeInputs(int b, int h)
        {
            Assert.That(() => _calculator.AreaOfTriangle(b, h), Throws.ArgumentException);
        }

        [TestCase(-3)]
        public void AreaOfCircle_WithNegativeInputs(int r)
        {
            Assert.That(() => _calculator.AreaOfCircle(r), Throws.ArgumentException);
        }



        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act                      
            double result = _calculator.Divide(5, 5);
            // Assert             
            Assert.That(result, Is.EqualTo(1));
        }
        //[Test]
        //public void UnknownFunctionA_WhenGivenTest1_Result()
        //{
        //    // Act                      
        //    double result = _calculator.UnknownFunctionA(5, 4);
        //    // Assert             
        //    Assert.That(result, Is.EqualTo(5));
        //} 


       

    }
    }