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

        public int [,] matrix
        {
            get { return _matrix; }
        }

        public Matrix(int width, int height)
        {
            this._width = width;
            this._height = height;
            this._matrix = new int[height, width];
        }

        public Matrix(int [,] matrix)
        {
            this._matrix = matrix;
            this._height = matrix.GetLength(0);
            this._width = matrix.GetLength(1);
        }
        
        public Matrix(Matrix matrix)
        {
            this._matrix = matrix._matrix;
            this._height = matrix._matrix.GetLength(0);
            this._width = matrix._matrix.GetLength(1);
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
        private float percentageOfOnesInRow = 0;
        private Random randomGenerator = new Random();

        public RandomMatrix(int width, int height, int numberOfMistakes, float percentageOfOnesInRow)
            : base(width, height)
        {
            this.numberOfMistakes = numberOfMistakes;
            this.percentageOfOnesInRow = percentageOfOnesInRow;
            this._matrix = this.generateRandomMatrix(this._matrix);
        }

        public RandomMatrix(int [,] matrix, int numberOfMistakes, float percentageOfOnesInRow)
            : base(matrix)
        {
            this.numberOfMistakes = numberOfMistakes;
            this.percentageOfOnesInRow = percentageOfOnesInRow;
            this._matrix = this.generateRandomMatrix(this._matrix);
        }
        
        public RandomMatrix(Matrix matrix, int numberOfMistakes, float percentageOfOnesInRow)
            : base(matrix)
        {
            this.numberOfMistakes = numberOfMistakes;
            this.percentageOfOnesInRow = percentageOfOnesInRow;
            this._matrix = this.generateRandomMatrix(this._matrix);
        }

        private int[,] generateRandomMatrix(int [,] matrix)
        {
            fillMatrixWithOnes(ref matrix);
            mixMatrixRows(ref matrix);
            addMistakesToMatrix(ref matrix);
            return matrix;
        }
        private void fillMatrixWithOnes(ref int[,] matrix)
        {
            throw new NotImplementedException();
        }
        private void mixMatrixRows(ref int[,] matrix)
        {
            throw new NotImplementedException();
        }

        private void addMistakesToMatrix(ref int[,] matrix)
        {
            throw new NotImplementedException();
        }

    }

    //class InputMatrix : RandomMatrix
    //{
    //    private int numerOfFieldsToDeleteForOptimalMatrix;
    //}
}
