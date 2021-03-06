using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace min_error_map
{
    public class Matrix
    {
        protected int[,] _matrix = null;
        protected int _width = 0;
        protected int _height = 0;
        protected int[] _columnIDs = null;
        protected int _cmax = -1;
        protected List<List<int>> _indexesToChange = null;

        public int[,] matrix
        {
            get { return _matrix; }
        }

        public int[] ColumnIDs
        {
            get { return _columnIDs; }
        }
        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get { return _height; }
        }

        public int CMAX
        {
            get { return _cmax; }
        }
        public List<List<int>> IndexesToChange
        {
            get { return _indexesToChange; }
        }

        public Matrix(int width, int height)
        {
            this._width = width;
            this._height = height;
            this._matrix = new int[height, width];
            this._columnIDs = Enumerable.Range(0, this._width).ToArray();
        }

        public Matrix(int[,] matrix)
        {
            this._matrix = (int[,])matrix.Clone();
            this._height = matrix.GetLength(0);
            this._width = matrix.GetLength(1);
            this._columnIDs = Enumerable.Range(0, this._width).ToArray();
        }

        public Matrix(Matrix matrix)
        {
            this._matrix = (int[,])matrix._matrix.Clone();
            this._height = matrix._height; 
            this._width = matrix._width;
            this._columnIDs = (int[])matrix._columnIDs.Clone();
            this._cmax = matrix._cmax;
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

        private bool isRowConsecutiveOnes(int[] row)
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

        
        // { 1, 1, 0, 0, 1, 1, 1, 0, 1 }
        // [ [0,1], [4,5,6], [8] ]
        private List<List<int>> partitionOnesIntoConsecutiveListOfIndexes(int[] row)
        {
            var indexesOfOnes = row.Select((b, i) => b == 1 ? i : -1).Where(i => i != -1).ToArray();
            List<List<int>> partitionedOnes = new List<List<int>>();
            List<int> currentSequence = new List<int>() { indexesOfOnes[0] };

            for (int i = 0; i < indexesOfOnes.Length - 1; i++)
            {
                if ((indexesOfOnes[i] + 1) == indexesOfOnes[i + 1])
                {
                    currentSequence.Add(indexesOfOnes[i + 1]);
                }
                else
                {
                    partitionedOnes.Add(new List<int>(currentSequence));
                    currentSequence.Clear();
                    currentSequence.Add(indexesOfOnes[i + 1]);
                }
            }
            partitionedOnes.Add(new List<int>(currentSequence));
            return partitionedOnes;
        }

        private Tuple<int, List<int>> cmaxRow(int[] row)
        {
            List<int> indexesToChange = new List<int>();
            int cmax = 0;
            // Patrition indexes of ones into list
            var partitions = partitionOnesIntoConsecutiveListOfIndexes(row);
            // Find first longest sequence
            var longestSequence = partitions.OrderByDescending(m => m.Count()).First();
            var indexOfLongestSequenceOnList = partitions.IndexOf(longestSequence);
            var rightPartitions = partitions.Where((item, index) => index > indexOfLongestSequenceOnList).ToList();
            var leftPartitions = partitions.Where((item, index) => index < indexOfLongestSequenceOnList).ToList();

            while (rightPartitions.Count != 0)
            {
                var currentPartition = rightPartitions.Last();

                int leftIndexOnes = longestSequence.Last();
                int rightIndexOnes = currentPartition.Last();
                var distance = rightIndexOnes - leftIndexOnes;
                //{ 1, 1, 1, 1, 1, | 0, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1 |, 0 }; first slice
                var slice = row.Skip(leftIndexOnes + 1).Take(distance).ToArray(); // +1 because we don't want to take "leftover" one
                var numberOfOnes = slice.Count(x => x == 1);
                /*
                 * If change is optimal
                 * - save cmax
                 * - calculate left side
                 * If not
                 *  - remove one "one"
                 *  - new iteration
                 */
                if (distance - numberOfOnes <= numberOfOnes)
                {
                    cmax += distance - numberOfOnes;
                    var indexesOfZeroToChange = slice.Select((b, i) => b == 0 ? i + leftIndexOnes + 1 : -1).Where(i => i != -1).ToList();
                    indexesToChange.AddRange(indexesOfZeroToChange);
                    break;
                }
                else
                {
                    cmax += 1;
                    var indexOfOneToRemove = currentPartition.Last();
                    currentPartition.RemoveAt(currentPartition.Count - 1);
                    indexesToChange.Add(indexOfOneToRemove);
                    if (currentPartition.Count == 0)
                        rightPartitions.Remove(currentPartition);
                }
            }

            while (leftPartitions.Count != 0)
            {
                var currentPartition = leftPartitions.First();

                int leftIndexOnes = currentPartition.First();
                int rightIndexOnes = longestSequence.First();
                var distance = rightIndexOnes - leftIndexOnes;
                //{0, | 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 1, 0, 0, | 1, 1, 1, 1, 1 };
                var slice = row.Skip(leftIndexOnes + 1).Take(distance).ToArray();
                var numberOfOnes = slice.Count(x => x == 1);
                if (distance - numberOfOnes <= numberOfOnes)
                {
                    cmax += distance - numberOfOnes;
                    var indexesOfZeroToChange = slice.Select((b, i) => b == 0 ? i + leftIndexOnes + 1 : -1).Where(i => i != -1).ToList();
                    indexesToChange.AddRange(indexesOfZeroToChange);
                    break;
                }
                else
                {
                    cmax += 1;
                    var indexOfOneToRemove = currentPartition.Last();
                    currentPartition.RemoveAt(currentPartition.Count - 1);
                    indexesToChange.Add(indexOfOneToRemove);
                    if (currentPartition.Count == 0)
                        leftPartitions.Remove(currentPartition);
                }
            }

            return new Tuple<int, List<int>>(cmax, indexesToChange);
        }

        public Tuple<int, List<List<int>>> calculateCmax()
        {
            int cmaxSum = 0;
            List<List<int>> indexesToChange = new List<List<int>>();

            for (int i = 0; i < this._height; i++)
            {
                var row = getRow(i);
                var rowResult = cmaxRow(row);
                cmaxSum += rowResult.Item1;
                indexesToChange.Add(rowResult.Item2);
            }
            this._cmax = cmaxSum;
            this._indexesToChange = indexesToChange;
            return new Tuple<int, List<List<int>>>(cmaxSum, indexesToChange);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Columns order: {String.Join(" ", this._columnIDs)}\n" +
                $"CMAX: {this._cmax}");

            if(IndexesToChange != null)
            {
                stringBuilder.Append("Indexes to change: ");
                for (int i = 0; i < IndexesToChange.Count; i++)
                {
                    foreach(var col in IndexesToChange[i])
                    {
                        stringBuilder.Append($"[{i},{col}] ");
                    }
                }
                stringBuilder.AppendLine();
            }

            for (int i = 0; i < this._height; ++i)
            {
                stringBuilder.AppendLine(String.Join(" ", this.getRow(i)));
            }

            return stringBuilder.ToString();
        }

        public string matrixToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < this._height; ++i)
            {
                stringBuilder.AppendLine(String.Join(" ", this.getRow(i)));
            }
            stringBuilder.Length = stringBuilder.Length - 2; //remove last newline + CR
            return stringBuilder.ToString();
        }
    }

    class RandomMatrix : Matrix
    {
        public int numberOfMistakes = 0;
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

        public RandomMatrix(int[,] matrix, int numberOfMistakes, double percentageOfOnesInRow)
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

        private int[,] fillMatrixWithOnes(int[,] matrix)
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

            var rowsToChange = Enumerable.Repeat(Enumerable.Range(0, height).ToArray(),
                                                (int)Math.Ceiling((double)this.numberOfMistakes / height))
                                        .SelectMany(x => x)
                                        .OrderBy(row => this.randomGenerator.Next())
                                        .Take(this.numberOfMistakes);

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


}
