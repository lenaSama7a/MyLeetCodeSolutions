using System;
using System.Collections;

namespace MyLeetCodeSolutions
{
    public class Question6
    {
        public static bool IsValid(string s)
        {
            Stack stack = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{' || s[i] == '[' || s[i] == '(')
                    stack.Push(s[i]);
                else
                {
                    if (stack.Count == 0)
                        return false;
                    else
                    {
                        if (s[i] == '}')
                        {
                            if (stack.Peek().Equals('{'))
                                stack.Pop();
                            else 
                                return false;
                        }
                        else if (s[i] == ']')
                        {
                            if (stack.Peek().Equals('['))
                                stack.Pop();
                            else 
                                return false;
                        }
                        else if (s[i] == ')')
                        {
                            if (stack.Peek().Equals('('))
                                stack.Pop();
                            else 
                                return false;
                        }
                    }

                }
            }
            if (stack.Count == 0)
                return true;
            else 
                return false;

        }
    }
}