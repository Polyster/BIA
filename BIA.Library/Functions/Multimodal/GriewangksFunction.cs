using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Multimodal
{
    public class GriewangksFunction : AbstractFunction
    {
        public override string FunctionName
        {
            get
            {
                return "Griewangk's function";
            }
        }
        public GriewangksFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        public override float CostFunction( params float[] parameters )
        {
            return parameters.Sum( f => (float)Math.Pow( f, 2 ) / 4000f ) - Product(parameters ) + 1f;
        }
        private float Product( params float[] values )
        {
            float result = float.NaN;

            for ( int i = 1; i <= values.Length; i++ )
            {
                float sub = (float)Math.Cos( values[i - 1] / Math.Sqrt( i ) );

                if ( float.IsNaN( result ) )
                {
                    result = sub;
                }
                else
                    result *= sub;
            }

            return result;
        }
    }
}
