namespace My_First_GUI_App
{
    partial class frmRandom
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
            this.btnRandoC = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandomN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandoC
            // 
            this.btnRandoC.Location = new System.Drawing.Point(145, 26);
            this.btnRandoC.Name = "btnRandoC";
            this.btnRandoC.Size = new System.Drawing.Size(529, 92);
            this.btnRandoC.TabIndex = 0;
            this.btnRandoC.Text = "Generate Random Color ";
            this.btnRandoC.UseVisualStyleBackColor = true;
            this.btnRandoC.Click += new System.EventHandler(this.btnRandoC_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(581, 341);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(171, 61);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "r-g-b";
            // 
            // btnRandomN
            // 
            this.btnRandomN.Location = new System.Drawing.Point(57, 336);
            this.btnRandomN.Name = "btnRandomN";
            this.btnRandomN.Size = new System.Drawing.Size(129, 66);
            this.btnRandomN.TabIndex = 2;
            this.btnRandomN.Text = "Random Number";
            this.btnRandomN.UseVisualStyleBackColor = true;
            this.btnRandomN.Click += new System.EventHandler(this.btnRandomN_Click_1);
            // 
            // Random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandomN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRandoC);
            this.Name = "Random";
            this.Text = "Random";
            this.Load += new System.EventHandler(this.Random_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandoC;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandomN;
    }
}