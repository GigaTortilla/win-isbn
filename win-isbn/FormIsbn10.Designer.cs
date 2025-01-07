using System.ComponentModel;

namespace win_isbn;

partial class FormIsbn10
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        textBoxIsbn10 = new System.Windows.Forms.TextBox();
        checkIsbn10 = new System.Windows.Forms.Button();
        back = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxIsbn10
        // 
        textBoxIsbn10.Location = new System.Drawing.Point(74, 35);
        textBoxIsbn10.Name = "textBoxIsbn10";
        textBoxIsbn10.Size = new System.Drawing.Size(213, 23);
        textBoxIsbn10.TabIndex = 0;
        // 
        // checkIsbn10
        // 
        checkIsbn10.Location = new System.Drawing.Point(18, 169);
        checkIsbn10.Name = "checkIsbn10";
        checkIsbn10.Size = new System.Drawing.Size(69, 35);
        checkIsbn10.TabIndex = 1;
        checkIsbn10.Text = "Check";
        checkIsbn10.UseVisualStyleBackColor = true;
        // 
        // back
        // 
        back.Location = new System.Drawing.Point(93, 169);
        back.Name = "back";
        back.Size = new System.Drawing.Size(60, 35);
        back.TabIndex = 2;
        back.Text = "Back";
        back.UseVisualStyleBackColor = true;
        back.Click += back_Click;
        // 
        // FormIsbn10
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(368, 217);
        Controls.Add(back);
        Controls.Add(checkIsbn10);
        Controls.Add(textBoxIsbn10);
        Text = "FormIsbn10";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button back;

    private System.Windows.Forms.Button checkIsbn10;

    private System.Windows.Forms.TextBox textBoxIsbn10;

    #endregion
}