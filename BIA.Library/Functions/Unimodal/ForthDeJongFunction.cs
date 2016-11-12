using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Unimodal
{
    public class ForthDeJongFunction : AbstractFunction
    {
        public override string FunctionName
        {
            get
            {
                return "4th De Jong function";
            }
        }

        public ForthDeJongFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }
        public override float CostFunction( params float[] parameters )
        {
            float result = 0f;
            for ( int i = 0; i < parameters.Length; i++ )
            {
                result += (float)Math.Pow( parameters[i], 4 );
            }
            return result;
        }
    }
}
