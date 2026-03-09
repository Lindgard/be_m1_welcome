namespace be_m1_welcome;

class Program
{
    static void Main(string[] args)
    {
        var currentDate = DateTime.Now;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hello, welcome to the message-generator");
        Console.ResetColor();
        while (true)
        {
            Console.WriteLine("Enter name:");

            string? userInput = Console.ReadLine();
            if (userInput != null && userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Exiting program...");
                Console.ResetColor();
                break;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Hello {userInput}\nThe time is: {currentDate}");
            Console.ResetColor();
        }
    }
}
