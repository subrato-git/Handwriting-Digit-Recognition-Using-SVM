namespace Handwriting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.dgvTrainingSource = new System.Windows.Forms.DataGridView();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrainingImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTrainingLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrainingFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvAnalysisTesting = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numEpsilon = new System.Windows.Forms.NumericUpDown();
            this.numTolerance = new System.Windows.Forms.NumericUpDown();
            this.numComplexity = new System.Windows.Forms.NumericUpDown();
            this.numConstant = new System.Windows.Forms.NumericUpDown();
            this.numDegree = new System.Windows.Forms.NumericUpDown();
            this.numSigma = new System.Windows.Forms.NumericUpDown();
            this.rbPolynomial = new System.Windows.Forms.RadioButton();
            this.rbGaussian = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClassify = new System.Windows.Forms.Button();
            this.btnSampleRunAnalysis = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.Load = new System.Windows.Forms.Button();
            this.colTestingImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTestingExpected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestingOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestingFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingSource)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysisTesting)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEpsilon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComplexity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigma)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem6});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "&Open";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "E&xit";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem6.Text = "&Help";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem7.Text = "&About...";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox15.Controls.Add(this.dgvTrainingSource);
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.ForeColor = System.Drawing.Color.Plum;
            this.groupBox15.Location = new System.Drawing.Point(272, 29);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(233, 436);
            this.groupBox15.TabIndex = 8;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Training";
            // 
            // dgvTrainingSource
            // 
            this.dgvTrainingSource.AllowUserToAddRows = false;
            this.dgvTrainingSource.AllowUserToDeleteRows = false;
            this.dgvTrainingSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvTrainingSource.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTrainingSource.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTrainingSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainingSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTrainingSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainingSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial,
            this.colTrainingImage,
            this.colTrainingLabel,
            this.colTrainingFeatures});
            this.dgvTrainingSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrainingSource.Location = new System.Drawing.Point(3, 17);
            this.dgvTrainingSource.Name = "dgvTrainingSource";
            this.dgvTrainingSource.ReadOnly = true;
            this.dgvTrainingSource.RowHeadersVisible = false;
            this.dgvTrainingSource.Size = new System.Drawing.Size(227, 416);
            this.dgvTrainingSource.TabIndex = 6;
            // 
            // Serial
            // 
            this.Serial.HeaderText = "Serial";
            this.Serial.MaxInputLength = 55000;
            this.Serial.Name = "Serial";
            this.Serial.ReadOnly = true;
            this.Serial.Width = 70;
            // 
            // colTrainingImage
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            this.colTrainingImage.DefaultCellStyle = dataGridViewCellStyle9;
            this.colTrainingImage.HeaderText = "Character";
            this.colTrainingImage.Name = "colTrainingImage";
            this.colTrainingImage.ReadOnly = true;
            this.colTrainingImage.Width = 75;
            // 
            // colTrainingLabel
            // 
            this.colTrainingLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTrainingLabel.DefaultCellStyle = dataGridViewCellStyle10;
            this.colTrainingLabel.FillWeight = 80F;
            this.colTrainingLabel.HeaderText = "Index";
            this.colTrainingLabel.MaxInputLength = 55000;
            this.colTrainingLabel.Name = "colTrainingLabel";
            this.colTrainingLabel.ReadOnly = true;
            this.colTrainingLabel.Width = 67;
            // 
            // colTrainingFeatures
            // 
            this.colTrainingFeatures.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrainingFeatures.HeaderText = "Features (array)";
            this.colTrainingFeatures.MaxInputLength = 200000;
            this.colTrainingFeatures.Name = "colTrainingFeatures";
            this.colTrainingFeatures.ReadOnly = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox7.Controls.Add(this.dgvAnalysisTesting);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Plum;
            this.groupBox7.Location = new System.Drawing.Point(759, 29);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(230, 436);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Testing";
            // 
            // dgvAnalysisTesting
            // 
            this.dgvAnalysisTesting.AllowUserToAddRows = false;
            this.dgvAnalysisTesting.AllowUserToDeleteRows = false;
            this.dgvAnalysisTesting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnalysisTesting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAnalysisTesting.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAnalysisTesting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnalysisTesting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAnalysisTesting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalysisTesting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTestingImage,
            this.colTestingExpected,
            this.colTestingOutput,
            this.colTestingFeatures});
            this.dgvAnalysisTesting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnalysisTesting.Location = new System.Drawing.Point(3, 17);
            this.dgvAnalysisTesting.Name = "dgvAnalysisTesting";
            this.dgvAnalysisTesting.ReadOnly = true;
            this.dgvAnalysisTesting.RowHeadersVisible = false;
            this.dgvAnalysisTesting.Size = new System.Drawing.Size(224, 416);
            this.dgvAnalysisTesting.TabIndex = 6;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox6.Controls.Add(this.numEpsilon);
            this.groupBox6.Controls.Add(this.numTolerance);
            this.groupBox6.Controls.Add(this.numComplexity);
            this.groupBox6.Controls.Add(this.numConstant);
            this.groupBox6.Controls.Add(this.numDegree);
            this.groupBox6.Controls.Add(this.numSigma);
            this.groupBox6.Controls.Add(this.rbPolynomial);
            this.groupBox6.Controls.Add(this.rbGaussian);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(56, 31);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(178, 295);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Settings";
            // 
            // numEpsilon
            // 
            this.numEpsilon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numEpsilon.DecimalPlaces = 6;
            this.numEpsilon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numEpsilon.Location = new System.Drawing.Point(90, 172);
            this.numEpsilon.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEpsilon.Name = "numEpsilon";
            this.numEpsilon.Size = new System.Drawing.Size(82, 22);
            this.numEpsilon.TabIndex = 7;
            this.numEpsilon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numEpsilon.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // numTolerance
            // 
            this.numTolerance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numTolerance.DecimalPlaces = 6;
            this.numTolerance.Location = new System.Drawing.Point(89, 222);
            this.numTolerance.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTolerance.Name = "numTolerance";
            this.numTolerance.Size = new System.Drawing.Size(82, 22);
            this.numTolerance.TabIndex = 7;
            this.numTolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTolerance.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numTolerance.ValueChanged += new System.EventHandler(this.numTolerance_ValueChanged);
            // 
            // numComplexity
            // 
            this.numComplexity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numComplexity.DecimalPlaces = 6;
            this.numComplexity.Location = new System.Drawing.Point(89, 198);
            this.numComplexity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numComplexity.Name = "numComplexity";
            this.numComplexity.Size = new System.Drawing.Size(82, 22);
            this.numComplexity.TabIndex = 7;
            this.numComplexity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numComplexity.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // numConstant
            // 
            this.numConstant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numConstant.DecimalPlaces = 4;
            this.numConstant.Location = new System.Drawing.Point(90, 150);
            this.numConstant.Name = "numConstant";
            this.numConstant.Size = new System.Drawing.Size(82, 22);
            this.numConstant.TabIndex = 7;
            this.numConstant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numDegree
            // 
            this.numDegree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numDegree.Location = new System.Drawing.Point(89, 126);
            this.numDegree.Name = "numDegree";
            this.numDegree.Size = new System.Drawing.Size(82, 22);
            this.numDegree.TabIndex = 7;
            this.numDegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDegree.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numSigma
            // 
            this.numSigma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numSigma.DecimalPlaces = 4;
            this.numSigma.Location = new System.Drawing.Point(96, 61);
            this.numSigma.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSigma.Name = "numSigma";
            this.numSigma.Size = new System.Drawing.Size(82, 22);
            this.numSigma.TabIndex = 7;
            this.numSigma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSigma.Value = new decimal(new int[] {
            622,
            0,
            0,
            131072});
            // 
            // rbPolynomial
            // 
            this.rbPolynomial.AutoSize = true;
            this.rbPolynomial.Checked = true;
            this.rbPolynomial.Location = new System.Drawing.Point(6, 103);
            this.rbPolynomial.Name = "rbPolynomial";
            this.rbPolynomial.Size = new System.Drawing.Size(134, 20);
            this.rbPolynomial.TabIndex = 6;
            this.rbPolynomial.TabStop = true;
            this.rbPolynomial.Text = "Polynomial Kernel";
            this.rbPolynomial.UseVisualStyleBackColor = true;
            // 
            // rbGaussian
            // 
            this.rbGaussian.AutoSize = true;
            this.rbGaussian.Location = new System.Drawing.Point(6, 28);
            this.rbGaussian.Name = "rbGaussian";
            this.rbGaussian.Size = new System.Drawing.Size(124, 20);
            this.rbGaussian.TabIndex = 6;
            this.rbGaussian.Text = "Gaussian Kernel";
            this.rbGaussian.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tolerance:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Epsilon:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Complexity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Constant:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Degree:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sigma:";
            // 
            // btnClassify
            // 
            this.btnClassify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClassify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClassify.Enabled = false;
            this.btnClassify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassify.ForeColor = System.Drawing.Color.White;
            this.btnClassify.Location = new System.Drawing.Point(547, 264);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(177, 48);
            this.btnClassify.TabIndex = 1;
            this.btnClassify.Text = "Identify";
            this.btnClassify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClassify.UseVisualStyleBackColor = false;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // btnSampleRunAnalysis
            // 
            this.btnSampleRunAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSampleRunAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSampleRunAnalysis.Enabled = false;
            this.btnSampleRunAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSampleRunAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnSampleRunAnalysis.Location = new System.Drawing.Point(546, 191);
            this.btnSampleRunAnalysis.Name = "btnSampleRunAnalysis";
            this.btnSampleRunAnalysis.Size = new System.Drawing.Size(177, 49);
            this.btnSampleRunAnalysis.TabIndex = 1;
            this.btnSampleRunAnalysis.Text = "Start Training";
            this.btnSampleRunAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSampleRunAnalysis.UseVisualStyleBackColor = false;
            this.btnSampleRunAnalysis.Click += new System.EventHandler(this.btnRunTraining_Click);
            // 
            // groupBox20
            // 
            this.groupBox20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox20.Location = new System.Drawing.Point(0, 0);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(450, 445);
            this.groupBox20.TabIndex = 8;
            this.groupBox20.TabStop = false;
            // 
            // groupBox19
            // 
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox19.Location = new System.Drawing.Point(0, 0);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(459, 445);
            this.groupBox19.TabIndex = 8;
            this.groupBox19.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1001, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(986, 17);
            this.lbStatus.Spring = true;
            this.lbStatus.Text = "toolStripStatusLabel1";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Visible = false;
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.ForeColor = System.Drawing.Color.White;
            this.Load.Location = new System.Drawing.Point(546, 124);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(178, 48);
            this.Load.TabIndex = 18;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // colTestingImage
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(2);
            this.colTestingImage.DefaultCellStyle = dataGridViewCellStyle12;
            this.colTestingImage.HeaderText = "Character";
            this.colTestingImage.Name = "colTestingImage";
            this.colTestingImage.ReadOnly = true;
            // 
            // colTestingExpected
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTestingExpected.DefaultCellStyle = dataGridViewCellStyle13;
            this.colTestingExpected.HeaderText = "Index";
            this.colTestingExpected.Name = "colTestingExpected";
            this.colTestingExpected.ReadOnly = true;
            // 
            // colTestingOutput
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTestingOutput.DefaultCellStyle = dataGridViewCellStyle14;
            this.colTestingOutput.HeaderText = "Identified";
            this.colTestingOutput.Name = "colTestingOutput";
            this.colTestingOutput.ReadOnly = true;
            // 
            // colTestingFeatures
            // 
            this.colTestingFeatures.HeaderText = "Features (array)";
            this.colTestingFeatures.Name = "colTestingFeatures";
            this.colTestingFeatures.ReadOnly = true;
            this.colTestingFeatures.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 609);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSampleRunAnalysis);
            this.Controls.Add(this.btnClassify);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Multiclass Support Vector Machines for Handwriting Recognition";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingSource)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysisTesting)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEpsilon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComplexity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigma)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numConstant;
        private System.Windows.Forms.NumericUpDown numDegree;
        private System.Windows.Forms.NumericUpDown numSigma;
        private System.Windows.Forms.RadioButton rbPolynomial;
        private System.Windows.Forms.RadioButton rbGaussian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSampleRunAnalysis;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.DataGridView dgvTrainingSource;
        private System.Windows.Forms.NumericUpDown numComplexity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvAnalysisTesting;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.NumericUpDown numEpsilon;
        private System.Windows.Forms.Label label6;
        // private Canvas canvas;
        // private System.Windows.Forms.Label lbCanvasClassification;
        private System.Windows.Forms.NumericUpDown numTolerance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewImageColumn colTrainingImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainingLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainingFeatures;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.DataGridViewImageColumn colTestingImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestingExpected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestingOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestingFeatures;

    }
}

