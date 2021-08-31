using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_error_map
{
    class Matrix
    {
        private int [,] _matrix;
        private int _width;
        private int _height;

        public int [,] matrix
        {
            get { return _matrix; }
        }

        public Matrix(int width, int height)
        {
            this._width = width;
            this._height = height;
        }
    }
}
