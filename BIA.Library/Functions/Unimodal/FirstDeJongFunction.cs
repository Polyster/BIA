using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Unimodal
{
    public class FirstDeJongFunction : AbstractFunction
    {
        public FirstDeJongFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        public override string FunctionName
        {
            get
            {
                return "1st De Jong function";
            }
        }

        public override float CostFunction(params float[] parameters)
        {
            float result = 0f;
            for ( int i = 0; i < parameters.Length; i++ )
            {
                result += parameters[i] * parameters[i];
            }
            return result;
        }
    }
}
