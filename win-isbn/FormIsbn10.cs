namespace win_isbn;

public partial class FormIsbn10 : Form
{
    public FormIsbn10()
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

    private void checkIsbn10_Click(object sender, EventArgs e)
    {
        var inputText = textBoxIsbn10.Text;
        if (Program.CheckIsbn10(inputText))
        {
            contextLabel.Text = "The ISBN-10 you entered is valid";
            var countryCode = Program.GetRegistrationGroup(inputText);
            if (countryCode != null) contextLabel.Text += "\nAgency: " + countryCode;
        }
        else contextLabel.Text = "You did not enter a valid ISBN-10";
    }

    private void buttonConvert_Click(object sender, EventArgs e)
    {
        var isbn13 = Program.ConvertToIsbn13(textBoxIsbn10.Text);
        contextLabel.Text = isbn13 != null
            ? "The ISBN-10 you entered is equivalent to " + isbn13 + " in ISBN-13"
            : "You did not enter a valid ISBN-10";
    }
}