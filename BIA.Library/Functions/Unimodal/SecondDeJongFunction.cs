using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Unimodal
{
    /// <summary>
    /// Rosenbrock's saddle
    /// </summary>
    public class SecondDeJongFunction : AbstractFunction
    {
        public override string FunctionName
        {
            get
            {
                return "2nd De Jong function";
            }
        }
        public SecondDeJongFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }
        //public override float[] HighBound
        //{
        //    get
        //    {
        //        return new float[] { 5f, 5f };
        //    }
        //}

        //public override float[] LowBound
        //{
        //    get
        //    {
        //        return new float[] { -5f, -5f };
        //    }
        //}

        public override float CostFunction( params float[] parameters )
        {
            float result = 0f;
            for ( int i = 0; i < parameters.Length-1; i++ )
            {
                result += (float)( 100 * Math.Pow( parameters[i] * parameters[i] - parameters[i+1], 2 ) + Math.Pow( 1 - parameters[i], 2 ) );
            }
            return result;
        }
    }
}
