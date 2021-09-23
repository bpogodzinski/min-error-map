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
            this.mainPanelTabuSearch = new System.Windows.Forms.TableLayoutPanel();
            this.mainTextboxMatrix = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanelAddRandomMatrixButton = new System.Windows.Forms.Button();
            this.mainPanelAddMatrixFromFileButton = new System.Windows.Forms.Button();
            this.mainPanelMatrixOptions = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanelSaveInputButton = new System.Windows.Forms.Button();
            this.mainPanel1.SuspendLayout();
            this.mainPanel2.SuspendLayout();
            this.mainPanelMatrix.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainPanelMatrixOptions.SuspendLayout();
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
            this.mainTitleLabel.Text = "TABU SEARCH FOR MIN-MAX-ERROR";
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
            this.mainPanelMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.22449F));
            this.mainPanelMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.68027F));
            this.mainPanelMatrix.Size = new System.Drawing.Size(741, 735);
            this.mainPanelMatrix.TabIndex = 0;
            // 
            // mainPanelTabuSearch
            // 
            this.mainPanelTabuSearch.ColumnCount = 2;
            this.mainPanelTabuSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanelTabuSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanelTabuSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelTabuSearch.Location = new System.Drawing.Point(750, 3);
            this.mainPanelTabuSearch.Name = "mainPanelTabuSearch";
            this.mainPanelTabuSearch.RowCount = 2;
            this.mainPanelTabuSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanelTabuSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanelTabuSearch.Size = new System.Drawing.Size(741, 735);
            this.mainPanelTabuSearch.TabIndex = 1;
            // 
            // mainTextboxMatrix
            // 
            this.mainTextboxMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextboxMatrix.Location = new System.Drawing.Point(3, 136);
            this.mainTextboxMatrix.Name = "mainTextboxMatrix";
            this.mainTextboxMatrix.Size = new System.Drawing.Size(735, 443);
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
            // 
            // mainPanelAddMatrixFromFileButton
            // 
            this.mainPanelAddMatrixFromFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelAddMatrixFromFileButton.Location = new System.Drawing.Point(370, 3);
            this.mainPanelAddMatrixFromFileButton.Name = "mainPanelAddMatrixFromFileButton";
            this.mainPanelAddMatrixFromFileButton.Size = new System.Drawing.Size(362, 121);
            this.mainPanelAddMatrixFromFileButton.TabIndex = 2;
            this.mainPanelAddMatrixFromFileButton.Text = "ADD MATRIX FROM FILE";
            this.mainPanelAddMatrixFromFileButton.UseVisualStyleBackColor = true;
            // 
            // mainPanelMatrixOptions
            // 
            this.mainPanelMatrixOptions.ColumnCount = 2;
            this.mainPanelMatrixOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanelMatrixOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanelMatrixOptions.Controls.Add(this.mainPanelSaveInputButton, 0, 0);
            this.mainPanelMatrixOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelMatrixOptions.Location = new System.Drawing.Point(3, 585);
            this.mainPanelMatrixOptions.Name = "mainPanelMatrixOptions";
            this.mainPanelMatrixOptions.RowCount = 2;
            this.mainPanelMatrixOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanelMatrixOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanelMatrixOptions.Size = new System.Drawing.Size(735, 147);
            this.mainPanelMatrixOptions.TabIndex = 3;
            // 
            // mainPanelSaveInputButton
            // 
            this.mainPanelSaveInputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelSaveInputButton.Location = new System.Drawing.Point(3, 3);
            this.mainPanelSaveInputButton.Name = "mainPanelSaveInputButton";
            this.mainPanelSaveInputButton.Size = new System.Drawing.Size(361, 67);
            this.mainPanelSaveInputButton.TabIndex = 0;
            this.mainPanelSaveInputButton.Text = "SAVE INPUT TO FILE";
            this.mainPanelSaveInputButton.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel1;
        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.TableLayoutPanel mainPanel2;
        private System.Windows.Forms.TableLayoutPanel mainPanelMatrix;
        private System.Windows.Forms.TableLayoutPanel mainPanelTabuSearch;
        private System.Windows.Forms.RichTextBox mainTextboxMatrix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button mainPanelAddRandomMatrixButton;
        private System.Windows.Forms.Button mainPanelAddMatrixFromFileButton;
        private System.Windows.Forms.TableLayoutPanel mainPanelMatrixOptions;
        private System.Windows.Forms.Button mainPanelSaveInputButton;
    }
}

