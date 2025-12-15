using Spectre.Console;

namespace SpectreConsoleLibrary;
public class Prompts
{
    // Default value style
    private static readonly Style Style = new(Color.Fuchsia, Color.Black, Decoration.None);
    public static string PromptStyleColor { get; set; } = "cyan";
    public static string PromptColor { get; set; } = "b";
    
    /// <summary>
    /// Prompts the user to enter an integer value.
    /// </summary>
    /// <returns>
    /// The integer value entered by the user. If no input is provided, a default value of <c>1</c> is returned.
    /// </returns>
    public static int GetInt() =>
        AnsiConsole.Prompt(
            new TextPrompt<int>("[cyan]Enter int[/]")
                .PromptStyle("yellow")
                .DefaultValue(1)
                .DefaultValueStyle(Style));

    /// <summary>
    /// Prompts the user to enter an integer value with a custom prompt message.
    /// </summary>
    /// <param name="prompt">The custom message displayed to the user when prompting for input.</param>
    /// <returns>
    /// The integer value entered by the user. If no input is provided, a default value of <c>1</c> is returned.
    /// </returns>
    public static int GetInt(string prompt) =>
        AnsiConsole.Prompt(
            new TextPrompt<int>($"[cyan]{prompt}[/]")
                .PromptStyle("yellow")
                .DefaultValue(1)
                .DefaultValueStyle(Style));


    /// <summary>
    /// Prompts the user to enter a date value, with an optional default date.
    /// </summary>
    /// <param name="defaultDate">
    /// The default date value displayed to the user if no input is provided. 
    /// If <c>null</c>, the current date is used as the default.
    /// </param>
    /// <returns>
    /// The <see cref="DateOnly"/> value entered by the user, or <c>null</c> if no valid input is provided.
    /// </returns>
    public static DateOnly? GetDateOnly(DateOnly? defaultDate)
    {
        var defaultValue = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        if (defaultDate.HasValue)
        {
            defaultValue = defaultDate.Value;
        }

        var input = AnsiConsole.Prompt(
            new TextPrompt<string>($"[{PromptColor}]Date[/]:")
                .PromptStyle(PromptStyleColor)
                .DefaultValue(defaultValue.ToString())
                .ValidationErrorMessage("[red]Please enter a valid date or press ENTER to not enter a date[/]")
                .AllowEmpty());

        return DateOnly.TryParse(input, out var date) ? date : null;
    }

    /// <summary>
    /// Prompts the user to enter a date value, with an optional default date and a custom prompt message.
    /// </summary>
    /// <param name="defaultDate">
    /// The default date value displayed to the user if no input is provided. 
    /// If <c>null</c>, the current date is used as the default.
    /// </param>
    /// <param name="prompt">
    /// The custom message displayed to the user when prompting for input.
    /// </param>
    /// <returns>
    /// The <see cref="DateOnly"/> value entered by the user, or <c>null</c> if no valid input is provided.
    /// </returns>
    public static DateOnly? GetDateOnly(DateOnly? defaultDate, string prompt)
    {
        var defaultValue = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        if (defaultDate.HasValue)
        {
            defaultValue = defaultDate.Value;
        }

        var input = AnsiConsole.Prompt(
            new TextPrompt<string>($"[{PromptColor}]{prompt}[/]:")
                .PromptStyle(PromptStyleColor)
                .DefaultValue(defaultValue.ToString())
                .ValidationErrorMessage("[red]Please enter a valid date or press ENTER to not enter a date[/]")
                .AllowEmpty());

        return DateOnly.TryParse(input, out var date) ? date : null;
    }
}
