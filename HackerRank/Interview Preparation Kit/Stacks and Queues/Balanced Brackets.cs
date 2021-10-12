using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isBalanced(string s)
    {
        if (s.Count() % 2 != 0)
            return "NO";
        else if (Balance(s))
            return "YES";
        else
            return "NO";
    }
    
    static bool Balance(string s)
    {
        Stack<char> stk = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stk.Push(c);
                continue;
            }
            if (stk.Count != 0)
            {
                char tmp = stk.Peek();
                if (c == ']')
                {
                    if (tmp == '[')
                    {
                        stk.Pop();
                        continue;
                    }
                }
                if (c == '}')
                {
                    if (tmp == '{')
                    {
                        stk.Pop();
                        continue;
                    }
                }
                if (c == ')')
                {
                    if (tmp == '(')
                    {
                        stk.Pop();
                        continue;
                    }
                }
            }
            else
                return false;
        }
        return (stk.Count == 0);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = Result.isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
