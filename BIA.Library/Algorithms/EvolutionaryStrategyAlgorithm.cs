using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIA.Library.Functions;
using BIA.Library.Points;

namespace BIA.Library.Algorithms
{
    public class EvolutionaryStrategyAlgorithm : AbstractAlgorithm
    {
        private int maxCycles;
        private int cycle;
        private int countOfMutants;
        private int esVersion;
        private double stdDeviation;
        public override string AlgorithmName
        {
            get
            {
                return "Evolutionary strategy";
            }
        }

        public EvolutionaryStrategyAlgorithm(int maxCycles, int countOfMutants, int es_version, double stdDeviation)
        {
            this.maxCycles = maxCycles;
            this.cycle = 0;
            this.countOfMutants = countOfMutants;
            this.esVersion = es_version;
            this.stdDeviation = stdDeviation;
        }

        public override bool IsFinnished
        {
            get
            {
                return cycle >= maxCycles;
            }
        }

        public override void Execute( AbstractFunction func )
        {
            List<Individual> newPopulation = new List<Individual>();
            for (int i = 0; i < Population.Count; i++)
            {
                for (int j = 0; j < countOfMutants; j++)
                {
                    var child = Mutate(func, Population[j]);
                    newPopulation.Add(child);
                }
            }
            if (esVersion == 0)
                newPopulation.AddRange(Population);
            newPopulation.Sort((x, y) => x.Fitness.CompareTo(y.Fitness));
            int popSize = Population.Count;

            Population.Clear();
            Population.AddRange(newPopulation.Take(popSize));
            newPopulation.Clear();
            cycle++;
        }

        private Individual Mutate(AbstractFunction func, Individual parent)
        {
            float[] vector = new float[parent.Parameters.Length];
            for (int i = 0; i < parent.Parameters.Length; i++)
            {
                vector[i] = (float)(NextGaussian(0,stdDeviation) * (func.HighBound[i] - func.LowBound[i]));
            }
            var tmp = new Individual();
            tmp.Parameters = new float[parent.Parameters.Length];
            for (int i = 0; i < parent.Parameters.Length; i++)
            {
                tmp.Parameters[i] = vector[i] + parent.Parameters[i];
            }
            PopulationManager.CheckBounds(tmp, func);
            tmp.Fitness = func.CostFunction(tmp.Parameters);
            return tmp;
        }
        private double NextGaussian(double mu, double sigma)
        {
            Random rand = new Random();
            var u1 = rand.NextDouble();
            var u2 = rand.NextDouble();

            var rand_std_normal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                                Math.Sin(2.0 * Math.PI * u2);

            var rand_normal = mu + sigma * rand_std_normal;

            return rand_normal;
        }
    }
}
