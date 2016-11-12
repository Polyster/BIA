using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Multimodal
{
    public class SineEnvelopeSineWaveFunction : AbstractFunction
    {
        public override string FunctionName
        {
            get
            {
                return "Sine Envelope Sine Wave function";
            }
        }
        public SineEnvelopeSineWaveFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        public override float CostFunction( params float[] parameters )
        {
            float result = 0f;
            for ( int i = 0; i < parameters.Length - 1; i++ )
            {
                result += (float)-( 0.5 + ( ( Math.Pow( Math.Sin( Math.Pow( parameters[i], 2 ) + Math.Pow( parameters[i + 1], 2 ) - 0.5 ), 2 ) )
                    / ( Math.Pow( 1 + 0.001 * ( Math.Pow( parameters[i], 2 ) + Math.Pow( parameters[i+1], 2 ) ), 2 ) ) ) );
            }
            return result;
        }
    }
}
