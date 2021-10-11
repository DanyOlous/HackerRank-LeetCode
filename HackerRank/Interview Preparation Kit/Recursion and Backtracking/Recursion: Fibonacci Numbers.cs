using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    
    public static int Fibonacci(int n) {
        if (n >= 0 && n <= 1)
            return n;
        var dict = new Dictionary<int, int>();
        dict.Add(0, 0);
        dict.Add(1, 1);
        return Fibo(n, dict);
    }
    
    static int Fibo(int n, Dictionary<int, int> dict)
    {
        if (dict.ContainsKey(n))
            return dict[n];
        int _tempValue = Fibo(n - 1, dict) + Fibo(n - 2, dict);
        dict.Add(n, _tempValue);
        return _tempValue;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fibonacci(n));
    }
}
