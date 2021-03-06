using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace min_error_map
{
    public partial class mainForm : Form
    {
        public Matrix matrix = null;
        CancellationTokenSource cancellationToken = new CancellationTokenSource();

        // https://stackoverflow.com/questions/1781172/generate-a-two-dimensional-array-via-linq/1814063#1814063
        public T[,] JaggedToMultidimensional<T>(T[][] jaggedArray)
        {
            int rows = jaggedArray.Length;
            int cols = jaggedArray.Max(subArray => subArray.Length);
            T[,] array = new T[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                cols = jaggedArray[i].Length;
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = jaggedArray[i][j];
                }
            }
            return array;
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainPanelAddRandomMatrixButton_Click(object sender, EventArgs e)
        {
            AddRandomMatrixForm randomMatrixForm = new AddRandomMatrixForm(this);
            randomMatrixForm.ShowDialog();
        }

        private void mainPanelSaveInputButton_Click(object sender, EventArgs e)
        {
            if(this.mainTextboxMatrix.Text == "")
            {
                MessageBox.Show("Input cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save input to file";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, this.mainTextboxMatrix.Text);
            }
        }

        private void mainPanelAddMatrixFromFileButton_Click(object sender, EventArgs e)
        {
            string path = "";

            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open Text File";
            open.Filter = "txt files (*.txt)|*.txt";


            if (open.ShowDialog() == DialogResult.OK)
                path = open.FileName;

            if (File.Exists(path))
                this.mainTextboxMatrix.Text = File.ReadAllText(path);
        }

        private void mainRunTabuButton_Click(object sender, EventArgs e)
        {
            Matrix matrix = null;
            int numberOfRestarts;
            int tabuListSize;
            int maxIterWithoutProgress;
            double divMovements;

            try
            {
                if (this.mainTextboxMatrix.Text == "")
                {
                    MessageBox.Show("Input cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int[][] tmpMatrix = this.mainTextboxMatrix.Text.ToString()
                                                               .Split('\n')
                                                               .Select(line => line.Split(' ').Select(i => int.Parse(i)).ToArray())
                                                               .ToArray();
                matrix = new Matrix(JaggedToMultidimensional(tmpMatrix));
                numberOfRestarts = (int)this.numericRestarts.Value;
                tabuListSize = (int)this.numericTabuSize.Value;
                maxIterWithoutProgress = (int)this.numericMaxIter.Value;
                divMovements = (double)this.numericDivMoves.Value;

                if(divMovements > 1 || divMovements < 0)
                    throw new ArgumentException("Bad value for % OF DIVERSIFY MOVES");

            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.logBox.Text = "";
            cancellationToken = new CancellationTokenSource();
            runTabuSearch(matrix, numberOfRestarts, tabuListSize, maxIterWithoutProgress, divMovements, cancellationToken);
        }

        public async Task runTabuSearch(Matrix matrix, int numberOfRestarts, int tabuListSize, int maxIterWithoutProgress, double divMovements, CancellationTokenSource cancellationToken)
        {
            TabuSearch ts = new TabuSearch(matrix);
            progressBar.Maximum = numberOfRestarts;
            progressBar.Step = 1;
            progressBar.Value = 0;
            var progress = new Progress<int>(v => { progressBar.PerformStep(); });
            matrix.calculateCmax();
            this.logBox.Text += $"BEGIN COMPUTING\n---------\n";
            this.logBox.Text += $"NUMBER OF RESTARTS: {numberOfRestarts}\n" +
                                $"TABU LIST SIZE: {tabuListSize}\n" +
                                $"MAXIMUM ITERATIONS WITHOUT PROGRESS: {maxIterWithoutProgress}\n" +
                                $"PERCENT OF ITERATIONS WITHOUT PROGRESS WHEN DIVERSIFYING STARTS: {divMovements}\n" +
                                $"PROBLEM INSTANCE:\n\n{matrix}\n";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int restartsLeft = 0;
            await Task.Run(() => restartsLeft = ts.run(numberOfRestarts, tabuListSize, maxIterWithoutProgress, divMovements, progress, cancellationToken.Token));
            watch.Stop();
            this.logBox.Text += $"\n" +
                                $"STOP COMPUTING\n---------\n" +
                                $"TIME ELAPSED: {watch.Elapsed.TotalMilliseconds / 1000} s\n" +
                                $"RESTARTS LEFT: {restartsLeft}\n" +
                                $"LAST BEST GLOBAL SOLUTION:\n\n{ts.globalSolution}\n";

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            cancellationToken.Cancel();
        }

    }
}
