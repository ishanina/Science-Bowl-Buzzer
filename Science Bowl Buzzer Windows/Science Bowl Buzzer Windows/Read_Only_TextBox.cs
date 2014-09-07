using System;
using System.Windows.Forms;

public class MyTextBox : TextBox
{
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        return false;
    }
}