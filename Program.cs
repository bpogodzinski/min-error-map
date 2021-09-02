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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int[,] matrix = new int[8, 8];
            RandomMatrix xd = new RandomMatrix(matrix, 0, 0.6);
            var xd1 = xd.fillMatrixWithOnes(matrix);
            Console.WriteLine(new Matrix(xd1).ToString());
            xd1 = xd.mixMatrixRows(xd1);
            Console.WriteLine(new Matrix(xd1).ToString());
            Application.Run(new Form1());
        }
    }
}
