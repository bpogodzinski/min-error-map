using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_error_map
{
    class TabuSearch
    {
        Matrix globalSolution = null;
        int bestCmax = -1;
        Random randomGenerator = new Random(Guid.NewGuid().GetHashCode());

        private void makeMove(Matrix localSolution, List<(int,int)> tabuList)
        {
            //var randomSwap = localSolution.
        }

        public TabuSearch(Matrix inputMatrix)
        {
            this.globalSolution = inputMatrix;
            this.bestCmax = inputMatrix.calculateCmax().Item1;
        }

        public void run(int timesToRestart, int tabuListSize)
        {
            Matrix localSolution = new Matrix(globalSolution);
            List<(int, int)> tabuList = new List<(int, int)>();
            List<Matrix> localSolutionsList = new List<Matrix>();

            while(timesToRestart != 0)
            {
                makeMove(localSolution, tabuList);
            }

        }

    }
}
