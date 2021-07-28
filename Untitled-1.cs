class quadrilateral :Shape
{
double longEdge;
double  shortEdge;
     public quadrilateral(double a,double b)
        {
            this.longEdge = a;
            this.shortEdge= b;
        }
        public override double Area()
        {
            Console.WriteLine("quadrilateral area :");
            return longEdge*shortEdge;
        }
 
    
}
class circle :Shape
{
    double r;
    double PI=3;
    public Cirle(double r)
        {
            this.r = r;
        }
        public override double Area()
        {
            Console.WriteLine("Circle area :");
            return PI * r * r;
        }

}
 public abstract class Shape
    {
        public abstract double Area();
    }
    