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
            this.runBtn = new System.Windows.Forms.Button();
            this.STRtxt = new System.Windows.Forms.RichTextBox();
            this.CONtxt = new System.Windows.Forms.RichTextBox();
            this.DEXtxt = new System.Windows.Forms.RichTextBox();
            this.SMRTtxt = new System.Windows.Forms.RichTextBox();
            this.WIStxt = new System.Windows.Forms.RichTextBox();
            this.CHAtxt = new System.Windows.Forms.RichTextBox();
            this.STRlabel = new System.Windows.Forms.Label();
            this.CHALabel = new System.Windows.Forms.Label();
            this.WISLabel = new System.Windows.Forms.Label();
            this.SMRTlabel = new System.Windows.Forms.Label();
            this.CONLabel = new System.Windows.Forms.Label();
            this.DEXlabel = new System.Windows.Forms.Label();
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
            this.FeatCheckBox.Location = new System.Drawing.Point(253, 231);
            this.FeatCheckBox.Name = "FeatCheckBox";
            this.FeatCheckBox.Size = new System.Drawing.Size(283, 89);
            this.FeatCheckBox.TabIndex = 8;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(728, 613);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(161, 23);
            this.runBtn.TabIndex = 9;
            this.runBtn.Text = "Click Me when finished";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // STRtxt
            // 
            this.STRtxt.Location = new System.Drawing.Point(815, 60);
            this.STRtxt.Name = "STRtxt";
            this.STRtxt.Size = new System.Drawing.Size(74, 67);
            this.STRtxt.TabIndex = 10;
            this.STRtxt.Text = "";
            // 
            // CONtxt
            // 
            this.CONtxt.Location = new System.Drawing.Point(815, 228);
            this.CONtxt.Name = "CONtxt";
            this.CONtxt.Size = new System.Drawing.Size(74, 67);
            this.CONtxt.TabIndex = 11;
            this.CONtxt.Text = "";
            // 
            // DEXtxt
            // 
            this.DEXtxt.Location = new System.Drawing.Point(815, 146);
            this.DEXtxt.Name = "DEXtxt";
            this.DEXtxt.Size = new System.Drawing.Size(74, 67);
            this.DEXtxt.TabIndex = 12;
            this.DEXtxt.Text = "";
            // 
            // SMRTtxt
            // 
            this.SMRTtxt.Location = new System.Drawing.Point(815, 314);
            this.SMRTtxt.Name = "SMRTtxt";
            this.SMRTtxt.Size = new System.Drawing.Size(74, 67);
            this.SMRTtxt.TabIndex = 13;
            this.SMRTtxt.Text = "";
            // 
            // WIStxt
            // 
            this.WIStxt.Location = new System.Drawing.Point(815, 404);
            this.WIStxt.Name = "WIStxt";
            this.WIStxt.Size = new System.Drawing.Size(74, 67);
            this.WIStxt.TabIndex = 14;
            this.WIStxt.Text = "";
            // 
            // CHAtxt
            // 
            this.CHAtxt.Location = new System.Drawing.Point(815, 495);
            this.CHAtxt.Name = "CHAtxt";
            this.CHAtxt.Size = new System.Drawing.Size(74, 67);
            this.CHAtxt.TabIndex = 15;
            this.CHAtxt.Text = "";
            // 
            // STRlabel
            // 
            this.STRlabel.AutoSize = true;
            this.STRlabel.Location = new System.Drawing.Point(834, 41);
            this.STRlabel.Name = "STRlabel";
            this.STRlabel.Size = new System.Drawing.Size(35, 16);
            this.STRlabel.TabIndex = 16;
            this.STRlabel.Text = "STR";
            // 
            // CHALabel
            // 
            this.CHALabel.AutoSize = true;
            this.CHALabel.Location = new System.Drawing.Point(834, 474);
            this.CHALabel.Name = "CHALabel";
            this.CHALabel.Size = new System.Drawing.Size(35, 16);
            this.CHALabel.TabIndex = 17;
            this.CHALabel.Text = "CHA";
            // 
            // WISLabel
            // 
            this.WISLabel.AutoSize = true;
            this.WISLabel.Location = new System.Drawing.Point(834, 384);
            this.WISLabel.Name = "WISLabel";
            this.WISLabel.Size = new System.Drawing.Size(32, 16);
            this.WISLabel.TabIndex = 18;
            this.WISLabel.Text = "WIS";
            // 
            // SMRTlabel
            // 
            this.SMRTlabel.AutoSize = true;
            this.SMRTlabel.Location = new System.Drawing.Point(834, 295);
            this.SMRTlabel.Name = "SMRTlabel";
            this.SMRTlabel.Size = new System.Drawing.Size(29, 16);
            this.SMRTlabel.TabIndex = 19;
            this.SMRTlabel.Text = "INT";
            // 
            // CONLabel
            // 
            this.CONLabel.AutoSize = true;
            this.CONLabel.Location = new System.Drawing.Point(834, 213);
            this.CONLabel.Name = "CONLabel";
            this.CONLabel.Size = new System.Drawing.Size(36, 16);
            this.CONLabel.TabIndex = 20;
            this.CONLabel.Text = "CON";
            // 
            // DEXlabel
            // 
            this.DEXlabel.AutoSize = true;
            this.DEXlabel.Location = new System.Drawing.Point(834, 130);
            this.DEXlabel.Name = "DEXlabel";
            this.DEXlabel.Size = new System.Drawing.Size(34, 16);
            this.DEXlabel.TabIndex = 21;
            this.DEXlabel.Text = "DEX";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 648);
            this.Controls.Add(this.DEXlabel);
            this.Controls.Add(this.CONLabel);
            this.Controls.Add(this.SMRTlabel);
            this.Controls.Add(this.WISLabel);
            this.Controls.Add(this.CHALabel);
            this.Controls.Add(this.STRlabel);
            this.Controls.Add(this.CHAtxt);
            this.Controls.Add(this.WIStxt);
            this.Controls.Add(this.SMRTtxt);
            this.Controls.Add(this.DEXtxt);
            this.Controls.Add(this.CONtxt);
            this.Controls.Add(this.STRtxt);
            this.Controls.Add(this.runBtn);
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
            this.Text = "Multifaceted Assistant Generating Iconic Characters Kit";
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
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.RichTextBox STRtxt;
        private System.Windows.Forms.RichTextBox CONtxt;
        private System.Windows.Forms.RichTextBox DEXtxt;
        private System.Windows.Forms.RichTextBox SMRTtxt;
        private System.Windows.Forms.RichTextBox WIStxt;
        private System.Windows.Forms.RichTextBox CHAtxt;
        private System.Windows.Forms.Label STRlabel;
        private System.Windows.Forms.Label CHALabel;
        private System.Windows.Forms.Label WISLabel;
        private System.Windows.Forms.Label SMRTlabel;
        private System.Windows.Forms.Label CONLabel;
        private System.Windows.Forms.Label DEXlabel;
    }
}

