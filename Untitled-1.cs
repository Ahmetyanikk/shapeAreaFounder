using System;
class TestClass
{
    static void Main(string[] args)
    {
        circle a = new circle(5);
        Console.WriteLine(a.Area());
        rectangle b = new rectangle(7, 8);
        Console.WriteLine(b.Area());
        square c = new square(4);
        Console.WriteLine(c.Area());
        perimeterFounder founder = new perimeterFounder();
        founder.foundPerimeter(a);
        founder.foundPerimeter(b);
        founder.foundPerimeter(c);

    }
    public interface Shape
    {
        //abstraction
         double Area();
         double Perimeter();
    }
    class square : Shape
{
    private double Edge;
    public square(double a)
    {
        this.Edge = a;

    }
    public  double Area()
    {
        Console.WriteLine("square area :");
        return Edge * Edge;
    }
    public  double Perimeter()
    {

        return (Edge * 4);
    }
}
class rectangle : Shape 
{
    //encapsulation
    private double longEdge;
    private double shortEdge;
    public rectangle(double a, double b)
    {
        this.longEdge = a;
        this.shortEdge = b;
    }
    public  double Area()
    {
        Console.WriteLine("rectangle area :");
        return longEdge * shortEdge;
    }
    public  double Perimeter()
    {

        return (2 * shortEdge + longEdge * 2);
    }

}

//inheritence
class circle : Shape
{
    private double r;
    private double PI = 3;
    public circle(double r)
    {
        this.r = r;
    }
    //Polymorphism
    public  double Area()
    {
        Console.WriteLine("Circle area :");
        return PI * r * r;
    }
    public  double Perimeter()
    {

        return (PI * r * 2);
    }

}
public class perimeterFounder 
    { 

    public void foundPerimeter(Shape shape)
    {
        Console.WriteLine(shape.Perimeter());
    }

   
}



}
