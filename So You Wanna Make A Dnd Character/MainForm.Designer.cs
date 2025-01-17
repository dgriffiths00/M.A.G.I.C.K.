namespace So_You_Wanna_Make_A_Dnd_Character
{
    partial class MainForm
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
            this.ClassPickerBox = new System.Windows.Forms.ComboBox();
            this.RacePickerBox = new System.Windows.Forms.ComboBox();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClassPickerBox
            // 
            this.ClassPickerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassPickerBox.FormattingEnabled = true;
            this.ClassPickerBox.Items.AddRange(new object[] {
            "Fighter",
            "Cleric",
            "Wizard",
            "Rogue",
            "Bard"});
            this.ClassPickerBox.Location = new System.Drawing.Point(12, 168);
            this.ClassPickerBox.Name = "ClassPickerBox";
            this.ClassPickerBox.Size = new System.Drawing.Size(194, 24);
            this.ClassPickerBox.TabIndex = 0;
            // 
            // RacePickerBox
            // 
            this.RacePickerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RacePickerBox.FormattingEnabled = true;
            this.RacePickerBox.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Dwarf",
            "Orc",
            "Dragon"});
            this.RacePickerBox.Location = new System.Drawing.Point(12, 250);
            this.RacePickerBox.Name = "RacePickerBox";
            this.RacePickerBox.Size = new System.Drawing.Size(194, 24);
            this.RacePickerBox.TabIndex = 1;
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(12, 231);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(40, 16);
            this.RaceLabel.TabIndex = 2;
            this.RaceLabel.Text = "Race";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(12, 149);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(41, 16);
            this.ClassLabel.TabIndex = 3;
            this.ClassLabel.Text = "Class";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 648);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.RacePickerBox);
            this.Controls.Add(this.ClassPickerBox);
            this.Name = "MainForm";
            this.Text = "So You Want To Make A DND Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassPickerBox;
        private System.Windows.Forms.ComboBox RacePickerBox;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label ClassLabel;
    }
}

