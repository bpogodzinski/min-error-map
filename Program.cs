﻿using System;
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

            //int[,] matrix = new int[,]
            //{
            //    {1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1 },
            //    {1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 0 },
            //    {1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1 },
            //    {1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
            //    {1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0 },
            //    {1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
            //    {1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0 },
            //    {1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1 },
            //};

            int[,] matrix = new int[,]
            {
                {1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1},
                {1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0},
                {1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 0, 1, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1},
                {1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0},
                {0, 1, 1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 1, 1},
                {1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 1, 1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 1, 1},
                {1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0},
                {1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0},
                {1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0},
                {1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0},
                {1, 1, 1, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0},
                {1, 1, 1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0},
                {0, 1, 1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 1, 1},
                {1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {1, 1, 1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0},
                {1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
                {1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0},
                {1, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0},
                {0, 1, 1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 1, 1},
                {1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0},
                {1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0},
            };


            //var x = 25;
            ////var matrix = new RandomMatrix(x, x, (int)(x*2) , 0.3);
            ////Debug.Assert(matrix.isConsecutiveOnes() == false);
            //Debug.WriteLine("Before");
            //var m = new Matrix(matrix);
            //m.calculateCmax();
            //Debug.WriteLine(m.ToString());
            //Debug.WriteLine("");
            //TabuSearch ts = new TabuSearch(m);
            //ts.run(100, 20, 100);
            //Debug.WriteLine("After");
            //Debug.WriteLine("");
            //Debug.WriteLine(ts.globalSolution.ToString());

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

            Application.Run(new mainForm());

        }
    }
}
