using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternCircleSquare {
    /// <summary>
    /// Các hằng số
    /// </summary>
    public class CONST {
        public enum eCHOICE {
            ROUND_HOLE_SQUARE_PEG = 0
        , ROUND_HOLE_ROUND_PEG = 1
        }
        public static int ZEROS_COORDINATE = 0;
        public static int POSITIVE_LENGTH_VALUE = 0;
        public static int TWO_TIME = 2;
        public static string EMPTY_TEXTBOX_CONTENT = "";
        public static string TEXT_INPUT_TWO_ROUND_HOLE_SQUARE_PEG = "Cạnh trụ vuông:";
        public static string TEXT_INPUT_TWO_ROUND_HOLE_ROUND_PEG = "Bán kính trụ tròn:";
        public static string CHARACTER_O_DRAW_AXIS = "O";
        public static string CHARACTER_X_DRAW_AXIS = "X";
        public static string CHARACTER_Y_DRAW_AXIS = "Y";
        public static string CHARACTER_MINUS_DRAW_AXIS = "-";
    }
}
