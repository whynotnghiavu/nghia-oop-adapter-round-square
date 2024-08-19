using System.Configuration;
using System.Drawing;

namespace AdapterPatternCircleSquare {

    /// <summary>
    /// Đọc thông tin từ tập tin cấu hình App.config
    /// </summary>
    public static class CONFIG {
        public static string GROUP_NAME {
            get { return ConfigurationManager.AppSettings["GROUP_NAME"]; }
        }
        public static int PEN_SIZE {
            get {
                return int.Parse(ConfigurationManager.AppSettings["PEN_SIZE"]);
            }
        }
        public static Color COLOR_OXY {
            get {
                return Color.FromName(ConfigurationManager.AppSettings["COLOR_OXY"]);
            }
        }
        public static string FONT_DECAC_AXIS {
            get { return ConfigurationManager.AppSettings["FONT_DECAC_AXIS"]; }
        }
        public static int FONT_SIZE_DECAC_AXIS {
            get {
                return int.Parse(ConfigurationManager.AppSettings["FONT_SIZE_DECAC_AXIS"]);
            }
        }
        public static int NUMBER_OF_PLOTS {
            get {
                return int.Parse(ConfigurationManager.AppSettings["NUMBER_OF_PLOTS"]);
            }
        }
        public static int RESIDUAL_UNIT {
            get {
                return int.Parse(ConfigurationManager.AppSettings["RESIDUAL_UNIT"]);
            }
        }
        public static Color COLOR_ONE {
            get {
                return Color.FromName(ConfigurationManager.AppSettings["COLOR_ONE"]);
            }
        }
        public static Color COLOR_TWO {
            get {
                return Color.FromName(ConfigurationManager.AppSettings["COLOR_TWO"]);
            }
        }
    }
}