using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIA.Library.Algorithms;
using BIA.Library.Functions;
using BIA.Library.Functions.Unimodal;
using BIA.Library.Functions.Multimodal;
using BIA.Library.Points;

namespace BIA.Console
{
    class Program
    {
        static void Main( string[] args )
        {
            float[] highBound = new float[] { 500f, 500f, 500f, 500f, 500f, 500f, 500f, 500f, 500f, 500f };
            float[] lowBound = new float[] { -500f, -500f, -500f, -500f, -500f, -500f, -500f, -500f, -500f, -500f };
            AbstractFunction function = new SchwefelsFunction( lowBound, highBound );

            PopulationManager popManager = new PopulationManager( 10 );
            var population = popManager.GeneratePopulation( function, 40 );
            AbstractAlgorithm algorithm = new DifferentialEvolutionAlgorithm( 100, 0.5f, 0.8f );
            algorithm.PopulationManager = popManager;
            algorithm.Population = population.Select( x => (Individual)x.Clone() ).ToList();

            int i = 0;
            while ( !algorithm.IsFinnished )
            {
                algorithm.Execute( function );
                if ( i % 5 == 0 )
                { 
                    var best = (
                                 from individual in algorithm.Population
                                 where individual.Fitness == algorithm.Population.Min( x => x.Fitness )
                                 select individual 
                               ).First().Fitness;
                    System.Console.WriteLine(best);
                }
                i++;
            }
            System.Console.WriteLine(); 
        }
    }
}
