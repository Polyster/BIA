using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIA.Library.Functions;
using BIA.Library.Points;

namespace BIA.Library.Algorithms
{
    public class DifferentialEvolutionAlgorithm : AbstractAlgorithm
    {
        private float CR;
        private float F;
        private int maxGenerations;
        private int generation;
        private Random rand;
        public override string AlgorithmName
        {
            get
            {
                return "Differential evolution";
            }
        }

        public override bool IsFinnished
        {
            get
            {
                return generation >= maxGenerations;
            }
        }

        public DifferentialEvolutionAlgorithm( int generations, float CR, float F )
        {
            this.generation = 0;
            this.maxGenerations = generations;
            this.rand = new Random();
            this.CR = CR;
            this.F = F;
            this.Population = new List<Individual>();
        }
        public override void Execute( AbstractFunction func )
        {
            List<Individual> newPopulation = new List<Individual>();
            for ( int i = 0; i < Population.Count; i++ )
            {
                var randomInstances = PickRandomInstancies( Population );
                Individual original = Population[i];
                Individual candidate = (Individual)original.Clone();

                Individual a = randomInstances[1];
                Individual b = randomInstances[2];
                Individual c = randomInstances[3];

                for ( int j = 0; j < PopulationManager.Dimension; j++ )
                {
                    if ( rand.NextDouble() <= CR )
                    {
                        candidate.Parameters[j] = a.Parameters[j] + ( F * ( b.Parameters[j] - c.Parameters[j] ) );
                    }
                }
                PopulationManager.CheckBounds( candidate, func );

                candidate.Fitness = PopulationManager.DSHVaules ? (int)func.CostFunction(candidate.Parameters) 
                                                                : func.CostFunction( candidate.Parameters );
                if ( candidate.Fitness < original.Fitness )
                {
                    newPopulation.Add( candidate );
                }
                else
                {
                    newPopulation.Add( original );
                }
            }
            Population.Clear();
            Population.AddRange( newPopulation );
            generation++;
        }
        private List<Individual> PickRandomInstancies( List<Individual> data )
        {
            List<Individual> randomInstancies = new List<Individual>();

            for ( int i = 0; i < 4; i++ )
            {
                while (true)
                {
                    int randomIndex = rand.Next( data.Count );
                    var randomVector = data[randomIndex];
                    if (!randomInstancies.Contains(randomVector))
                    {
                        randomInstancies.Add( randomVector );
                        break;
                    }
                }
            }
            return randomInstancies;
        }
    }
}