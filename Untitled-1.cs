class quadrilateral :Shape
{
    //encapsulation
    private double longEdge;
    private double  shortEdge;
     public quadrilateral(double a,double b)
        {
            this.longEdge = a;
            this.shortEdge= b;
        }
        //Polymorphism
        public override double Area()
        {
            Console.WriteLine("quadrilateral area :");
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
            quadrilateral b = new quadrilateral(7, 8);
            Console.WriteLine(b.Area());

    }
}
