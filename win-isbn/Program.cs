namespace win_isbn;

internal static class Program
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
}