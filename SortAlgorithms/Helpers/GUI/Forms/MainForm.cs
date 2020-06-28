using SortAlgorithms.Core;
using System;
using System.Windows.Forms;
using System.Reflection;
using SortAlgorithms.GUI.Models;
using SortAlgorithms.GUI.Controls;
using SortAlgorithms.Helpers;

namespace SortAlgorithms.GUI.Forms
{
    public enum ArrayCreationType : byte { Shuffle, Random }
    public partial class MainForm : Form
    {
        private int[] _array;
        public MainForm()
        {
            InitializeComponent();
            Type[] types = AssemblyHelper.GetTypes(Assembly.GetAssembly(typeof(Sorter<int>)), $"{nameof(SortAlgorithms)}.{nameof(Core)}.{nameof(Core.Sorts)}");
            foreach (Type type in types)
            {
                if (type.BaseType.Name == typeof(Sorter<int>).Name) cbSortType.Items.Add(new SortType(type));
            }
            cbSortType.SelectedIndex = 0;
            nRandomFrom.Enabled = false;
            nRandomTo.Enabled = false;
            cbArrayCreationType.Items.AddRange(Enum.GetNames(typeof(ArrayCreationType)));
            cbArrayCreationType.SelectedIndex = 0;
            cbArrayCreationType.SelectedIndexChanged += cbArrayCreationType_SelectedIndexChanged;
            pnlSorts.AutoScroll = true;
        }
        private void cbArrayCreationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((ArrayCreationType)cbArrayCreationType.SelectedIndex)
            {
                case ArrayCreationType.Shuffle:
                    nRandomFrom.Enabled = nRandomTo.Enabled = false;
                    break;
                case ArrayCreationType.Random:
                    nRandomFrom.Enabled = nRandomTo.Enabled = true;
                    break;
                default: throw new NotSupportedException();
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int[] array = new int[Convert.ToInt32(nArrayLength.Value)];
            switch (cbArrayCreationType.SelectedIndex)
            {
                case 0: array.FillShuffle(); break;
                case 1: array.FillRandom(Convert.ToInt32(nRandomFrom.Value), Convert.ToInt32(nRandomTo.Value)); break;
                default: throw new NotSupportedException();
            }
            _array = array;
            foreach (SortViewer control in pnlSorts.Controls)
            {
                control.ApplyArray(_array);
            }
        }
        private void BtnSort_Click(object sender, EventArgs e)
        {
            foreach (SortViewer viewer in pnlSorts.Controls) viewer.Sort();
        }
        private void btnAddSort_Click(object sender, EventArgs e)
        {
            SortViewer viewer = new SortViewer(((SortType)cbSortType.SelectedItem), Convert.ToInt32(nSortDelay.Value))
            {
                Width = Convert.ToInt32(nWidth.Value),
                Height = Convert.ToInt32(nHeight.Value),
            };
            if (_array != null) viewer.ApplyArray(_array);
            pnlSorts.Controls.Add(viewer);
        }
        private void btnApplySortViewSize_Click(object sender, EventArgs e)
        {
            foreach (SortViewer viewer in pnlSorts.Controls)
            {
                viewer.Width = Convert.ToInt32(nWidth.Value);
                viewer.Height = Convert.ToInt32(nHeight.Value);
            }
        }
    }
}
