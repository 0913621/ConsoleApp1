using System;

class Program
{
    public static void Main()
    {
        string s = "";
        for (int i = 5; i <= 10; i += 2)
            s += i + " ";

        for (int i = 10; i >= 3; i--)
            if (i % 2 == 0)
                s += i + " ";
        Console.WriteLine(s);
    }
}

