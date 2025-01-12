﻿namespace win_isbn;

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
        contextLabel.Text = Program.CheckIsbn10(inputText) ? "The ISBN-10 you entered is valid" : "You did not enter a valid ISBN-10";
    }
}