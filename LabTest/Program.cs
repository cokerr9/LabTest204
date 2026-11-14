using System;
using System.Windows.Forms;

namespace LabTest
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmCategory());
        }
    }
}
