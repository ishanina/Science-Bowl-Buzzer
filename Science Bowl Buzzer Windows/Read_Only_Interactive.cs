using System;
using System.Windows.Forms;

public class Read_Only) : TextBox
{
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        return false;
    }
}