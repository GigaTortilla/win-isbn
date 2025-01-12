namespace win_isbn;

public partial class FormIsbn13 : Form
{
    public FormIsbn13()
    {
        InitializeComponent();
    }

    private void FormExitApp_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Escape) Close();
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

    private void checkIsbn13_Click(object sender, EventArgs e)
    {
        var inputText = textBoxIsbn13.Text;
        contextLabel.Text = Program.CheckIsbn13(inputText)
            ? "The ISBN-13 you entered is valid"
            : "You did not enter a valid ISBN-13";
    }

    private void buttonConvert_Click(object sender, EventArgs e)
    {
        var isbn10 = Program.ConvertToIsbn10(textBoxIsbn13.Text);
        contextLabel.Text = isbn10 != null
            ? "The entered ISBN-13 number is equivalent to " + isbn10 + " in ISBN-10"
            : "You did not enter a valid ISBN-13 number";
    }
}