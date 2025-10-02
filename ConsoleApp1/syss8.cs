using System;

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
    
    public double Area => Width * Height; 

    public Rectangle (double width, double height)
    {
        Width = width;
        Height = height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle1 = new Rectangle(10, 5);
        Console.WriteLine($"Rektangel 1: Bredd = {rectangle1.Width}, Höjd = {rectangle1.Height}");
        Console.WriteLine($"Yta = {rectangle1.Area}");

        Rectangle rectangle2 = new Rectangle(7.5, 3.2);
        Console.WriteLine($"Rektangel 2: Bredd = {rectangle2.Width}, Höjd = {rectangle2.Height}");
        Console.WriteLine($"Yta = {rectangle2.Area}");
        Console.WriteLine("Test! För git");
    }
}

