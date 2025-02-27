﻿namespace Tester
{
    [TestClass]
    public sealed class CalculatorTest
    {
        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            Collection.Calculator calculator = new();
            float first = 15;
            float second = 10;
            float expected = 25;

            //Act
            float actual = calculator.Add(first, second);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
