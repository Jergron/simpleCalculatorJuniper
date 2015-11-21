using System;
using SimpleCalculator;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ParseTests
    {
        [TestMethod]
        public void ParseEnsureICanCreateInstance()
        {
            Parse two_term = new Parse();
            Assert.IsNotNull(two_term);
        }

        [TestMethod]
        public void ParseEnsureGetTheExpressionFromUser()
        {
            // Arrange
            Parse userInput = new Parse();
            userInput.Expression = "1 + 1";
            // Act
            string expected = "1 + 1";
            string actual = userInput.Expression;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ParseEnsureConvertStringToInteger()
        {
            // Arrange
            Parse userInput = new Parse();
            // Act
            int actual;
            string input = "13";
            int expected = 13;
            int.TryParse(input, out actual);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ParseEnsureSplitMethodWithSpaces()
        {
            // Arrange
            char[] delimiterChars = { ' ' };
            string input = "1 + 1";
            // Act
            string[] actual = input.Split(delimiterChars);
            string[] expected = new[] { "1", "+","1"};
            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ParseEnsureGoodInput()
        {
            // Arrange
            Parse noSpaces = new Parse();
            // Act          
            string actual = noSpaces.AddSpace("1-1");
            string expectedNoSpaces = "1 - 1";
            // Assert
            Assert.AreEqual(expectedNoSpaces, actual);
        }

        [TestMethod]
        public void ParseEnsureBadInput()
        {
            // Arrange
            Parse noOperator = new Parse();
            // Act
            string actual = noOperator.AddSpace("1 1");
            string expected = null;
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
