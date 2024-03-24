using System;

class prog2
{

    static void Main()
    {

        Console.WriteLine("ArmStrong No:");


        for (int i = 0; i <= 1000; i++)
        {

            if (isArmstrongNo(i))
            {
                Console.WriteLine(i);
            }
        }

    }

    static bool isArmstrongNo(int n)
    {

        int original = n;
        int sum = 0;
        int num = countDigits(n);

        while (n > 0)
        {
            int dig = n % 10;
            sum += (int)Math.Pow(dig,num);
            n /= 10;
        }
        return sum == original;
    }

    static int countDigits(int n)
    {
        int c = 0;
        while (n > 0)
        {
            n = n / 10;
            c++;
        }
        return c;
    }
}