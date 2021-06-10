using System;
using System.Collections.Generic;
using System.Linq;

namespace BracketPair
{
    class Program
    {
        static void Main(string[] args)
        {
            var brackets = new List<string>
            {
                "{[()]}",
                "{[(])}",
                "{ {[[(())]]} }"
            };

            for(int i = 0; i < brackets.Count; i++)
            {
                Console.WriteLine(Result.isBalanced(brackets[i].Replace(" ", "")));
            }
        }
    }

    class Result
    {
        public static string isBalanced(string s)
        {
            Stack<char> chars = new Stack<char>();
            char[] stringCharArray = s.ToCharArray(); 

            for (int i = 0; i < s.Length; i++)
            {
                if(stringCharArray[i] == '(' || stringCharArray[i] == '{' || stringCharArray[i] == '[')
                {
                    chars.Push(stringCharArray[i]);
                }
                else if(stringCharArray[i] == ')' || stringCharArray[i] == '}' || stringCharArray[i] == ']')
                {
                    if (chars.Count == 0 || !ArePair(chars.FirstOrDefault(), stringCharArray[i]))
                        return "NO";
                    else
                        chars.Pop();
                }
                else
                {
                    return "NO";
                }
            }

            return chars.Count == 0 ? "YES" : "NO";
        }

        private static bool ArePair(char openChar, char closeChar)
        {
            if (openChar == '(' && closeChar == ')')
                return true;

            else if (openChar == '{' && closeChar == '}')
                return true;

            else if (openChar == '[' && closeChar == ']')
                return true;

            return false;
        }
    }
}
