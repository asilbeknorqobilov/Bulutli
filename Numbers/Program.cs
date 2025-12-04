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

    
    static string Sakkizlik(int n)
    {
        if (n == 0) return "0";
        string result = "";
        while (n > 0)
        {
            int remainder = n % 8;
            result = remainder + result;
            n /= 8;
        }
        return result;
    }
    
    static void Main(string[] args)
    {

        Console.WriteLine(Ikkilik(10));
    }
}