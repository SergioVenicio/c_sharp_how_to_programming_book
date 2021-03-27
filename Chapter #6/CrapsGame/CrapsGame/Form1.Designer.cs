namespace CrapsGame
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lbl_die1 = new System.Windows.Forms.Label();
            this.lbl_die2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(23, 187);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(104, 187);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(12, 9);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(42, 13);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Points: ";
            // 
            // lbl_die1
            // 
            this.lbl_die1.AutoSize = true;
            this.lbl_die1.Location = new System.Drawing.Point(12, 58);
            this.lbl_die1.Name = "lbl_die1";
            this.lbl_die1.Size = new System.Drawing.Size(35, 13);
            this.lbl_die1.TabIndex = 3;
            this.lbl_die1.Text = "Die 1:";
            // 
            // lbl_die2
            // 
            this.lbl_die2.AutoSize = true;
            this.lbl_die2.Location = new System.Drawing.Point(101, 58);
            this.lbl_die2.Name = "lbl_die2";
            this.lbl_die2.Size = new System.Drawing.Size(35, 13);
            this.lbl_die2.TabIndex = 4;
            this.lbl_die2.Text = "Die 2:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 118);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 237);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lbl_die2);
            this.Controls.Add(this.lbl_die1);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lbl_die1;
        private System.Windows.Forms.Label lbl_die2;
        private System.Windows.Forms.Label lblResult;
    }
}

