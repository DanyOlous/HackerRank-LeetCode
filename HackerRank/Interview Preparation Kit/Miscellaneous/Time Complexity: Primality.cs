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
     * Complete the 'primality' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER n as parameter.
     */

    public static string primality(int n)
    {
        int[] primeNumber = new int[] {2, 3, 5, 7, 11, 13, 17, 19, 23};
        if (primeNumber.Contains(n))
            return "Prime";
        if (prime(n))
            return "Prime";
        else
            return "Not prime";
    }
    
    private static bool prime(int n)
    {
        if (n == 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        for (int pItr = 0; pItr < p; pItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.primality(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
