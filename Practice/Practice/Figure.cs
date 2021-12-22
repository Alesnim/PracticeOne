public abstract class Figure
{
    private int _width;
    private int _height;

    public int Width { get; set; }

    public int Height { get; set; }


    public abstract int getSquare {get;}

}



public class Circle : Figure
{

    public Circle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override int getSquare => Width * Height;
}



public class Rectangle : Figure
{
    public Rectangle(int width, int height) {
        Width = width;
        Height = height;
    }
    public override int getSquare => Width * Height;
}


