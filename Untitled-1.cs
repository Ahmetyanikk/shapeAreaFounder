class square :Shape
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
}
class rectangle :Shape
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
}

//inheritence
class circle :Shape
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

}
public class perimeterFounder {
 
    public void foundPerimeter (rectangle rectangle) {
        System.out.print(2*rectangle.shortEdge+rectangle.longEdge*2);
    }
 
    public void foundPerimeter (square square) {
        System.out.print(square.Edge*4);
    }
    public void foundPerimeter(circle circle) {
        System.out.print(circle.PI*circle.r*2);
    }
}
 public interface Shape
    {
        //abstraction
        public abstract double Area();
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
