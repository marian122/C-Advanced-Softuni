using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputParentheses = Console.ReadLine();

            char[] validOpeningParentheses = new char[] { '(', '{', '[' };

            Stack<char> stack = new Stack<char>();

            bool isValid = true;

            for (int i = 0; i < inputParentheses.Length; i++)
            {
                if (validOpeningParentheses.Contains(inputParentheses[i]))
                {
                    stack.Push(inputParentheses[i]);
                    continue;
                }
                if (stack.Count == 0)
                {
                    isValid = false;
                    break;

                }
                if (stack.Peek() == '(' && inputParentheses[i] == ')')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '{' && inputParentheses[i] == '}')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '[' && inputParentheses[i] == ']')
                {
                    stack.Pop();
                }
            }
            if (stack.Count == 0 && isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
