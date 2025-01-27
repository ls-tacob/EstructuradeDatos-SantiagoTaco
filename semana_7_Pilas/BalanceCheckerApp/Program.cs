using System;
using System.Collections.Generic;

public class BalanceChecker
{
    public static bool IsBalanced(string expression)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in expression)
        {
            if (c == '{' || c == '[' || c == '(')
            {
                stack.Push(c);
            }
            else if (c == '}' || c == ']' || c == ')')
            {
                if (stack.Count == 0) return false;
                char top = stack.Pop();
                if (!IsMatchingPair(top, c)) return false;
            }
        }
        return stack.Count == 0;
    }

    private static bool IsMatchingPair(char open, char close)
    {
        return (open == '{' && close == '}') || (open == '[' && close == ']') || (open == '(' && close == ')');
    }

    public static void Main()
    {
        string expression = "{7+(8*5)-[(9-7)+(4+1)]}";
        Console.WriteLine($"¿Está la fórmula balanceada? {IsBalanced(expression)}");
    }
}
