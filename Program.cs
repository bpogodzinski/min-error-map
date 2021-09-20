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
            //int[,] matrix = new int[,] { { 1, 0, 0}, { 1, 0, 0} };
            RandomMatrix xd = new RandomMatrix(100, 100, 16, 0.4);
            //Matrix xd = new Matrix(matrix);
            Console.WriteLine(xd.ToString());
            xd.swapColumns(0, 1);
            Console.WriteLine(xd.ToString());
            Application.Run(new Form1());
        }
    }
}
