﻿namespace RPGGameCharacterCreator
{
    partial class CreateCharacter
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
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAllocation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtVitality = new System.Windows.Forms.TextBox();
            this.TxtDefense = new System.Windows.Forms.TextBox();
            this.TxtStrength = new System.Windows.Forms.TextBox();
            this.BtnAddVIT = new System.Windows.Forms.Button();
            this.BtnAddSTR = new System.Windows.Forms.Button();
            this.BtnAddDEF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblRandomAlottment = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(93, 222);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 2;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.Location = new System.Drawing.Point(12, 222);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(75, 23);
            this.BtnRandom.TabIndex = 3;
            this.BtnRandom.Text = "Randomize";
            this.BtnRandom.UseVisualStyleBackColor = true;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Allocation points: ";
            // 
            // LblAllocation
            // 
            this.LblAllocation.AutoSize = true;
            this.LblAllocation.Location = new System.Drawing.Point(108, 9);
            this.LblAllocation.Name = "LblAllocation";
            this.LblAllocation.Size = new System.Drawing.Size(19, 13);
            this.LblAllocation.TabIndex = 5;
            this.LblAllocation.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vitality: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Defense: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Strength: ";
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(108, 44);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(100, 20);
            this.txtCharacterName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Character Name: ";
            // 
            // TxtVitality
            // 
            this.TxtVitality.Enabled = false;
            this.TxtVitality.Location = new System.Drawing.Point(71, 84);
            this.TxtVitality.Name = "TxtVitality";
            this.TxtVitality.ReadOnly = true;
            this.TxtVitality.Size = new System.Drawing.Size(29, 20);
            this.TxtVitality.TabIndex = 11;
            // 
            // TxtDefense
            // 
            this.TxtDefense.Enabled = false;
            this.TxtDefense.Location = new System.Drawing.Point(71, 167);
            this.TxtDefense.Name = "TxtDefense";
            this.TxtDefense.ReadOnly = true;
            this.TxtDefense.Size = new System.Drawing.Size(31, 20);
            this.TxtDefense.TabIndex = 12;
            // 
            // TxtStrength
            // 
            this.TxtStrength.Enabled = false;
            this.TxtStrength.Location = new System.Drawing.Point(71, 126);
            this.TxtStrength.Name = "TxtStrength";
            this.TxtStrength.ReadOnly = true;
            this.TxtStrength.Size = new System.Drawing.Size(31, 20);
            this.TxtStrength.TabIndex = 13;
            // 
            // BtnAddVIT
            // 
            this.BtnAddVIT.Location = new System.Drawing.Point(108, 82);
            this.BtnAddVIT.Name = "BtnAddVIT";
            this.BtnAddVIT.Size = new System.Drawing.Size(20, 23);
            this.BtnAddVIT.TabIndex = 14;
            this.BtnAddVIT.Text = "+";
            this.BtnAddVIT.UseVisualStyleBackColor = true;
            this.BtnAddVIT.Click += new System.EventHandler(this.BtnAddVIT_Click);
            // 
            // BtnAddSTR
            // 
            this.BtnAddSTR.Location = new System.Drawing.Point(108, 123);
            this.BtnAddSTR.Name = "BtnAddSTR";
            this.BtnAddSTR.Size = new System.Drawing.Size(20, 23);
            this.BtnAddSTR.TabIndex = 15;
            this.BtnAddSTR.Text = "+";
            this.BtnAddSTR.UseVisualStyleBackColor = true;
            this.BtnAddSTR.Click += new System.EventHandler(this.BtnAddSTR_Click);
            // 
            // BtnAddDEF
            // 
            this.BtnAddDEF.Location = new System.Drawing.Point(108, 164);
            this.BtnAddDEF.Name = "BtnAddDEF";
            this.BtnAddDEF.Size = new System.Drawing.Size(20, 23);
            this.BtnAddDEF.TabIndex = 16;
            this.BtnAddDEF.Text = "+";
            this.BtnAddDEF.UseVisualStyleBackColor = true;
            this.BtnAddDEF.Click += new System.EventHandler(this.BtnAddDEF_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Randomize Stats:";
            // 
            // LblRandomAlottment
            // 
            this.LblRandomAlottment.AutoSize = true;
            this.LblRandomAlottment.Location = new System.Drawing.Point(222, 9);
            this.LblRandomAlottment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRandomAlottment.Name = "LblRandomAlottment";
            this.LblRandomAlottment.Size = new System.Drawing.Size(13, 13);
            this.LblRandomAlottment.TabIndex = 19;
            this.LblRandomAlottment.Text = "5";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(174, 164);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(74, 45);
            this.BtnReset.TabIndex = 20;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // CreateCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 257);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.LblRandomAlottment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAddDEF);
            this.Controls.Add(this.BtnAddSTR);
            this.Controls.Add(this.BtnAddVIT);
            this.Controls.Add(this.TxtStrength);
            this.Controls.Add(this.TxtDefense);
            this.Controls.Add(this.TxtVitality);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblAllocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRandom);
            this.Controls.Add(this.BtnCreate);
            this.Name = "CreateCharacter";
            this.Text = "Create a Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAllocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtVitality;
        private System.Windows.Forms.TextBox TxtDefense;
        private System.Windows.Forms.TextBox TxtStrength;
        private System.Windows.Forms.Button BtnAddVIT;
        private System.Windows.Forms.Button BtnAddSTR;
        private System.Windows.Forms.Button BtnAddDEF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblRandomAlottment;
        private System.Windows.Forms.Button BtnReset;
    }
}