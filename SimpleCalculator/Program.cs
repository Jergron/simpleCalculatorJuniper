using System;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    class Program 
    {
  
        static void Main(string[] args)
        {
            Stack user = new Stack();
            Program count = new Program();
            Regex rgx = new Regex(@"-?\d+\s?[+-/*%]\s?-?\d+");
            Regex addToDictionary = new Regex(@"[a-zA-Z]\s?[=]\s?-?\d+");
            Regex constants1 = new Regex(@"[a-zA-Z]\s?[+-/*%]\s?\d+");
            Regex constants2 = new Regex(@"\d+\s?[+-/*%]\s?[a-zA-Z]");

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
                else if (addToDictionary.IsMatch(input))
                {
                    user.Constants(input);
                }
                else if (constants1.IsMatch(input))
                {
                    string newInput = user.AddSpace(input);
                    string[] array = newInput.Split();
                    int value = user.constants[array[0]];

                    if(array[1] == "+")
                    {
                        user.EvalEx(value + "+" + array[2]);
                    }
                    else if(array[1] == "-")
                    {
                        user.EvalEx(value + "-" + array[2]);
                    }
                    else if (array[1] == "/")
                    {
                        user.EvalEx(value + "/" + array[2]);
                    }
                    else if (array[1] == "*")
                    {
                        user.EvalEx(value + "*" + array[2]);
                    }
                    else 
                    {
                        user.EvalEx(value + "%" + array[2]);
                    }
                    Console.WriteLine("   = " + user.Answer);
                }
                else if (constants2.IsMatch(input))
                {
                    string newInput = user.AddSpace(input);
                    string[] array = newInput.Split();
                    int value = user.constants[array[2]];

                    if (array[1] == "+")
                    {
                        user.EvalEx(array[0] + "+" + value);
                    }
                    else if (array[1] == "-")
                    {
                        user.EvalEx(array[0] + "-" + value);
                    }
                    else if (array[1] == "/")
                    {
                        user.EvalEx(array[0] + "/" + value);
                    }
                    else if (array[1] == "*")
                    {
                        user.EvalEx(array[0] + "*" + value);
                    }
                    else
                    {
                        user.EvalEx(array[0] + "%" + value);
                    }
                    Console.WriteLine("   = " + user.Answer);
                }
                else if(rgx.IsMatch(input))
                {
                    user.EvalEx(input);
                    Console.WriteLine("   = " + user.Answer);
                }
                else
                {
                    Console.WriteLine("> Please enter a valid expression or command");
                    counter -= 1;
                }
                counter += 1;
            }   
        }
    }
}
