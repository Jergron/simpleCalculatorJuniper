using System;

namespace SimpleCalculator
{
    public class Evaluate : Parse
    {
        public int x;
        public int y;
        public decimal last;
        public string lastq;

        public decimal EvalEx(string input)
        {
            string newInput = ValEx(input);
            string[] array = newInput.Split(' ');
            int.TryParse(array[0], out x);
            int.TryParse(array[2], out y);
            lastq = newInput;
          
            if (array[1] == "+")
            {
               return last = x + y;        
            }
            else if (array[1] == "-")
            {
               return last = x - y;
            }
            else if (array[1] == "*")
            {
               return last = x * y;
            }
            else if (array[1] == "/")
            {
                return last = decimal.Round(Convert.ToDecimal(x) / Convert.ToDecimal(y),2);
            }
            else if (array[1] == "%")
            {
               return last = x % y;
            }
            else
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
