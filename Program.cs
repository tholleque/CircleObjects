namespace CircleObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cirle Tester!");
            Console.WriteLine("Enter a radius:");
            bool goOn = true;
            while (goOn) { 
            bool tryRad = false;

                while (tryRad == false)
                {
                    try
                    {
                        tryRad = true;
                        double radius = double.Parse(Console.ReadLine());
                        Circle c = new Circle(radius);
                        Console.WriteLine("Diameter: " + c.CalculateDiameter());
                        Console.WriteLine("Circumference: " + c.CalculateCircumference());
                        Console.WriteLine("Area: " + c.CalculateArea());

                        Console.WriteLine("Should the circle grow?");
                        string grow = Console.ReadLine();
                        if (grow == "y")
                        {
                            c.Grow();
                            Console.WriteLine("Diameter: " + c.CalculateDiameter());
                            Console.WriteLine("Circumference: " + c.CalculateCircumference());
                            Console.WriteLine("Area: " + c.CalculateArea());
                            
                        }
                        else
                        {
                            double newRad = c.GetRadius();
                            Console.WriteLine("Goodbye! The circle's radius is: " + newRad);
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Please enter a valid number:");
                    }
                }
            }
        }
    }
}