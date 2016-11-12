using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA.Library.Points
{
    public class Individual : ICloneable
    {
        public float[] Parameters { get; set; }
        public float X
        {
            get
            {
                return Parameters[0];
            }
        }
        public float Y
        {
            get
            {
                return Parameters[1];
            }
        }
        public float Fitness { get; set; }

        public object Clone()
        {
            Individual cloned = new Individual();
            cloned.Fitness = this.Fitness;
            cloned.Parameters = (float[])Parameters.Clone();
            return cloned;
        }
    }
}
