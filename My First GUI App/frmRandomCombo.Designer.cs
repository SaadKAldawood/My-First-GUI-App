namespace My_First_GUI_App
{
    partial class frmRandomCombo
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenerate1 = new System.Windows.Forms.Button();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblQuizAAF = new System.Windows.Forms.Label();
            this.lblQuizEAF = new System.Windows.Forms.Label();
            this.RdoLess500 = new System.Windows.Forms.RadioButton();
            this.RdoGreater500 = new System.Windows.Forms.RadioButton();
            this.Rdoless50 = new System.Windows.Forms.RadioButton();
            this.RdoGreater50 = new System.Windows.Forms.RadioButton();
            this.CmbAAF = new System.Windows.Forms.ComboBox();
            this.CmbEAF = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(264, 92);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 40);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(264, 239);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenerate1
            // 
            this.btnGenerate1.Location = new System.Drawing.Point(597, 92);
            this.btnGenerate1.Name = "btnGenerate1";
            this.btnGenerate1.Size = new System.Drawing.Size(100, 40);
            this.btnGenerate1.TabIndex = 0;
            this.btnGenerate1.Text = "Generate";
            this.btnGenerate1.UseVisualStyleBackColor = true;
            this.btnGenerate1.Click += new System.EventHandler(this.btnGenerate1_Click);
            // 
            // btnReset1
            // 
            this.btnReset1.Location = new System.Drawing.Point(597, 239);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(100, 40);
            this.btnReset1.TabIndex = 0;
            this.btnReset1.Text = "Reset";
            this.btnReset1.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(597, 367);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 42);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblQuizAAF
            // 
            this.lblQuizAAF.AutoSize = true;
            this.lblQuizAAF.Location = new System.Drawing.Point(122, 47);
            this.lblQuizAAF.Name = "lblQuizAAF";
            this.lblQuizAAF.Size = new System.Drawing.Size(97, 17);
            this.lblQuizAAF.TabIndex = 1;
            this.lblQuizAAF.Text = "Quiz03_AAF19";
            // 
            // lblQuizEAF
            // 
            this.lblQuizEAF.AutoSize = true;
            this.lblQuizEAF.Location = new System.Drawing.Point(517, 47);
            this.lblQuizEAF.Name = "lblQuizEAF";
            this.lblQuizEAF.Size = new System.Drawing.Size(97, 17);
            this.lblQuizEAF.TabIndex = 1;
            this.lblQuizEAF.Text = "Quiz03_EAF19";
            // 
            // RdoLess500
            // 
            this.RdoLess500.AutoSize = true;
            this.RdoLess500.Location = new System.Drawing.Point(230, 171);
            this.RdoLess500.Name = "RdoLess500";
            this.RdoLess500.Size = new System.Drawing.Size(115, 21);
            this.RdoLess500.TabIndex = 2;
            this.RdoLess500.TabStop = true;
            this.RdoLess500.Text = "Less than 500";
            this.RdoLess500.UseVisualStyleBackColor = true;
            // 
            // RdoGreater500
            // 
            this.RdoGreater500.AutoSize = true;
            this.RdoGreater500.Location = new System.Drawing.Point(230, 198);
            this.RdoGreater500.Name = "RdoGreater500";
            this.RdoGreater500.Size = new System.Drawing.Size(134, 21);
            this.RdoGreater500.TabIndex = 2;
            this.RdoGreater500.TabStop = true;
            this.RdoGreater500.Text = "Greater than 500";
            this.RdoGreater500.UseVisualStyleBackColor = true;
            // 
            // Rdoless50
            // 
            this.Rdoless50.AutoSize = true;
            this.Rdoless50.Location = new System.Drawing.Point(456, 171);
            this.Rdoless50.Name = "Rdoless50";
            this.Rdoless50.Size = new System.Drawing.Size(107, 21);
            this.Rdoless50.TabIndex = 2;
            this.Rdoless50.TabStop = true;
            this.Rdoless50.Text = "Less than 50";
            this.Rdoless50.UseVisualStyleBackColor = true;
            // 
            // RdoGreater50
            // 
            this.RdoGreater50.AutoSize = true;
            this.RdoGreater50.Location = new System.Drawing.Point(456, 198);
            this.RdoGreater50.Name = "RdoGreater50";
            this.RdoGreater50.Size = new System.Drawing.Size(134, 21);
            this.RdoGreater50.TabIndex = 2;
            this.RdoGreater50.TabStop = true;
            this.RdoGreater50.Text = "Greater than 500";
            this.RdoGreater50.UseVisualStyleBackColor = true;
            // 
            // CmbAAF
            // 
            this.CmbAAF.FormattingEnabled = true;
            this.CmbAAF.Location = new System.Drawing.Point(98, 92);
            this.CmbAAF.Name = "CmbAAF";
            this.CmbAAF.Size = new System.Drawing.Size(121, 24);
            this.CmbAAF.TabIndex = 3;
            // 
            // CmbEAF
            // 
            this.CmbEAF.FormattingEnabled = true;
            this.CmbEAF.Location = new System.Drawing.Point(444, 92);
            this.CmbEAF.Name = "CmbEAF";
            this.CmbEAF.Size = new System.Drawing.Size(121, 24);
            this.CmbEAF.TabIndex = 3;
            // 
            // frmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbEAF);
            this.Controls.Add(this.CmbAAF);
            this.Controls.Add(this.RdoGreater50);
            this.Controls.Add(this.RdoGreater500);
            this.Controls.Add(this.Rdoless50);
            this.Controls.Add(this.RdoLess500);
            this.Controls.Add(this.lblQuizEAF);
            this.Controls.Add(this.lblQuizAAF);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset1);
            this.Controls.Add(this.btnGenerate1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Name = "frmRandomCombo";
            this.Text = "frmRandomCombo";
            this.Load += new System.EventHandler(this.frmRandomCombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenerate1;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblQuizAAF;
        private System.Windows.Forms.Label lblQuizEAF;
        private System.Windows.Forms.RadioButton RdoLess500;
        private System.Windows.Forms.RadioButton RdoGreater500;
        private System.Windows.Forms.RadioButton Rdoless50;
        private System.Windows.Forms.RadioButton RdoGreater50;
        private System.Windows.Forms.ComboBox CmbAAF;
        private System.Windows.Forms.ComboBox CmbEAF;
    }
}