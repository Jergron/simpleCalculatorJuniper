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
            user.EvalEx("1+1");
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
            user.EvalEx("1+1");
            decimal actual = user.Answer;
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
            user.EvalEx("1+1");
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
            user.EvalEx("1+1");
            decimal actual = user.last;
            int expected = 2;
            // Assert  
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StackEnsureICanGetValueFromDictionary()
        {
            Stack user = new Stack();
            user.Constants("x=1");
            int actual = user.constants["x"];
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StackEnsureThrowsArgumentExceptionForSameKey()
        {
            Stack user = new Stack();
            user.constants.Add("x", 1);
            user.constants.Add("x", 1);
        }

    }
}
