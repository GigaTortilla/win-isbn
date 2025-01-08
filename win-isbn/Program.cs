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
        var checksum = text.Select((t, i) => (i + 1) * t.GetHashCode()).Sum();
        return checksum % 11 == 0;
    }

    public static bool CheckIsbn13(string text)
    {
        throw new System.NotImplementedException("CheckIsbn13 is not implemented");
    }

    [GeneratedRegex(@"[^0-9Xx]")]
    private static partial Regex MyRegex();
}