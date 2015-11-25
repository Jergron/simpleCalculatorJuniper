using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace SimpleCalculator
{
    public class Stack : Evaluate 
    {
        public string Expression
        {
            get { return lastq; }
            set { lastq = value; }
        }
        public decimal Answer
        {
            get { return last; }
            set { last = value; }
        }

       public Dictionary<string, int> constants =
                   new Dictionary<string, int>();

        public void Constants(string input)
        {
            int digit;
            string[] array = input.Split('=');
            int.TryParse(array[1], out digit);

            try
            {
                constants.Add(array[0].ToLower(), digit);
                Console.WriteLine("   = saved " + "\'" + array[0].ToLower() + "\' " + "as" + " \'" + array[1] + '\'');
            }
            catch (ArgumentException)
            {               
                Console.WriteLine("An element with Key " + array[0].ToLower() + " already exists.");
            }
            
        }
    }
}
