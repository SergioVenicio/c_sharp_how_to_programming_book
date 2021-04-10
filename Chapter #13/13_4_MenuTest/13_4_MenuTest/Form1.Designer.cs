namespace _13_4_MenuTest
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemBlackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemBlueColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemRedColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemGreenColor = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemTimesNewRomanFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemCourierFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemComicSansFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuItemBoldText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemItalicText = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemBlackColor,
            this.tsMenuItemBlueColor,
            this.tsMenuItemRedColor,
            this.tsMenuItemGreenColor});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // tsMenuItemBlackColor
            // 
            this.tsMenuItemBlackColor.Checked = true;
            this.tsMenuItemBlackColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsMenuItemBlackColor.Name = "tsMenuItemBlackColor";
            this.tsMenuItemBlackColor.Size = new System.Drawing.Size(180, 22);
            this.tsMenuItemBlackColor.Text = "Black";
            this.tsMenuItemBlackColor.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // tsMenuItemBlueColor
            // 
            this.tsMenuItemBlueColor.Name = "tsMenuItemBlueColor";
            this.tsMenuItemBlueColor.Size = new System.Drawing.Size(180, 22);
            this.tsMenuItemBlueColor.Text = "Blue";
            this.tsMenuItemBlueColor.Click += new System.EventHandler(this.tsMenuItemBlueColor_Click);
            // 
            // tsMenuItemRedColor
            // 
            this.tsMenuItemRedColor.Name = "tsMenuItemRedColor";
            this.tsMenuItemRedColor.Size = new System.Drawing.Size(180, 22);
            this.tsMenuItemRedColor.Text = "Red";
            this.tsMenuItemRedColor.Click += new System.EventHandler(this.tsMenuItemRedColor_Click);
            // 
            // tsMenuItemGreenColor
            // 
            this.tsMenuItemGreenColor.Name = "tsMenuItemGreenColor";
            this.tsMenuItemGreenColor.Size = new System.Drawing.Size(180, 22);
            this.tsMenuItemGreenColor.Text = "Green";
            this.tsMenuItemGreenColor.Click += new System.EventHandler(this.tsMenuItemGreenColor_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemTimesNewRomanFont,
            this.tsMenuItemCourierFont,
            this.tsMenuItemComicSansFont,
            this.toolStripSeparator1,
            this.tsMenuItemBoldText,
            this.tsMenuItemItalicText});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // tsMenuItemTimesNewRomanFont
            // 
            this.tsMenuItemTimesNewRomanFont.Name = "tsMenuItemTimesNewRomanFont";
            this.tsMenuItemTimesNewRomanFont.Size = new System.Drawing.Size(180, 22);
            this.tsMenuItemTimesNewRomanFont.Text = "Times New Roman";
            this.tsMenuItemTimesNewRomanFont.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem_Click);
            // 
            // tsMenuItemCourierFont
            // 
            this.tsMenuItemCourierFont.Name = "tsMenuItemCourierFont";
            this.tsMenuItemCourierFont.Size = new System.Drawing.Size(180, 22);
            this.tsMenuItemCourierFont.Text = "Courier";
            this.tsMenuItemCourierFont.Click += new System.EventHandler(this.tsMenuItemCourierFont_Click);
            // 
            // tsMenuItemComicSansFont
            // 
            this.tsMenuItemComicSansFont.Name = "tsMenuItemComicSansFont";
            this.tsMenuItemComicSansFont.Size = new System.Drawing.Size(180, 22);
            this.tsMenuItemComicSansFont.Text = "Comic Sans";
            this.tsMenuItemComicSansFont.Click += new System.EventHandler(this.tsMenuItemComicSansFont_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsMenuItemBoldText
            // 
            this.tsMenuItemBoldText.Name = "tsMenuItemBoldText";
            this.tsMenuItemBoldText.Size = new System.Drawing.Size(180, 22);
            this.tsMenuItemBoldText.Text = "Bold";
            this.tsMenuItemBoldText.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // tsMenuItemItalicText
            // 
            this.tsMenuItemItalicText.Name = "tsMenuItemItalicText";
            this.tsMenuItemItalicText.Size = new System.Drawing.Size(180, 22);
            this.tsMenuItemItalicText.Text = "Italic";
            this.tsMenuItemItalicText.Click += new System.EventHandler(this.tsMenuItemItalicText_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(82, 44);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(502, 24);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "Use the format menu to change the appearance of this text.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 113);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemBlackColor;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemBlueColor;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemRedColor;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemGreenColor;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemTimesNewRomanFont;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemCourierFont;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemComicSansFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemBoldText;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemItalicText;
        private System.Windows.Forms.Label lblDisplay;
    }
}

