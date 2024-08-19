namespace AdapterPatternCircleSquare {
    partial class frmInput {
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
            this.pnlChoice=new System.Windows.Forms.Panel();
            this.rdoRoundHoleRoundPeg=new RJCodeAdvance.RJControls.RJRadioButton();
            this.rdoRoundHoleSquarePeg=new RJCodeAdvance.RJControls.RJRadioButton();
            this.pnlInputOne=new System.Windows.Forms.Panel();
            this.txtInputOne=new RJCodeAdvance.RJControls.RJTextBox();
            this.lblInputOne=new System.Windows.Forms.Label();
            this.pnlInputTwo=new System.Windows.Forms.Panel();
            this.txtInputTwo=new RJCodeAdvance.RJControls.RJTextBox();
            this.lblInputTwo=new System.Windows.Forms.Label();
            this.pnlSolve=new System.Windows.Forms.Panel();
            this.btnSolve=new RJCodeAdvance.RJControls.RJButton();
            this.pnlChoice.SuspendLayout();
            this.pnlInputOne.SuspendLayout();
            this.pnlInputTwo.SuspendLayout();
            this.pnlSolve.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChoice
            // 
            this.pnlChoice.Controls.Add(this.rdoRoundHoleRoundPeg);
            this.pnlChoice.Controls.Add(this.rdoRoundHoleSquarePeg);
            this.pnlChoice.Dock=System.Windows.Forms.DockStyle.Top;
            this.pnlChoice.Location=new System.Drawing.Point(0,0);
            this.pnlChoice.Name="pnlChoice";
            this.pnlChoice.Size=new System.Drawing.Size(360,119);
            this.pnlChoice.TabIndex=0;
            // 
            // rdoRoundHoleRoundPeg
            // 
            this.rdoRoundHoleRoundPeg.AutoSize=true;
            this.rdoRoundHoleRoundPeg.CheckedColor=System.Drawing.Color.MediumSlateBlue;
            this.rdoRoundHoleRoundPeg.Font=new System.Drawing.Font("Microsoft Sans Serif",24F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
            this.rdoRoundHoleRoundPeg.Location=new System.Drawing.Point(20,70);
            this.rdoRoundHoleRoundPeg.MinimumSize=new System.Drawing.Size(0,21);
            this.rdoRoundHoleRoundPeg.Name="rdoRoundHoleRoundPeg";
            this.rdoRoundHoleRoundPeg.Padding=new System.Windows.Forms.Padding(10,0,0,0);
            this.rdoRoundHoleRoundPeg.Size=new System.Drawing.Size(300,41);
            this.rdoRoundHoleRoundPeg.TabIndex=1;
            this.rdoRoundHoleRoundPeg.TabStop=true;
            this.rdoRoundHoleRoundPeg.Text="Lỗ tròn và trụ tròn";
            this.rdoRoundHoleRoundPeg.UnCheckedColor=System.Drawing.Color.Gray;
            this.rdoRoundHoleRoundPeg.UseVisualStyleBackColor=true;
            this.rdoRoundHoleRoundPeg.CheckedChanged+=new System.EventHandler(this.rdoRoundHoleRoundPeg_CheckedChanged);
            // 
            // rdoRoundHoleSquarePeg
            // 
            this.rdoRoundHoleSquarePeg.AutoSize=true;
            this.rdoRoundHoleSquarePeg.CheckedColor=System.Drawing.Color.MediumSlateBlue;
            this.rdoRoundHoleSquarePeg.Font=new System.Drawing.Font("Microsoft Sans Serif",24F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
            this.rdoRoundHoleSquarePeg.Location=new System.Drawing.Point(20,20);
            this.rdoRoundHoleSquarePeg.MinimumSize=new System.Drawing.Size(0,21);
            this.rdoRoundHoleSquarePeg.Name="rdoRoundHoleSquarePeg";
            this.rdoRoundHoleSquarePeg.Padding=new System.Windows.Forms.Padding(10,0,0,0);
            this.rdoRoundHoleSquarePeg.Size=new System.Drawing.Size(331,41);
            this.rdoRoundHoleSquarePeg.TabIndex=0;
            this.rdoRoundHoleSquarePeg.TabStop=true;
            this.rdoRoundHoleSquarePeg.Text="Lỗ tròn và trụ vuông";
            this.rdoRoundHoleSquarePeg.UnCheckedColor=System.Drawing.Color.Gray;
            this.rdoRoundHoleSquarePeg.UseVisualStyleBackColor=true;
            this.rdoRoundHoleSquarePeg.CheckedChanged+=new System.EventHandler(this.rdoRoundHoleSquarePeg_CheckedChanged);
            // 
            // pnlInputOne
            // 
            this.pnlInputOne.Controls.Add(this.txtInputOne);
            this.pnlInputOne.Controls.Add(this.lblInputOne);
            this.pnlInputOne.Dock=System.Windows.Forms.DockStyle.Top;
            this.pnlInputOne.Location=new System.Drawing.Point(0,119);
            this.pnlInputOne.Name="pnlInputOne";
            this.pnlInputOne.Size=new System.Drawing.Size(360,111);
            this.pnlInputOne.TabIndex=1;
            // 
            // txtInputOne
            // 
            this.txtInputOne.BackColor=System.Drawing.SystemColors.Window;
            this.txtInputOne.BorderColor=System.Drawing.Color.MediumSlateBlue;
            this.txtInputOne.BorderFocusColor=System.Drawing.Color.HotPink;
            this.txtInputOne.BorderRadius=0;
            this.txtInputOne.BorderSize=2;
            this.txtInputOne.Font=new System.Drawing.Font("Microsoft Sans Serif",9.5F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
            this.txtInputOne.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(64)))),((int)(((byte)(64)))),((int)(((byte)(64)))));
            this.txtInputOne.Location=new System.Drawing.Point(20,70);
            this.txtInputOne.Margin=new System.Windows.Forms.Padding(4);
            this.txtInputOne.Multiline=false;
            this.txtInputOne.Name="txtInputOne";
            this.txtInputOne.Padding=new System.Windows.Forms.Padding(10,7,10,7);
            this.txtInputOne.PasswordChar=false;
            this.txtInputOne.PlaceholderColor=System.Drawing.Color.DarkGray;
            this.txtInputOne.PlaceholderText="";
            this.txtInputOne.Size=new System.Drawing.Size(331,31);
            this.txtInputOne.TabIndex=1;
            this.txtInputOne.Texts="";
            this.txtInputOne.UnderlinedStyle=false;
            this.txtInputOne.Enter+=new System.EventHandler(this.txtInputOne_Enter);
            this.txtInputOne.Leave+=new System.EventHandler(this.txtInputOne_Leave);
            // 
            // lblInputOne
            // 
            this.lblInputOne.AutoSize=true;
            this.lblInputOne.Font=new System.Drawing.Font("Microsoft Sans Serif",24F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
            this.lblInputOne.Location=new System.Drawing.Point(20,20);
            this.lblInputOne.Name="lblInputOne";
            this.lblInputOne.Size=new System.Drawing.Size(250,37);
            this.lblInputOne.TabIndex=0;
            this.lblInputOne.Text="Bán kính lỗ tròn:";
            // 
            // pnlInputTwo
            // 
            this.pnlInputTwo.Controls.Add(this.txtInputTwo);
            this.pnlInputTwo.Controls.Add(this.lblInputTwo);
            this.pnlInputTwo.Dock=System.Windows.Forms.DockStyle.Top;
            this.pnlInputTwo.Location=new System.Drawing.Point(0,230);
            this.pnlInputTwo.Name="pnlInputTwo";
            this.pnlInputTwo.Size=new System.Drawing.Size(360,111);
            this.pnlInputTwo.TabIndex=2;
            // 
            // txtInputTwo
            // 
            this.txtInputTwo.BackColor=System.Drawing.SystemColors.Window;
            this.txtInputTwo.BorderColor=System.Drawing.Color.MediumSlateBlue;
            this.txtInputTwo.BorderFocusColor=System.Drawing.Color.HotPink;
            this.txtInputTwo.BorderRadius=0;
            this.txtInputTwo.BorderSize=2;
            this.txtInputTwo.Font=new System.Drawing.Font("Microsoft Sans Serif",9.5F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
            this.txtInputTwo.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(64)))),((int)(((byte)(64)))),((int)(((byte)(64)))));
            this.txtInputTwo.Location=new System.Drawing.Point(20,70);
            this.txtInputTwo.Margin=new System.Windows.Forms.Padding(4);
            this.txtInputTwo.Multiline=false;
            this.txtInputTwo.Name="txtInputTwo";
            this.txtInputTwo.Padding=new System.Windows.Forms.Padding(10,7,10,7);
            this.txtInputTwo.PasswordChar=false;
            this.txtInputTwo.PlaceholderColor=System.Drawing.Color.DarkGray;
            this.txtInputTwo.PlaceholderText="";
            this.txtInputTwo.Size=new System.Drawing.Size(331,31);
            this.txtInputTwo.TabIndex=1;
            this.txtInputTwo.Texts="";
            this.txtInputTwo.UnderlinedStyle=false;
            this.txtInputTwo.Enter+=new System.EventHandler(this.txtInputTwo_Enter);
            this.txtInputTwo.Leave+=new System.EventHandler(this.txtInputTwo_Leave);
            // 
            // lblInputTwo
            // 
            this.lblInputTwo.AutoSize=true;
            this.lblInputTwo.Font=new System.Drawing.Font("Microsoft Sans Serif",24F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
            this.lblInputTwo.Location=new System.Drawing.Point(20,20);
            this.lblInputTwo.Name="lblInputTwo";
            this.lblInputTwo.Size=new System.Drawing.Size(102,37);
            this.lblInputTwo.TabIndex=0;
            this.lblInputTwo.Text="label2";
            // 
            // pnlSolve
            // 
            this.pnlSolve.Controls.Add(this.btnSolve);
            this.pnlSolve.Dock=System.Windows.Forms.DockStyle.Fill;
            this.pnlSolve.Location=new System.Drawing.Point(0,341);
            this.pnlSolve.Name="pnlSolve";
            this.pnlSolve.Size=new System.Drawing.Size(360,162);
            this.pnlSolve.TabIndex=3;
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor=System.Drawing.SystemColors.Control;
            this.btnSolve.BackgroundColor=System.Drawing.SystemColors.Control;
            this.btnSolve.BorderColor=System.Drawing.Color.MediumSlateBlue;
            this.btnSolve.BorderRadius=10;
            this.btnSolve.BorderSize=2;
            this.btnSolve.FlatAppearance.BorderSize=0;
            this.btnSolve.FlatStyle=System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.Font=new System.Drawing.Font("Microsoft Sans Serif",24F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
            this.btnSolve.ForeColor=System.Drawing.Color.MediumSlateBlue;
            this.btnSolve.Location=new System.Drawing.Point(106,6);
            this.btnSolve.Name="btnSolve";
            this.btnSolve.Size=new System.Drawing.Size(150,40);
            this.btnSolve.TabIndex=1;
            this.btnSolve.Text="Bắt đầu";
            this.btnSolve.TextColor=System.Drawing.Color.MediumSlateBlue;
            this.btnSolve.UseVisualStyleBackColor=false;
            this.btnSolve.Click+=new System.EventHandler(this.btnSolve_Click);
            // 
            // frmInput
            // 
            this.AutoScaleDimensions=new System.Drawing.SizeF(6F,13F);
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize=new System.Drawing.Size(360,503);
            this.Controls.Add(this.pnlSolve);
            this.Controls.Add(this.pnlInputTwo);
            this.Controls.Add(this.pnlInputOne);
            this.Controls.Add(this.pnlChoice);
            this.Name="frmInput";
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="Form1";
            this.pnlChoice.ResumeLayout(false);
            this.pnlChoice.PerformLayout();
            this.pnlInputOne.ResumeLayout(false);
            this.pnlInputOne.PerformLayout();
            this.pnlInputTwo.ResumeLayout(false);
            this.pnlInputTwo.PerformLayout();
            this.pnlSolve.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChoice;
        private RJCodeAdvance.RJControls.RJRadioButton rdoRoundHoleRoundPeg;
        private RJCodeAdvance.RJControls.RJRadioButton rdoRoundHoleSquarePeg;

        private System.Windows.Forms.Panel pnlInputOne;
        private System.Windows.Forms.Label lblInputOne;
        private RJCodeAdvance.RJControls.RJTextBox txtInputOne;

        private System.Windows.Forms.Panel pnlInputTwo;
        private System.Windows.Forms.Label lblInputTwo;
        private RJCodeAdvance.RJControls.RJTextBox txtInputTwo;

        private System.Windows.Forms.Panel pnlSolve;
        private RJCodeAdvance.RJControls.RJButton btnSolve;
    }
}

