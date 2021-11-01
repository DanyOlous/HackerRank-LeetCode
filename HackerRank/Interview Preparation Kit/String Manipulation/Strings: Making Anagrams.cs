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
     * Complete the 'makeAnagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING a
     *  2. STRING b
     */

    public static int makeAnagram(string a, string b)
    {
        var dict = new Dictionary<char, int>();
        foreach (char c in a)
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict.Add(c, 1);
        }
        foreach (char c in b)
        {
            if (dict.ContainsKey(c))
                dict[c]--;

            else
                dict.Add(c, -1);
        }
        int sum = 0;
        foreach (int i in dict.Values)
            sum += Math.Abs(i);
        return sum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = Result.makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
