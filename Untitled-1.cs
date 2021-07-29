class square :Shape,perimeterFounder
{
 private double Edge;
 public square(double a)
        {
            this.Edge = a;
            
        }
        public override double Area()
        {
            Console.WriteLine("square area :");
            return Edge*Edge;
        }
           public override double Perimeter()
        {
            
            return (Edge*4);
        }
}
class rectangle :Shape,perimeterFounder
{
    //encapsulation
    private double longEdge;
    private double  shortEdge;
    public quadrilateral(double a,double b)
        {
            this.longEdge = a;
            this.shortEdge= b;
        }
        public override double Area()
        {
            Console.WriteLine("rectangle area :");
            return longEdge*shortEdge;
        }
         public override double Perimeter()
        {
            
            return (2*shortEdge+longEdge*2);
        }
        
}

//inheritence
class circle :Shape,perimeterFounder
{
    private double r;
    private double PI=3;
    public Cirle(double r)
        {
            this.r = r;
        }
        //Polymorphism
        public override double Area()
        {
            Console.WriteLine("Circle area :");
            return PI * r * r;
        }
           public override double Perimeter()
        {
            
            return (PI*r*2);
        }

}
public class perimeterFounder:Shape {
 
    public void foundPerimeter (rectangle rectangle) {
        System.out.print(rectangle.Perimeter());
    }
 
    public void foundPerimeter (square square) {
        System.out.print(square.Perimeter());
    }
    public void foundPerimeter(circle circle) {
        System.out.print(circle.Perimeter());
    }
}
 public interface Shape
    {
        //abstraction
        public abstract double Area();
        public abstract double Perimeter();
    }

class TestClass
{
    static void Main(string[] args)
    {
            Cirle a = new Cirle(5);
            Console.WriteLine(a.Area());
            quadrilateral b = new rectangle(7, 8);
            Console.WriteLine(b.Area());
            square c= new square(4);
            Console.WriteLine(c.Area());
            perimeterFounder founder = new perimeterFounder();
            founder.foundPerimeter(a);
            founder.foundPerimeter(b);
            founder.foundPerimeter(c);

    }
}
