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

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RandomMatrix m = new RandomMatrix(10, 10, 0, 0.55);
            var xd = m.ColumnIDs;
            xd[0] = 99999999;
            //int[] row = new int[] { 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1, 0 };
            //row = row.Reverse().ToArray();
            //int[] row = new int[] { 1, 1, 1, 0, 0, 1, 0 };
            //row = row.Reverse().ToArray();

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
