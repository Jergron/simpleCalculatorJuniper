using System;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{ 
    public class Parse
    {
        public string AddSpace(string input)
        {          
            string firstDigit = @"^-?[a-zA-Z\d]+";
            string secondDigit = @"(?<![a-zA-Z\d])(-?[a-zA-z\d]+$)";
            string operators = @"(?!^)([-+*/%])";
            string replacement = Regex.Match(input, firstDigit) + " " + Regex.Match(input, operators) + " " + Regex.Match(input, secondDigit);
            string pattern = @"-?[a-zA_Z\d]+[+-/%*]-?[a-zA-z\d]+";
            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(input))
            {
                return rgx.Replace(input, replacement);
            }
            else
            {
                return input;
            }           
        }

        public string ValEx(string input)
        {
            string expression = AddSpace(input);

            Regex rgx = new Regex(@"-?\d+\s[+-/*%]\s-?\d+");
            if (rgx.IsMatch(expression))
            {
                return expression;
            }
            else
            {
                throw new ArgumentException();
            }           
        }

        public int NegCount()
        {
            return -1;
        }
    }
}
