using System;
using System.Collections.Generic;
using System.Linq;
using BIA.Library.Functions;

namespace BIA.Library.Points
{
    public class PopulationManager
    {
        public bool DSHVaules { get; set; }
        public int Dimension { get { return dimension; } }

        private Random rand;
        private int dimension;

        public PopulationManager(int dimension)
        {
            rand = new Random();
            this.dimension = dimension;
        }

        /// <summary>
        /// Generates population for a given function
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public List<Individual> GeneratePopulation(AbstractFunction function, int populationSize)
        {
            List<Individual> population = new List<Individual>();
            for (int i = 0; i < populationSize; i++)
            {
                population.Add(GenerateIndividual(function, function.LowBound[0], function.HighBound[0]));
            }
            return population;
        }

        /// <summary>
        /// Generates single individual for a given function
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public Individual GenerateIndividual( AbstractFunction function, float lowBound, float highBound )
        {
            Individual individual = new Individual();
            individual.Parameters = new float[dimension];
            for ( int i = 0; i < dimension; i++ )
            {
                float x = (float)( rand.NextDouble() * (highBound - lowBound) + lowBound );
                individual.Parameters[i] = DSHVaules ? (int)x : x;
            }
            CheckBounds( individual, function );
            individual.Fitness = DSHVaules ? function.CostFunction( individual.Parameters.Select(x=>(float)(int)x).ToArray())
                                           : function.CostFunction( individual.Parameters );
            return individual;
        }
        public void CheckBounds( Individual individual, AbstractFunction function )
        {
            for ( int i = 0; i < individual.Parameters.Length; i++ )
            {
                if ( individual.Parameters[i] > function.HighBound[i] )
                    individual.Parameters[i] = function.HighBound[i];
                else if ( individual.Parameters[i] < function.LowBound[i] )
                    individual.Parameters[i] = function.LowBound[i];
            }
        }
    }
}
