using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternCircleSquare {
    /// <summary>
    /// Dùng Adapter "Đóng giả" làm trụ tròn ngoại tiếp trụ vuông​
    /// Bán kính của trụ tròn = Cạnh của trụ vuông * Sqrt(2) / 2
    /// </summary>
    class SquarePegAdapter : IRound {
        #region Fields 
        private ISquare squarePeg;
        #endregion
        #region Properties 
        public ISquare SquarePeg { get => squarePeg; set => squarePeg=value; }
        #endregion
        #region Constructor
        public SquarePegAdapter(ISquare iSquare) {
            SquarePeg=iSquare;
        }
        #endregion
        #region Methods 
        public float GetRadius() {
            return (float)(SquarePeg.GetWidth()*Math.Sqrt(2)/2);
        }
        public override string ToString() {
            return "Đây là đối tượng của lớp SquarePegAdapter.";
        }
        #endregion
    }
}
