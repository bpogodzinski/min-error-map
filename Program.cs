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
            RandomMatrix xd = new RandomMatrix(matrix, 16, 0.4);
            Console.WriteLine(xd.ToString());
            Application.Run(new Form1());
        }
    }
}
