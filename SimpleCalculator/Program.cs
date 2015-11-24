using System;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack user = new Stack();
            Regex rgx = new Regex(@"-?\d+\s?[+-/*%]\s?-?\d+");
            int counter = 0;
            bool running = true;

            while (running)
            {
               Console.Write("[" + counter + "]> ");
                string input = Console.ReadLine();

                if( input == "exit" || input =="quit")
                {
                    Console.WriteLine("Bye!!");
                    running = false;
                }
                else if(input == "lastq")
                {                 
                    Console.WriteLine("> Your last expression was: " + "\" " + user.Expression + " \"");      
                }
                else if (input == "last")
                {
                    Console.WriteLine("> Your last answer was: " + "\" " + user.Answer + " \"");
                }
                else if(!rgx.IsMatch(input))
                {
                    Console.WriteLine("> Please enter a valid expression or command");
                    counter -= 1;
                }
                else
                {
                    user.EvalEx(input);
                    Console.WriteLine("   = " + user.Answer);
                }
                counter += 1;
            }   
        }
    }
}
