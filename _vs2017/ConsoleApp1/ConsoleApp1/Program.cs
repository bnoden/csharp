
using System;

class Program {
    static void Main(string[] args) {
        double dp, t;

        Console.Write("Enter the ratio D/P: ");

        dp = Convert.ToDouble(Console.ReadLine());
        t = (5730/Math.Log(2)*Math.Log(1+dp));

        Console.WriteLine(
            $"Given a D/P ratio of {dp} for C14, the age of the sample is {t:f2} years");
    }
};