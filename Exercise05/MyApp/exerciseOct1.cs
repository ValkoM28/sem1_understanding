namespace Book;
public class Infobook
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{args[0]}");

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{args[1]}");

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"{args[2]}");

        Console.ResetColor();
    }
}

