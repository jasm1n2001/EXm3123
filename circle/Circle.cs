namespace circle;

public class Circle
{
    private double _radius;
    private string _color;

    public Circle()
    {

    }

    public Circle(double radius)
    {
        _radius = radius;
    }

    public Circle(double radius, string color)
    {
        _radius = radius;
        _color = color;
    }

    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public string GetColor()
    {
        return $"{_color}";
    }
    public string SetColor(string color)
    {
        _color = color;
    }

    public string ToStrin()
    {
        return $"This is a radius {_radius}";
    }

    public double GetArea()
    {
        return 3.14 * (_radius *_radius);
    }


}
