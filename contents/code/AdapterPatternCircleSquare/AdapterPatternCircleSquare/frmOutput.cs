using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPatternCircleSquare {
 public partial class frmOutput : Form {
 private float drawingScale = 1;
 private string result;
 private int choice;
 private float dataOne;
 private float dataTwo;

 public string Result { get => result; set => result=value; }
 public int Choice { get => choice; set => choice=value; }
 public float DataOne { get => dataOne; set => dataOne=value; }
 public float DataTwo { get => dataTwo; set => dataTwo=value; }

 public frmOutput() {
 InitializeComponent();
 Text=CONFIG.GROUP_NAME;
 }

 private void pnlOutputShape_Paint(object sender,PaintEventArgs e) {
 // Hiển thị kết quả 
 drawingScale=1;
 DrawingOutput.DrawResult(pnlOutputShape,dataOne,dataTwo,drawingScale,choice);
 lblResult.Text=Result;
 }
 private void btnExit_Click(object sender,EventArgs e) {
 Application.Exit();
 }
 private void btnZoomOut_Click(object sender,EventArgs e) {
 drawingScale/=2;
 DrawingOutput.DrawResult(pnlOutputShape,dataOne,dataTwo,drawingScale,choice);
 }
 private void btnEnlarge_Click(object sender,EventArgs e) {
 drawingScale*=2;
 DrawingOutput.DrawResult(pnlOutputShape,dataOne,dataTwo,drawingScale,choice);
 }
 }
}
