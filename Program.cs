using System;
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
            // Patrition indexes of ones into list
            var partitions = partitionOnesIntoConsecutiveListOfIndexes(row);
            // Find first longest sequence
            var longestSequence = partitions.OrderByDescending(m => m.Count()).First();
            var indexOfLongestSequenceOnList = partitions.IndexOf(longestSequence);
            // Start calculating from most right
            for (int i = partitions.Count - 1; i >= indexOfLongestSequenceOnList; i--)
            {
                // Longest sequence is at most right
                if (partitions[i] == longestSequence)
                    break;

                var xd = partitions[i];
                Console.WriteLine("xd");
            }
            // Calculate left side
            Console.WriteLine("xd");
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //int[] row = new int[] { 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1, 0 };
            int[] row = new int[] { 1, 1, 0, 0, 1, 1, 1 };
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
