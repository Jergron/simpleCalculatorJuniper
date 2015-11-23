using System;
using SimpleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackEnsureICanCreateInstance()
        {
            Stack userInput = new Stack();
            Assert.IsNotNull(userInput);
        }

        [TestMethod]
        public void StackEnsureLastEvaluatedExpressionIsSet()
        {
            // Arrange
            Stack user = new Stack();
            Parse input = new Parse();
            // Act
            user.EvalEx(input.ValEx("1+1"));
            string actual = user.Expression;
            string expected = "1 + 1";
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StackEnsureLastAnswerIsSet()
        {
            // Arrange
            Stack user = new Stack();
            Parse input = new Parse();
            // Act
            user.EvalEx(input.ValEx("1+1"));
            int actual = user.Answer;
            int expected = 2;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StackProveLastQHandlesCommandInEvaluateClass()
        {
            // Arrange
            Stack user = new Stack();
            // Act  
            user.EvalEx(user.ValEx("1+1"));
            string actual = user.lastq;
            string expected = "1 + 1";
            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StackProveLastHandlesCommandInEvaluateClass()
        {
            // Arrange
            Stack user = new Stack();
            // Act  
            user.EvalEx(user.ValEx("1+1"));
            int actual = user.last;
            int expected = 2;
            // Assert 
            Assert.AreEqual(expected, actual);
        }

    }
}
