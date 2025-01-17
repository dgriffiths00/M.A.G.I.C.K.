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
            this.ClassDropBox = new System.Windows.Forms.ComboBox();
            this.RaceDropBox = new System.Windows.Forms.ComboBox();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.NameDropBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EquipmentCheckBox = new System.Windows.Forms.CheckedListBox();
            this.SpellCheckBox = new System.Windows.Forms.CheckedListBox();
            this.FeatCheckBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ClassDropBox
            // 
            this.ClassDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassDropBox.FormattingEnabled = true;
            this.ClassDropBox.Items.AddRange(new object[] {
            "Fighter",
            "Cleric",
            "Wizard",
            "Rogue",
            "Bard"});
            this.ClassDropBox.Location = new System.Drawing.Point(12, 168);
            this.ClassDropBox.Name = "ClassDropBox";
            this.ClassDropBox.Size = new System.Drawing.Size(194, 24);
            this.ClassDropBox.TabIndex = 0;
            // 
            // RaceDropBox
            // 
            this.RaceDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RaceDropBox.FormattingEnabled = true;
            this.RaceDropBox.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Dwarf",
            "Orc",
            "Dragon"});
            this.RaceDropBox.Location = new System.Drawing.Point(12, 250);
            this.RaceDropBox.Name = "RaceDropBox";
            this.RaceDropBox.Size = new System.Drawing.Size(194, 24);
            this.RaceDropBox.TabIndex = 1;
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
            // NameDropBox
            // 
            this.NameDropBox.Location = new System.Drawing.Point(12, 95);
            this.NameDropBox.Name = "NameDropBox";
            this.NameDropBox.Size = new System.Drawing.Size(100, 22);
            this.NameDropBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 63);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 16);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name";
            // 
            // EquipmentCheckBox
            // 
            this.EquipmentCheckBox.FormattingEnabled = true;
            this.EquipmentCheckBox.Items.AddRange(new object[] {
            "This",
            "Will",
            "Have",
            "The ",
            "equitment ",
            "you ",
            "can pick"});
            this.EquipmentCheckBox.Location = new System.Drawing.Point(15, 343);
            this.EquipmentCheckBox.Name = "EquipmentCheckBox";
            this.EquipmentCheckBox.Size = new System.Drawing.Size(231, 293);
            this.EquipmentCheckBox.TabIndex = 6;
            // 
            // SpellCheckBox
            // 
            this.SpellCheckBox.FormattingEnabled = true;
            this.SpellCheckBox.Items.AddRange(new object[] {
            "This",
            "will",
            "Have",
            "The",
            "Spells",
            "You",
            "Can",
            "Pick"});
            this.SpellCheckBox.Location = new System.Drawing.Point(277, 343);
            this.SpellCheckBox.Name = "SpellCheckBox";
            this.SpellCheckBox.Size = new System.Drawing.Size(259, 293);
            this.SpellCheckBox.TabIndex = 7;
            // 
            // FeatCheckBox
            // 
            this.FeatCheckBox.FormattingEnabled = true;
            this.FeatCheckBox.Items.AddRange(new object[] {
            "This",
            "Will",
            "Have",
            "The",
            "Feats",
            "you",
            "Can",
            "Pick"});
            this.FeatCheckBox.Location = new System.Drawing.Point(558, 547);
            this.FeatCheckBox.Name = "FeatCheckBox";
            this.FeatCheckBox.Size = new System.Drawing.Size(283, 89);
            this.FeatCheckBox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 648);
            this.Controls.Add(this.FeatCheckBox);
            this.Controls.Add(this.SpellCheckBox);
            this.Controls.Add(this.EquipmentCheckBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameDropBox);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.RaceDropBox);
            this.Controls.Add(this.ClassDropBox);
            this.Name = "MainForm";
            this.Text = "So You Want To Make A DND Character";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassDropBox;
        private System.Windows.Forms.ComboBox RaceDropBox;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.TextBox NameDropBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.CheckedListBox EquipmentCheckBox;
        private System.Windows.Forms.CheckedListBox SpellCheckBox;
        private System.Windows.Forms.CheckedListBox FeatCheckBox;
    }
}

