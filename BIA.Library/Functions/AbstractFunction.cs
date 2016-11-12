using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions
{
    public abstract class AbstractFunction
    {
        protected float[] highBound;
        protected float[] lowBound;
        public abstract string FunctionName { get; }
        public float Xmax
        {
            get
            {
                return HighBound[0];
            }
        }
        public float Ymax
        {
            get
            {
                return HighBound[1];
            }
        }
        public float Xmin
        {
            get
            {
                return LowBound[0];
            }
        }
        public float Ymin
        {
            get
            {
                return LowBound[1];
            }
        }
        public float[] HighBound
        {
            get
            {
                return this.highBound;
            }
            set
            {
                this.highBound = value;
            }
        }
        public float[] LowBound
        {
            get
            {
                return this.lowBound;
            }
            set
            {
                this.lowBound = value;
            }
        }

        /// <summary>
        /// Computes Z for 3D
        /// </summary>
        /// <returns>Value of Z</returns>
        public Func<float, float, float> CostFunction3D()
        {
            return ( x, y ) => CostFunction( x, y );
        }
        /// <summary>
        /// Calculates fitness for N dimensions
        /// </summary>
        /// <param name="parameters">Dimension</param>
        /// <returns>Fitness</returns>
        public abstract float CostFunction( params float[] parameters );

        /// <summary>
        /// Returns a name of function
        /// </summary>
        /// <returns>Returns a name of function</returns>
        public override string ToString()
        {
            return FunctionName;
        }
    }
}
