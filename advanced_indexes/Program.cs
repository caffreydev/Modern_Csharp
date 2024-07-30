using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var text = "0123456789";
        var numbers = new List<int> { 10, 20, 30, 40, 50 };

        int n = 1;
        Console.WriteLine(text[^n]);
        Console.WriteLine(numbers[^(n + 2)]);
    }
}