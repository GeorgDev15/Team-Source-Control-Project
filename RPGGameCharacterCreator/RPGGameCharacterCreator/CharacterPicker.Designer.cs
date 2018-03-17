namespace RPGGameCharacterCreator
{
    partial class CharacterPicker
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
            this.lstCharacters = new System.Windows.Forms.ListBox();
            this.btnSelectCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCharacters
            // 
            this.lstCharacters.FormattingEnabled = true;
            this.lstCharacters.Location = new System.Drawing.Point(12, 10);
            this.lstCharacters.Name = "lstCharacters";
            this.lstCharacters.Size = new System.Drawing.Size(247, 108);
            this.lstCharacters.TabIndex = 0;
            // 
            // btnSelectCharacter
            // 
            this.btnSelectCharacter.Location = new System.Drawing.Point(58, 137);
            this.btnSelectCharacter.Name = "btnSelectCharacter";
            this.btnSelectCharacter.Size = new System.Drawing.Size(139, 23);
            this.btnSelectCharacter.TabIndex = 1;
            this.btnSelectCharacter.Text = "Select Character";
            this.btnSelectCharacter.UseVisualStyleBackColor = true;
            // 
            // CharacterPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 184);
            this.Controls.Add(this.btnSelectCharacter);
            this.Controls.Add(this.lstCharacters);
            this.Name = "CharacterPicker";
            this.Text = "CharacterPicker";
            this.Load += new System.EventHandler(this.CharacterPicker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCharacters;
        private System.Windows.Forms.Button btnSelectCharacter;
    }
}