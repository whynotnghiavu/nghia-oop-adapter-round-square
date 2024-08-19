namespace AdapterPatternCircleSquare {
 partial class frmOutput {
 /// <summary>
 /// Required designer variable.
 /// </summary>
 private System.ComponentModel.IContainer components = null;

 /// <summary>
 /// Clean up any resources being used.
 /// </summary>
 /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
 protected override void Dispose(bool disposing) {
 if(disposing&&(components!=null)) {
 components.Dispose();
 }
 base.Dispose(disposing);
 }

 #region Windows Form Designer generated code

 /// <summary>
 /// Required method for Designer support - do not modify
 /// the contents of this method with the code editor.
 /// </summary>
 private void InitializeComponent() {
 this.pnlOutputText=new System.Windows.Forms.Panel();
 this.lblResult=new System.Windows.Forms.Label();
 this.pnlZoom=new System.Windows.Forms.Panel();
 this.btnEnlarge=new RJCodeAdvance.RJControls.RJButton();
 this.btnZoomOut=new RJCodeAdvance.RJControls.RJButton();
 this.btnExit=new RJCodeAdvance.RJControls.RJButton();
 this.pnlOutputShape=new System.Windows.Forms.Panel();
 this.pnlOutputText.SuspendLayout();
 this.pnlZoom.SuspendLayout();
 this.SuspendLayout();
 // 
 // pnlOutputText
 // 
 this.pnlOutputText.Controls.Add(this.lblResult);
 this.pnlOutputText.Dock=System.Windows.Forms.DockStyle.Top;
 this.pnlOutputText.Location=new System.Drawing.Point(0,0);
 this.pnlOutputText.Name="pnlOutputText";
 this.pnlOutputText.Size=new System.Drawing.Size(1035,57);
 this.pnlOutputText.TabIndex=0;
 // 
 // lblResult
 // 
 this.lblResult.AutoSize=true;
 this.lblResult.Font=new System.Drawing.Font("Microsoft Sans Serif",24F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
 this.lblResult.ForeColor=System.Drawing.Color.MediumSlateBlue;
 this.lblResult.Location=new System.Drawing.Point(10,10);
 this.lblResult.Name="lblResult";
 this.lblResult.Size=new System.Drawing.Size(100,37);
 this.lblResult.TabIndex=0;
 this.lblResult.Text="label1";
 // 
 // pnlZoom
 // 
 this.pnlZoom.Controls.Add(this.btnEnlarge);
 this.pnlZoom.Controls.Add(this.btnZoomOut);
 this.pnlZoom.Controls.Add(this.btnExit);
 this.pnlZoom.Dock=System.Windows.Forms.DockStyle.Bottom;
 this.pnlZoom.Location=new System.Drawing.Point(0,365);
 this.pnlZoom.Name="pnlZoom";
 this.pnlZoom.Size=new System.Drawing.Size(1035,85);
 this.pnlZoom.TabIndex=1;
 // 
 // btnEnlarge
 // 
 this.btnEnlarge.BackColor=System.Drawing.SystemColors.Control;
 this.btnEnlarge.BackgroundColor=System.Drawing.SystemColors.Control;
 this.btnEnlarge.BorderColor=System.Drawing.Color.MediumSlateBlue;
 this.btnEnlarge.BorderRadius=10;
 this.btnEnlarge.BorderSize=2;
 this.btnEnlarge.FlatAppearance.BorderSize=0;
 this.btnEnlarge.FlatStyle=System.Windows.Forms.FlatStyle.Flat;
 this.btnEnlarge.Font=new System.Drawing.Font("Microsoft Sans Serif",24F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
 this.btnEnlarge.ForeColor=System.Drawing.Color.MediumSlateBlue;
 this.btnEnlarge.Location=new System.Drawing.Point(662,20);
 this.btnEnlarge.Name="btnEnlarge";
 this.btnEnlarge.Size=new System.Drawing.Size(333,55);
 this.btnEnlarge.TabIndex=2;
 this.btnEnlarge.Text="Phóng to hình x2";
 this.btnEnlarge.TextColor=System.Drawing.Color.MediumSlateBlue;
 this.btnEnlarge.UseVisualStyleBackColor=false;
 this.btnEnlarge.Click+=new System.EventHandler(this.btnEnlarge_Click);
 // 
 // btnZoomOut
 // 
 this.btnZoomOut.BackColor=System.Drawing.SystemColors.Control;
 this.btnZoomOut.BackgroundColor=System.Drawing.SystemColors.Control;
 this.btnZoomOut.BorderColor=System.Drawing.Color.MediumSlateBlue;
 this.btnZoomOut.BorderRadius=10;
 this.btnZoomOut.BorderSize=2;
 this.btnZoomOut.FlatAppearance.BorderSize=0;
 this.btnZoomOut.FlatStyle=System.Windows.Forms.FlatStyle.Flat;
 this.btnZoomOut.Font=new System.Drawing.Font("Microsoft Sans Serif",24F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
 this.btnZoomOut.ForeColor=System.Drawing.Color.MediumSlateBlue;
 this.btnZoomOut.Location=new System.Drawing.Point(387,20);
 this.btnZoomOut.Name="btnZoomOut";
 this.btnZoomOut.Size=new System.Drawing.Size(269,55);
 this.btnZoomOut.TabIndex=1;
 this.btnZoomOut.Text="Thu nhỏ hình /2";
 this.btnZoomOut.TextColor=System.Drawing.Color.MediumSlateBlue;
 this.btnZoomOut.UseVisualStyleBackColor=false;
 this.btnZoomOut.Click+=new System.EventHandler(this.btnZoomOut_Click);
 // 
 // btnExit
 // 
 this.btnExit.BackColor=System.Drawing.SystemColors.Control;
 this.btnExit.BackgroundColor=System.Drawing.SystemColors.Control;
 this.btnExit.BorderColor=System.Drawing.Color.MediumSlateBlue;
 this.btnExit.BorderRadius=10;
 this.btnExit.BorderSize=2;
 this.btnExit.FlatAppearance.BorderSize=0;
 this.btnExit.FlatStyle=System.Windows.Forms.FlatStyle.Flat;
 this.btnExit.Font=new System.Drawing.Font("Microsoft Sans Serif",24F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
 this.btnExit.ForeColor=System.Drawing.Color.MediumSlateBlue;
 this.btnExit.Location=new System.Drawing.Point(20,20);
 this.btnExit.Name="btnExit";
 this.btnExit.Size=new System.Drawing.Size(361,55);
 this.btnExit.TabIndex=0;
 this.btnExit.Text="Thoát chương trình";
 this.btnExit.TextColor=System.Drawing.Color.MediumSlateBlue;
 this.btnExit.UseVisualStyleBackColor=false;
 this.btnExit.Click+=new System.EventHandler(this.btnExit_Click);
 // 
 // pnlOutputShape
 // 
 this.pnlOutputShape.Dock=System.Windows.Forms.DockStyle.Fill;
 this.pnlOutputShape.Location=new System.Drawing.Point(0,57);
 this.pnlOutputShape.Name="pnlOutputShape";
 this.pnlOutputShape.Size=new System.Drawing.Size(1035,308);
 this.pnlOutputShape.TabIndex=2;
 this.pnlOutputShape.Paint+=new System.Windows.Forms.PaintEventHandler(this.pnlOutputShape_Paint);
 // 
 // frmOutput
 // 
 this.AutoScaleDimensions=new System.Drawing.SizeF(6F,13F);
 this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
 this.ClientSize=new System.Drawing.Size(1035,450);
 this.Controls.Add(this.pnlOutputShape);
 this.Controls.Add(this.pnlZoom);
 this.Controls.Add(this.pnlOutputText);
 this.Name="frmOutput";
 this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
 this.Text="frmOutput";
 this.WindowState=System.Windows.Forms.FormWindowState.Maximized;
 this.pnlOutputText.ResumeLayout(false);
 this.pnlOutputText.PerformLayout();
 this.pnlZoom.ResumeLayout(false);
 this.ResumeLayout(false);

 }

 #endregion

 private System.Windows.Forms.Panel pnlOutputText;
 private System.Windows.Forms.Panel pnlOutputShape;
 private System.Windows.Forms.Panel pnlZoom;

 private System.Windows.Forms.Label lblResult;

 private RJCodeAdvance.RJControls.RJButton btnExit;
 private RJCodeAdvance.RJControls.RJButton btnZoomOut;
 private RJCodeAdvance.RJControls.RJButton btnEnlarge;
 }
}