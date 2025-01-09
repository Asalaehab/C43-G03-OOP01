using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigntmentOOP
{
     struct Point
    {

        #region Attributes
        public float x { get; set; }
        public float y { get; set; }
        #endregion

        #region Constructor
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        } 
        #endregion

    }
}
