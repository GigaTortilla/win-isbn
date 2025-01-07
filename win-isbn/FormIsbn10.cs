namespace win_isbn;

public partial class FormIsbn10 : Form
{
    public FormIsbn10()
    {
        InitializeComponent();
    }

    private void back_Click(object sender, EventArgs e)
    {
        var f = new FormMain();
        f.Region = Region;
        f.Location = Location;
        f.StartPosition = FormStartPosition.Manual;
        f.Show();
        Close();
    }
}