namespace be_m1_welcome;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hello, welcome to the message-generator");
        Console.ResetColor();
        while (true)
        {
            Console.WriteLine("Enter name:");

            var userInput = Console.ReadLine();
            if (userInput != null && userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Exiting program...");
                Console.ResetColor();
                break;
            }
            var currentDate = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Hello {userInput}\nThe time is: {currentDate}");
            Console.ResetColor();
        }
    }
}
