using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace SimpleCalculator
{
    public class Stack : Evaluate 
    {
        public string Expression
        {
            get { return lastq; }
            set { lastq = value; }
        }
        public int Answer
        {
            get { return last; }
            set { last = value; }
        }
         
        //public void CheckConstants()
        //{
        //    Regex rgx = new Regex(@"[a-zA-Z]{1,1}\s[+-*/%]{1,1}\s[a-zA-Z]{1,1}");

        //    if (rgx.IsMatch(Expression))
        //    {
        //         Expression = Expression;
        //    }
        //}
       
    }
}
