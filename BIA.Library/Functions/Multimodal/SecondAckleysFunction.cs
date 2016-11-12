using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Multimodal
{
    public class SecondAckleysFunction : AbstractFunction
    {
        public override string FunctionName
        {
            get
            {
                return "Auckley's function II";
            }
        }
        public SecondAckleysFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        public override float CostFunction( params float[] parameters )
        {
            float result = 0f;
            for ( int i = 0; i < parameters.Length - 1; i++ )
            {
                result += (float)( 20 + Math.E - ( 20 / ( Math.Pow( Math.E, ( 0.2 * Math.Sqrt( ( ( parameters[i] * parameters[i] + parameters[i + 1] * parameters[i + 1] ) / 2 ) ) ) ) ) )
                                                - Math.Pow( ( Math.E ), ( 0.5 * ( ( Math.Cos( 2 * Math.PI * parameters[i] ) ) + ( Math.Cos( 2 * Math.PI * parameters[i+1] ) ) ) ) ) );
            }
            return result;
        }
    }
}
