using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> ShapeList = new List<Shape>();

        Square newSquare = new Square("red", 8);
        ShapeList.Add(newSquare);
        
        // Old testing code from beginning of practice
        //Console.WriteLine(newSquare.GetColor());
        //Console.WriteLine(newSquare.GetArea());

        Rectangle newRectangle = new Rectangle("blue", 10, 30);
        ShapeList.Add(newRectangle);
        
        // Old testing code from beginning of practice
        //Console.WriteLine(newRectangle.GetColor());
        //Console.WriteLine(newRectangle.GetArea());

        Circle newCircle = new Circle("blue", 10);
        ShapeList.Add(newCircle);
        
        // Old testing code from beginning of practice
        //Console.WriteLine(newCircle.GetColor());
        //Console.WriteLine(newCircle.GetArea());

        foreach(Shape s in ShapeList)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}