namespace win_isbn;

using System.Text.RegularExpressions;

internal static partial class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        var entryForm = new FormMain();
        entryForm.FormClosed += MyFormClosed;
        entryForm.Show();
        Application.Run();
    }

    private static void MyFormClosed(object? sender, FormClosedEventArgs e)
    {
        if (Application.OpenForms.Count < 1) Application.Exit();
        else Application.OpenForms[0].FormClosed += MyFormClosed;
    }

    public static bool CheckIsbn10(string text)
    {
        // check for input string length 
        if (text.Length != 10) return false;
        
        // check for invalid characters
        var match = MyRegex().Match(text);
        if (match.Success) return false;
        
        // check for invalid 'x' char positions
        var posLowerX = (short)text.IndexOf('x');
        var posUpperX = (short)text.IndexOf('X');
        if (posLowerX is > -1 and < 9 || posUpperX is > -1 and < 9) return false;
        
        // calculate checksum using LINQ
        // if the selected char is not a number it has to be either 'x' or 'X'
        // because of the regex filter
        var checksum = text.Select((t, i) => (i + 1) * (char.IsNumber(t) ? t - '0' : 10)).Sum();
        return checksum % 11 == 0;
    }

    public static bool CheckIsbn13(string text)
    {
        // check for input string length
        if (text.Length != 13) return false;
        
        // check for invalid characters
        if (!long.TryParse(text, out _)) return false;
        
        // calculate checksum using LINQ
        var checksum = text.Select((t, i) => (t - '0') * (i % 2 == 0 ? 1 : 3)).Sum();
        return checksum % 10 == 0;
    }
    
    public static string? ConvertToIsbn10(string isbn13)
    {
        if (!CheckIsbn13(isbn13)) return null;

        var partialIsbn10 = isbn13.Substring(3, 9);
        var weight = 10;
        var checksum = 0;
        foreach (var c in partialIsbn10)
        {
            checksum += (c - '0') * weight;
            weight--;
        }
        checksum = 11 - checksum % 11;
        return partialIsbn10 + (checksum == 10 ? "X" : checksum.ToString());
    }

    public static string? ConvertToIsbn13(string isbn10)
    {
        if (!CheckIsbn10(isbn10)) return null;
        
        var partialIsbn13 = "978" + isbn10[..^1];
        var checksum = 0;
        for (var i = 0; i < 12; i++) checksum += (partialIsbn13[i] - '0') * (i % 2 == 0 ? 1 : 3);
        checksum = 10 - checksum % 10;
        return partialIsbn13 + checksum;
    }

    [GeneratedRegex(@"[^0-9Xx]")]
    private static partial Regex MyRegex();
}