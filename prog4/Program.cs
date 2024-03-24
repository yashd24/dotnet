using System;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Intrinsics.Arm;

interface Resizable
{
    void resizeWidth(int width);
    void resizeheight(int height);

}
class Rectangle : Resizable
{
    private int height, width;
    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;

    }

    public void resizeWidth(int newwidth)
    {
        width = newwidth;
        Console.WriteLine($"Resized to {newwidth}");
    }
    public void resizeheight(int newheight)
    {
        height = newheight;
        Console.WriteLine($"Resized to {newheight}");
    }

    public void display()
    {
        Console.WriteLine($"Rectangle:- \nwidth = {} ");
    }
}


class Prog
{
    static void Main()
    {


    }
}
