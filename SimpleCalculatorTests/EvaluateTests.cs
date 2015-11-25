using System;
using SimpleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class EvaluateTests
    {
        [TestMethod]
        public void EvaluateEnsureICanCreateInstance()
        {
            Evaluate two_term = new Evaluate();
            Assert.IsNotNull(two_term);
        }

        [TestMethod]
        public void EvaluateEnsureGoodInputEvalutesExpression()
        {
            // Arrange
            Evaluate userInput = new Evaluate();
            // Act  
            decimal actual = userInput.EvalEx("1--1");
            int expected = 2;      
            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EvaluateEnsureBadInputThrowsException()
        {
            Evaluate user_input = new Evaluate();
            user_input.EvalEx("1++1");
        }


    }
}
