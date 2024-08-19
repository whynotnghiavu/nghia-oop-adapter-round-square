using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternCircleSquare {
    class RoundHole : IRound {
        #region Fields 
        private float radius;
        #endregion
        #region Properties 
        public float Radius { get => radius; set => radius=value; }
        #endregion
        #region Constructor 
        public RoundHole(float iRadius) {
            Radius=iRadius;
        }
        #endregion
        #region Methods 
        public float GetRadius() {
            return Radius;
        }
        public string Fits(IRound iPeg) {
            if(GetRadius()>=iPeg.GetRadius()) {
                return "Kết quả: vừa";
            } else {
                return "Kết quả: không vừa";
            }
        }
        public override string ToString() {
            return "Đây là đối tượng của lớp RoundHole.";
        }
        #endregion
    }
}
