namespace SortAlgorithms.GUI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nHeight = new System.Windows.Forms.NumericUpDown();
            this.btnApplySortViewSize = new System.Windows.Forms.Button();
            this.lblSortViewWidth = new System.Windows.Forms.Label();
            this.lblSortViewHeight = new System.Windows.Forms.Label();
            this.nWidth = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnAddSort = new System.Windows.Forms.Button();
            this.lblSortDelay = new System.Windows.Forms.Label();
            this.lblSortType = new System.Windows.Forms.Label();
            this.cbSortType = new System.Windows.Forms.ComboBox();
            this.nSortDelay = new System.Windows.Forms.NumericUpDown();
            this.gbArray = new System.Windows.Forms.GroupBox();
            this.lblArrayLength = new System.Windows.Forms.Label();
            this.lblArrayCreationType = new System.Windows.Forms.Label();
            this.nArrayLength = new System.Windows.Forms.NumericUpDown();
            this.lblRandomTo = new System.Windows.Forms.Label();
            this.nRandomTo = new System.Windows.Forms.NumericUpDown();
            this.lblRandomFrom = new System.Windows.Forms.Label();
            this.nRandomFrom = new System.Windows.Forms.NumericUpDown();
            this.cbArrayCreationType = new System.Windows.Forms.ComboBox();
            this.pnlSorts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSortDelay)).BeginInit();
            this.gbArray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nArrayLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRandomTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRandomFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Location = new System.Drawing.Point(215, 32);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 21);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.OnCreateButtonClick);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))));
            this.pnlMenu.Controls.Add(this.groupBox1);
            this.pnlMenu.Controls.Add(this.groupBox2);
            this.pnlMenu.Controls.Add(this.gbArray);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(733, 92);
            this.pnlMenu.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nHeight);
            this.groupBox1.Controls.Add(this.btnApplySortViewSize);
            this.groupBox1.Controls.Add(this.lblSortViewWidth);
            this.groupBox1.Controls.Add(this.lblSortViewHeight);
            this.groupBox1.Controls.Add(this.nWidth);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(521, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 79);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort View Size";
            // 
            // nHeight
            // 
            this.nHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.nHeight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nHeight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nHeight.Location = new System.Drawing.Point(44, 47);
            this.nHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nHeight.Name = "nHeight";
            this.nHeight.Size = new System.Drawing.Size(72, 21);
            this.nHeight.TabIndex = 15;
            this.nHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nHeight.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // btnApplySortViewSize
            // 
            this.btnApplySortViewSize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnApplySortViewSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplySortViewSize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplySortViewSize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnApplySortViewSize.Location = new System.Drawing.Point(122, 32);
            this.btnApplySortViewSize.Name = "btnApplySortViewSize";
            this.btnApplySortViewSize.Size = new System.Drawing.Size(80, 21);
            this.btnApplySortViewSize.TabIndex = 0;
            this.btnApplySortViewSize.Text = "Apply";
            this.btnApplySortViewSize.UseVisualStyleBackColor = true;
            this.btnApplySortViewSize.Click += new System.EventHandler(this.OnApplySortViewSizeButtonClick);
            // 
            // lblSortViewWidth
            // 
            this.lblSortViewWidth.AutoSize = true;
            this.lblSortViewWidth.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSortViewWidth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSortViewWidth.Location = new System.Drawing.Point(9, 23);
            this.lblSortViewWidth.Name = "lblSortViewWidth";
            this.lblSortViewWidth.Size = new System.Drawing.Size(35, 13);
            this.lblSortViewWidth.TabIndex = 12;
            this.lblSortViewWidth.Text = "Width";
            // 
            // lblSortViewHeight
            // 
            this.lblSortViewHeight.AutoSize = true;
            this.lblSortViewHeight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSortViewHeight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSortViewHeight.Location = new System.Drawing.Point(6, 50);
            this.lblSortViewHeight.Name = "lblSortViewHeight";
            this.lblSortViewHeight.Size = new System.Drawing.Size(38, 13);
            this.lblSortViewHeight.TabIndex = 14;
            this.lblSortViewHeight.Text = "Heigth";
            // 
            // nWidth
            // 
            this.nWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.nWidth.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nWidth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nWidth.Location = new System.Drawing.Point(44, 20);
            this.nWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nWidth.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nWidth.Name = "nWidth";
            this.nWidth.Size = new System.Drawing.Size(72, 21);
            this.nWidth.TabIndex = 11;
            this.nWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nWidth.Value = new decimal(new int[] {
            730,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSort);
            this.groupBox2.Controls.Add(this.btnAddSort);
            this.groupBox2.Controls.Add(this.lblSortDelay);
            this.groupBox2.Controls.Add(this.lblSortType);
            this.groupBox2.Controls.Add(this.cbSortType);
            this.groupBox2.Controls.Add(this.nSortDelay);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(310, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 79);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort";
            // 
            // btnSort
            // 
            this.btnSort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(200)))));
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSort.Location = new System.Drawing.Point(118, 47);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(80, 21);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.OnSortButtonClick);
            // 
            // btnAddSort
            // 
            this.btnAddSort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnAddSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSort.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddSort.Location = new System.Drawing.Point(118, 20);
            this.btnAddSort.Name = "btnAddSort";
            this.btnAddSort.Size = new System.Drawing.Size(80, 21);
            this.btnAddSort.TabIndex = 0;
            this.btnAddSort.Text = "Add";
            this.btnAddSort.UseVisualStyleBackColor = true;
            this.btnAddSort.Click += new System.EventHandler(this.OnAddSortButtonClick);
            // 
            // lblSortDelay
            // 
            this.lblSortDelay.AutoSize = true;
            this.lblSortDelay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSortDelay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSortDelay.Location = new System.Drawing.Point(6, 23);
            this.lblSortDelay.Name = "lblSortDelay";
            this.lblSortDelay.Size = new System.Drawing.Size(34, 13);
            this.lblSortDelay.TabIndex = 12;
            this.lblSortDelay.Text = "Delay";
            // 
            // lblSortType
            // 
            this.lblSortType.AutoSize = true;
            this.lblSortType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSortType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSortType.Location = new System.Drawing.Point(9, 50);
            this.lblSortType.Name = "lblSortType";
            this.lblSortType.Size = new System.Drawing.Size(31, 13);
            this.lblSortType.TabIndex = 14;
            this.lblSortType.Text = "Type";
            // 
            // cbSortType
            // 
            this.cbSortType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.cbSortType.DisplayMember = "0";
            this.cbSortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSortType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbSortType.FormattingEnabled = true;
            this.cbSortType.Location = new System.Drawing.Point(40, 47);
            this.cbSortType.Name = "cbSortType";
            this.cbSortType.Size = new System.Drawing.Size(72, 21);
            this.cbSortType.TabIndex = 13;
            this.cbSortType.ValueMember = "0";
            // 
            // nSortDelay
            // 
            this.nSortDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.nSortDelay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nSortDelay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nSortDelay.Location = new System.Drawing.Point(40, 20);
            this.nSortDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSortDelay.Name = "nSortDelay";
            this.nSortDelay.Size = new System.Drawing.Size(72, 21);
            this.nSortDelay.TabIndex = 11;
            this.nSortDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbArray
            // 
            this.gbArray.Controls.Add(this.lblArrayLength);
            this.gbArray.Controls.Add(this.btnCreate);
            this.gbArray.Controls.Add(this.lblArrayCreationType);
            this.gbArray.Controls.Add(this.nArrayLength);
            this.gbArray.Controls.Add(this.lblRandomTo);
            this.gbArray.Controls.Add(this.nRandomTo);
            this.gbArray.Controls.Add(this.lblRandomFrom);
            this.gbArray.Controls.Add(this.nRandomFrom);
            this.gbArray.Controls.Add(this.cbArrayCreationType);
            this.gbArray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbArray.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbArray.Location = new System.Drawing.Point(3, 3);
            this.gbArray.Name = "gbArray";
            this.gbArray.Size = new System.Drawing.Size(301, 79);
            this.gbArray.TabIndex = 11;
            this.gbArray.TabStop = false;
            this.gbArray.Text = "Array";
            // 
            // lblArrayLength
            // 
            this.lblArrayLength.AutoSize = true;
            this.lblArrayLength.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArrayLength.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblArrayLength.Location = new System.Drawing.Point(6, 23);
            this.lblArrayLength.Name = "lblArrayLength";
            this.lblArrayLength.Size = new System.Drawing.Size(40, 13);
            this.lblArrayLength.TabIndex = 4;
            this.lblArrayLength.Text = "Length";
            // 
            // lblArrayCreationType
            // 
            this.lblArrayCreationType.AutoSize = true;
            this.lblArrayCreationType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArrayCreationType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblArrayCreationType.Location = new System.Drawing.Point(14, 50);
            this.lblArrayCreationType.Name = "lblArrayCreationType";
            this.lblArrayCreationType.Size = new System.Drawing.Size(31, 13);
            this.lblArrayCreationType.TabIndex = 10;
            this.lblArrayCreationType.Text = "Type";
            // 
            // nArrayLength
            // 
            this.nArrayLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.nArrayLength.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nArrayLength.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nArrayLength.Location = new System.Drawing.Point(46, 20);
            this.nArrayLength.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nArrayLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nArrayLength.Name = "nArrayLength";
            this.nArrayLength.Size = new System.Drawing.Size(72, 21);
            this.nArrayLength.TabIndex = 3;
            this.nArrayLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nArrayLength.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblRandomTo
            // 
            this.lblRandomTo.AutoSize = true;
            this.lblRandomTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRandomTo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRandomTo.Location = new System.Drawing.Point(131, 49);
            this.lblRandomTo.Name = "lblRandomTo";
            this.lblRandomTo.Size = new System.Drawing.Size(22, 14);
            this.lblRandomTo.TabIndex = 8;
            this.lblRandomTo.Text = "To";
            // 
            // nRandomTo
            // 
            this.nRandomTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.nRandomTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nRandomTo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nRandomTo.Location = new System.Drawing.Point(154, 47);
            this.nRandomTo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nRandomTo.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nRandomTo.Name = "nRandomTo";
            this.nRandomTo.Size = new System.Drawing.Size(56, 21);
            this.nRandomTo.TabIndex = 9;
            this.nRandomTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nRandomTo.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // lblRandomFrom
            // 
            this.lblRandomFrom.AutoSize = true;
            this.lblRandomFrom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRandomFrom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRandomFrom.Location = new System.Drawing.Point(119, 22);
            this.lblRandomFrom.Name = "lblRandomFrom";
            this.lblRandomFrom.Size = new System.Drawing.Size(34, 14);
            this.lblRandomFrom.TabIndex = 6;
            this.lblRandomFrom.Text = "From";
            // 
            // nRandomFrom
            // 
            this.nRandomFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.nRandomFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nRandomFrom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nRandomFrom.Location = new System.Drawing.Point(154, 20);
            this.nRandomFrom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nRandomFrom.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nRandomFrom.Name = "nRandomFrom";
            this.nRandomFrom.Size = new System.Drawing.Size(56, 21);
            this.nRandomFrom.TabIndex = 7;
            this.nRandomFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nRandomFrom.Value = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            // 
            // cbArrayCreationType
            // 
            this.cbArrayCreationType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.cbArrayCreationType.DisplayMember = "0";
            this.cbArrayCreationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArrayCreationType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbArrayCreationType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbArrayCreationType.FormattingEnabled = true;
            this.cbArrayCreationType.Location = new System.Drawing.Point(46, 47);
            this.cbArrayCreationType.Name = "cbArrayCreationType";
            this.cbArrayCreationType.Size = new System.Drawing.Size(72, 21);
            this.cbArrayCreationType.TabIndex = 5;
            this.cbArrayCreationType.ValueMember = "0";
            // 
            // pnlSorts
            // 
            this.pnlSorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSorts.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlSorts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSorts.Location = new System.Drawing.Point(0, 92);
            this.pnlSorts.Name = "pnlSorts";
            this.pnlSorts.Size = new System.Drawing.Size(733, 488);
            this.pnlSorts.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(733, 580);
            this.Controls.Add(this.pnlSorts);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort Algorithms";
            this.pnlMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSortDelay)).EndInit();
            this.gbArray.ResumeLayout(false);
            this.gbArray.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nArrayLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRandomTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRandomFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ComboBox cbArrayCreationType;
        private System.Windows.Forms.Label lblArrayLength;
        private System.Windows.Forms.NumericUpDown nArrayLength;
        private System.Windows.Forms.NumericUpDown nRandomFrom;
        private System.Windows.Forms.Label lblRandomFrom;
        private System.Windows.Forms.NumericUpDown nRandomTo;
        private System.Windows.Forms.Label lblRandomTo;
        private System.Windows.Forms.Label lblArrayCreationType;
        private System.Windows.Forms.GroupBox gbArray;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblSortDelay;
        private System.Windows.Forms.Label lblSortType;
        private System.Windows.Forms.ComboBox cbSortType;
        private System.Windows.Forms.NumericUpDown nSortDelay;
        private System.Windows.Forms.Button btnAddSort;
        private System.Windows.Forms.FlowLayoutPanel pnlSorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nHeight;
        private System.Windows.Forms.Button btnApplySortViewSize;
        private System.Windows.Forms.Label lblSortViewWidth;
        private System.Windows.Forms.Label lblSortViewHeight;
        private System.Windows.Forms.NumericUpDown nWidth;
    }
}