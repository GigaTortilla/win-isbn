namespace win_isbn;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    private void FormExitApp_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Escape) Close();
    }
    
    private void ISBN10_Click(object sender, EventArgs e)
    {
        var f = new FormIsbn10();
        f.Region = Region;
        f.Location = Location;
        f.StartPosition = FormStartPosition.Manual;
        f.Show();
        Close();
    }

    private void ISBN13_Click(object sender, EventArgs e)
    {
        var f = new FormIsbn10();
        f.Region = Region;
        f.Location = Location;
        f.StartPosition = FormStartPosition.Manual;
        f.Show();
        Close();
    }
}