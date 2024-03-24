using System;

class prog3
{

    static void Main()
    {
        Console.WriteLine("Enter a String");
        string a = Console.ReadLine();

        if (a.Length == 0)
        {
            Console.WriteLine("Empty String");
        }

        else
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 1; j <= a.Length - i; j++)
                {
                    Console.WriteLine(a.Substring(i, j));
                }
            }
        }
    }
}