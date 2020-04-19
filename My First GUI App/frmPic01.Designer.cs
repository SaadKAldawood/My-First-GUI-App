namespace My_First_GUI_App
{
    partial class frmPic01
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PicTry = new System.Windows.Forms.PictureBox();
            this.btnFromF = new System.Windows.Forms.Button();
            this.btnFromR = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.PicTry);
            this.groupBox1.Location = new System.Drawing.Point(215, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(498, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(460, 344);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PicTry
            // 
            this.PicTry.Location = new System.Drawing.Point(6, 53);
            this.PicTry.Name = "PicTry";
            this.PicTry.Size = new System.Drawing.Size(460, 344);
            this.PicTry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTry.TabIndex = 0;
            this.PicTry.TabStop = false;
            this.PicTry.Click += new System.EventHandler(this.PicTry_Click);
            // 
            // btnFromF
            // 
            this.btnFromF.Location = new System.Drawing.Point(40, 41);
            this.btnFromF.Name = "btnFromF";
            this.btnFromF.Size = new System.Drawing.Size(156, 46);
            this.btnFromF.TabIndex = 1;
            this.btnFromF.Text = "Image From File";
            this.btnFromF.UseVisualStyleBackColor = true;
            this.btnFromF.Click += new System.EventHandler(this.btnFromF_Click);
            // 
            // btnFromR
            // 
            this.btnFromR.Location = new System.Drawing.Point(40, 113);
            this.btnFromR.Name = "btnFromR";
            this.btnFromR.Size = new System.Drawing.Size(156, 46);
            this.btnFromR.TabIndex = 1;
            this.btnFromR.Text = "Image From Resource";
            this.btnFromR.UseVisualStyleBackColor = true;
            this.btnFromR.Click += new System.EventHandler(this.btnFromR_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1016, 511);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 46);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmPic01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 560);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFromR);
            this.Controls.Add(this.btnFromF);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPic01";
            this.Text = "frmPic01";
            this.Load += new System.EventHandler(this.frmPic01_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PicTry;
        private System.Windows.Forms.Button btnFromF;
        private System.Windows.Forms.Button btnFromR;
        private System.Windows.Forms.Button btnBack;
    }
}