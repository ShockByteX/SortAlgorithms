using SortAlgorithms.Core;
using SortAlgorithms.GUI.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms.GUI.Controls
{
    public class SortViewer : Control
    {
        public static readonly Point Point_MinusOne = new Point(-1, -1);
        private const string BTN_CLOSE_CAPTION = "r";
        private SortBase<int> _sort;
        private SolidBrush _bshBackground = new SolidBrush(Color.Black);
        private SolidBrush _bshElement = new SolidBrush(Color.WhiteSmoke);
        private SolidBrush _bshElementSwap = new SolidBrush(Color.Green);
        private SolidBrush _bshElementCompare = new SolidBrush(Color.Red);
        private SolidBrush _bshText = new SolidBrush(Color.Violet);
        private SolidBrush _bshStats = new SolidBrush(Color.FromArgb(10, 20, 30));
        private SolidBrush _bshFontClose = new SolidBrush(Color.FromArgb(200, 50, 100));
        private Font _fontFinished = new Font("Tahoma", 12f, FontStyle.Bold);
        private Font _fontStats = new Font("Tahoma", 8.25f, FontStyle.Regular);
        private Font _fontClose = new Font("Webdings", 12f, FontStyle.Regular);
        private TimeSpan _elapsed = TimeSpan.Zero;
        private int _maxElement, _minElement, _totElement;
        private int _delay;
        private Point _pSwap = Point_MinusOne, _pCompare = Point_MinusOne;
        private int _swaps, _comparsions, _sets;
        private Rectangle _rectStatsPanel, _rectCloseButton;
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
        public Color StatsPanelColor
        {
            get => _bshStats.Color; set
            {
                _bshStats.Color = value;
                Invalidate();
            }
        }
        public int StatsPanelHeight
        {
            get => _rectStatsPanel.Height; set
            {
                _rectStatsPanel = new Rectangle(0, Height - value, Width, value);
                _rectCloseButton = new Rectangle(Width - value, _rectStatsPanel.Y, value, value);
                Invalidate();
            }
        }
        public SortViewer(SortType sortType, int delay)
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.Opaque | ControlStyles.CacheText, true);
            DoubleBuffered = true;
            Width = 600;
            Height = 200;
            _sort = (SortBase<int>)Activator.CreateInstance(sortType.Type.MakeGenericType(typeof(int)));
            _sort.SetEvent += sort_SetEvent;
            _sort.SwapEvent += sort_SwapEvent;
            _sort.CompareEvent += sort_CompareEvent;
            _delay = delay;
            StatsPanelHeight = 26;
        }
        public void Sort()
        {
            Task.Run(() =>
            {
                TimeSpan elapsed = _sort.Sort();
                _pSwap = Point_MinusOne;
                _pCompare = Point_MinusOne;
                _elapsed = elapsed;
                Invalidate();
            });
        }
        public void ApplyArray(int[] array)
        {
            _elapsed = TimeSpan.Zero;
            _sort.ApplyArray(array);
            _minElement = _maxElement = _sort.BaseArray[0];
            foreach (int item in _sort.BaseArray)
            {
                if (item < _minElement) _minElement = item;
                if (item > _maxElement) _maxElement = item;
            }
            _totElement = _maxElement - _minElement;
            Invalidate();
        }
        protected override void OnResize(EventArgs e)
        {
            StatsPanelHeight = _rectStatsPanel.Height;
            base.OnResize(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            Cursor = e.X > _rectCloseButton.X && e.Y > _rectCloseButton.Y ? Cursors.Hand : Cursors.Default;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X > _rectCloseButton.X && e.Y > _rectCloseButton.Y) Parent.Controls.Remove(this);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(_bshBackground.Color);
            DrawStatsPanel(g);
            DrawCloseButton(g);
            int[] array = _sort.BaseArray;
            if (array == null) return;
            float elementWidth = (float)Width / (float)array.Length;
            float elementIndent = Width / array.Length >= 3f ? 1f : 0f;
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                int elementHeight = _rectStatsPanel.Y - (_rectStatsPanel.Y * (_maxElement - value) / _totElement);
                SolidBrush bshUse = _bshElement;
                if (array[i] == _pCompare.X || array[i] == _pCompare.Y) bshUse = _bshElementCompare;
                if (i == _pSwap.X || i == _pSwap.Y) bshUse = _bshElementSwap;
                g.FillRectangle(bshUse, elementWidth * i + elementIndent, _rectStatsPanel.Y - elementHeight, elementWidth - elementIndent * 2, elementHeight);
            }
            if (_elapsed != TimeSpan.Zero)
            {
                string text = _elapsed.ToString();
                SizeF size = g.MeasureString(text, _fontFinished);
                g.DrawString(text, _fontFinished, _bshElement, Width / 2 - size.Width / 2, size.Height / 2 + 10);
            }
        }
        private void DrawCloseButton(Graphics g)
        {
            SizeF fontSize = g.MeasureString(BTN_CLOSE_CAPTION, _fontClose);
            float x = (_rectCloseButton.Width - fontSize.Width) / 2f + _rectCloseButton.X;
            float y = (_rectCloseButton.Height - fontSize.Height) / 2f + _rectCloseButton.Y;
            g.DrawString(BTN_CLOSE_CAPTION, _fontClose, _bshFontClose, x, y);
        }
        private void DrawStatsPanel(Graphics g)
        {
            g.DrawString($"{_delay} ms", _fontStats, _bshText, 0, 0);
            g.FillRectangle(_bshStats, _rectStatsPanel);
            float fontY = _rectStatsPanel.Y + (_rectStatsPanel.Height - g.MeasureString("BlaTest", _fontStats).Height) / 2;
            float statsLastY = DrawStat(g, "Comparsions: ", _comparsions, 4, fontY);
            statsLastY = DrawStat(g, "Swaps: ", _swaps, statsLastY, fontY);
            statsLastY = DrawStat(g, "Sets: ", _sets, statsLastY, fontY);
        }
        private float DrawStat(Graphics g, string text, int value, float lastX, float y)
        {
            string strComparsions = text;
            g.DrawString($"{strComparsions}{value}", _fontStats, _bshElement, lastX, y);
            return g.MeasureString(strComparsions, _fontStats).Width + 50 + lastX;
        }
        private void sort_SwapEvent(object sender, Tuple<int, int> e)
        {
            if (_delay > 0) Thread.Sleep(_delay);
            _pCompare = Point_MinusOne;
            _pSwap = new Point(e.Item1, e.Item2);
            _swaps = _sort.SwapsCount;
            Invalidate();
        }
        private void sort_CompareEvent(object sender, Tuple<int, int> e)
        {
            if (_delay > 0) Thread.Sleep(_delay);
            _pCompare = new Point(e.Item1, e.Item2);
            _comparsions = _sort.ComparsionsCount;
            Invalidate();
        }
        private void sort_SetEvent(object sender, Tuple<int, int> e)
        {
            if (_delay > 0) Thread.Sleep(_delay);
            _pCompare = Point_MinusOne;
            _pSwap = new Point(e.Item1, -1);
            _sets = _sort.SetsCount;
            Invalidate();
        }
    }
}
