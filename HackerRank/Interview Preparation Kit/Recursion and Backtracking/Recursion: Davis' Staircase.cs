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
     * Complete the 'stepPerms' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */
     
    public static int stepPerms(int n) {
        if (n == 0)
            return 1;
        if (n == 1)
            return 1;
        if (n == 2)
            return 2;
        if (n == 3)
            return 4;
        if (n == 4)
            return 7;
        if (n == 5)
            return 13;
        if (n == 6)
            return 24;
        if (n == 7)
            return 44;
        else
            return stepPerms(n - 1) + stepPerms(n - 2) + stepPerms(n - 3);
    }


    /*public static int stepPerms(int n)
    {
        var dict = new Dictionary<int, int>();
        dict.Add(0, 1);
        dict.Add(1, 1);
        dict.Add(2, 2);
        dict.Add(3, 4);
        dict.Add(4, 7);
        dict.Add(5, 13);
        dict.Add(6, 24);
        dict.Add(7, 44);
        if (!dict.ContainsKey(n))
            dict.Add(n, stepPerms(n - 1) + stepPerms(n - 2) + stepPerms(n - 3));
        return dict[n];
    }*/
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int s = Convert.ToInt32(Console.ReadLine().Trim());

        for (int sItr = 0; sItr < s; sItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int res = Result.stepPerms(n);

            textWriter.WriteLine(res);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
