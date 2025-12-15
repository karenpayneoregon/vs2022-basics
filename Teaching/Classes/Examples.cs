using System;
using System.Diagnostics;

// Needed for DateTimeFormatInfo.CurrentInfo
using System.Globalization;

using Teaching.Classes.Extensions;
using TeachingLibrary.Classes;
using TeachingLibrary.Models;

namespace Teaching.Classes;

internal class Examples
{
    /// <summary>
    /// PeopleListData has three people
    /// peopleSet will have only two people because HashSet prevents duplicates
    /// </summary>
    /// <remarks>
    /// HashSet automatically prevents duplicate entries. If you attempt to add
    /// an element that already exists, the operation is simply ignored, and no exception is thrown.
    /// </remarks>
    public static void ListToSet()
    {
        var people = MockedData.PeopleListData();
        ISet<Person> peopleSet = new HashSet<Person>(people);
        
        Debugger.Break();
    }
    /// <summary>
    /// TODO 
    /// </summary>
    public static void CurrentListMontNamesUsingForEach()
    {
        // Get the month names from the current culture's 
        var months = DateTimeFormatInfo.CurrentInfo.MonthNames[..^1].ToList();
        var index = 1;

        foreach (var month in months)
        {
            Console.WriteLine($"{index++,-4}{month}");
        }
    }
    
    /// <summary>
    /// Lists the names of the months using a foreach loop.
    /// </summary>
    public static void CurrentListMontNamesUsingForEachIndexed()
    {
        // Get the month names from the current culture's 
        var months = DateTimeFormatInfo.CurrentInfo.MonthNames[..^1].ToList();
        
        foreach (var (index, monthName) in months.Index())
        {
            Console.WriteLine($"{index,-4}{monthName}");
        }
    }
    
    /// <summary>
    /// Lists the names of the months using a foreach loop.
    /// </summary>
    public static void OldListMontNamesUsingForEach()
    {
        // Get the month names from the current culture's 
        var months = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12);
        var index = 1;

        foreach (var month in months)
        {
            Console.WriteLine($"{index++,-4}{month}");
        }
    }
}
