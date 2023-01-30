class Program
{
    static void Main(string[] args)
    {
        Circle crc = new Circle(3, 4, 6);
        Sphere ccc = new Sphere(3, 4, 6, 9);
        Console.WriteLine("s = " + crc.SquareC(crc.r));
        Console.WriteLine("v = " + ccc.SquareC(ccc.r));
        Console.Read();
    }
}
class Circle
{
    public double x, y, r;
 
    public Circle(double arg1, double arg2, double arg3)
    {
        x = arg1; 
        y = arg2;
        r = arg3;
    }
 
    // Вычисление площади круга
    public virtual double SquareC(double arg)
    {
        double s = Math.PI * arg * arg;
        return s;
    }
}
class Sphere: Circle
{
    public double h;
 
    public Sphere (double arg1, double arg2, double arg3, double arg4) : base(arg1, arg2, arg3)
    {
        h = arg4;
    }
 
    // V=1 ⅓ π R³ - объем сферы
    public override double SquareC(double arg)
    {
        double v = Math.PI * arg * arg * h / 3.0;
        return v;
    }
}