namespace My_First_GUI_App
{
    partial class frmRadio
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.GrbRadio = new System.Windows.Forms.GroupBox();
            this.RdoRed1 = new System.Windows.Forms.RadioButton();
            this.RdoGreen1 = new System.Windows.Forms.RadioButton();
            this.RdoBlue1 = new System.Windows.Forms.RadioButton();
            this.RdoYellow1 = new System.Windows.Forms.RadioButton();
            this.RdoRed = new System.Windows.Forms.RadioButton();
            this.RdoGreen = new System.Windows.Forms.RadioButton();
            this.RdoBlue = new System.Windows.Forms.RadioButton();
            this.RdoYellow = new System.Windows.Forms.RadioButton();
            this.GrbRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(42, 235);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(166, 75);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(430, 235);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(166, 75);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GrbRadio
            // 
            this.GrbRadio.Controls.Add(this.RdoYellow1);
            this.GrbRadio.Controls.Add(this.RdoBlue1);
            this.GrbRadio.Controls.Add(this.RdoGreen1);
            this.GrbRadio.Controls.Add(this.RdoRed1);
            this.GrbRadio.Location = new System.Drawing.Point(281, 12);
            this.GrbRadio.Name = "GrbRadio";
            this.GrbRadio.Size = new System.Drawing.Size(227, 183);
            this.GrbRadio.TabIndex = 2;
            this.GrbRadio.TabStop = false;
            this.GrbRadio.Text = "Grouped Radio Buttons";
            // 
            // RdoRed1
            // 
            this.RdoRed1.AutoSize = true;
            this.RdoRed1.Location = new System.Drawing.Point(28, 35);
            this.RdoRed1.Name = "RdoRed1";
            this.RdoRed1.Size = new System.Drawing.Size(53, 21);
            this.RdoRed1.TabIndex = 0;
            this.RdoRed1.TabStop = true;
            this.RdoRed1.Text = "Red";
            this.RdoRed1.UseVisualStyleBackColor = true;
            // 
            // RdoGreen1
            // 
            this.RdoGreen1.AutoSize = true;
            this.RdoGreen1.Location = new System.Drawing.Point(28, 62);
            this.RdoGreen1.Name = "RdoGreen1";
            this.RdoGreen1.Size = new System.Drawing.Size(65, 21);
            this.RdoGreen1.TabIndex = 0;
            this.RdoGreen1.TabStop = true;
            this.RdoGreen1.Text = "Green";
            this.RdoGreen1.UseVisualStyleBackColor = true;
            this.RdoGreen1.CheckedChanged += new System.EventHandler(this.RdoGreen1_CheckedChanged);
            // 
            // RdoBlue1
            // 
            this.RdoBlue1.AutoSize = true;
            this.RdoBlue1.Location = new System.Drawing.Point(28, 89);
            this.RdoBlue1.Name = "RdoBlue1";
            this.RdoBlue1.Size = new System.Drawing.Size(54, 21);
            this.RdoBlue1.TabIndex = 0;
            this.RdoBlue1.TabStop = true;
            this.RdoBlue1.Text = "Blue";
            this.RdoBlue1.UseVisualStyleBackColor = true;
            // 
            // RdoYellow1
            // 
            this.RdoYellow1.AutoSize = true;
            this.RdoYellow1.Location = new System.Drawing.Point(27, 116);
            this.RdoYellow1.Name = "RdoYellow1";
            this.RdoYellow1.Size = new System.Drawing.Size(66, 21);
            this.RdoYellow1.TabIndex = 0;
            this.RdoYellow1.TabStop = true;
            this.RdoYellow1.Text = "Yellow";
            this.RdoYellow1.UseVisualStyleBackColor = true;
            // 
            // RdoRed
            // 
            this.RdoRed.AutoSize = true;
            this.RdoRed.Location = new System.Drawing.Point(32, 52);
            this.RdoRed.Name = "RdoRed";
            this.RdoRed.Size = new System.Drawing.Size(53, 21);
            this.RdoRed.TabIndex = 0;
            this.RdoRed.TabStop = true;
            this.RdoRed.Text = "Red";
            this.RdoRed.UseVisualStyleBackColor = true;
            this.RdoRed.CheckedChanged += new System.EventHandler(this.RdoRed_CheckedChanged);
            // 
            // RdoGreen
            // 
            this.RdoGreen.AutoSize = true;
            this.RdoGreen.Location = new System.Drawing.Point(32, 79);
            this.RdoGreen.Name = "RdoGreen";
            this.RdoGreen.Size = new System.Drawing.Size(65, 21);
            this.RdoGreen.TabIndex = 0;
            this.RdoGreen.TabStop = true;
            this.RdoGreen.Text = "Green";
            this.RdoGreen.UseVisualStyleBackColor = true;
            this.RdoGreen.CheckedChanged += new System.EventHandler(this.RdoGreen_CheckedChanged);
            // 
            // RdoBlue
            // 
            this.RdoBlue.AutoSize = true;
            this.RdoBlue.Location = new System.Drawing.Point(33, 106);
            this.RdoBlue.Name = "RdoBlue";
            this.RdoBlue.Size = new System.Drawing.Size(54, 21);
            this.RdoBlue.TabIndex = 0;
            this.RdoBlue.TabStop = true;
            this.RdoBlue.Text = "Blue";
            this.RdoBlue.UseVisualStyleBackColor = true;
            this.RdoBlue.CheckedChanged += new System.EventHandler(this.RdoBlue_CheckedChanged);
            // 
            // RdoYellow
            // 
            this.RdoYellow.AutoSize = true;
            this.RdoYellow.Location = new System.Drawing.Point(33, 133);
            this.RdoYellow.Name = "RdoYellow";
            this.RdoYellow.Size = new System.Drawing.Size(66, 21);
            this.RdoYellow.TabIndex = 0;
            this.RdoYellow.TabStop = true;
            this.RdoYellow.Text = "Yellow";
            this.RdoYellow.UseVisualStyleBackColor = true;
            this.RdoYellow.CheckedChanged += new System.EventHandler(this.RdoYellow_CheckedChanged);
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 350);
            this.Controls.Add(this.RdoYellow);
            this.Controls.Add(this.GrbRadio);
            this.Controls.Add(this.RdoBlue);
            this.Controls.Add(this.RdoGreen);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.RdoRed);
            this.Controls.Add(this.btnReset);
            this.Name = "frmRadio";
            this.Text = "frmRadio";
            this.GrbRadio.ResumeLayout(false);
            this.GrbRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox GrbRadio;
        private System.Windows.Forms.RadioButton RdoYellow1;
        private System.Windows.Forms.RadioButton RdoBlue1;
        private System.Windows.Forms.RadioButton RdoGreen1;
        private System.Windows.Forms.RadioButton RdoRed1;
        private System.Windows.Forms.RadioButton RdoRed;
        private System.Windows.Forms.RadioButton RdoGreen;
        private System.Windows.Forms.RadioButton RdoBlue;
        private System.Windows.Forms.RadioButton RdoYellow;
    }
}