namespace CostCalculator;

class Program
{
    public const int AVERAGE_NUMBER_FLOORING = 20;
    public const double COST_PER_HOUR = 86.00;
    public const string USER_CHOICE_CIRCLE = "C";
    public const string USER_CHOICE_RECTANGLE = "R";

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tile Cost Calculator. Use this calculator to calculate the total amount of flooring needed.\n");
        double area = 0.0;

        //User choice of room shape
        string shapeType = string.Empty;
        Console.WriteLine("Enter type of room: C for circle or R for rectangle\n");
        shapeType = Console.ReadLine();

        if (shapeType == USER_CHOICE_CIRCLE)
        {
            Console.WriteLine("Enter radius of circle room\n");

            //User input and calculations for circle shaped rooms
            double roomRadius = 0.0;

            Console.Write("Enter radius\n");
            roomRadius = Double.Parse(Console.ReadLine());
            area = Math.PI * roomRadius * roomRadius;
            Console.WriteLine($"The area of the circle room is: {area}");
        }

        if (shapeType == USER_CHOICE_RECTANGLE)
        {
            Console.WriteLine("Enter length and width of rectangle room\n");

            //User input and calculations for rectangle shaped rooms
            double roomLength = 0.0;
            double roomWidth = 0.0;

            Console.WriteLine("Enter length\n");
            roomLength = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width\n");
            roomWidth = Double.Parse(Console.ReadLine());
            area = roomLength * roomWidth;
            Console.WriteLine($"The area of the floor is: {area}");
        }

        //The cost for tile flooring
        if (area > 0)
        {
            double costPerUnit = 0.0;
            double floorCost = 0.0;

            Console.WriteLine("Enter cost per 1 unit of flooring\n");
            costPerUnit = Double.Parse(Console.ReadLine());
            floorCost = area * costPerUnit;
            Console.WriteLine($"The total cost for tile flooring is: {floorCost}");

            //The cost for floor tiling labor
            double laborCost = 0.0;

            laborCost = area / AVERAGE_NUMBER_FLOORING * COST_PER_HOUR;
            Console.WriteLine($"The total cost for labor is: {laborCost}");
        }

        else
        {
            Console.WriteLine("Cost could not be calculated");
        }
    }
}

