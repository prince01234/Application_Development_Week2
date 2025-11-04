// Create a class named Circle.
public class Circle
{
    //Inside the class, declare a constant variable named PI and initialize it with the value 3.14.
    const double PI = 3.14;

    //In the Main() method of Program.cs,
    //Try to modify the value of PI of the Circle class and observe the compilation error and explain the error.
    public Circle()
    {
        //PI = 3.14159; //it is causing compilation error
    }

    //create methods to calculate area and perimeter of the circle.
    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}