using System;

class prog1{
    static void Main(){
        Console.WriteLine("Calculator");
        int a,b,c,res;
        Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
        Console.WriteLine("Enter your choice");
        c = Convert.ToInt32(Console.ReadLine());

        switch(c){
            case 1:
                Console.WriteLine("Enter two numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                res = a + b;
                Console.WriteLine("Result: " + res);
                break;

            case 2:
                Console.WriteLine("Enter two numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                res = a - b;
                Console.WriteLine("Result: " + res);
                break;

            case 3:
                Console.WriteLine("Enter two numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                res = a * b;
                Console.WriteLine("Result: " + res);
                break;

            case 4:
                Console.WriteLine("Enter two numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                res = a / b;
                Console.WriteLine("Result: " + res);
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}