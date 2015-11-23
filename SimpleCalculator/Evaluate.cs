using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate : Parse
    {
        int x;
        int y;

        public int EvalEx(string input)
        {
            string[] array = input.Split(' ');

            int.TryParse(array[0], out x);
            int.TryParse(array[2], out y);

            if (array[1] == "+")
            {
                return x + y;
            }
            else if (array[1] == "-")
            {
                return x - y;
            }
            else if (array[1] == "*")
            {
                return x * y;
            }
            else if (array[1] == "/")
            {
                return x / y;
            }
            else if (array[1] == "%")
            {
                return x % y;
            }

            throw new NotImplementedException();
        }
    }
}
