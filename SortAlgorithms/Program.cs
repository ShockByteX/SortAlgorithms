using System;
using System.Windows.Forms;
using SortAlgorithms.Core.Data;
using SortAlgorithms.GUI.Forms;
using SortAlgorithms.Helpers;

namespace SortAlgorithms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int[] array = new int[10];
            array.FillRandom(-200, 200);
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            for (int i = 0; i < array.Length; i++) tree.Add(array[i]);
            //int min = tree.FindMin(tree.Root).Item;
            Application.Run(new MainForm());
        }
    }
}
