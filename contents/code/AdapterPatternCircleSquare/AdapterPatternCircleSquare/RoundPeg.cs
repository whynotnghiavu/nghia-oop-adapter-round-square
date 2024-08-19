using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternCircleSquare {
    class RoundPeg : IRound {
        #region Fields 
        private float radius;
        #endregion
        #region Properties 
        public float Radius { get => radius; set => radius=value; }
        #endregion
        #region Constructor 
        public RoundPeg(float iRadius) {
            radius=iRadius;
        }
        #endregion
        #region Methods 
        public float GetRadius() {
            return radius;
        }
        public override string ToString() {
            return "Đây là đối tượng của lớp RoundPeg.";
        }
        #endregion
    }
}
