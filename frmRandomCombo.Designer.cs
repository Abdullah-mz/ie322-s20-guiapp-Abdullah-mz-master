﻿namespace Project_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoGreater = new System.Windows.Forms.RadioButton();
            this.cmbRandom = new System.Windows.Forms.ComboBox();
            this.rdoLess = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.BtnRandomNum = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoGreater2 = new System.Windows.Forms.RadioButton();
            this.cmbRandom2 = new System.Windows.Forms.ComboBox();
            this.rdoLess2 = new System.Windows.Forms.RadioButton();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.rdoGreater);
            this.groupBox1.Controls.Add(this.cmbRandom);
            this.groupBox1.Controls.Add(this.rdoLess);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.BtnRandomNum);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz03-AAF19";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoGreater
            // 
            this.rdoGreater.AutoSize = true;
            this.rdoGreater.Location = new System.Drawing.Point(187, 154);
            this.rdoGreater.Name = "rdoGreater";
            this.rdoGreater.Size = new System.Drawing.Size(154, 25);
            this.rdoGreater.TabIndex = 2;
            this.rdoGreater.TabStop = true;
            this.rdoGreater.Text = "Greater than 500";
            this.rdoGreater.UseVisualStyleBackColor = true;
            // 
            // cmbRandom
            // 
            this.cmbRandom.FormattingEnabled = true;
            this.cmbRandom.Location = new System.Drawing.Point(19, 103);
            this.cmbRandom.Name = "cmbRandom";
            this.cmbRandom.Size = new System.Drawing.Size(118, 28);
            this.cmbRandom.TabIndex = 2;
            this.cmbRandom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rdoLess
            // 
            this.rdoLess.AutoSize = true;
            this.rdoLess.Location = new System.Drawing.Point(187, 112);
            this.rdoLess.Name = "rdoLess";
            this.rdoLess.Size = new System.Drawing.Size(134, 25);
            this.rdoLess.TabIndex = 1;
            this.rdoLess.TabStop = true;
            this.rdoLess.Text = "Less than 500";
            this.rdoLess.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(207, 194);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 39);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // BtnRandomNum
            // 
            this.BtnRandomNum.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRandomNum.Location = new System.Drawing.Point(207, 39);
            this.BtnRandomNum.Name = "BtnRandomNum";
            this.BtnRandomNum.Size = new System.Drawing.Size(114, 58);
            this.BtnRandomNum.TabIndex = 0;
            this.BtnRandomNum.Text = "Generate";
            this.BtnRandomNum.UseVisualStyleBackColor = true;
            this.BtnRandomNum.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rdoGreater2);
            this.groupBox2.Controls.Add(this.cmbRandom2);
            this.groupBox2.Controls.Add(this.rdoLess2);
            this.groupBox2.Controls.Add(this.btnReset2);
            this.groupBox2.Controls.Add(this.BtnGenerate2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(511, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 277);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quiz03-EAF19";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Count";
            // 
            // rdoGreater2
            // 
            this.rdoGreater2.AutoSize = true;
            this.rdoGreater2.Location = new System.Drawing.Point(189, 154);
            this.rdoGreater2.Name = "rdoGreater2";
            this.rdoGreater2.Size = new System.Drawing.Size(145, 25);
            this.rdoGreater2.TabIndex = 2;
            this.rdoGreater2.TabStop = true;
            this.rdoGreater2.Text = "Greater than 50";
            this.rdoGreater2.UseVisualStyleBackColor = true;
            // 
            // cmbRandom2
            // 
            this.cmbRandom2.FormattingEnabled = true;
            this.cmbRandom2.Location = new System.Drawing.Point(22, 55);
            this.cmbRandom2.Name = "cmbRandom2";
            this.cmbRandom2.Size = new System.Drawing.Size(117, 28);
            this.cmbRandom2.TabIndex = 2;
            this.cmbRandom2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // rdoLess2
            // 
            this.rdoLess2.AutoSize = true;
            this.rdoLess2.Location = new System.Drawing.Point(189, 110);
            this.rdoLess2.Name = "rdoLess2";
            this.rdoLess2.Size = new System.Drawing.Size(125, 25);
            this.rdoLess2.TabIndex = 1;
            this.rdoLess2.TabStop = true;
            this.rdoLess2.Text = "Less than 50";
            this.rdoLess2.UseVisualStyleBackColor = true;
            // 
            // btnReset2
            // 
            this.btnReset2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.Location = new System.Drawing.Point(206, 194);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(108, 39);
            this.btnReset2.TabIndex = 1;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate2.Location = new System.Drawing.Point(206, 23);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(108, 61);
            this.BtnGenerate2.TabIndex = 0;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = true;
            this.BtnGenerate2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(353, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(286, 98);
            this.button3.TabIndex = 4;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 534);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRandomCombo";
            this.Text = "frmRandomCombo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRandomNum;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbRandom;
        private System.Windows.Forms.RadioButton rdoGreater;
        private System.Windows.Forms.RadioButton rdoLess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoGreater2;
        private System.Windows.Forms.ComboBox cmbRandom2;
        private System.Windows.Forms.RadioButton rdoLess2;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}