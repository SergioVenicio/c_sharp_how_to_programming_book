namespace _17_12_CreditInquiry
{
    partial class CredityInquiryForm
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtOutPut = new System.Windows.Forms.RichTextBox();
            this.btnZero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 192);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 34);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(126, 192);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(94, 34);
            this.btnCredit.TabIndex = 1;
            this.btnCredit.Text = "Credit Balances";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.get_Click);
            // 
            // btnDebit
            // 
            this.btnDebit.Location = new System.Drawing.Point(243, 192);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(94, 34);
            this.btnDebit.TabIndex = 2;
            this.btnDebit.Text = "Debit Balances";
            this.btnDebit.UseVisualStyleBackColor = true;
            this.btnDebit.Click += new System.EventHandler(this.get_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(460, 192);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(94, 34);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtOutPut
            // 
            this.txtOutPut.Location = new System.Drawing.Point(12, 13);
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(542, 173);
            this.txtOutPut.TabIndex = 4;
            this.txtOutPut.Text = "";
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(354, 192);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(94, 34);
            this.btnZero.TabIndex = 5;
            this.btnZero.Text = "Zero Balances";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.get_Click);
            // 
            // CredityInquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 229);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnOpen);
            this.Name = "CredityInquiryForm";
            this.Text = "CreditInqruiry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnDebit;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.RichTextBox txtOutPut;
        private System.Windows.Forms.Button btnZero;
    }
}

