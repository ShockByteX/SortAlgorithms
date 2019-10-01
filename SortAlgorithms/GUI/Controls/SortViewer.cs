using SortAlgorithms.Core;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace SortAlgorithms.GUI.Controls
{
    public class SortViewer : Control
    {
        public static readonly Point Point_MinusOne = new Point(-1, -1);
        private int[] _array;
        private SortBase<int> _sort;
        private SolidBrush _bshBackground = new SolidBrush(Color.Black);
        private SolidBrush _bshElement = new SolidBrush(Color.WhiteSmoke);
        private SolidBrush _bshElementSwap = new SolidBrush(Color.Green);
        private SolidBrush _bshElementCompare = new SolidBrush(Color.Red);
        private SolidBrush _bshText = new SolidBrush(Color.Violet);
        private Font _fontException = new Font("Tahoma", 12, FontStyle.Regular);
        private Font _fontDelay = new Font("Tahoma", 9, FontStyle.Regular);
        private Font _fontFinished = new Font("Tahoma", 12, FontStyle.Bold);
        private TimeSpan _elapsed = TimeSpan.Zero;
        private int _maxElement, _minElement, _totElement;
        private int _delay;
        private Point _pSwap = Point_MinusOne, _pCompare = Point_MinusOne;
        public int Delay
        {
            get => _delay; set
            {
                _delay = value;
                Invalidate();
            }
        }
        public Color BackgroundColor
        {
            get => _bshBackground.Color; set
            {
                _bshBackground.Color = value;
                Invalidate();
            }
        }
        public Color ElementColor
        {
            get => _bshElement.Color; set
            {
                _bshElement.Color = value;
                Invalidate();
            }
        }
        public Color ElementSwapColor
        {
            get => _bshElementSwap.Color; set
            {
                _bshElementSwap.Color = value;
                Invalidate();
            }
        }
        public Color ElementCompareColor
        {
            get => _bshElementCompare.Color; set
            {
                _bshElementCompare.Color = value;
                Invalidate();
            }
        }
        public SortViewer()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.Opaque | ControlStyles.CacheText, true);
            DoubleBuffered = true;
        }
        public void ShowArray(int[] array)
        {
            _array = array;
            _minElement = _maxElement = array[0];
            foreach (int item in array)
            {
                if (item < _minElement) _minElement = item;
                if (item > _maxElement) _maxElement = item;
            }
            _totElement = _maxElement - _minElement;
            Invalidate();
        }
        public void ApplySort(SortBase<int> sort)
        {
            if (_sort != null)
            {
                _sort.SwapEvent -= sort_SwapEvent;
                _sort.CompareEvent -= sort_CompareEvent;
            }
            _sort = sort;
            _sort.SwapEvent += sort_SwapEvent;
            _sort.CompareEvent += sort_CompareEvent;
            Invalidate();
        }
        public void ApplyArray(int[] array)
        {
            _elapsed = TimeSpan.Zero;
            _sort.CopyFrom(array);
            _minElement = _maxElement = _sort.BaseArray[0];
            foreach (int item in _sort.BaseArray)
            {
                if (item < _minElement) _minElement = item;
                if (item > _maxElement) _maxElement = item;
            }
            _totElement = _maxElement - _minElement;
            Invalidate();
        }
        public void Finished(TimeSpan elapsed)
        {
            _pSwap = Point_MinusOne;
            _pCompare = Point_MinusOne;
            _elapsed = elapsed;
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(_bshBackground.Color);
            g.DrawString($"{_delay} ms", _fontDelay, _bshText, 0, 0);
            int[] array = _sort == null ? _array : _sort.BaseArray;
            if (array == null) return;
            float elementWidth = (float)Width / (float)array.Length;
            if (elementWidth >= 0f)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int value = array[i];
                    int elementHeight = Height - (Height * (_maxElement - value) / _totElement);
                    SolidBrush bshUse = _bshElement;

                    if (i == _pSwap.X || i == _pSwap.Y) bshUse = _bshElementSwap;
                    if (i == _pCompare.X || i == _pCompare.Y) bshUse = _bshElementCompare;
                    g.FillRectangle(bshUse, elementWidth * i + 1, Height - elementHeight, elementWidth - 2, elementHeight);
                }
                if (_elapsed != TimeSpan.Zero)
                {
                    string text = _elapsed.ToString();
                    SizeF size = g.MeasureString(text, _fontFinished);
                    g.DrawString(text, _fontFinished, _bshElement, Width / 2 - size.Width / 2, size.Height / 2 + 10);
                }
            }
            else
            {
                string text = "CAN'T DRAW. RESIZE.";
                SizeF size = g.MeasureString(text, _fontException);
                g.DrawString(text, _fontException, _bshElement, Width / 2 - size.Width / 2, Height / 2 - size.Height / 2);
            }
        }
        private void sort_SwapEvent(object sender, Tuple<int, int> e)
        {
            if (_delay > 0) Thread.Sleep(_delay);
            _pSwap = new Point(e.Item1, e.Item2);
            Invalidate();
        }
        private void sort_CompareEvent(object sender, Tuple<int, int> e)
        {
            if (_delay > 0) Thread.Sleep(_delay);
            _pCompare = new Point(e.Item1, e.Item2);
            Invalidate();
        }
    }
}
