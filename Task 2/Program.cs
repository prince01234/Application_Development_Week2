class Circle
{
    public const double Pi = 3.14;

    public double calculateArea(double radius)
    {
        return Pi * radius * radius;
    }

    public double calculatePerimeter(double radius)
    {
        double circumference = 2 * Pi * radius;
        return circumference;
    }

}

class Program
{
    static void Main()
    {

      //  Circle.Pi = 3.14159; // It is causing compilation error
    }
}