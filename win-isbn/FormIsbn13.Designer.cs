﻿using System.ComponentModel;

namespace win_isbn;

partial class FormIsbn13
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
        checkIsbn13 = new System.Windows.Forms.Button();
        back = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        contextLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // checkIsbn13
        // 
        checkIsbn13.Location = new System.Drawing.Point(18, 169);
        checkIsbn13.Name = "checkIsbn13";
        checkIsbn13.Size = new System.Drawing.Size(69, 35);
        checkIsbn13.TabIndex = 0;
        checkIsbn13.Text = "Check";
        checkIsbn13.UseVisualStyleBackColor = true;
        checkIsbn13.Click += checkIsbn13_Click;
        checkIsbn13.KeyPress += FormExitApp_KeyPress;
        // 
        // back
        // 
        back.Location = new System.Drawing.Point(93, 169);
        back.Name = "back";
        back.Size = new System.Drawing.Size(60, 35);
        back.TabIndex = 1;
        back.Text = "Back";
        back.UseVisualStyleBackColor = true;
        back.Click += back_Click;
        back.KeyPress += FormExitApp_KeyPress;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(74, 35);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(213, 23);
        textBox1.TabIndex = 2;
        // 
        // contextLabel
        // 
        contextLabel.Location = new System.Drawing.Point(74, 85);
        contextLabel.Name = "contextLabel";
        contextLabel.Size = new System.Drawing.Size(213, 55);
        contextLabel.TabIndex = 3;
        contextLabel.Text = "Please enter a number to check.";
        // 
        // FormIsbn13
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(368, 217);
        Controls.Add(contextLabel);
        Controls.Add(textBox1);
        Controls.Add(back);
        Controls.Add(checkIsbn13);
        Text = "FormIsbn13";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label contextLabel;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Button checkIsbn13;

    private System.Windows.Forms.Button back;

    #endregion
}