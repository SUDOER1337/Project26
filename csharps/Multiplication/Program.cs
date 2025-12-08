using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number:");
        int Number = int.Parse(Console.ReadLinel);
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine(Number + "*" + i + "=" + Number * i);
        }
    }
}