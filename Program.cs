using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace min_error_map
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>

        // { 1, 1, 0, 0, 1, 1, 1, 0, 1 }
        // [ [0,1], [4,5,6], [8] ]
        public static List<List<int>> partitionOnesIntoConsecutiveListOfIndexes(int[] row)
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

        public static void cmax(int[] row)
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
                if(distance - numberOfOnes <= numberOfOnes)
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
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int[] row = new int[] { 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1, 0 };
            row = row.Reverse().ToArray();
            //int[] row = new int[] { 1, 1, 1, 0, 0, 1, 0 };
            //row = row.Reverse().ToArray();
            Program.cmax(row);

            //int[,] m = new int[,] { { 0, 0 }, { 0, 0 } };
            //Matrix original = new Matrix(m);
            //Matrix copy = new Matrix(m);
            //copy.matrix[0, 0] = 1;
            //Console.WriteLine(original.ToString());
            //Console.WriteLine(copy.ToString());


            Application.Run(new Form1());
        }
    }
}
