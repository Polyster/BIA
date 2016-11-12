using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Multimodal
{
    public class SchwefelsFunction : AbstractFunction
    {
        public override string FunctionName
        {
            get
            {
                return "Schwefel's function";
            }
        }

        public SchwefelsFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        public override float CostFunction( params float[] parameters )
        {
            float result = 0f;
            for ( int i = 0; i < parameters.Length; i++ )
            {
                result += (float)( -parameters[i] * Math.Sin( Math.Sqrt( Math.Abs( parameters[i] ) ) ) );
            }
            return result;
        }
    }
}
