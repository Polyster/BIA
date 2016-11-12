using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Multimodal
{
    public class MichalewiczsFunction : AbstractFunction
    {
        public override string FunctionName
        {
            get
            {
                return "Michalewicz's function";
            }
        }
        public MichalewiczsFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        public override float CostFunction( params float[] parameters )
        {
            float result = 0f;
            for ( int i = 0; i < parameters.Length - 1; i++ )
            {
                result += (float)( -1 * ( Math.Sin( parameters[i] ) * Math.Pow( Math.Sin( ( parameters[i] * parameters[i] ) / Math.PI ), 20 ) +
                     Math.Sin( parameters[i+1] ) * Math.Pow( Math.Sin( ( 2 * parameters[i + 1] * parameters[i + 1] ) / Math.PI ), 20 ) ) );
            }
            return result;
        }
    }
}
