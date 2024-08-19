using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternCircleSquare {
    class SquarePeg : ISquare {
        #region Fields 
        private float width;
        #endregion
        #region Properties 
        public float Width { get => width; set => width=value; }
        #endregion
        #region Constructor 
        public SquarePeg(float iWidth) {
            Width=iWidth;
        }
        #endregion
        #region Methods 
        public float GetWidth() {
            return Width;
        }
        #endregion
    }
}
