﻿using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Create a new action that will be used to ask for two integers and then display calculation in a message box
// The public function can be called from other scripts
// The private function is only called under this action and can't be called from other scripts

// Load script in Eplan using [Utilities]>[Scripts]>[Load]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [DeclareAction("MethodInt")]
    public void Function(int INT1, int INT2)
    {
        CalcMessageBox(INT1, INT2);
        FinishedMessageBox2();

        return;
    }

    private static void CalcMessageBox(int INT1, int INT2)
    {
        int intResult = INT1 + INT2;
        MessageBox.Show(INT1.ToString() + " + " + INT2.ToString() + " = " + intResult.ToString());

        return;
    }

    private static void FinishedMessageBox2()
    {
        MessageBox.Show("Calculation completed.");

        return;
    }
}



