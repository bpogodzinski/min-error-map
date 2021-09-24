using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace min_error_map
{
    class TabuSearch
    {
        public Matrix problemInstance = null;
        public Matrix globalSolution = null;
        public List<List<int>> indexesToChange = null;
        public int bestCmax = -1;
        Random randomGenerator = new Random(Guid.NewGuid().GetHashCode());

        private (Matrix, List<int>) makeMove(Matrix localSolutionCopy, List<(int,int)> tabuList)
        {
            var columnsIDsCopy = (int[])localSolutionCopy.ColumnIDs.Clone();
            List<int> randomSwap = null;
            do
            {
                randomSwap = columnsIDsCopy.Select(x => x)
                                                .OrderBy(x => randomGenerator.Next())
                                                .Take(2)
                                                .OrderByDescending(x => x)
                                                .ToList();


            } while (tabuList.Contains((randomSwap[0], randomSwap[1])));

            localSolutionCopy.swapColumns(randomSwap[0], randomSwap[1]);
            
            return (localSolutionCopy, randomSwap);
        }

        public TabuSearch(Matrix inputMatrix)
        {
            this.problemInstance = new Matrix(inputMatrix);
            this.bestCmax = this.problemInstance.calculateCmax().Item1;
        }

        public int run(int timesToRestart, int tabuListMaxSize, int maxMovesWithoutProgess, double divMoves, IProgress<int> progress, CancellationToken cts)
        {
            Matrix globalSolution = new Matrix(this.problemInstance);

            try
            {
                while (timesToRestart != 0)
                {
                    cts.ThrowIfCancellationRequested();
                    progress.Report(timesToRestart);
                    Matrix localSolution = new Matrix(this.problemInstance);
                    List<(int, int)> tabuList = new List<(int, int)>();
                    int movesWithoutProgress = 0;

                    while (movesWithoutProgress < maxMovesWithoutProgess)
                    {
                        // Make new move not in tabu and check new solution
                        var newLocalSolution = makeMove(new Matrix(localSolution), tabuList);
                        var newLocalSolutionMatrix = newLocalSolution.Item1;
                        var randomColumnSwap = newLocalSolution.Item2;
                        newLocalSolutionMatrix.calculateCmax();
                        localSolution.calculateCmax();

                        // Check if new solution is better and add to Tabu
                        if (newLocalSolutionMatrix.CMAX < localSolution.CMAX)
                        {
                            if (tabuList.Count > tabuListMaxSize)
                            {
                                tabuList.RemoveAt(0);
                            }
                            tabuList.Add((randomColumnSwap[0], randomColumnSwap[1]));
                            localSolution = new Matrix(newLocalSolutionMatrix);
                            movesWithoutProgress = 0;
                        }
                        // If we are stuck in local optimum, add some divesifying moves
                        else if (newLocalSolutionMatrix.CMAX == localSolution.CMAX && movesWithoutProgress > (int)(maxMovesWithoutProgess * divMoves))
                        {
                            localSolution = new Matrix(newLocalSolutionMatrix);
                            if (tabuList.Count > tabuListMaxSize)
                            {
                                tabuList.RemoveAt(0);
                            }
                            tabuList.Add((randomColumnSwap[0], randomColumnSwap[1]));
                            movesWithoutProgress++;
                        }
                        else
                            movesWithoutProgress++;
                    }

                    //If no progress is made, check global and local solutions                                
                    globalSolution.calculateCmax();
                    localSolution.calculateCmax();
                    if (localSolution.CMAX < globalSolution.CMAX)
                    {
                        globalSolution = new Matrix(localSolution);
                    }
                    timesToRestart--;
                }
            }
            catch (OperationCanceledException)
            {}

            this.globalSolution = new Matrix(globalSolution);
            this.globalSolution.calculateCmax();
            this.bestCmax = globalSolution.CMAX;
            this.indexesToChange = globalSolution.IndexesToChange;
            return timesToRestart;
        }

    }
}
