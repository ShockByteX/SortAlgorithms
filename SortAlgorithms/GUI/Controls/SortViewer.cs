using SortAlgorithms.Core;
using SortAlgorithms.Core.Extensions;
using SortAlgorithms.Extensions;
using SortAlgorithms.GUI.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms.GUI.Controls
{
    public class SortViewer : Control
    {
        public static readonly Point Point_MinusOne = new Point(-1, -1);
        private const string CloseButtonCaption = "r";

        private readonly ISort<int> _sort;

        private ISorter<int> _sorter;
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
        private Font _fontCaption = new Font("Tahoma", 8.25f, FontStyle.Bold);
        private TimeSpan _elapsed = TimeSpan.Zero;
        private int _maxElement, _minElement, _totalElements;
        private int _delay;
        private Point _pSwap = Point_MinusOne, _pCompare = Point_MinusOne;
        private int _swaps, _comparsions, _sets;
        private Rectangle _rectStatsPanel, _rectCloseButton;
        private string _sortName;
        private int[] _array;

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
        public SortViewer(SortWrapper sortWrapper, int delay)
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.Opaque | ControlStyles.CacheText, true);
            DoubleBuffered = true;
            Width = 600;
            Height = 200;
            _sort = sortWrapper.Sort;
            _sorter = new Sorter<int>();
            _sorter.SetEvent += OnSet;
            _sorter.SwapEvent += OnSwap;
            _sorter.CompareEvent += OnCompare;
            _delay = delay;
            _sortName = sortWrapper.Name;
            StatsPanelHeight = 26;
        }
        public void Sort()
        {
            Task.Factory.StartNew(() =>
            {
                var result = _sorter.Sort(_array, _sort);
                _pSwap = Point_MinusOne;
                _pCompare = Point_MinusOne;
                _elapsed = result.TimeSpent;
                Invalidate();
            });
        }
        public void ApplyArray(int[] array)
        {
            _elapsed = TimeSpan.Zero;
            _array = array.ToArray();

            var minMax = _array.GetMinMax();
            
            _minElement = minMax.Item1;
            _maxElement = minMax.Item2;
            _totalElements = _maxElement - _minElement;

            _comparsions = _swaps = _sets = 0;

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
            Graphics graphics = e.Graphics;

            graphics.ConfigureHiqhQuality();
            graphics.Clear(_bshBackground.Color);

            DrawStatsPanel(graphics);
            DrawCloseButton(graphics);

            SizeF captionSize = graphics.MeasureString(_sortName, _fontCaption);
            float captionX = Width - (_rectCloseButton.Width + captionSize.Width + 4);
            float captionY = (_rectCloseButton.Height - captionSize.Height) / 2f + _rectCloseButton.Y;
            graphics.DrawString(_sortName, _fontCaption, _bshElement, captionX, captionY);
            int[] array = _array;
            if (array == null) return;
            float elementWidth = (float)Width / (float)array.Length;
            float elementIndent = Width / array.Length >= 3f ? 1f : 0f;
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                int elementHeight = _rectStatsPanel.Y - (_rectStatsPanel.Y * (_maxElement - value) / _totalElements);
                SolidBrush bshUse = _bshElement;
                if (array[i] == _pCompare.X || array[i] == _pCompare.Y) bshUse = _bshElementCompare;
                if (i == _pSwap.X || i == _pSwap.Y) bshUse = _bshElementSwap;
                graphics.FillRectangle(bshUse, elementWidth * i + elementIndent, _rectStatsPanel.Y - elementHeight, elementWidth - elementIndent * 2, elementHeight);
            }
            if (_elapsed != TimeSpan.Zero)
            {
                string text = _elapsed.ToString();
                SizeF size = graphics.MeasureString(text, _fontFinished);
                graphics.DrawString(text, _fontFinished, _bshElement, Width / 2 - size.Width / 2, size.Height / 2 + 10);
            }
        }
        private void DrawCloseButton(Graphics g)
        {
            SizeF fontSize = g.MeasureString(CloseButtonCaption, _fontClose);
            float x = (_rectCloseButton.Width - fontSize.Width) / 2f + _rectCloseButton.X;
            float y = (_rectCloseButton.Height - fontSize.Height) / 2f + _rectCloseButton.Y;
            g.DrawString(CloseButtonCaption, _fontClose, _bshFontClose, x, y);
        }
        private void DrawStatsPanel(Graphics g)
        {
            g.DrawString($"{_delay} ms", _fontStats, _bshText, 0, 0);
            g.FillRectangle(_bshStats, _rectStatsPanel);

            var fontY = _rectStatsPanel.Y + (_rectStatsPanel.Height - g.MeasureString("BlaTest", _fontStats).Height) / 2;
            var statsComparsionsY = DrawStat(g, "Comparsions: ", _comparsions, 4, fontY);
            var statsSwapsY =  DrawStat(g, "Swaps: ", _swaps, statsComparsionsY, fontY);
           
            DrawStat(g, "Sets: ", _sets, statsSwapsY, fontY);
        }
        private float DrawStat(Graphics g, string text, int value, float lastX, float y)
        {
            string strComparsions = text;
            g.DrawString($"{strComparsions}{value}", _fontStats, _bshElement, lastX, y);
            return g.MeasureString(strComparsions, _fontStats).Width + 50 + lastX;
        }
        private void OnSwap(object sender, Tuple<int, int> e)
        {
            if (_delay > 0) Thread.Sleep(_delay);
            _pCompare = Point_MinusOne;
            _pSwap = new Point(e.Item1, e.Item2);
            _swaps++;
            Invalidate();
        }
        private void OnCompare(object sender, Tuple<int, int> e)
        {
            if (_delay > 0) Thread.Sleep(_delay);
            _pCompare = new Point(e.Item1, e.Item2);
            _comparsions++;
            Invalidate();
        }
        private void OnSet(object sender, Tuple<int, int> e)
        {
            if (_delay > 0) Thread.Sleep(_delay);
            _pCompare = Point_MinusOne;
            _pSwap = new Point(e.Item1, -1);
            _sets++;
            Invalidate();
        }
    }
}