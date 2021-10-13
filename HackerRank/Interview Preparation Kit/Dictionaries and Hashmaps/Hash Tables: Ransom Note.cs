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
     * Complete the 'checkMagazine' function below.
     *
     * The function accepts following parameters:
     *  1. STRING_ARRAY magazine
     *  2. STRING_ARRAY note
     */

    public static void checkMagazine(List<string> magazine, List<string> note)
    {
        if (check(magazine, note))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }

    public static bool check(List<string> magazine, List<string> note)
    {
        var dict = new Dictionary<string, int>();
        foreach (string word in magazine)
        {
            if (dict.ContainsKey(word))
            {
                dict[word]++;
                continue;
            }
            dict.Add(word, 1);
        }
        foreach (string word in note)
        {
            if (dict.ContainsKey(word) && dict[word] > 0)
            {
                dict[word]--;
                continue;
            }
            return false;
        }
        return true;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(firstMultipleInput[0]);

        int n = Convert.ToInt32(firstMultipleInput[1]);

        List<string> magazine = Console.ReadLine().TrimEnd().Split(' ').ToList();

        List<string> note = Console.ReadLine().TrimEnd().Split(' ').ToList();

        Result.checkMagazine(magazine, note);
    }
}
