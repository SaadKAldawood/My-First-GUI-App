namespace My_First_GUI_App
{
    partial class frmMain
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
            this.linkLblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.LblPW = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCheckBox = new System.Windows.Forms.Button();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSelfieApp = new System.Windows.Forms.Button();
            this.BtnPictureBox2 = new System.Windows.Forms.Button();
            this.BtnGroupieApp = new System.Windows.Forms.Button();
            this.BtnPictureBox = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnProgress = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnRandomCombo = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnABCAnalysis = new System.Windows.Forms.Button();
            this.BtnRoboticCell = new System.Windows.Forms.Button();
            this.BtnJohari = new System.Windows.Forms.Button();
            this.BtnManufacturingCell = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnArduino = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.linkLblForgotPassword);
            this.groupBox1.Controls.Add(this.LblPW);
            this.groupBox1.Controls.Add(this.LblUser);
            this.groupBox1.Controls.Add(this.TxtPW);
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // linkLblForgotPassword
            // 
            this.linkLblForgotPassword.AutoSize = true;
            this.linkLblForgotPassword.Font = new System.Drawing.Font("Tahoma", 8F);
            this.linkLblForgotPassword.Location = new System.Drawing.Point(18, 168);
            this.linkLblForgotPassword.Name = "linkLblForgotPassword";
            this.linkLblForgotPassword.Size = new System.Drawing.Size(118, 17);
            this.linkLblForgotPassword.TabIndex = 7;
            this.linkLblForgotPassword.TabStop = true;
            this.linkLblForgotPassword.Text = "Forgot Password?";
            // 
            // LblPW
            // 
            this.LblPW.AutoSize = true;
            this.LblPW.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LblPW.Location = new System.Drawing.Point(69, 86);
            this.LblPW.Name = "LblPW";
            this.LblPW.Size = new System.Drawing.Size(81, 21);
            this.LblPW.TabIndex = 6;
            this.LblPW.Text = "Password";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LblUser.Location = new System.Drawing.Point(66, 45);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(85, 21);
            this.LblUser.TabIndex = 5;
            this.LblUser.Text = "Username";
            // 
            // TxtPW
            // 
            this.TxtPW.Location = new System.Drawing.Point(171, 86);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.Size = new System.Drawing.Size(100, 32);
            this.TxtPW.TabIndex = 4;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(171, 42);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(100, 32);
            this.TxtUser.TabIndex = 3;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Green;
            this.BtnLogin.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnLogin.Location = new System.Drawing.Point(171, 159);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(100, 31);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Firebrick;
            this.BtnExit.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(961, 385);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(290, 102);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox2.Controls.Add(this.BtnCheckBox);
            this.groupBox2.Controls.Add(this.BtnCombo);
            this.groupBox2.Controls.Add(this.BtnRadio);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.Location = new System.Drawing.Point(345, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Controls";
            // 
            // BtnCheckBox
            // 
            this.BtnCheckBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnCheckBox.Location = new System.Drawing.Point(36, 89);
            this.BtnCheckBox.Name = "BtnCheckBox";
            this.BtnCheckBox.Size = new System.Drawing.Size(132, 34);
            this.BtnCheckBox.TabIndex = 2;
            this.BtnCheckBox.Text = "CheckBox";
            this.BtnCheckBox.UseVisualStyleBackColor = true;
            this.BtnCheckBox.Click += new System.EventHandler(this.BtnCheckBox_Click);
            // 
            // BtnCombo
            // 
            this.BtnCombo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnCombo.Location = new System.Drawing.Point(36, 138);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(132, 34);
            this.BtnCombo.TabIndex = 1;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = true;
            this.BtnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // BtnRadio
            // 
            this.BtnRadio.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnRadio.Location = new System.Drawing.Point(36, 41);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(132, 34);
            this.BtnRadio.TabIndex = 0;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = true;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.BtnSelfieApp);
            this.groupBox3.Controls.Add(this.BtnPictureBox2);
            this.groupBox3.Controls.Add(this.BtnGroupieApp);
            this.groupBox3.Controls.Add(this.BtnPictureBox);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox3.Location = new System.Drawing.Point(937, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 246);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphical";
            // 
            // BtnSelfieApp
            // 
            this.BtnSelfieApp.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnSelfieApp.Location = new System.Drawing.Point(194, 33);
            this.BtnSelfieApp.Name = "BtnSelfieApp";
            this.BtnSelfieApp.Size = new System.Drawing.Size(154, 71);
            this.BtnSelfieApp.TabIndex = 3;
            this.BtnSelfieApp.Text = "Selfie App";
            this.BtnSelfieApp.UseVisualStyleBackColor = true;
            // 
            // BtnPictureBox2
            // 
            this.BtnPictureBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnPictureBox2.Location = new System.Drawing.Point(24, 137);
            this.BtnPictureBox2.Name = "BtnPictureBox2";
            this.BtnPictureBox2.Size = new System.Drawing.Size(154, 71);
            this.BtnPictureBox2.TabIndex = 2;
            this.BtnPictureBox2.Text = "PictureBox2";
            this.BtnPictureBox2.UseVisualStyleBackColor = true;
            // 
            // BtnGroupieApp
            // 
            this.BtnGroupieApp.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnGroupieApp.Location = new System.Drawing.Point(194, 137);
            this.BtnGroupieApp.Name = "BtnGroupieApp";
            this.BtnGroupieApp.Size = new System.Drawing.Size(154, 71);
            this.BtnGroupieApp.TabIndex = 1;
            this.BtnGroupieApp.Text = "Groupie App";
            this.BtnGroupieApp.UseVisualStyleBackColor = true;
            // 
            // BtnPictureBox
            // 
            this.BtnPictureBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnPictureBox.Location = new System.Drawing.Point(24, 33);
            this.BtnPictureBox.Name = "BtnPictureBox";
            this.BtnPictureBox.Size = new System.Drawing.Size(154, 71);
            this.BtnPictureBox.TabIndex = 0;
            this.BtnPictureBox.Text = "PictureBox";
            this.BtnPictureBox.UseVisualStyleBackColor = true;
            this.BtnPictureBox.Click += new System.EventHandler(this.BtnPictureBox_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox4.Controls.Add(this.BtnProgress);
            this.groupBox4.Controls.Add(this.BtnTimer);
            this.groupBox4.Controls.Add(this.BtnRandomCombo);
            this.groupBox4.Controls.Add(this.BtnRandom);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox4.Location = new System.Drawing.Point(345, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 245);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "More Controls";
            // 
            // BtnProgress
            // 
            this.BtnProgress.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnProgress.Location = new System.Drawing.Point(36, 74);
            this.BtnProgress.Name = "BtnProgress";
            this.BtnProgress.Size = new System.Drawing.Size(132, 49);
            this.BtnProgress.TabIndex = 3;
            this.BtnProgress.Text = "Progress";
            this.BtnProgress.UseVisualStyleBackColor = true;
            // 
            // BtnTimer
            // 
            this.BtnTimer.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnTimer.Location = new System.Drawing.Point(36, 23);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(132, 49);
            this.BtnTimer.TabIndex = 2;
            this.BtnTimer.Text = "Timer";
            this.BtnTimer.UseVisualStyleBackColor = true;
            // 
            // BtnRandomCombo
            // 
            this.BtnRandomCombo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnRandomCombo.Location = new System.Drawing.Point(36, 187);
            this.BtnRandomCombo.Name = "BtnRandomCombo";
            this.BtnRandomCombo.Size = new System.Drawing.Size(132, 49);
            this.BtnRandomCombo.TabIndex = 1;
            this.BtnRandomCombo.Text = "RandomCombo";
            this.BtnRandomCombo.UseVisualStyleBackColor = true;
            this.BtnRandomCombo.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnRandom.Location = new System.Drawing.Point(36, 129);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(132, 49);
            this.BtnRandom.TabIndex = 0;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = true;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox5.Controls.Add(this.BtnDraw);
            this.groupBox5.Controls.Add(this.BtnTalk);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox5.Location = new System.Drawing.Point(45, 265);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(229, 138);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Draw and Talk";
            // 
            // BtnDraw
            // 
            this.BtnDraw.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnDraw.Location = new System.Drawing.Point(17, 51);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(97, 53);
            this.BtnDraw.TabIndex = 2;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = true;
            // 
            // BtnTalk
            // 
            this.BtnTalk.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnTalk.Location = new System.Drawing.Point(126, 51);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(97, 53);
            this.BtnTalk.TabIndex = 1;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox6.Controls.Add(this.BtnABCAnalysis);
            this.groupBox6.Controls.Add(this.BtnRoboticCell);
            this.groupBox6.Controls.Add(this.BtnJohari);
            this.groupBox6.Controls.Add(this.BtnManufacturingCell);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox6.Location = new System.Drawing.Point(610, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(223, 322);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Exam Apps";
            // 
            // BtnABCAnalysis
            // 
            this.BtnABCAnalysis.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnABCAnalysis.Location = new System.Drawing.Point(37, 162);
            this.BtnABCAnalysis.Name = "BtnABCAnalysis";
            this.BtnABCAnalysis.Size = new System.Drawing.Size(157, 59);
            this.BtnABCAnalysis.TabIndex = 3;
            this.BtnABCAnalysis.Text = "ABC Analysis";
            this.BtnABCAnalysis.UseVisualStyleBackColor = true;
            // 
            // BtnRoboticCell
            // 
            this.BtnRoboticCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnRoboticCell.Location = new System.Drawing.Point(38, 227);
            this.BtnRoboticCell.Name = "BtnRoboticCell";
            this.BtnRoboticCell.Size = new System.Drawing.Size(156, 57);
            this.BtnRoboticCell.TabIndex = 2;
            this.BtnRoboticCell.Text = "Robotic Cell";
            this.BtnRoboticCell.UseVisualStyleBackColor = true;
            // 
            // BtnJohari
            // 
            this.BtnJohari.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnJohari.Location = new System.Drawing.Point(37, 99);
            this.BtnJohari.Name = "BtnJohari";
            this.BtnJohari.Size = new System.Drawing.Size(157, 57);
            this.BtnJohari.TabIndex = 1;
            this.BtnJohari.Text = "Johari";
            this.BtnJohari.UseVisualStyleBackColor = true;
            this.BtnJohari.Click += new System.EventHandler(this.button14_Click);
            // 
            // BtnManufacturingCell
            // 
            this.BtnManufacturingCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnManufacturingCell.Location = new System.Drawing.Point(36, 34);
            this.BtnManufacturingCell.Name = "BtnManufacturingCell";
            this.BtnManufacturingCell.Size = new System.Drawing.Size(158, 59);
            this.BtnManufacturingCell.TabIndex = 0;
            this.BtnManufacturingCell.Text = "Manufacturing Cell";
            this.BtnManufacturingCell.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox7.Controls.Add(this.BtnArduino);
            this.groupBox7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox7.Location = new System.Drawing.Point(610, 350);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(223, 93);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Macro Controler";
            // 
            // BtnArduino
            // 
            this.BtnArduino.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnArduino.Location = new System.Drawing.Point(38, 35);
            this.BtnArduino.Name = "BtnArduino";
            this.BtnArduino.Size = new System.Drawing.Size(156, 46);
            this.BtnArduino.TabIndex = 2;
            this.BtnArduino.Text = "Arduino";
            this.BtnArduino.UseVisualStyleBackColor = true;
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.Color.Khaki;
            this.BtnAbout.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.Location = new System.Drawing.Point(71, 429);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(164, 58);
            this.BtnAbout.TabIndex = 4;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 499);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblPW;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCheckBox;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnPictureBox2;
        private System.Windows.Forms.Button BtnGroupieApp;
        private System.Windows.Forms.Button BtnPictureBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnRandomCombo;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnRoboticCell;
        private System.Windows.Forms.Button BtnJohari;
        private System.Windows.Forms.Button BtnManufacturingCell;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button BtnArduino;
        private System.Windows.Forms.Button BtnSelfieApp;
        private System.Windows.Forms.Button BtnProgress;
        private System.Windows.Forms.Button BtnABCAnalysis;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.LinkLabel linkLblForgotPassword;
    }
}

