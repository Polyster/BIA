using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BIA.Library.Functions.Multimodal
{
    public class RastriginsFunction : AbstractFunction
    {
        public override string FunctionName
        {
            get
            {
                return "Rastrigin's function";
            }
        }
        public RastriginsFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        //public override float[] HighBound
        //{
        //    get
        //    {
        //        return new float[] { 5.12f, 5.12f };
        //    }
        //}

        //public override float[] LowBound
        //{
        //    get
        //    {
        //        return new float[] { -5.12f, -5.12f };
        //    }
        //}

        public override float CostFunction( params float[] parameters )
        {
            float result = 0f;
            for ( int i = 0; i < parameters.Length; i++ )
            {
                result += (float)( ( parameters[i] * parameters[i] ) - 10 * Math.Cos( 2 * Math.PI * parameters[i] ) );
            }
            return 2 * result;
        }
    }
}
