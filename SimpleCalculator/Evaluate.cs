using System;

namespace SimpleCalculator
{
    public class Evaluate : Parse
    {
        public int x;
        public int y;
        public int last;
        public string lastq;

        public int EvalEx(string input)
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
                return last = x / y;
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
