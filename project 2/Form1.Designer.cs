﻿namespace Project_2
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
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.LbpPW = new System.Windows.Forms.Label();
            this.LbpUser = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnRadio = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.btnProg = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnSelfieApp = new System.Windows.Forms.Button();
            this.btnPic2 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(161, 119);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(235, 28);
            this.TxtUser.TabIndex = 0;
            this.TxtUser.TextChanged += new System.EventHandler(this.TxtUser_TextChanged);
            // 
            // TxtPW
            // 
            this.TxtPW.Location = new System.Drawing.Point(161, 174);
            this.TxtPW.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.Size = new System.Drawing.Size(235, 28);
            this.TxtPW.TabIndex = 1;
            this.TxtPW.TextChanged += new System.EventHandler(this.TxtPW_TextChanged);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Tomato;
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExit.Location = new System.Drawing.Point(53, 422);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(397, 131);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(230, 276);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(212, 56);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.BtnAbout);
            this.groupBox1.Controls.Add(this.LbpPW);
            this.groupBox1.Controls.Add(this.LbpUser);
            this.groupBox1.Controls.Add(this.TxtPW);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Location = new System.Drawing.Point(13, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(450, 371);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login to IE322";
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAbout.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.Location = new System.Drawing.Point(8, 276);
            this.BtnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(199, 56);
            this.BtnAbout.TabIndex = 7;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = false;
            // 
            // LbpPW
            // 
            this.LbpPW.AutoSize = true;
            this.LbpPW.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbpPW.Location = new System.Drawing.Point(36, 174);
            this.LbpPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbpPW.Name = "LbpPW";
            this.LbpPW.Size = new System.Drawing.Size(81, 19);
            this.LbpPW.TabIndex = 6;
            this.LbpPW.Text = "Password";
            // 
            // LbpUser
            // 
            this.LbpUser.AutoSize = true;
            this.LbpUser.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbpUser.Location = new System.Drawing.Point(34, 123);
            this.LbpUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbpUser.Name = "LbpUser";
            this.LbpUser.Size = new System.Drawing.Size(83, 19);
            this.LbpUser.TabIndex = 5;
            this.LbpUser.Text = "Username";
            this.LbpUser.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnCombo);
            this.groupBox2.Controls.Add(this.btnRadio);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(505, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(306, 169);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Controls";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(154, 45);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "CheckBox";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCombo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCombo.Location = new System.Drawing.Point(71, 111);
            this.btnCombo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(149, 46);
            this.btnCombo.TabIndex = 8;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = false;
            this.btnCombo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRadio
            // 
            this.btnRadio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRadio.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadio.Location = new System.Drawing.Point(8, 45);
            this.btnRadio.Margin = new System.Windows.Forms.Padding(4);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(139, 46);
            this.btnRadio.TabIndex = 0;
            this.btnRadio.Text = "Radio";
            this.btnRadio.UseVisualStyleBackColor = false;
            this.btnRadio.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(1195, 37);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(303, 413);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exam Apps";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(26, 209);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(260, 71);
            this.button6.TabIndex = 2;
            this.button6.Text = "Abc Analysis";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(26, 134);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(260, 62);
            this.button5.TabIndex = 1;
            this.button5.Text = "Robotic Cell";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(26, 49);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 78);
            this.button4.TabIndex = 0;
            this.button4.Text = "Manufacturing Cell";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Location = new System.Drawing.Point(26, 304);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(260, 72);
            this.button7.TabIndex = 3;
            this.button7.Text = "Johan";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Location = new System.Drawing.Point(869, 348);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(262, 136);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Micro Controller";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Location = new System.Drawing.Point(32, 32);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(190, 79);
            this.button8.TabIndex = 0;
            this.button8.Text = "Arduino";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnProg
            // 
            this.btnProg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProg.Location = new System.Drawing.Point(21, 49);
            this.btnProg.Margin = new System.Windows.Forms.Padding(4);
            this.btnProg.Name = "btnProg";
            this.btnProg.Size = new System.Drawing.Size(128, 71);
            this.btnProg.TabIndex = 9;
            this.btnProg.Text = "Progress";
            this.btnProg.UseVisualStyleBackColor = false;
            this.btnProg.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimer.Location = new System.Drawing.Point(156, 49);
            this.btnTimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(136, 71);
            this.btnTimer.TabIndex = 10;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = false;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRandom.Location = new System.Drawing.Point(21, 159);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(128, 79);
            this.btnRandom.TabIndex = 11;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button12.Location = new System.Drawing.Point(156, 159);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(136, 79);
            this.button12.TabIndex = 12;
            this.button12.Text = "RandomCom";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnPic
            // 
            this.btnPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPic.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPic.Location = new System.Drawing.Point(8, 31);
            this.btnPic.Margin = new System.Windows.Forms.Padding(4);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(138, 56);
            this.btnPic.TabIndex = 13;
            this.btnPic.Text = "PictureBox";
            this.btnPic.UseVisualStyleBackColor = false;
            this.btnPic.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnSelfieApp
            // 
            this.btnSelfieApp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelfieApp.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelfieApp.Location = new System.Drawing.Point(160, 31);
            this.btnSelfieApp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelfieApp.Name = "btnSelfieApp";
            this.btnSelfieApp.Size = new System.Drawing.Size(141, 56);
            this.btnSelfieApp.TabIndex = 14;
            this.btnSelfieApp.Text = "SelfieApp";
            this.btnSelfieApp.UseVisualStyleBackColor = false;
            this.btnSelfieApp.Click += new System.EventHandler(this.button14_Click);
            // 
            // btnPic2
            // 
            this.btnPic2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPic2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPic2.Location = new System.Drawing.Point(10, 119);
            this.btnPic2.Margin = new System.Windows.Forms.Padding(4);
            this.btnPic2.Name = "btnPic2";
            this.btnPic2.Size = new System.Drawing.Size(128, 56);
            this.btnPic2.TabIndex = 15;
            this.btnPic2.Text = "PictureBox2";
            this.btnPic2.UseVisualStyleBackColor = false;
            this.btnPic2.Click += new System.EventHandler(this.btnPic2_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button16.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(160, 119);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(131, 56);
            this.button16.TabIndex = 16;
            this.button16.Text = "GroupieApp";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDraw.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(16, 49);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(122, 56);
            this.btnDraw.TabIndex = 17;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button18.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(176, 49);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(114, 56);
            this.button18.TabIndex = 18;
            this.button18.Text = "Talk";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox5.Controls.Add(this.btnProg);
            this.groupBox5.Controls.Add(this.btnTimer);
            this.groupBox5.Controls.Add(this.btnRandom);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Location = new System.Drawing.Point(859, 26);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(302, 280);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "More Controls";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox6.Controls.Add(this.btnPic);
            this.groupBox6.Controls.Add(this.btnSelfieApp);
            this.groupBox6.Controls.Add(this.btnPic2);
            this.groupBox6.Controls.Add(this.button16);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(515, 222);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(309, 190);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Graphical";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox7.Controls.Add(this.btnDraw);
            this.groupBox7.Controls.Add(this.button18);
            this.groupBox7.Location = new System.Drawing.Point(515, 427);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(312, 126);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Draw and Talk";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 665);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "IE322_S20";
            this.Load += new System.EventHandler(this.frmMain_Load);
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

        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbpUser;
        private System.Windows.Forms.Label LbpPW;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRadio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnProg;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnSelfieApp;
        private System.Windows.Forms.Button btnPic2;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button BtnAbout;
    }
}

