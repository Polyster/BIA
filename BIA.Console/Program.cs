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
            var population = popManager.GeneratePopulation( function, 30 );

            //AbstractAlgorithm algorithm = new DifferentialEvolutionAlgorithm( 305, 0.5f, 0.8f );
            AbstractAlgorithm algorithm = new SOMAAlgorithm(305, 3f, 0.3f, 0.3f);

            algorithm.PopulationManager = popManager;
            algorithm.Population = population.Select( x => (Individual)x.Clone() ).ToList();

            int generation = 0;
            while ( !algorithm.IsFinnished )
            {
                algorithm.Execute( function );
                if (generation % 5 == 0)
                {
                    var best = algorithm.GetBestIndividual(algorithm.Population).Fitness;
                    System.Console.WriteLine(best);
                }
                generation++;
            }
            System.Console.WriteLine(); 
        }
    }
}
