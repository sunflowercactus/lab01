using System;
class Point                        
{   private int x;
    private int y;
    public int X                   
    {
        get { return x; }
    }
    public int Y
    {
        get { return y; }
    }
    public Point(int x, int y)     
    {
        this.x = x;                
        this.y = y;
    }
}
class Figure                       
{
    private Point[] points;
    private string name;
    public Figure(Point p1, Point p2, Point p3, Point p4)
    {   points = new Point[4];
        points[0] = p1;
        points[1] = p2;
        points[2] = p3;
        points[3] = p4;
    }
    public string Name
    { get {return name;}
      set {name = value;}
    }
    public double LengthSide(Point A, Point B)
    {int dx = A.X - B.X;
        int dy = A.Y - B.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public void PerimeterCalculator()
    {   double perimeter = 0;
        for (int i = 0; i < points.Length-1; i++)
        { perimeter += LengthSide(points[i], points[i+1]);}
        if (points.Length > 2)
        { perimeter += LengthSide(points[points.Length-1], points[0]);}
        Console.WriteLine(name);
        Console.WriteLine(perimeter);
    }
}
class Program
{static void Main(string[] args)
    {   Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 5);
        Point p3 = new Point(5, 5);
        Point p4 = new Point(5, 0);
        Figure rectangle = new Figure(p1, p2, p3, p4); 
        rectangle.PerimeterCalculator();
    }
}
