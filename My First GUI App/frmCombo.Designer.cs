namespace My_First_GUI_App
{
    partial class frmCombo
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
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.btnShowSelected1 = new System.Windows.Forms.Button();
            this.btnShowSelected2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRemoveByIndex = new System.Windows.Forms.Button();
            this.btnRemoveByName = new System.Windows.Forms.Button();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btnRemove2ndLast = new System.Windows.Forms.Button();
            this.btnShowSelected3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(89, 123);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(121, 24);
            this.CmbDays.TabIndex = 0;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.CmbDays_SelectedIndexChanged);
            // 
            // btnShowSelected1
            // 
            this.btnShowSelected1.Location = new System.Drawing.Point(12, 29);
            this.btnShowSelected1.Name = "btnShowSelected1";
            this.btnShowSelected1.Size = new System.Drawing.Size(116, 47);
            this.btnShowSelected1.TabIndex = 1;
            this.btnShowSelected1.Text = "Show Selected Method1";
            this.btnShowSelected1.UseVisualStyleBackColor = true;
            this.btnShowSelected1.Click += new System.EventHandler(this.btnShowSelected1_Click);
            // 
            // btnShowSelected2
            // 
            this.btnShowSelected2.Location = new System.Drawing.Point(134, 29);
            this.btnShowSelected2.Name = "btnShowSelected2";
            this.btnShowSelected2.Size = new System.Drawing.Size(116, 47);
            this.btnShowSelected2.TabIndex = 1;
            this.btnShowSelected2.Text = "Show Selected Method2";
            this.btnShowSelected2.UseVisualStyleBackColor = true;
            this.btnShowSelected2.Click += new System.EventHandler(this.btnShowSelected2_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(557, 339);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 39);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRemoveByIndex
            // 
            this.btnRemoveByIndex.Location = new System.Drawing.Point(42, 329);
            this.btnRemoveByIndex.Name = "btnRemoveByIndex";
            this.btnRemoveByIndex.Size = new System.Drawing.Size(116, 49);
            this.btnRemoveByIndex.TabIndex = 1;
            this.btnRemoveByIndex.Text = "Remove by Index";
            this.btnRemoveByIndex.UseVisualStyleBackColor = true;
            this.btnRemoveByIndex.Click += new System.EventHandler(this.btnRemoveByIndex_Click);
            // 
            // btnRemoveByName
            // 
            this.btnRemoveByName.Location = new System.Drawing.Point(186, 329);
            this.btnRemoveByName.Name = "btnRemoveByName";
            this.btnRemoveByName.Size = new System.Drawing.Size(116, 49);
            this.btnRemoveByName.TabIndex = 1;
            this.btnRemoveByName.Text = "Remove by Name";
            this.btnRemoveByName.UseVisualStyleBackColor = true;
            this.btnRemoveByName.Click += new System.EventHandler(this.btnRemoveByName_Click);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.Location = new System.Drawing.Point(514, 29);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(227, 65);
            this.btnRemoveLast.TabIndex = 1;
            this.btnRemoveLast.Text = "Remove last item";
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // btnRemove2ndLast
            // 
            this.btnRemove2ndLast.Location = new System.Drawing.Point(514, 123);
            this.btnRemove2ndLast.Name = "btnRemove2ndLast";
            this.btnRemove2ndLast.Size = new System.Drawing.Size(227, 65);
            this.btnRemove2ndLast.TabIndex = 1;
            this.btnRemove2ndLast.Text = "Remove 2nd last item";
            this.btnRemove2ndLast.UseVisualStyleBackColor = true;
            this.btnRemove2ndLast.Click += new System.EventHandler(this.btnRemove2ndLast_Click);
            // 
            // btnShowSelected3
            // 
            this.btnShowSelected3.Location = new System.Drawing.Point(256, 29);
            this.btnShowSelected3.Name = "btnShowSelected3";
            this.btnShowSelected3.Size = new System.Drawing.Size(116, 47);
            this.btnShowSelected3.TabIndex = 2;
            this.btnShowSelected3.Text = "Show Selected Method3";
            this.btnShowSelected3.UseVisualStyleBackColor = true;
            this.btnShowSelected3.Click += new System.EventHandler(this.btnShowSelected3_Click);
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowSelected3);
            this.Controls.Add(this.btnRemove2ndLast);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.btnRemoveByName);
            this.Controls.Add(this.btnRemoveByIndex);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShowSelected2);
            this.Controls.Add(this.btnShowSelected1);
            this.Controls.Add(this.CmbDays);
            this.Name = "frmCombo";
            this.Text = "frmCombo";
            this.Load += new System.EventHandler(this.frmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button btnShowSelected1;
        private System.Windows.Forms.Button btnShowSelected2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemoveByIndex;
        private System.Windows.Forms.Button btnRemoveByName;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnRemove2ndLast;
        private System.Windows.Forms.Button btnShowSelected3;
    }
}