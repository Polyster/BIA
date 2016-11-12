using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIA.Library.Functions;

namespace BIA.Library.Algorithms
{
    public class SOMAAlgorithm : AbstractAlgorithm
    {
        private float pathLength;
        private float step;
        private float perturbateVect;
        private int maxGenerations;
        public override string AlgorithmName
        {
            get
            {
                return "SOMA";
            }
        }

        public SOMAAlgorithm(float pathLength, float step, float perturbateVect )
        {
            this.pathLength = pathLength;
            this.step = step;
            this.perturbateVect = perturbateVect;
        }

        public override bool IsFinnished
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override void Execute( AbstractFunction func )
        {
            throw new NotImplementedException();
        }
    }
}
