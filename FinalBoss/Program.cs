// See https://aka.ms/new-console-template for more information

// Создать класс Point. На его основе создать классы ColoredPoint и Line
// На основе класса Line создать класс ColoredLine и PolyLine (многоугольник).
// В классах описать следующие элементы:
// - конструкторы с параметрами и конструкторы по умолчанию
// - свойства для установки и получения значений всех координат, а также для изменения цвета и получения текущего цвета
// - для линий - методы изменения угла поворота линий относительно первой точки
// - для многоугольника - метод масштабирования

using System.Drawing;

Console.WriteLine("Hello, World!");

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }
    
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void SetPoint(double newX, double newY)
    {
        X = newX;
        Y = newY;
    }

    public void GetCoords()
    {
        Console.WriteLine($"X: {X}\nY: {Y}");
    }
}

public class ColoredPoint : Point
{
    public double X { get; set; }

    public double Y { get; set; }

    public Color Color { get; set; }
    
    public ColoredPoint(double x, double y, Color color) : base(x, y)
    {
        X = x;
        Y = y;
        Color = color;
    }

    public void GetColor()
    {
        Console.WriteLine($"Color: {Color.Name}");
    }

    public void SetColor(Color color)
    {
        Color = color;
    }
}

public class Line : Point
{
    public double X2 { get; set; }

    public double Y2 { get; set; }
    
    public Line(double x1, double y1, double x2, double y2) : base(x1, y1)
    {
        X = x1;
        Y = y1;
        X2 = x2;
        Y2 = y2;
    }

    public void GetInfo()
    {
        Console.WriteLine("X: " + X);
        Console.WriteLine("Y: " + Y);
        Console.WriteLine("X2: " + X2);
        Console.WriteLine("Y2: " + Y2);
    }

    public void ChangeCoords(double x2, double y2)
    {
        X2 = x2;
        Y2 = y2;
    }
}

public class ColoredLine : Line
{
    public Color Color { get; set; }
    
    public ColoredLine(double x1, double y1, double x2, double y2, Color color) : base(x1, y1, x2, y2)
    {
        X = x1;
        Y = y1;
        X2 = x2;
        Y2 = y2;
        Color = color;
    }
    
    public void GetInfo()
    {
        Console.WriteLine("X: " + X);
        Console.WriteLine("Y: " + Y);
        Console.WriteLine("X2: " + X2);
        Console.WriteLine("Y2: " + Y2);
        Console.WriteLine("Color: " + Color.Name);
    }
    
    public void SetColor(Color color)
    {
        Color = color;
    }
}

public class Polyline : Line
{
    public double X3 { get; set; }

    public double Y3 { get; set; }
    
    public Polyline(double x1, double y1, double x2, double y2, double x3, double y3) : base(x1, y1, x2, y2)
    {
        X = x1;
        Y = y1;
        X2 = x2;
        Y2 = y2;
        X3 = x3;
        Y3 = y3;
    }

    public void GetInfo()
    {
        Console.WriteLine("X1: " + X);
        Console.WriteLine("Y1: " + Y);
        Console.WriteLine("X2: " + X2);
        Console.WriteLine("Y2: " + Y2);
        Console.WriteLine("X3: " + X3);
        Console.WriteLine("Y3: " + Y3);
    }
    
    public void SetPolyline(double x3, double y3)
    {
        X3 = x3;
        Y3 = y3;
    }

    public void Resize(double resizeX)
    {
        X = X * resizeX;
        Y = Y * resizeX;
        X2 = X2 * resizeX;
        Y2 = Y2  * resizeX;
        X3 = X3 * resizeX;
        Y3 = Y3 * resizeX;
        
    }
}