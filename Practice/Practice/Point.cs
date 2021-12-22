public class Point
{

    public int X { get; set; }

    public int Y { get; set; }


    public Point()
    {
        X = Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void AddNumber(int n)
    {
        X += n;
        Y += n;
    }

    public void MinusNumber(int n) {
        X -= n;
        Y -= n;
    }


    public void AddPoint(Point p) {
        X += p.X;
        Y += p.Y;
    }

    public void MinusPoint(Point p) {
        X -= p.X;
        Y -= p.Y;
    }
}