using System;

namespace AdapterPatternCircleSquare {
    /// <summary>
    /// Custom Exception: Bạn phải nhập độ dài là số thực và không âm.
    /// </summary>
    class InvalidLengthException : Exception {
        #region Constructor 
        public InvalidLengthException()
        : base("Bạn phải nhập độ dài là số thực và không âm.") { }
        #endregion
    }
}