using System;

namespace SimpleCalculator
{
    public class Evaluate: Parse
    {
        public int x;
        public int y;
        public int last;
        public string lastq;

        public int EvalEx(string input)
        {
            lastq = input;
            string[] array = input.Split(' ');

            int.TryParse(array[0], out x);
            int.TryParse(array[2], out y);

            if (array[1] == "+")
            {
                last = x + y;
                return x + y;
            }
            else if (array[1] == "-")
            {
                last = x - y;
                return x - y;
            }
            else if (array[1] == "*")
            {
                last = x * y;
                return x * y;
            }
            else if (array[1] == "/")
            {
                last = x / y;
                return x / y;
            }
            else if (array[1] == "%")
            {
                last = x % y;
                return x % y;
            }
            else
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
