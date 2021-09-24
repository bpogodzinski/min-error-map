namespace min_error_map
{
    partial class mainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.mainPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanelMatrix = new System.Windows.Forms.TableLayoutPanel();
            this.mainTextboxMatrix = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanelAddRandomMatrixButton = new System.Windows.Forms.Button();
            this.mainPanelAddMatrixFromFileButton = new System.Windows.Forms.Button();
            this.mainPanelMatrixOptions = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanelSaveInputButton = new System.Windows.Forms.Button();
            this.mainRunTabuButton = new System.Windows.Forms.Button();
            this.mainPanelTabuSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericRestarts = new System.Windows.Forms.NumericUpDown();
            this.numericTabuSize = new System.Windows.Forms.NumericUpDown();
            this.numericMaxIter = new System.Windows.Forms.NumericUpDown();
            this.numericDivMoves = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.mainPanel1.SuspendLayout();
            this.mainPanel2.SuspendLayout();
            this.mainPanelMatrix.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainPanelMatrixOptions.SuspendLayout();
            this.mainPanelTabuSearch.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRestarts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTabuSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxIter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDivMoves)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel1
            // 
            this.mainPanel1.ColumnCount = 1;
            this.mainPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel1.Controls.Add(this.mainTitleLabel, 0, 0);
            this.mainPanel1.Controls.Add(this.mainPanel2, 0, 1);
            this.mainPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel1.Location = new System.Drawing.Point(0, 0);
            this.mainPanel1.Name = "mainPanel1";
            this.mainPanel1.RowCount = 2;
            this.mainPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.66667F));
            this.mainPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.33334F));
            this.mainPanel1.Size = new System.Drawing.Size(1500, 875);
            this.mainPanel1.TabIndex = 0;
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(1494, 128);
            this.mainTitleLabel.TabIndex = 0;
            this.mainTitleLabel.Text = "TABU SEARCH FOR MIN-MAP-ERROR";
            this.mainTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel2
            // 
            this.mainPanel2.ColumnCount = 2;
            this.mainPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel2.Controls.Add(this.mainPanelMatrix, 0, 0);
            this.mainPanel2.Controls.Add(this.mainPanelTabuSearch, 1, 0);
            this.mainPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel2.Location = new System.Drawing.Point(3, 131);
            this.mainPanel2.Name = "mainPanel2";
            this.mainPanel2.RowCount = 1;
            this.mainPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel2.Size = new System.Drawing.Size(1494, 741);
            this.mainPanel2.TabIndex = 1;
            // 
            // mainPanelMatrix
            // 
            this.mainPanelMatrix.ColumnCount = 1;
            this.mainPanelMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanelMatrix.Controls.Add(this.mainTextboxMatrix, 0, 1);
            this.mainPanelMatrix.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.mainPanelMatrix.Controls.Add(this.mainPanelMatrixOptions, 0, 2);
            this.mainPanelMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelMatrix.Location = new System.Drawing.Point(3, 3);
            this.mainPanelMatrix.Name = "mainPanelMatrix";
            this.mainPanelMatrix.RowCount = 3;
            this.mainPanelMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.23129F));
            this.mainPanelMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.80952F));
            this.mainPanelMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.09524F));
            this.mainPanelMatrix.Size = new System.Drawing.Size(741, 735);
            this.mainPanelMatrix.TabIndex = 0;
            // 
            // mainTextboxMatrix
            // 
            this.mainTextboxMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextboxMatrix.Location = new System.Drawing.Point(3, 136);
            this.mainTextboxMatrix.Name = "mainTextboxMatrix";
            this.mainTextboxMatrix.Size = new System.Drawing.Size(735, 462);
            this.mainTextboxMatrix.TabIndex = 1;
            this.mainTextboxMatrix.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.mainPanelAddRandomMatrixButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainPanelAddMatrixFromFileButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 127);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // mainPanelAddRandomMatrixButton
            // 
            this.mainPanelAddRandomMatrixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelAddRandomMatrixButton.Location = new System.Drawing.Point(3, 3);
            this.mainPanelAddRandomMatrixButton.Name = "mainPanelAddRandomMatrixButton";
            this.mainPanelAddRandomMatrixButton.Size = new System.Drawing.Size(361, 121);
            this.mainPanelAddRandomMatrixButton.TabIndex = 0;
            this.mainPanelAddRandomMatrixButton.Text = "ADD RANDOM MATRIX";
            this.mainPanelAddRandomMatrixButton.UseVisualStyleBackColor = true;
            this.mainPanelAddRandomMatrixButton.Click += new System.EventHandler(this.mainPanelAddRandomMatrixButton_Click);
            // 
            // mainPanelAddMatrixFromFileButton
            // 
            this.mainPanelAddMatrixFromFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelAddMatrixFromFileButton.Location = new System.Drawing.Point(370, 3);
            this.mainPanelAddMatrixFromFileButton.Name = "mainPanelAddMatrixFromFileButton";
            this.mainPanelAddMatrixFromFileButton.Size = new System.Drawing.Size(362, 121);
            this.mainPanelAddMatrixFromFileButton.TabIndex = 2;
            this.mainPanelAddMatrixFromFileButton.Text = "LOAD MATRIX FROM FILE";
            this.mainPanelAddMatrixFromFileButton.UseVisualStyleBackColor = true;
            this.mainPanelAddMatrixFromFileButton.Click += new System.EventHandler(this.mainPanelAddMatrixFromFileButton_Click);
            // 
            // mainPanelMatrixOptions
            // 
            this.mainPanelMatrixOptions.ColumnCount = 2;
            this.mainPanelMatrixOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanelMatrixOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanelMatrixOptions.Controls.Add(this.mainPanelSaveInputButton, 0, 0);
            this.mainPanelMatrixOptions.Controls.Add(this.mainRunTabuButton, 1, 0);
            this.mainPanelMatrixOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelMatrixOptions.Location = new System.Drawing.Point(3, 604);
            this.mainPanelMatrixOptions.Name = "mainPanelMatrixOptions";
            this.mainPanelMatrixOptions.RowCount = 1;
            this.mainPanelMatrixOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanelMatrixOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.mainPanelMatrixOptions.Size = new System.Drawing.Size(735, 128);
            this.mainPanelMatrixOptions.TabIndex = 3;
            // 
            // mainPanelSaveInputButton
            // 
            this.mainPanelSaveInputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelSaveInputButton.Location = new System.Drawing.Point(3, 3);
            this.mainPanelSaveInputButton.Name = "mainPanelSaveInputButton";
            this.mainPanelSaveInputButton.Size = new System.Drawing.Size(361, 122);
            this.mainPanelSaveInputButton.TabIndex = 0;
            this.mainPanelSaveInputButton.Text = "SAVE INPUT TO FILE";
            this.mainPanelSaveInputButton.UseVisualStyleBackColor = true;
            this.mainPanelSaveInputButton.Click += new System.EventHandler(this.mainPanelSaveInputButton_Click);
            // 
            // mainRunTabuButton
            // 
            this.mainRunTabuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainRunTabuButton.Location = new System.Drawing.Point(370, 3);
            this.mainRunTabuButton.Name = "mainRunTabuButton";
            this.mainRunTabuButton.Size = new System.Drawing.Size(362, 122);
            this.mainRunTabuButton.TabIndex = 1;
            this.mainRunTabuButton.Text = "RUN TABU SEARCH";
            this.mainRunTabuButton.UseVisualStyleBackColor = true;
            this.mainRunTabuButton.Click += new System.EventHandler(this.mainRunTabuButton_Click);
            // 
            // mainPanelTabuSearch
            // 
            this.mainPanelTabuSearch.ColumnCount = 1;
            this.mainPanelTabuSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanelTabuSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanelTabuSearch.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.mainPanelTabuSearch.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.mainPanelTabuSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelTabuSearch.Location = new System.Drawing.Point(750, 3);
            this.mainPanelTabuSearch.Name = "mainPanelTabuSearch";
            this.mainPanelTabuSearch.RowCount = 2;
            this.mainPanelTabuSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.619048F));
            this.mainPanelTabuSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.38095F));
            this.mainPanelTabuSearch.Size = new System.Drawing.Size(741, 735);
            this.mainPanelTabuSearch.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericRestarts, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericTabuSize, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericMaxIter, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericDivMoves, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(735, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "# OF RESTARTS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(186, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TABU LIST SIZE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(369, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "MAX ITER W/O PROGRESS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(552, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "% WHEN DIVERSIFY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericRestarts
            // 
            this.numericRestarts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericRestarts.Location = new System.Drawing.Point(3, 28);
            this.numericRestarts.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericRestarts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRestarts.Name = "numericRestarts";
            this.numericRestarts.Size = new System.Drawing.Size(177, 20);
            this.numericRestarts.TabIndex = 4;
            this.numericRestarts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericTabuSize
            // 
            this.numericTabuSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericTabuSize.Location = new System.Drawing.Point(186, 28);
            this.numericTabuSize.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericTabuSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTabuSize.Name = "numericTabuSize";
            this.numericTabuSize.Size = new System.Drawing.Size(177, 20);
            this.numericTabuSize.TabIndex = 5;
            this.numericTabuSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericMaxIter
            // 
            this.numericMaxIter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericMaxIter.Location = new System.Drawing.Point(369, 28);
            this.numericMaxIter.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericMaxIter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMaxIter.Name = "numericMaxIter";
            this.numericMaxIter.Size = new System.Drawing.Size(177, 20);
            this.numericMaxIter.TabIndex = 6;
            this.numericMaxIter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericDivMoves
            // 
            this.numericDivMoves.DecimalPlaces = 2;
            this.numericDivMoves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericDivMoves.Location = new System.Drawing.Point(552, 28);
            this.numericDivMoves.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.numericDivMoves.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericDivMoves.Name = "numericDivMoves";
            this.numericDivMoves.Size = new System.Drawing.Size(180, 20);
            this.numericDivMoves.TabIndex = 7;
            this.numericDivMoves.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.08469F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.915304F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(735, 673);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.progressBar, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.logBox, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.19926F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.80075F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(729, 606);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 543);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(723, 60);
            this.progressBar.TabIndex = 1;
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Location = new System.Drawing.Point(3, 3);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(723, 534);
            this.logBox.TabIndex = 2;
            this.logBox.Text = "";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.buttonStop, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 615);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(729, 55);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // buttonStop
            // 
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStop.Location = new System.Drawing.Point(3, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(723, 49);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 875);
            this.Controls.Add(this.mainPanel1);
            this.Name = "mainForm";
            this.Text = "Tabu Search";
            this.mainPanel1.ResumeLayout(false);
            this.mainPanel1.PerformLayout();
            this.mainPanel2.ResumeLayout(false);
            this.mainPanelMatrix.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mainPanelMatrixOptions.ResumeLayout(false);
            this.mainPanelTabuSearch.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRestarts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTabuSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxIter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDivMoves)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel1;
        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.TableLayoutPanel mainPanel2;
        private System.Windows.Forms.TableLayoutPanel mainPanelMatrix;
        private System.Windows.Forms.TableLayoutPanel mainPanelTabuSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button mainPanelAddRandomMatrixButton;
        private System.Windows.Forms.Button mainPanelAddMatrixFromFileButton;
        private System.Windows.Forms.TableLayoutPanel mainPanelMatrixOptions;
        private System.Windows.Forms.Button mainPanelSaveInputButton;
        public System.Windows.Forms.RichTextBox mainTextboxMatrix;
        private System.Windows.Forms.Button mainRunTabuButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericRestarts;
        private System.Windows.Forms.NumericUpDown numericTabuSize;
        private System.Windows.Forms.NumericUpDown numericMaxIter;
        private System.Windows.Forms.NumericUpDown numericDivMoves;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonStop;
    }
}

