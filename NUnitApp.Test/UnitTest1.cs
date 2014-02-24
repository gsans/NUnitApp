using System;
using NUnit.Framework;

using Calculator;

namespace NUnitApp.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(0, 1, Result = 1)]
        [TestCase(1, 1, Result = 2)]
        [TestCase(1, -1, Result = 0)]
        public int Calculator_Add(int a, int b)
        {
            //Arrange
            Calculator.Calculator c = new Calculator.Calculator(a);
            //Act
            c.Add(b);
            //Assert
            return c.Total;
        }

        [TestCase(0, 1, Result = 1, ExpectedException = typeof(ArgumentNullException))]
        public int Calculator_Add_ArgumentNullException(int a, int b)
        {
            //Arrange
            Calculator.Calculator c = new Calculator.Calculator(a);
            //Act
            c.Add(b);
            throw new ArgumentNullException();
            //Assert
            return c.Total;
        }
    }
}