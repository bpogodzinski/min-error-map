using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_error_map
{
    class Matrix
    {
        protected int [,] _matrix = null;
        protected int _width = 0;
        protected int _height = 0;
        protected int[] _columnIDs = null;

        public int [,] matrix
        {
            get { return _matrix; }
        }

        public Matrix(int width, int height)
        {
            this._width = width;
            this._height = height;
            this._matrix = new int[height, width];
            this._columnIDs = Enumerable.Range(0, this._width).ToArray();
        }

        public Matrix(int [,] matrix)
        {
            this._matrix = matrix;
            this._height = matrix.GetLength(0);
            this._width = matrix.GetLength(1);
            this._columnIDs = Enumerable.Range(0, this._width).ToArray();
        }
        
        public Matrix(Matrix matrix)
        {
            this._matrix = matrix._matrix;
            this._height = matrix._matrix.GetLength(0);
            this._width = matrix._matrix.GetLength(1);
            this._columnIDs = Enumerable.Range(0, this._width).ToArray();
        }

        public int[] getColumn(int columnNumber)
        {
            return Enumerable.Range(0, this._matrix.GetLength(0))
                    .Select(x => this._matrix[x, columnNumber])
                    .ToArray();
        }

        public int[] getRow(int rowNumber)
        {
            return Enumerable.Range(0, this._matrix.GetLength(1))
                    .Select(x => this._matrix[rowNumber, x])
                    .ToArray();
        }

        public bool swapColumns(int id1, int id2)
        {  

            var tmpSwap = this._columnIDs[id1];
            this._columnIDs[id1] = this._columnIDs[id2];
            this._columnIDs[id2] = tmpSwap;

            for (int i = 0; i < this._height; i++)
            {
                var tmpColumnSwap = this._matrix[i, id1];
                this._matrix[i, id1] = this._matrix[i, id2];
                this._matrix[i, id2] = tmpColumnSwap;
            }
            return true;
        }

        private bool isRowConsecutiveOnes(int [] row)
        {
            bool foundOne = false;
            bool foundZeroAfterOne = false;

            for (int i = 0; i < row.Length; i++)
            {
                if (!foundOne && row[i] == 1)
                {
                    foundOne = true;
                }
                if (foundOne && row[i] == 0)
                {
                    foundZeroAfterOne = true;
                }
                if (foundZeroAfterOne && row[i] == 1)
                {
                    return false;
                }
            }
            return true;
        }

        public bool isConsecutiveOnes()
        {
            for (int row = 0; row < this._height; row++)
            {
                if (isRowConsecutiveOnes(getRow(row)) == false) 
                    return false;
            }
            return true;
        }

        //TODO: add greedy heuristic + calculate cmax


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Columns order: {String.Join(" ", this._columnIDs)}");
            for(int i = 0; i < this._height; ++i)
            {
                stringBuilder.AppendLine(String.Join(" ", this.getRow(i)));
            }
            return stringBuilder.ToString();
        }
    }

    //TODO: remove Debug.Assert statements 
    class RandomMatrix : Matrix
    {
        private int numberOfMistakes = 0;
        private double percentageOfOnesInRow = 0;
        public int[,] originalMatrix = null;
        private Random randomGenerator = new Random(Guid.NewGuid().GetHashCode());

        public RandomMatrix(int width, int height, int numberOfMistakes, double percentageOfOnesInRow)
            : base(width, height)
        {
            this.numberOfMistakes = numberOfMistakes;
            this.percentageOfOnesInRow = percentageOfOnesInRow;
            this._matrix = this.fillMatrixWithOnes(this._matrix);
            Debug.Assert(isConsecutiveOnes() == true);
            this.originalMatrix = this._matrix;
            this._matrix = this.mixMatrixRows(this._matrix);
            this._matrix = this.addMistakesToMatrix(this._matrix);
            Debug.Assert(isConsecutiveOnes() == false);
        }

        public RandomMatrix(int [,] matrix, int numberOfMistakes, double percentageOfOnesInRow)
            : base(matrix)
        {
            this.numberOfMistakes = numberOfMistakes;
            this.percentageOfOnesInRow = percentageOfOnesInRow;
            this._matrix = this.fillMatrixWithOnes(this._matrix);
            Debug.Assert(isConsecutiveOnes() == true);
            this.originalMatrix = this._matrix;
            this._matrix = this.mixMatrixRows(this._matrix);
            this._matrix = this.addMistakesToMatrix(this._matrix);
            Debug.Assert(isConsecutiveOnes() == false);
        }
        
        public RandomMatrix(Matrix matrix, int numberOfMistakes, double percentageOfOnesInRow)
            : base(matrix)
        {
            this.numberOfMistakes = numberOfMistakes;
            this.percentageOfOnesInRow = percentageOfOnesInRow;
            this._matrix = this.fillMatrixWithOnes(this._matrix);
            Debug.Assert(isConsecutiveOnes() == true);
            this.originalMatrix = this._matrix;
            this._matrix = this.mixMatrixRows(this._matrix);
            this._matrix = this.addMistakesToMatrix(this._matrix);
            Debug.Assert(isConsecutiveOnes() == false);
        }

        private int [,] fillMatrixWithOnes(int[,] matrix)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            int lengthStringOfOnes = Convert.ToInt32(Math.Floor(this.percentageOfOnesInRow * width));
            bool areAllCollumnsCovered = false;
            int endPositionOfOnes = 0;

            for (int i = 0; i < height; i++)
            {
                int startPositionOfOnes = areAllCollumnsCovered ? this.randomGenerator.Next(width - lengthStringOfOnes) : endPositionOfOnes;
                endPositionOfOnes = startPositionOfOnes + lengthStringOfOnes;
                if (endPositionOfOnes > width)
                {
                    startPositionOfOnes -= endPositionOfOnes - width;
                    endPositionOfOnes = width;
                }
                if (endPositionOfOnes == width) areAllCollumnsCovered = true;
                for (int j = startPositionOfOnes; j < endPositionOfOnes; j++) matrix[i, j] = 1;
            }

            return matrix;
        }
        private int[,] mixMatrixRows(int[,] matrix)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            int[] rowPositions = Enumerable.Range(0, height).ToArray();
            int[] randomizedRowPositions = rowPositions.OrderBy(position => randomGenerator.Next()).ToArray();
            int[,] mixedMatrix = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    mixedMatrix[i, j] = matrix[randomizedRowPositions[i], j];
                }
            }

            return mixedMatrix;
        }

        private int[,] addMistakesToMatrix(int[,] matrix)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            int mistakesCount = 0;

            // TODO: zmień (int)Math.Ceiling((double)this.numberOfMistakes / height)
            var rowsToChange = Enumerable.Repeat(Enumerable.Range(0, height).ToArray(), (int)Math.Ceiling((double)this.numberOfMistakes / height))
                                .SelectMany(x => x)
                                .OrderBy(row => this.randomGenerator.Next())
                                .Take(Math.Min(this.numberOfMistakes, height));

            foreach (var randomRow in rowsToChange)
            {
                int start = this.randomGenerator.Next(width - 3);
                for (int i = start; i < width - 2; i++)
                {
                    if (matrix[randomRow, i] == 1 && matrix[randomRow, i + 1] == 1 && matrix[randomRow, i + 2] == 1)
                    {
                        matrix[randomRow, i + 1] = 0;
                        mistakesCount++;
                        break;
                    }
                    if (matrix[randomRow, i] == 1 && matrix[randomRow, i + 1] == 0 && matrix[randomRow, i + 2] == 0)
                    {
                        matrix[randomRow, i + 2] = 1;
                        mistakesCount++;
                        break;
                    }
                    if (matrix[randomRow, i] == 0 && matrix[randomRow, i + 1] == 0 && matrix[randomRow, i + 2] == 1)
                    {
                        matrix[randomRow, i] = 1;
                        mistakesCount++;
                        break;
                    }
                    if (matrix[randomRow, i] == 0 && matrix[randomRow, i + 1] == 0 && matrix[randomRow, i + 2] == 0)
                    {
                        matrix[randomRow, i + 1] = 1;
                        mistakesCount++;
                        break;
                    }
                }
            }
            this.numberOfMistakes = mistakesCount;
            return matrix;
        }

    }

    //class InputMatrix : RandomMatrix
    //{
    //    private int numerOfFieldsToDeleteForOptimalMatrix;
    //}
}
