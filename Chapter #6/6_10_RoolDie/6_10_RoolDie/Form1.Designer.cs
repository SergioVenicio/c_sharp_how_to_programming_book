namespace _6_10_RoolDie
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.lbl_die_1 = new System.Windows.Forms.Label();
            this.lbl_die_2 = new System.Windows.Forms.Label();
            this.lbl_die_3 = new System.Windows.Forms.Label();
            this.lbl_die_4 = new System.Windows.Forms.Label();
            this.txtStatistics = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(81, 151);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lbl_die_1
            // 
            this.lbl_die_1.AutoSize = true;
            this.lbl_die_1.Location = new System.Drawing.Point(28, 24);
            this.lbl_die_1.Name = "lbl_die_1";
            this.lbl_die_1.Size = new System.Drawing.Size(0, 13);
            this.lbl_die_1.TabIndex = 5;
            // 
            // lbl_die_2
            // 
            this.lbl_die_2.AutoSize = true;
            this.lbl_die_2.Location = new System.Drawing.Point(28, 99);
            this.lbl_die_2.Name = "lbl_die_2";
            this.lbl_die_2.Size = new System.Drawing.Size(0, 13);
            this.lbl_die_2.TabIndex = 6;
            // 
            // lbl_die_3
            // 
            this.lbl_die_3.AutoSize = true;
            this.lbl_die_3.Location = new System.Drawing.Point(143, 24);
            this.lbl_die_3.Name = "lbl_die_3";
            this.lbl_die_3.Size = new System.Drawing.Size(0, 13);
            this.lbl_die_3.TabIndex = 7;
            // 
            // lbl_die_4
            // 
            this.lbl_die_4.AutoSize = true;
            this.lbl_die_4.Location = new System.Drawing.Point(143, 99);
            this.lbl_die_4.Name = "lbl_die_4";
            this.lbl_die_4.Size = new System.Drawing.Size(0, 13);
            this.lbl_die_4.TabIndex = 8;
            // 
            // txtStatistics
            // 
            this.txtStatistics.Location = new System.Drawing.Point(2, 183);
            this.txtStatistics.Name = "txtStatistics";
            this.txtStatistics.ReadOnly = true;
            this.txtStatistics.Size = new System.Drawing.Size(232, 105);
            this.txtStatistics.TabIndex = 9;
            this.txtStatistics.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 291);
            this.Controls.Add(this.txtStatistics);
            this.Controls.Add(this.lbl_die_4);
            this.Controls.Add(this.lbl_die_3);
            this.Controls.Add(this.lbl_die_2);
            this.Controls.Add(this.lbl_die_1);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lbl_die_1;
        private System.Windows.Forms.Label lbl_die_2;
        private System.Windows.Forms.Label lbl_die_3;
        private System.Windows.Forms.Label lbl_die_4;
        private System.Windows.Forms.RichTextBox txtStatistics;
    }
}

