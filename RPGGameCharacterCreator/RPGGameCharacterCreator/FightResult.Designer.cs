namespace RPGGameCharacterCreator
{
    partial class FightResult
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
            this.LblWinner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblLevelUp = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblWinner
            // 
            this.LblWinner.AutoSize = true;
            this.LblWinner.Location = new System.Drawing.Point(89, 55);
            this.LblWinner.Name = "LblWinner";
            this.LblWinner.Size = new System.Drawing.Size(152, 13);
            this.LblWinner.TabIndex = 0;
            this.LblWinner.Text = "Winning Character Name Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "XP: ";
            // 
            // LblLevelUp
            // 
            this.LblLevelUp.AutoSize = true;
            this.LblLevelUp.Location = new System.Drawing.Point(214, 91);
            this.LblLevelUp.Name = "LblLevelUp";
            this.LblLevelUp.Size = new System.Drawing.Size(10, 13);
            this.LblLevelUp.TabIndex = 2;
            this.LblLevelUp.Text = " ";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(125, 145);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // FightResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 225);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblLevelUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblWinner);
            this.Name = "FightResult";
            this.Text = "FightResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWinner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblLevelUp;
        private System.Windows.Forms.Button BtnClose;
    }
}