
namespace _11_1_DivideByZero
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumerator = new System.Windows.Forms.Label();
            this.lblDenominator = new System.Windows.Forms.Label();
            this.txtNumerator = new System.Windows.Forms.TextBox();
            this.txtDenominator = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumerator
            // 
            this.lblNumerator.AutoSize = true;
            this.lblNumerator.Location = new System.Drawing.Point(28, 13);
            this.lblNumerator.Name = "lblNumerator";
            this.lblNumerator.Size = new System.Drawing.Size(93, 15);
            this.lblNumerator.TabIndex = 0;
            this.lblNumerator.Text = "Enter numerator";
            // 
            // lblDenominator
            // 
            this.lblDenominator.AutoSize = true;
            this.lblDenominator.Location = new System.Drawing.Point(28, 70);
            this.lblDenominator.Name = "lblDenominator";
            this.lblDenominator.Size = new System.Drawing.Size(106, 15);
            this.lblDenominator.TabIndex = 1;
            this.lblDenominator.Text = "Enter denominator";
            // 
            // txtNumerator
            // 
            this.txtNumerator.Location = new System.Drawing.Point(149, 10);
            this.txtNumerator.Name = "txtNumerator";
            this.txtNumerator.Size = new System.Drawing.Size(117, 23);
            this.txtNumerator.TabIndex = 2;
            // 
            // txtDenominator
            // 
            this.txtDenominator.Location = new System.Drawing.Point(149, 62);
            this.txtDenominator.Name = "txtDenominator";
            this.txtDenominator.Size = new System.Drawing.Size(117, 23);
            this.txtDenominator.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(175, 115);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 4;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(28, 111);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(106, 23);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.Text = "Click to Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 161);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtDenominator);
            this.Controls.Add(this.txtNumerator);
            this.Controls.Add(this.lblDenominator);
            this.Controls.Add(this.lblNumerator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumerator;
        private System.Windows.Forms.Label lblDenominator;
        private System.Windows.Forms.TextBox txtNumerator;
        private System.Windows.Forms.TextBox txtDenominator;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDivide;
    }
}

