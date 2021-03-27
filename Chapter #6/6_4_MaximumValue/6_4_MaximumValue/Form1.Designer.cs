namespace _6_4_MaximumValue
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
            this.btnMax = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txbFirstNumber = new System.Windows.Forms.TextBox();
            this.txbSecondNumber = new System.Windows.Forms.TextBox();
            this.txbThirdNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(12, 168);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(115, 23);
            this.btnMax.TabIndex = 0;
            this.btnMax.Text = "Calculate Maximum";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Third Number:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(156, 173);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(63, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "maximum is:";
            // 
            // txbFirstNumber
            // 
            this.txbFirstNumber.Location = new System.Drawing.Point(159, 25);
            this.txbFirstNumber.Name = "txbFirstNumber";
            this.txbFirstNumber.Size = new System.Drawing.Size(127, 20);
            this.txbFirstNumber.TabIndex = 8;
            // 
            // txbSecondNumber
            // 
            this.txbSecondNumber.Location = new System.Drawing.Point(159, 69);
            this.txbSecondNumber.Name = "txbSecondNumber";
            this.txbSecondNumber.Size = new System.Drawing.Size(127, 20);
            this.txbSecondNumber.TabIndex = 9;
            this.txbSecondNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txbThirdNumber
            // 
            this.txbThirdNumber.Location = new System.Drawing.Point(159, 114);
            this.txbThirdNumber.Name = "txbThirdNumber";
            this.txbThirdNumber.Size = new System.Drawing.Size(127, 20);
            this.txbThirdNumber.TabIndex = 10;
            this.txbThirdNumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 206);
            this.Controls.Add(this.txbThirdNumber);
            this.Controls.Add(this.txbSecondNumber);
            this.Controls.Add(this.txbFirstNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txbFirstNumber;
        private System.Windows.Forms.TextBox txbSecondNumber;
        private System.Windows.Forms.TextBox txbThirdNumber;
    }
}

