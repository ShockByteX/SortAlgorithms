using System;
using System.Windows.Forms;
using SortAlgorithms.GUI.Forms;

namespace SortAlgorithms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
