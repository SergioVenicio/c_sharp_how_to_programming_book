namespace _15_16_CharMethods
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnalyzeChar = new System.Windows.Forms.Button();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.ltbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a character: ";
            // 
            // btnAnalyzeChar
            // 
            this.btnAnalyzeChar.Location = new System.Drawing.Point(38, 52);
            this.btnAnalyzeChar.Name = "btnAnalyzeChar";
            this.btnAnalyzeChar.Size = new System.Drawing.Size(126, 23);
            this.btnAnalyzeChar.TabIndex = 1;
            this.btnAnalyzeChar.Text = "Analyze Character";
            this.btnAnalyzeChar.UseVisualStyleBackColor = true;
            this.btnAnalyzeChar.Click += new System.EventHandler(this.btnAnalyzeChar_Click);
            // 
            // txtChar
            // 
            this.txtChar.Location = new System.Drawing.Point(113, 6);
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(62, 20);
            this.txtChar.TabIndex = 2;
            // 
            // ltbResult
            // 
            this.ltbResult.FormattingEnabled = true;
            this.ltbResult.Location = new System.Drawing.Point(15, 102);
            this.ltbResult.Name = "ltbResult";
            this.ltbResult.Size = new System.Drawing.Size(160, 121);
            this.ltbResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 233);
            this.Controls.Add(this.ltbResult);
            this.Controls.Add(this.txtChar);
            this.Controls.Add(this.btnAnalyzeChar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnalyzeChar;
        private System.Windows.Forms.TextBox txtChar;
        private System.Windows.Forms.ListBox ltbResult;
    }
}

