using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Multimodal
{
    public class MastersCosineWaveFunction : AbstractFunction
    {
        public override string FunctionName
        {
            get
            {
                return "Masters' cosine wave function";
            }
        }
        public MastersCosineWaveFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        public override float CostFunction( params float[] parameters )
        {
            float result = 0f;
            for ( int i = 0; i < parameters.Length - 1; i++ )
            {
                result += (float)( Math.Pow( Math.E, -( parameters[i] * parameters[i] + parameters[i+1] * parameters[i + 1] + 0.5 * parameters[i] * parameters[i + 1] ) / 8 ) *
                                        Math.Cos( 4 * ( Math.Sqrt( parameters[i] * parameters[i] + parameters[i + 1] * parameters[i + 1] + 0.5 * parameters[i] * parameters[i + 1] ) ) ) );
            }
            return result;
        }
    }
}
