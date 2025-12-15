using Teaching.Classes;
using Teaching.Classes.Extensions;
using TeachingLibrary.Models;

namespace Teaching;

internal class Program
{
        
    //ListMontNamesUsingForEach();
    //ListMontNamesUsingForEachWithIfStatement();
    //Examples.ListToSet();
    static void Main(string[] args)
    {

        Console.WriteLine("Press ENTER to exit...");
        Console.ReadLine();
    }
        
        

    /// <summary>
    /// Lists the names of the months using a foreach loop.
    /// </summary>
    /// <remarks>
    /// I do not understand the -4
    /// </remarks>
    private static void ListMontNamesUsingForEach()
    {
        var months = GetMonths();
        var index = 1;

        foreach (var month in months)
        {
            Console.WriteLine($"{index++,-4}{month}");
        }
    }

    /// <summary>
    /// Iterates through a list of month names and performs specific actions 
    /// based on conditional checks for the month "December".
    /// </summary>
    /// <remarks>
    /// This method demonstrates the use of a <c>foreach</c> loop combined with 
    /// <c>if</c> statements to evaluate and process specific conditions.
    /// </remarks>
    private static void ListMontNamesUsingForEachWithIfStatement()
    {
        var months = GetMonths();

        foreach (var month in months)
        {
            // Check if the month is exactly "December"
            if (month == "December")
            {
                    
            }

            // Check if the month is "december" (case-insensitive)
            if (string.Equals(month, "december", StringComparison.OrdinalIgnoreCase))
            {
                    
            }
        }
    }

    /// <summary>
    /// Retrieves a list of month names.
    /// </summary>
    /// <returns>
    /// A list of strings containing the names of all months in a year.
    /// </returns>
    /// <remarks>
    /// 1. Why is there a squiggly line under List&lt;string&gt;?
    /// 2. Is there a way to get the month names from the system instead of hardcoding them?
    /// 3. Why use List&lt;string&gt; ?
    /// </remarks>
    private static List<string> GetMonths()
    {
        return
        [
            "January", "February", "March", "April", "May", "June", "July",
            "August", "September", "October", "November", "December"
        ];
    }
}