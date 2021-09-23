using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace min_error_map
{
    public partial class mainForm : Form
    {
        public Matrix matrix = null;

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
            int[,] matrix = null;

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
                matrix = JaggedToMultidimensional(tmpMatrix);
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            
        }
    }
}
