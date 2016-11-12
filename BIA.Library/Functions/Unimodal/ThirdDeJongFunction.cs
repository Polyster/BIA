using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Unimodal
{
    public class ThirdDeJongFunction : AbstractFunction
    {
        public override string FunctionName
        {
            get
            {
                return "3rd De Jong function";
            }
        }
        public ThirdDeJongFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        public override float CostFunction( params float[] parameters )
        {
            float result = 0f;
            for ( int i = 0; i < parameters.Length; i++ )
            {
                result += Math.Abs( parameters[i] );
            }
            return result;
        }
    }
}
