namespace win_isbn;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ISBN13 = new System.Windows.Forms.Button();
        ISBN10 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // ISBN13
        // 
        ISBN13.Cursor = System.Windows.Forms.Cursors.Hand;
        ISBN13.Location = new System.Drawing.Point(130, 152);
        ISBN13.Name = "ISBN13";
        ISBN13.Size = new System.Drawing.Size(105, 36);
        ISBN13.TabIndex = 0;
        ISBN13.Text = "ISBN-13";
        ISBN13.UseVisualStyleBackColor = true;
        ISBN13.Click += ISBN13_Click;
        ISBN13.KeyPress += FormExitApp_KeyPress;
        // 
        // ISBN10
        // 
        ISBN10.Cursor = System.Windows.Forms.Cursors.Hand;
        ISBN10.Location = new System.Drawing.Point(130, 96);
        ISBN10.Name = "ISBN10";
        ISBN10.Size = new System.Drawing.Size(105, 36);
        ISBN10.TabIndex = 1;
        ISBN10.Text = "ISBN-10";
        ISBN10.UseVisualStyleBackColor = true;
        ISBN10.Click += ISBN10_Click;
        ISBN10.KeyPress += FormExitApp_KeyPress;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(38, 31);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(298, 30);
        label1.TabIndex = 2;
        label1.Text = "Please choose which ISBN type you want to check for.";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(368, 217);
        Controls.Add(label1);
        Controls.Add(ISBN10);
        Controls.Add(ISBN13);
        Text = "win-isbn";
        KeyPress += FormExitApp_KeyPress;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button ISBN13;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button ISBN10;

    #endregion
}