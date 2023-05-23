using Lab_8_C_;

class Program
{
    static void Main()
    {
        List<Expression> expressions = new List<Expression>();
    start:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Enter the operands:");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("A:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("B:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("C:");
        double c = double.Parse(Console.ReadLine());
        Console.Write("D:");
        double d = double.Parse(Console.ReadLine());
        Expression expr = new Expression(a, b, c, d);
        Console.WriteLine("Your operands: a({0}), b({1}), c({2}), d({3})", a, b, c, d);
        expressions.Add(expr);
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter 1 if you want to get the result");
            Console.WriteLine("Enter 2 if you want to change operands");
            Console.ForegroundColor = ConsoleColor.White;
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                expr.Print();
            }
            else if (choice == "2")
            {
                Console.Clear();
                goto start;
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
