using System;
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

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < this._height; ++i)
            {
                stringBuilder.AppendLine(String.Join(" ", this.getRow(i)));
            }
            return stringBuilder.ToString();
        }
    }

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
            this.originalMatrix = this._matrix;
            this._matrix = this.mixMatrixRows(this._matrix);
            this._matrix = this.addMistakesToMatrix(this._matrix);
        }

        public RandomMatrix(int [,] matrix, int numberOfMistakes, double percentageOfOnesInRow)
            : base(matrix)
        {
            this.numberOfMistakes = numberOfMistakes;
            this.percentageOfOnesInRow = percentageOfOnesInRow;
            this._matrix = this.fillMatrixWithOnes(this._matrix);
            this.originalMatrix = this._matrix;
            this._matrix = this.mixMatrixRows(this._matrix);
            this._matrix = this.addMistakesToMatrix(this._matrix);
        }
        
        public RandomMatrix(Matrix matrix, int numberOfMistakes, double percentageOfOnesInRow)
            : base(matrix)
        {
            this.numberOfMistakes = numberOfMistakes;
            this.percentageOfOnesInRow = percentageOfOnesInRow;
            this._matrix = this.fillMatrixWithOnes(this._matrix);
            this.originalMatrix = this._matrix;
            this._matrix = this.mixMatrixRows(this._matrix);
            this._matrix = this.addMistakesToMatrix(this._matrix);
        }

        private int [,] fillMatrixWithOnes(int[,] matrix)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            int lengthStringOfOnes = Convert.ToInt32(Math.Floor(this.percentageOfOnesInRow * width));
            bool areAllCollumnsCovered = false;
            int startPositionOfOnes = 0;
            int endPositionOfOnes = 0;

            for (int i = 0; i < height; i++)
            {
                startPositionOfOnes = areAllCollumnsCovered ? this.randomGenerator.Next(width - lengthStringOfOnes) : endPositionOfOnes;
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
