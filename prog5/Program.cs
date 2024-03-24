using System;

class prog5
{
    static void Main()
    {
        Console.WriteLine("Pascals Triangle");
        Console.WriteLine("Enter number of rows:");
        int row = Convert.ToInt32(Console.ReadLine());
        int c = 1;
        int[,] pascal = new int[row, row];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || i == j)
                {
                    pascal[i, j] = 1;
                }
                else
                {
                    pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j];
                }
            }
        }

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(pascal[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}