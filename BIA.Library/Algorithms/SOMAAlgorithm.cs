using System;
using System.Collections.Generic;
using BIA.Library.Functions;

namespace BIA.Library.Algorithms
{
    public class SOMAAlgorithm : AbstractAlgorithm
    {
        private float pathLength;
        private float step;
        private float perturbation;
        private float t;
        private int migrations;
        private int maxMigrations;

        private Random rand;
        public override string AlgorithmName
        {
            get
            {
                return "SOMA";
            }
        }

        public SOMAAlgorithm(int maxMigrations,  float pathLength, float step, float perturbation )
        {
            this.pathLength = pathLength;
            this.step = step;
            this.perturbation = perturbation;
            this.t = 0f;
            this.rand = new Random();
            this.maxMigrations = maxMigrations;
            migrations = 0;
        }

        public override bool IsFinnished
        {
            get
            {
                return migrations >= maxMigrations;
            }
        }

        public override void Execute(AbstractFunction func)
        {
            List<Points.Individual> jumps = new List<Points.Individual>();
            List<Points.Individual> newPopulation = new List<Points.Individual>();
            var leader = GetBestIndividual(Population);
            Population.Remove(leader);
            newPopulation.Add(leader);
            for (int i = 0; i < Population.Count; i++)
            {
                float[] pertVector = GeneratePerturbationVector();
                while (t <= pathLength)
                {
                    float[] parameters = new float[PopulationManager.Dimension];
                    for (int j = 0; j < PopulationManager.Dimension; j++)
                    {
                        parameters[j] = Population[i].Parameters[j] + (leader.Parameters[j] - Population[i].Parameters[j]) * t * pertVector[j];
                    }
                    Points.Individual newIndividual = new Points.Individual { Parameters = parameters};
                    PopulationManager.CheckBounds(newIndividual, func);
                    newIndividual.Fitness = func.CostFunction(parameters);

                    jumps.Add(newIndividual);
                    t += step;
                }
                jumps.Add(Population[i]);
                var bestJumper = GetBestIndividual(jumps);
                newPopulation.Add(bestJumper);
                jumps.Clear();
                t = 0;
            }
            Population.Clear();
            Population.AddRange(newPopulation);
            newPopulation.Clear();
            migrations++;
        }

        private float[] GeneratePerturbationVector()
        {
            float[] prt = new float[PopulationManager.Dimension];
            for (int i = 0; i < PopulationManager.Dimension; i++)
            {
                if(rand.NextDouble() < perturbation)
                {
                    prt[i] = 1;
                }
                else
                {
                    prt[i] = 0;
                }
            }
            return prt;
        }
    }
}
