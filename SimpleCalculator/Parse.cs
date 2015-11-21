using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Parse
    {
        public string Expression { get; set; }

        public string AddSpace(string input)
        {
            string operators = @"[+-/%*]";
            string pattern = @"\s*[+-/%*]\s*";
            string replacement = " " + Regex.Match(input, operators) + " ";
            Regex rgx = new Regex(pattern);
            return rgx.Replace(input, replacement);

        }
    }
}
