using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AdapterPatternCircleSquare {
    public partial class frmInput : Form {
        #region Constructor 
        public frmInput() {
            InitializeComponent();
            Text=CONFIG.GROUP_NAME;
        }
        #endregion
        #region Event Thay đổi giao diện theo người dùng
        private void ReSetInput() {
            txtInputTwo.Texts=CONST.EMPTY_TEXTBOX_CONTENT;
            txtInputOne.Texts=CONST.EMPTY_TEXTBOX_CONTENT;
        }
        private void txtInputOne_Enter(object sender,EventArgs e) {
            lblInputOne.ForeColor=Color.HotPink;
        }
        private void txtInputOne_Leave(object sender,EventArgs e) {
            lblInputOne.ForeColor=Color.Black;
        }
        private void txtInputTwo_Enter(object sender,EventArgs e) {
            lblInputTwo.ForeColor=Color.HotPink;
        }
        private void txtInputTwo_Leave(object sender,EventArgs e) {
            lblInputTwo.ForeColor=Color.Black;
        }
        private void rdoRoundHoleSquarePeg_CheckedChanged(object sender,EventArgs e) {
            ReSetInput();
            lblInputTwo.Text=CONST.TEXT_INPUT_TWO_ROUND_HOLE_SQUARE_PEG;
            if(rdoRoundHoleSquarePeg.Checked==true) {
                rdoRoundHoleSquarePeg.ForeColor=Color.MediumSlateBlue;
            } else {
                rdoRoundHoleSquarePeg.ForeColor=Color.Black;
            }
        }
        private void rdoRoundHoleRoundPeg_CheckedChanged(object sender,EventArgs e) {
            ReSetInput();
            lblInputTwo.Text=CONST.TEXT_INPUT_TWO_ROUND_HOLE_ROUND_PEG;
            if(rdoRoundHoleRoundPeg.Checked==true) {
                rdoRoundHoleRoundPeg.ForeColor=Color.MediumSlateBlue;
            } else {
                rdoRoundHoleRoundPeg.ForeColor=Color.Black;
            }
        }
        #endregion

        #region Logic nhận input
        private static float GetInputTextBox(RJTextBox iTextBox) {
            float _inputDistance = float.Parse(iTextBox.Texts);
            if(_inputDistance<=CONST.POSITIVE_LENGTH_VALUE) {
                throw new InvalidLengthException();
            }
            return _inputDistance;
        }
        private void btnSolve_Click(object sender,EventArgs e) {
            try {
                float _inputDataOne = GetInputTextBox(txtInputOne);
                float _inputDataTwo = GetInputTextBox(txtInputTwo);

                frmOutput _frmOutput = new frmOutput();
                _frmOutput.DataOne=_inputDataOne;
                _frmOutput.DataTwo=_inputDataTwo;

                if(rdoRoundHoleSquarePeg.Checked) {
                    // TH1 dùng adapter
                    RoundHole _inputRoundHoleOne = new RoundHole(_inputDataOne);
                    ISquare _inputSquarePegTwo = new SquarePeg(_inputDataTwo);

                    IRound _SquarePegAdapter = new SquarePegAdapter(_inputSquarePegTwo);

                    _frmOutput.Result=_inputRoundHoleOne.Fits(_SquarePegAdapter);
                    _frmOutput.Choice=(int)CONST.eCHOICE.ROUND_HOLE_SQUARE_PEG;
                }
                if(rdoRoundHoleRoundPeg.Checked) {
                    // TH2 không dùng adapter
                    RoundHole _inputRoundHoleOne = new RoundHole(_inputDataOne);
                    IRound _inputRoundPegTwo = new RoundPeg(_inputDataTwo);

                    _frmOutput.Result=_inputRoundHoleOne.Fits(_inputRoundPegTwo);
                    _frmOutput.Choice=(int)CONST.eCHOICE.ROUND_HOLE_ROUND_PEG;
                }
                _frmOutput.Show();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}