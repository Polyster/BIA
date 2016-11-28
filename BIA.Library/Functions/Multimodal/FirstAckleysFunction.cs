using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Multimodal
{
    public class FirstAckleysFunction : AbstractFunction
    {
        public override string FunctionName
        {
            get
            {
                return "Auckley's function I";
            }
        }
        public FirstAckleysFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        public override float CostFunction( params float[] parameters )
        {
            float result = 0f;
            for ( int i = 0; i < parameters.Length - 1; i++ )
            {
                result += (float)( ( 1 / Math.E ) * Math.Sqrt( parameters[i] * parameters[i] + parameters[i + 1] * parameters[i + 1] ) + 3 * ( Math.Cos( 2 * parameters[i] ) + Math.Sin( 2 * parameters[i + 1] ) ) );
            }
            return result;
        }
    }
}
