using System;

class Program
{
    static int Method1(int a)
    {
        if (a % 2 == 0)
            return a / 2;
        else return 0;
    }
    public static void Main()
    {
        int a = Int32.Parse(Console.ReadLine());
        Console.WriteLine(Method1(a));
    }
}