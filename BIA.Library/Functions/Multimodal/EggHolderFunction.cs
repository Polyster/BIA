using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Multimodal
{
    public class EggHolderFunction : AbstractFunction
    {

        public override string FunctionName
        {
            get
            {
                return "Egg holder function";
            }
        }

        public EggHolderFunction(float[] lowBound, float[] highBound)
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        public override float CostFunction( params float[] parameters )
        {
            float result = 0f;
            for ( int i = 0; i < parameters.Length - 1; i++ )
            {
                result += (float)( -parameters[i] * Math.Sin( Math.Sqrt( Math.Abs( parameters[i] - parameters[i + 1] - 47 ) ) )
                                - ( parameters[i + 1] + 47 ) 
                                * Math.Sin( Math.Sqrt( Math.Abs( parameters[i + 1] + 47 + ( parameters[i] / 2 ) ) ) ) );
            }
            return result;
        }
    }
}
