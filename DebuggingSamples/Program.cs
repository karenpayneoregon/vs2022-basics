using SpectreConsoleLibrary;

namespace DebuggingSamples;
internal partial class Program
{
    static void Main(string[] args)
    {
        //BadExampleForAskingForInteger();
        //GetIntegerInputProactively();

        GetAndDisplayIntegerInput();

        SpectreConsoleHelpers.ExitPrompt();
    }

    private static void BadExampleForAskingForInteger()
    {
        try
        {
            Console.WriteLine("Enter your name:");
            var value = Console.ReadLine();
            int result = Convert.ToInt32(value);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    private static void GetIntegerInputProactively()
    {
        Console.WriteLine("Enter a integer:");
        
        var value = Console.ReadLine();
        if (int.TryParse(value, out int intValue))
        {
            Console.WriteLine($"You entered: {intValue}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    private static void GetAndDisplayIntegerInput()
    {
        SpectreConsoleHelpers.PrintPink();
        var value = Prompts.GetInt("Please enter an integer value");
        Console.WriteLine(value);
    }
}
