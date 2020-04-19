namespace Project_2
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
            this.BtnShowSelected1 = new System.Windows.Forms.Button();
            this.ButtonShowSelected2 = new System.Windows.Forms.Button();
            this.BtnRemoveLast = new System.Windows.Forms.Button();
            this.BtnRemove2ndLast = new System.Windows.Forms.Button();
            this.BtnRemoveByName = new System.Windows.Forms.Button();
            this.BtnRemoveByIndex = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.BtnShowSelected3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShowSelected1
            // 
            this.BtnShowSelected1.BackColor = System.Drawing.Color.Peru;
            this.BtnShowSelected1.Location = new System.Drawing.Point(53, 51);
            this.BtnShowSelected1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnShowSelected1.Name = "BtnShowSelected1";
            this.BtnShowSelected1.Size = new System.Drawing.Size(173, 86);
            this.BtnShowSelected1.TabIndex = 0;
            this.BtnShowSelected1.Text = "Show selected Method1";
            this.BtnShowSelected1.UseVisualStyleBackColor = false;
            this.BtnShowSelected1.Click += new System.EventHandler(this.BtnShowSelected1_Click);
            // 
            // ButtonShowSelected2
            // 
            this.ButtonShowSelected2.BackColor = System.Drawing.Color.Peru;
            this.ButtonShowSelected2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShowSelected2.Location = new System.Drawing.Point(253, 51);
            this.ButtonShowSelected2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonShowSelected2.Name = "ButtonShowSelected2";
            this.ButtonShowSelected2.Size = new System.Drawing.Size(174, 86);
            this.ButtonShowSelected2.TabIndex = 1;
            this.ButtonShowSelected2.Text = "Show Selected Method 2";
            this.ButtonShowSelected2.UseVisualStyleBackColor = false;
            this.ButtonShowSelected2.Click += new System.EventHandler(this.ButtonShowSelected2_Click);
            // 
            // BtnRemoveLast
            // 
            this.BtnRemoveLast.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnRemoveLast.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveLast.Location = new System.Drawing.Point(753, 169);
            this.BtnRemoveLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRemoveLast.Name = "BtnRemoveLast";
            this.BtnRemoveLast.Size = new System.Drawing.Size(197, 86);
            this.BtnRemoveLast.TabIndex = 2;
            this.BtnRemoveLast.Text = "Remove last item.";
            this.BtnRemoveLast.UseVisualStyleBackColor = false;
            this.BtnRemoveLast.Click += new System.EventHandler(this.BtnRemoveLast_Click);
            // 
            // BtnRemove2ndLast
            // 
            this.BtnRemove2ndLast.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnRemove2ndLast.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove2ndLast.Location = new System.Drawing.Point(753, 273);
            this.BtnRemove2ndLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRemove2ndLast.Name = "BtnRemove2ndLast";
            this.BtnRemove2ndLast.Size = new System.Drawing.Size(197, 98);
            this.BtnRemove2ndLast.TabIndex = 3;
            this.BtnRemove2ndLast.Text = "Remove 2nd last item";
            this.BtnRemove2ndLast.UseVisualStyleBackColor = false;
            this.BtnRemove2ndLast.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnRemoveByName
            // 
            this.BtnRemoveByName.BackColor = System.Drawing.Color.Bisque;
            this.BtnRemoveByName.Location = new System.Drawing.Point(281, 424);
            this.BtnRemoveByName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRemoveByName.Name = "BtnRemoveByName";
            this.BtnRemoveByName.Size = new System.Drawing.Size(274, 69);
            this.BtnRemoveByName.TabIndex = 4;
            this.BtnRemoveByName.Text = "Remove by Name";
            this.BtnRemoveByName.UseVisualStyleBackColor = false;
            this.BtnRemoveByName.Click += new System.EventHandler(this.BtnRemoveByName_Click);
            // 
            // BtnRemoveByIndex
            // 
            this.BtnRemoveByIndex.BackColor = System.Drawing.Color.Bisque;
            this.BtnRemoveByIndex.Location = new System.Drawing.Point(17, 424);
            this.BtnRemoveByIndex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRemoveByIndex.Name = "BtnRemoveByIndex";
            this.BtnRemoveByIndex.Size = new System.Drawing.Size(243, 69);
            this.BtnRemoveByIndex.TabIndex = 5;
            this.BtnRemoveByIndex.Text = "Remove by Index";
            this.BtnRemoveByIndex.UseVisualStyleBackColor = false;
            this.BtnRemoveByIndex.Click += new System.EventHandler(this.BtnRemoveByIndex_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(690, 433);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(251, 90);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(53, 239);
            this.CmbDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(267, 28);
            this.CmbDays.TabIndex = 7;
            // 
            // BtnShowSelected3
            // 
            this.BtnShowSelected3.BackColor = System.Drawing.Color.Peru;
            this.BtnShowSelected3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowSelected3.Location = new System.Drawing.Point(467, 51);
            this.BtnShowSelected3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnShowSelected3.Name = "BtnShowSelected3";
            this.BtnShowSelected3.Size = new System.Drawing.Size(180, 86);
            this.BtnShowSelected3.TabIndex = 8;
            this.BtnShowSelected3.Text = "Show Selected Method 3";
            this.BtnShowSelected3.UseVisualStyleBackColor = false;
            this.BtnShowSelected3.Click += new System.EventHandler(this.BtnShowSelected3_Click);
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.BtnShowSelected3);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BtnRemoveByIndex);
            this.Controls.Add(this.BtnRemoveByName);
            this.Controls.Add(this.BtnRemove2ndLast);
            this.Controls.Add(this.BtnRemoveLast);
            this.Controls.Add(this.ButtonShowSelected2);
            this.Controls.Add(this.BtnShowSelected1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCombo";
            this.Text = "Remove last item.";
            this.Load += new System.EventHandler(this.frmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShowSelected1;
        private System.Windows.Forms.Button ButtonShowSelected2;
        private System.Windows.Forms.Button BtnRemoveLast;
        private System.Windows.Forms.Button BtnRemove2ndLast;
        private System.Windows.Forms.Button BtnRemoveByName;
        private System.Windows.Forms.Button BtnRemoveByIndex;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button BtnShowSelected3;
    }
}