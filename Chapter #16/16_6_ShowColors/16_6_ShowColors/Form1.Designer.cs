namespace _16_6_ShowColors
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.btnSetColorName = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.btnSetColorValue = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtColorName);
            this.groupBox1.Controls.Add(this.btnSetColorName);
            this.groupBox1.Location = new System.Drawing.Point(14, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Back Color Name";
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(22, 32);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(253, 20);
            this.txtColorName.TabIndex = 1;
            // 
            // btnSetColorName
            // 
            this.btnSetColorName.Location = new System.Drawing.Point(290, 30);
            this.btnSetColorName.Name = "btnSetColorName";
            this.btnSetColorName.Size = new System.Drawing.Size(115, 23);
            this.btnSetColorName.TabIndex = 0;
            this.btnSetColorName.Text = "Set Color Name";
            this.btnSetColorName.UseVisualStyleBackColor = true;
            this.btnSetColorName.Click += new System.EventHandler(this.btnSetColorName_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBlue);
            this.groupBox2.Controls.Add(this.txtGreen);
            this.groupBox2.Controls.Add(this.txtRed);
            this.groupBox2.Controls.Add(this.txtAlpha);
            this.groupBox2.Controls.Add(this.btnSetColorValue);
            this.groupBox2.Location = new System.Drawing.Point(14, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Front Color Value";
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(219, 32);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(56, 20);
            this.txtBlue.TabIndex = 4;
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(150, 32);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(63, 20);
            this.txtGreen.TabIndex = 3;
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(81, 32);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(63, 20);
            this.txtRed.TabIndex = 2;
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(22, 32);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(53, 20);
            this.txtAlpha.TabIndex = 1;
            // 
            // btnSetColorValue
            // 
            this.btnSetColorValue.Location = new System.Drawing.Point(290, 30);
            this.btnSetColorValue.Name = "btnSetColorValue";
            this.btnSetColorValue.Size = new System.Drawing.Size(115, 23);
            this.btnSetColorValue.TabIndex = 0;
            this.btnSetColorValue.Text = "Set Color Value";
            this.btnSetColorValue.UseVisualStyleBackColor = true;
            this.btnSetColorValue.Click += new System.EventHandler(this.btnSetColorValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Button btnSetColorName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.Button btnSetColorValue;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtRed;
    }
}

