namespace circle;

public class Cylinder : Circle
{
    private double _height;

    public Cylinder()
    {

    }

    public Cylinder(double height)
    {
        _height = height;
    }

    public Cylinder(double height, double radius, string color)
    {
        _height = height;
        SetRadius(radius);
    }

    public Cylinder(double height, double radius, sbyte color)
    {
        _height = height;
        SetRadius(radius);
        SetColor(color);
    }

    public double GetHeight()
    {
        return _height;
    }
    public void SetHeight(double height)
    {
        _height = height;
    }

    public  override  ToStrin()
    {
        return "This is a height {height} ";
    }

    public double GetVolume()
    {
        return 2 * (_height * GetRadius);
    }
}

