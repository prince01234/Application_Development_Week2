// Create a class named Circle.
class Circle

{
    //Inside the class, declare a constant variable named PI and initialize it with the value 3.14
    public const double PI = 3.14;

    //Try to modify the value of PI of the Circle class and observe the compilation error and explain the error. 
    public void ModifyPI()
    {
        PI = 3.9999;
    }
}