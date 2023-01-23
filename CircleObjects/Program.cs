using System.Diagnostics.Metrics;
using CircleObjects;

int circle = 1;

bool restart = true;
while (restart)
{
    Console.WriteLine("Welcome to the Circle Tester!\n");

    Console.Write("Enter Radius of Circle: ");
    double value = double.Parse(Console.ReadLine());

    Console.WriteLine($"Circle {circle++}:");

    Circle myCircle = new Circle(value);
    Console.WriteLine($"Circimference: {myCircle.CalculateFormattedCircumference()}");
    Console.WriteLine($"Area: {myCircle.CalculateFormattedArea()}");

    Console.WriteLine();
    exitProgram(ref restart);
}
Console.WriteLine($"You created {circle - 1} Circle Objects. Goodbye!!");


static void exitProgram(ref bool x)
{
    while (true)
    {
        Console.Write("Continue? (y/n): ");
        string answer = Console.ReadLine().ToLower().Trim();

        if (answer.Contains('y'))
        {
            Console.Clear();
            break;
        }
        else if (answer.Contains('n'))
        {
            x = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid Entry.");
        }
    }
}