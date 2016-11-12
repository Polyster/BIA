using BIA.Library.Functions;
using BIA.Library.Points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BIA.Library.Algorithms
{
    public class SimulatedAnnealingAlgorithm : AbstractAlgorithm
    {
        private float temperature;
        private float radius;
        private float finalTemp;
        private static readonly float BETA = 0.03f;
        private Random rand = new Random();
        private Individual currentSolution;
        public override string AlgorithmName
        {
            get
            {
                return "Simulated annealing";
            }
        }

        public override bool IsFinnished
        {
            get
            {
                return temperature <= finalTemp;
            }
        }
        public SimulatedAnnealingAlgorithm(float temperature, float finalTemp, float radius)
        {
            this.temperature = temperature;
            this.finalTemp = finalTemp;
            this.radius = radius;
            this.Population = new List<Individual>();
        }
        public override void Execute(AbstractFunction func)
        {
            currentSolution = Population.First();
            float lowBound = func.LowBound[0] + radius;
            float highBound = func.HighBound[0] + radius;

            //while or if depends..
            while (!IsFinnished)
            {
                float fitness = currentSolution.Fitness;
                Individual neighbor = PopulationManager.GenerateIndividual( func, lowBound, highBound );

                PopulationManager.CheckBounds( neighbor, func );

                float neighbourFitness = neighbor.Fitness;

                double probabilty = AcceptanceProbability(fitness, neighbourFitness);
                if (probabilty > rand.NextDouble())
                {
                    Population.Clear();
                    currentSolution = neighbor;
                    Population.Add(currentSolution);
                }
                Alpha();
            }
        }
      
        public double AcceptanceProbability(double energy, double newEnergy)
        {
            if (newEnergy < energy)
            {
                return 1;
            }
            else
            {
                return Math.Exp( -( newEnergy - energy ) / this.temperature );
            }
        }
        public void Alpha()
        {
            this.temperature = this.temperature / (1 + BETA * this.temperature);
        }
    }
}
