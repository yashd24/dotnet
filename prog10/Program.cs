using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.Marshalling;




class Shape
{
    public virtual void draw()
    {
        Console.WriteLine("Drawing a generic shape");
    }
    public virtual void erase()
    {
        Console.WriteLine("erasing a generic shape");
    }
}

class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing a circle");
    }
    public override void erase()
    {
        Console.WriteLine("erasing a circle");
    }
}
class Square : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing a square");
    }
    public override void erase()
    {
        Console.WriteLine("erasing a square");
    }
}
class Triangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing a triangle");
    }
    public override void erase()
    {
        Console.WriteLine("erasing a triangle");
    }
}

class prog
{
    static void Main()
    {
        Circle c = new Circle();
        Triangle t = new Triangle();
        Square s = new Square();

        c.draw();
        c.erase();

        t.draw();
        t.erase();

        s.draw();
        s.erase();

    }
}