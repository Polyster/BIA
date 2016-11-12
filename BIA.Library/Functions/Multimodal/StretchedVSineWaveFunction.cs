using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Multimodal
{
    public class StretchedVSineWaveFunction : AbstractFunction
    {
        public override string FunctionName
        {
            get
            {
                return "Stretched V Sine Wave function";
            }
        }
        public StretchedVSineWaveFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        public override float CostFunction( params float[] parameters )
        {
            float result = 0f;
            for ( int i = 0; i < parameters.Length - 1; i++ )
            {
                result += (float)( ( Math.Pow( parameters[i] * parameters[i] + parameters[i + 1] * parameters[i + 1], 0.25 ) )
                                *  Math.Pow( Math.Sin( 50 * ( Math.Pow( ( parameters[i] * parameters[i] + parameters[i + 1] * parameters[i + 1] ), 0.1 ) ) ), 2 ) + 1  );
            }
            return result;
        }
    }
}
