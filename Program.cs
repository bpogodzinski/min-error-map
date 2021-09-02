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
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            Matrix test = new Matrix(matrix);
            Console.WriteLine(test.ToString());
            Application.Run(new Form1());
        }
    }
}
