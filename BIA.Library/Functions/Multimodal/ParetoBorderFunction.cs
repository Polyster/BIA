using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Functions.Multimodal
{
    public class ParetoBorderFunction : AbstractFunction
    {
        public override string FunctionName
        {
            get
            {
                return "Pareto border";
            }
        }
        public ParetoBorderFunction( float[] lowBound, float[] highBound )
        {
            this.lowBound = lowBound;
            this.highBound = highBound;
        }

        private float fConstant = 1f;
        public float F
        {
            get
            {
                return fConstant;
            }
            set
            {
                fConstant = value;
            }
        }

        private float Alpha(float x)
        {
            return 0.25f + 3.75f * ((G(x)-12)/(11-12));
        }
        private float G(float x)
        {
            return 10 + x;
        }
     
        public override float CostFunction( params float[] parameters )
        {
            return (float)Math.Pow( parameters[0] / G( parameters[1] ), Alpha( parameters[1] ) ) - ( parameters[0] / G( parameters[1] ) ) * (float)Math.Sin( Math.PI * F * parameters[0] * G( parameters[1] ) );
        }
    }
}
