using System;
using SimpleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void ParseEnsureGoodInputNoSpace()
        {
            // Arrange 
            Parse user_input = new Parse();
            // Act          
            string actual = user_input.ValEx("1-12");
            string expected = "1 - 12";
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ParseEnsureGoodInputWithSpace()
        {
            // Arrange 
            Parse user_input = new Parse();
            // Act          
            string actual = user_input.ValEx("1 - 12");
            string expected = "1 - 12";
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseEnsureBadInputMisplacedOperator()
        {
            Parse user_input = new Parse();
            user_input.ValEx("1 +1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseEnsureBadInputNoOperator()
        {
            Parse user_input = new Parse();
            user_input.ValEx("1 1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseEnsureBadInputExtraOperator()
        {
            Parse user_input = new Parse();
            user_input.ValEx("1++1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseEnsureBadInputOperatorAtEndOfExpression()
        {
            Parse user_input = new Parse();
            user_input.ValEx("1+1+");
        }
    }
}
