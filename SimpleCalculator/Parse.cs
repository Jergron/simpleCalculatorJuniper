using System;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Parse
    {
        public string Expression { get; set; }

        public string AddSpace(string input)
        {
            string firstDigit = @"^\d+";
            string secondDigit = @"\d*\D*$";
            string operators = @"[+-/%*]";
            string pattern = @"\d+\s{0,0}[+-/%*]\s{0,0}\d+";
            string replacement = Regex.Match(input, firstDigit) + " " + Regex.Match(input, operators) + " " + Regex.Match(input, secondDigit);
            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(input))
            {
                return rgx.Replace(input, replacement);
            }
            return input;

        }

        public string ValEx(string input)
        {
           string newInput = AddSpace(input);
            Regex rgx = new Regex(@"-?\d+\s[+-/*%]{1,1}\s-?\d");
            if (rgx.IsMatch(newInput))
            {
                return newInput;
            }
            throw new ArgumentException();
        }
    }
}
