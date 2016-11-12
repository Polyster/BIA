using BIA.Library.Functions;
using BIA.Library.Points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Algorithms
{
    public class BlindSearchAlgorithm : AbstractAlgorithm
    {
        public override string AlgorithmName
        {
            get
            {
                return "Blind Search";
            }
        }

        private int generations = 0;
        public override bool IsFinnished
        {
            get
            {
                return generations >= 20;
            }
        }

        public override void Execute(AbstractFunction func)
        {
            var best = (from individual in Population
                        where individual.Fitness == Population.Min(x => x.Fitness)
                        select individual ).First();
            var population = PopulationManager.GeneratePopulation(func, Population.Count-1);
            population.Add( best );
            Population = population;
            generations++;
        }
    }
}
