using System;

class Program
{
    static string Ikkilik(int n)
    {
        if (n == 0) return "0";

        string result = "";

        while (n > 0)
        {
            int qoldiq = n % 2;
            result = qoldiq + result;
            n /= 2;
        }

        return result;
    }

    static void Main(string[] args)
    {

        Console.WriteLine(Ikkilik(10));
    }
}