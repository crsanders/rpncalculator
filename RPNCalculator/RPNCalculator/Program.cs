using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPNCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            float a = 0, b = 0;
            int x = 0, y = 0;
            foreach (string arg in args)
            {
                #region switch
                switch (arg)
                {
                    case " ":
                        break;
                    case "+":
                        b = float.Parse(stack.Pop());
                        a = float.Parse(stack.Pop());
                        stack.Push((a + b).ToString());
                        break;
                    case "-":
                        b = float.Parse(stack.Pop());
                        a = float.Parse(stack.Pop());
                        stack.Push((a - b).ToString());
                        break;
                    case "*":
                        b = float.Parse(stack.Pop());
                        a = float.Parse(stack.Pop());
                        stack.Push((a * b).ToString());
                        break;
                    case "x":
                        b = float.Parse(stack.Pop());
                        a = float.Parse(stack.Pop());
                        stack.Push((a * b).ToString());
                        break;
                    case "/":
                        b = float.Parse(stack.Pop());
                        a = float.Parse(stack.Pop());
                        stack.Push((a / b).ToString());
                        break;
                    case "//":
                        y = Convert.ToInt32(stack.Pop());
                        x = Convert.ToInt32(stack.Pop());
                        stack.Push((a / b).ToString());
                        break;
                    case "%":
                        b = float.Parse(stack.Pop());
                        a = float.Parse(stack.Pop());
                        stack.Push((a % b).ToString());
                        break;
                    case "^":
                        b = float.Parse(stack.Pop());
                        a = float.Parse(stack.Pop());
                        stack.Push((Math.Pow(a, b)).ToString());
                        break;
                    case "!":
                        x = Convert.ToInt32(stack.Pop());
                        stack.Push((Factorial(x)).ToString());
                        break;
                    default:
                        stack.Push(arg);
                        break;
                }
                #endregion
            }

            if (stack.Count > 1)
            {
                Console.Write("Invalid RPN Input");
            }
            else
            {
                Console.Write(stack.Pop());
            }
        }
        public static int Factorial(int i)
        {
            if (i <= 1) return 1;
            return i * Factorial(i - 1);
        }
    }
}
