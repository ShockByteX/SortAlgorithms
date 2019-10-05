using System;
using System.Threading;
using System.Windows.Forms;
using SortAlgorithms.Core;
using SortAlgorithms.GUI.Models;

namespace SortAlgorithms.GUI.Controls
{
    public partial class SortControl : UserControl
    {
        private SortBase<int> _sort;
        public SortControl(SortType sortType, int delay)
        {
            InitializeComponent();
            sortViewer.Delay = delay;
            lblSort.Text = sortType.ToString();
            _sort = (SortBase<int>)Activator.CreateInstance(sortType.Type.MakeGenericType(typeof(int)));
            _sort.SwapEvent += (s, e) => InvokeAction(() => lblSwaps.Text = _sort.SwapsCount.ToString());
            _sort.CompareEvent += (s, e) => InvokeAction(() => lblComparsions.Text = _sort.ComparsionsCount.ToString());
            _sort.SetEvent += (s, e) => InvokeAction(() => lblSets.Text = _sort.SetsCount.ToString());
            sortViewer.ApplySort(_sort);
        }
        public void ApplyArray(int[] array)
        {
            sortViewer.ApplyArray(array);
        }
        public void Sort()
        {
            new Thread(() =>
            {
                sortViewer.Finished(_sort.Sort());
            }).Start();
        }
        private void InvokeAction(Action action)
        {
            if (InvokeRequired) Invoke(action); else action?.Invoke();
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
