using BIA.Library.Functions;
using BIA.Library.Points;
using System;
using System.Collections.Generic;

namespace BIA.Library.Algorithms
{
    public abstract class AbstractAlgorithm
    {
        public abstract string AlgorithmName { get; }
        public abstract void Execute( AbstractFunction func );
        public abstract bool IsFinnished { get; }
        public List<Individual> Population { get; set; }
        public PopulationManager PopulationManager { get; set; }
        public override string ToString()
        {
            return AlgorithmName;
        }
    }
}
