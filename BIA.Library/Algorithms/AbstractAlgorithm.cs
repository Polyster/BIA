using BIA.Library.Functions;
using BIA.Library.Points;
using System;
using System.Linq;
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
        public Individual GetBestIndividual(List<Individual> population)
        {
            return 
            (
                from individual in population
                where individual.Fitness == population.Min(x => x.Fitness)
                select individual
            ).First();
        }
        public override string ToString()
        {
            return AlgorithmName;
        }
    }
}
