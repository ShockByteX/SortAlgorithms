namespace SortAlgorithms.GUI.Controls
{
    partial class SortControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlStatsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblSets = new System.Windows.Forms.Label();
            this.lblSetsText = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSwaps = new System.Windows.Forms.Label();
            this.lblSwapsText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblComparsions = new System.Windows.Forms.Label();
            this.lblComparsionsText = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.sortViewer = new SortAlgorithms.GUI.Controls.SortViewer();
            this.pnlStats.SuspendLayout();
            this.pnlStatsLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.pnlStats.Controls.Add(this.pnlStatsLayout);
            this.pnlStats.Controls.Add(this.tableLayoutPanel2);
            this.pnlStats.Controls.Add(this.tableLayoutPanel1);
            this.pnlStats.Controls.Add(this.lblSort);
            this.pnlStats.Controls.Add(this.lblClose);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStats.Location = new System.Drawing.Point(0, 213);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(480, 27);
            this.pnlStats.TabIndex = 0;
            // 
            // pnlStatsLayout
            // 
            this.pnlStatsLayout.ColumnCount = 2;
            this.pnlStatsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlStatsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.pnlStatsLayout.Controls.Add(this.lblSets, 1, 0);
            this.pnlStatsLayout.Controls.Add(this.lblSetsText, 0, 0);
            this.pnlStatsLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatsLayout.Location = new System.Drawing.Point(247, 0);
            this.pnlStatsLayout.Name = "pnlStatsLayout";
            this.pnlStatsLayout.RowCount = 1;
            this.pnlStatsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlStatsLayout.Size = new System.Drawing.Size(94, 27);
            this.pnlStatsLayout.TabIndex = 5;
            // 
            // lblSets
            // 
            this.lblSets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.lblSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSets.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSets.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSets.Location = new System.Drawing.Point(41, 0);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(50, 27);
            this.lblSets.TabIndex = 1;
            this.lblSets.Text = "0";
            this.lblSets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSetsText
            // 
            this.lblSetsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.lblSetsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSetsText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSetsText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSetsText.Location = new System.Drawing.Point(3, 0);
            this.lblSetsText.Name = "lblSetsText";
            this.lblSetsText.Size = new System.Drawing.Size(32, 27);
            this.lblSetsText.TabIndex = 0;
            this.lblSetsText.Text = "Sets:";
            this.lblSetsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.Controls.Add(this.lblSwaps, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSwapsText, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(136, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(111, 27);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblSwaps
            // 
            this.lblSwaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.lblSwaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSwaps.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSwaps.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSwaps.Location = new System.Drawing.Point(58, 0);
            this.lblSwaps.Name = "lblSwaps";
            this.lblSwaps.Size = new System.Drawing.Size(50, 27);
            this.lblSwaps.TabIndex = 1;
            this.lblSwaps.Text = "0";
            this.lblSwaps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSwapsText
            // 
            this.lblSwapsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.lblSwapsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSwapsText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSwapsText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSwapsText.Location = new System.Drawing.Point(3, 0);
            this.lblSwapsText.Name = "lblSwapsText";
            this.lblSwapsText.Size = new System.Drawing.Size(49, 27);
            this.lblSwapsText.TabIndex = 0;
            this.lblSwapsText.Text = "Swaps:";
            this.lblSwapsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Controls.Add(this.lblComparsions, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblComparsionsText, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(136, 27);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblComparsions
            // 
            this.lblComparsions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.lblComparsions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComparsions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComparsions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblComparsions.Location = new System.Drawing.Point(83, 0);
            this.lblComparsions.Name = "lblComparsions";
            this.lblComparsions.Size = new System.Drawing.Size(50, 27);
            this.lblComparsions.TabIndex = 1;
            this.lblComparsions.Text = "0";
            this.lblComparsions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComparsionsText
            // 
            this.lblComparsionsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.lblComparsionsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComparsionsText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComparsionsText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblComparsionsText.Location = new System.Drawing.Point(3, 0);
            this.lblComparsionsText.Name = "lblComparsionsText";
            this.lblComparsionsText.Size = new System.Drawing.Size(74, 27);
            this.lblComparsionsText.TabIndex = 0;
            this.lblComparsionsText.Text = "Comparsions:";
            this.lblComparsionsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSort
            // 
            this.lblSort.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSort.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSort.Location = new System.Drawing.Point(309, 0);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(144, 27);
            this.lblSort.TabIndex = 6;
            this.lblSort.Text = "BubbleSort";
            this.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClose
            // 
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.lblClose.Location = new System.Drawing.Point(453, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 27);
            this.lblClose.TabIndex = 7;
            this.lblClose.Text = "r";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // sortViewer
            // 
            this.sortViewer.BackgroundColor = System.Drawing.Color.Black;
            this.sortViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortViewer.ElementColor = System.Drawing.Color.WhiteSmoke;
            this.sortViewer.ElementCompareColor = System.Drawing.Color.Red;
            this.sortViewer.ElementSwapColor = System.Drawing.Color.Green;
            this.sortViewer.Location = new System.Drawing.Point(0, 0);
            this.sortViewer.Name = "sortViewer";
            this.sortViewer.Size = new System.Drawing.Size(480, 213);
            this.sortViewer.TabIndex = 1;
            this.sortViewer.Text = "sortViewer1";
            // 
            // SortControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.sortViewer);
            this.Controls.Add(this.pnlStats);
            this.DoubleBuffered = true;
            this.Name = "SortControl";
            this.Size = new System.Drawing.Size(480, 240);
            this.pnlStats.ResumeLayout(false);
            this.pnlStatsLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.TableLayoutPanel pnlStatsLayout;
        private System.Windows.Forms.Label lblSets;
        private System.Windows.Forms.Label lblSetsText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSwaps;
        private System.Windows.Forms.Label lblSwapsText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblComparsions;
        private System.Windows.Forms.Label lblComparsionsText;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblClose;
        private SortViewer sortViewer;
    }
}
