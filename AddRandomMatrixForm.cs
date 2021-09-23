﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace min_error_map
{
    public partial class AddRandomMatrixForm : Form
    {
        mainForm main = null;
        public AddRandomMatrixForm(mainForm main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void randomMatrixBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addRandomMatrixGenerateButton_Click(object sender, EventArgs e)
        {
            int height;
            int width;
            int mistakes;
            double percent;
            try
            {
                height = (int)numericHeight.Value;
                width = (int)numericWidth.Value;
                mistakes = (int)numericMistakes.Value;
                percent = (double)numericPercent.Value;
                if (0 > percent || 1 < percent)
                    throw new ArgumentException();

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid arguments", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RandomMatrix randomMatrix = new RandomMatrix(width, height, mistakes, percent);
            var mistakesMade = randomMatrix.numberOfMistakes;
            main.mainTextboxMatrix.Text = randomMatrix.matrixToString();
            main.matrix = randomMatrix;
            MessageBox.Show($"Number of mistakes made: {mistakesMade}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
