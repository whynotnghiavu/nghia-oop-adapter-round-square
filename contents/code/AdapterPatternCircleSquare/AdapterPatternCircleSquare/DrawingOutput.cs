using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPatternCircleSquare {
    /// <summary>
    /// Vẽ kết quả hình lên chính giữa panel.iLengthShapeOne
    /// </summary>
    internal class DrawingOutput {
        #region Methods 
        public static void DrawResult(Panel iPanel,float iLengthShapeOne,float iLengthShapeTwo,float iDrawingScale,int Choice) {
            ReSetPanel(iPanel);
            DrawCoordinateAxisOXY(iPanel,iDrawingScale);
            if(Choice==(int)CONST.eCHOICE.ROUND_HOLE_SQUARE_PEG) {
                DrawCircle(iPanel,iLengthShapeOne,iDrawingScale,CONFIG.COLOR_ONE);
                DrawSquare(iPanel,iLengthShapeTwo,iDrawingScale,CONFIG.COLOR_TWO);
                return;
            }
            if(Choice==(int)CONST.eCHOICE.ROUND_HOLE_ROUND_PEG) {
                DrawCircle(iPanel,iLengthShapeOne,iDrawingScale,CONFIG.COLOR_ONE);
                DrawCircle(iPanel,iLengthShapeTwo,iDrawingScale,CONFIG.COLOR_TWO);
                return;
            }
        }
        private static void ReSetPanel(Panel iPanel) {
            Graphics _Graphic = iPanel.CreateGraphics();
            _Graphic.Clear(iPanel.BackColor);
        }
        private static void DrawCoordinateAxisOXY(Panel iPanel,float iDrawingScale) {
            DrawOXY(iPanel,iDrawingScale);
            DrawX(iPanel,iDrawingScale);
            DrawY(iPanel,iDrawingScale);
        }
        private static void DrawOXY(Panel iPanel,float iDrawingScale) {
            int _OxCenter = iPanel.Width/CONST.TWO_TIME;
            int _OyCenter = iPanel.Height/CONST.TWO_TIME;
            int _Scope = iPanel.Width<iPanel.Height ? iPanel.Width : iPanel.Height;
            Graphics _Graphic = iPanel.CreateGraphics();

            _Graphic.DrawString(CONST.CHARACTER_O_DRAW_AXIS,new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),_OxCenter,_OyCenter);
            _Graphic.DrawLine(new Pen(CONFIG.COLOR_OXY,CONFIG.PEN_SIZE),_OxCenter,CONST.ZEROS_COORDINATE,_OxCenter,_Scope);
            _Graphic.DrawString(CONST.CHARACTER_Y_DRAW_AXIS,new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),_OxCenter,CONST.ZEROS_COORDINATE);
            _Graphic.DrawLine(new Pen(CONFIG.COLOR_OXY,CONFIG.PEN_SIZE),(iPanel.Width-_Scope)/CONST.TWO_TIME,iPanel.Height/CONST.TWO_TIME,(iPanel.Width+_Scope)/CONST.TWO_TIME,iPanel.Height/CONST.TWO_TIME);
            _Graphic.DrawString(CONST.CHARACTER_X_DRAW_AXIS,new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),(iPanel.Width+_Scope)/CONST.TWO_TIME,iPanel.Height/CONST.TWO_TIME);
        }
        private static void DrawX(Panel iPanel,float iDrawingScale) {
            int _OxCenter = iPanel.Width/CONST.TWO_TIME;
            int _OyCenter = iPanel.Height/CONST.TWO_TIME;
            int _Scope = iPanel.Width<iPanel.Height ? iPanel.Width : iPanel.Height;
            _Scope=CONFIG.NUMBER_OF_PLOTS*_Scope/(CONFIG.RESIDUAL_UNIT+CONFIG.NUMBER_OF_PLOTS);
            int _DistanceValue = _Scope/CONFIG.NUMBER_OF_PLOTS;
            Graphics _Graphic = iPanel.CreateGraphics();

            for(int _iLoop = 1;_iLoop<=CONFIG.NUMBER_OF_PLOTS/CONST.TWO_TIME;_iLoop++) {
                //vẽ x dương
                _Graphic.DrawString((_iLoop*_DistanceValue/iDrawingScale).ToString(),new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),_OxCenter+_iLoop*_DistanceValue,_OyCenter);
                _Graphic.DrawLine(new Pen(CONFIG.COLOR_OXY,CONFIG.PEN_SIZE),_OxCenter+_iLoop*_DistanceValue,_DistanceValue,_OxCenter+_iLoop*_DistanceValue,_Scope+_DistanceValue);
                //vẽ x âm
                _Graphic.DrawString(CONST.CHARACTER_MINUS_DRAW_AXIS+(_iLoop*_DistanceValue/iDrawingScale).ToString(),new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),_OxCenter-_iLoop*_DistanceValue,_OyCenter);
                _Graphic.DrawLine(new Pen(CONFIG.COLOR_OXY,CONFIG.PEN_SIZE),_OxCenter-_iLoop*_DistanceValue,_DistanceValue,_OxCenter-_iLoop*_DistanceValue,_Scope+_DistanceValue);
            }
        }
        private static void DrawY(Panel iPanel,float iDrawingScale) {
            int _OxCenter = iPanel.Width/CONST.TWO_TIME;
            int _OyCenter = iPanel.Height/CONST.TWO_TIME;
            int _Scope = iPanel.Width<iPanel.Height ? iPanel.Width : iPanel.Height;
            _Scope=CONFIG.NUMBER_OF_PLOTS*_Scope/(CONFIG.RESIDUAL_UNIT+CONFIG.NUMBER_OF_PLOTS);
            int _DistanceValue = _Scope/CONFIG.NUMBER_OF_PLOTS;
            Graphics _Graphic = iPanel.CreateGraphics();

            for(int _iLoop = 1;_iLoop<=CONFIG.NUMBER_OF_PLOTS/CONST.TWO_TIME;_iLoop++) {
                //vẽ y dương
                _Graphic.DrawString((_iLoop*_DistanceValue/iDrawingScale).ToString(),new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),_OxCenter,_OyCenter-_iLoop*_DistanceValue);
                _Graphic.DrawLine(new Pen(CONFIG.COLOR_OXY,CONFIG.PEN_SIZE),(iPanel.Width-_Scope)/CONST.TWO_TIME,_OyCenter-_iLoop*_DistanceValue,(iPanel.Width+_Scope)/CONST.TWO_TIME,_OyCenter-_iLoop*_DistanceValue);
                //vẽ y âm
                _Graphic.DrawString(CONST.CHARACTER_MINUS_DRAW_AXIS+(_iLoop*_DistanceValue/iDrawingScale).ToString(),new Font(CONFIG.FONT_DECAC_AXIS,CONFIG.FONT_SIZE_DECAC_AXIS),new SolidBrush(Color.Red),_OxCenter,_OyCenter+_iLoop*_DistanceValue);
                _Graphic.DrawLine(new Pen(CONFIG.COLOR_OXY,CONFIG.PEN_SIZE),(iPanel.Width-_Scope)/CONST.TWO_TIME,_OyCenter+_iLoop*_DistanceValue,(iPanel.Width+_Scope)/CONST.TWO_TIME,_OyCenter+_iLoop*_DistanceValue);
            }
        }
        private static void DrawSquare(Panel iPanel,float iLengthShape,float iDrawingScale,Color iColor) {
            Graphics _Graphic = iPanel.CreateGraphics();
            iLengthShape*=iDrawingScale;
            float _TopLeftX = (float)((iPanel.Width-iLengthShape)/CONST.TWO_TIME);
            float _TopLeftY = (float)((iPanel.Height-iLengthShape)/CONST.TWO_TIME);
            _Graphic.DrawRectangle(new Pen(iColor),_TopLeftX,_TopLeftY,(float)iLengthShape,(float)iLengthShape);
        }
        private static void DrawCircle(Panel iPanel,float iLengthShape,float iDrawingScale,Color iColor) {
            Graphics _Graphic = iPanel.CreateGraphics();
            iLengthShape*=CONST.TWO_TIME*iDrawingScale;
            float _TopLeftX = (float)((iPanel.Width-iLengthShape)/CONST.TWO_TIME);
            float _TopLeftY = (float)((iPanel.Height-iLengthShape)/CONST.TWO_TIME);
            _Graphic.DrawEllipse(new Pen(iColor),_TopLeftX,_TopLeftY,(float)iLengthShape,(float)iLengthShape);
        }
        #endregion
    }
}