using System;
using System.Data;

class prog4
{
    static void Main()
    {
        Stack st = new Stack();
        while (true)
        {
            Console.WriteLine("1. Push\n2. Pop\n3.Display \n4.Exit");
            Console.Write("Enter Choice:");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.Write("Enter The element:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    st.push(n);
                    break;

                case 2:
                    st.pop();
                    break;

                case 3:
                    st.display();
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

}

class Stack
{

    private const int max = 10;
    private int[] stack = new int[max];
    private int top = -1;
    public void push(int n)
    {
        if (top == max - 1)
        {
            Console.WriteLine("Stack Overflow!!");
        }

        else
        {
            stack[++top] = n;
        }
    }

    public int pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack underflow!!");
        }
        else
        {
            Console.WriteLine($"Popped Element: {stack[top--]}");
        }

        return 0;
    }

    public void display()
    {
        Console.WriteLine("Stack ELements");
        if (top == -1)
        {
            Console.WriteLine("Stack is empty.");
            return;
        }

        Console.WriteLine("Stack elements:");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(stack[i]);
        }
    }
}