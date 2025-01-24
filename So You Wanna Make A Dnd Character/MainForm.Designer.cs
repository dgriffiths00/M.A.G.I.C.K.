namespace M_A_G_I_C_K
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
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
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
            this.NameSLabel = new System.Windows.Forms.Label();
            this.SecondNameTxt = new System.Windows.Forms.TextBox();
            this.LevelPicker = new System.Windows.Forms.NumericUpDown();
            this.LevelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LevelPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassDropBox
            // 
            this.ClassDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassDropBox.FormattingEnabled = true;
            this.ClassDropBox.Items.AddRange(new object[] {
            "Select Option",
            "Fighter",
            "Cleric",
            "Wizard",
            "Rogue",
            "Bard"});
            this.ClassDropBox.Location = new System.Drawing.Point(9, 136);
            this.ClassDropBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClassDropBox.Name = "ClassDropBox";
            this.ClassDropBox.Size = new System.Drawing.Size(146, 21);
            this.ClassDropBox.TabIndex = 0;
            this.ClassDropBox.SelectedIndexChanged += new System.EventHandler(this.ClassDropBox_SelectedIndexChanged);
            // 
            // RaceDropBox
            // 
            this.RaceDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RaceDropBox.FormattingEnabled = true;
            this.RaceDropBox.Items.AddRange(new object[] {
            "Select Option",
            "Human",
            "Elf",
            "Dwarf",
            "Orc",
            "Dragonborn"});
            this.RaceDropBox.Location = new System.Drawing.Point(9, 203);
            this.RaceDropBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RaceDropBox.Name = "RaceDropBox";
            this.RaceDropBox.Size = new System.Drawing.Size(146, 21);
            this.RaceDropBox.TabIndex = 0;
            this.RaceDropBox.SelectedIndexChanged += new System.EventHandler(this.RaceDropBox_SelectedIndexChanged);
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(9, 188);
            this.RaceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(33, 13);
            this.RaceLabel.TabIndex = 2;
            this.RaceLabel.Text = "Race";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(9, 121);
            this.ClassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(32, 13);
            this.ClassLabel.TabIndex = 3;
            this.ClassLabel.Text = "Class";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(8, 28);
            this.FirstNameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(76, 20);
            this.FirstNameTxt.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(8, 13);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "First Name";
            // 
            // EquipmentCheckBox
            // 
            this.EquipmentCheckBox.FormattingEnabled = true;
            this.EquipmentCheckBox.Location = new System.Drawing.Point(11, 279);
            this.EquipmentCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EquipmentCheckBox.Name = "EquipmentCheckBox";
            this.EquipmentCheckBox.Size = new System.Drawing.Size(174, 229);
            this.EquipmentCheckBox.TabIndex = 6;
            // 
            // SpellCheckBox
            // 
            this.SpellCheckBox.FormattingEnabled = true;
            this.SpellCheckBox.Location = new System.Drawing.Point(208, 279);
            this.SpellCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpellCheckBox.Name = "SpellCheckBox";
            this.SpellCheckBox.Size = new System.Drawing.Size(195, 229);
            this.SpellCheckBox.TabIndex = 7;
            // 
            // FeatCheckBox
            // 
            this.FeatCheckBox.FormattingEnabled = true;
            this.FeatCheckBox.Location = new System.Drawing.Point(208, 188);
            this.FeatCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FeatCheckBox.Name = "FeatCheckBox";
            this.FeatCheckBox.Size = new System.Drawing.Size(195, 64);
            this.FeatCheckBox.TabIndex = 8;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(546, 498);
            this.runBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(121, 19);
            this.runBtn.TabIndex = 9;
            this.runBtn.Text = "Click Me when finished";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // STRtxt
            // 
            this.STRtxt.Location = new System.Drawing.Point(611, 49);
            this.STRtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.STRtxt.Name = "STRtxt";
            this.STRtxt.Size = new System.Drawing.Size(56, 55);
            this.STRtxt.TabIndex = 10;
            this.STRtxt.Text = "";
            // 
            // CONtxt
            // 
            this.CONtxt.Location = new System.Drawing.Point(611, 185);
            this.CONtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CONtxt.Name = "CONtxt";
            this.CONtxt.Size = new System.Drawing.Size(56, 55);
            this.CONtxt.TabIndex = 11;
            this.CONtxt.Text = "";
            // 
            // DEXtxt
            // 
            this.DEXtxt.Location = new System.Drawing.Point(611, 119);
            this.DEXtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DEXtxt.Name = "DEXtxt";
            this.DEXtxt.Size = new System.Drawing.Size(56, 55);
            this.DEXtxt.TabIndex = 12;
            this.DEXtxt.Text = "";
            // 
            // SMRTtxt
            // 
            this.SMRTtxt.Location = new System.Drawing.Point(611, 255);
            this.SMRTtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SMRTtxt.Name = "SMRTtxt";
            this.SMRTtxt.Size = new System.Drawing.Size(56, 55);
            this.SMRTtxt.TabIndex = 13;
            this.SMRTtxt.Text = "";
            // 
            // WIStxt
            // 
            this.WIStxt.Location = new System.Drawing.Point(611, 328);
            this.WIStxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WIStxt.Name = "WIStxt";
            this.WIStxt.Size = new System.Drawing.Size(56, 55);
            this.WIStxt.TabIndex = 14;
            this.WIStxt.Text = "";
            // 
            // CHAtxt
            // 
            this.CHAtxt.Location = new System.Drawing.Point(611, 402);
            this.CHAtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CHAtxt.Name = "CHAtxt";
            this.CHAtxt.Size = new System.Drawing.Size(56, 55);
            this.CHAtxt.TabIndex = 15;
            this.CHAtxt.Text = "";
            // 
            // STRlabel
            // 
            this.STRlabel.AutoSize = true;
            this.STRlabel.Location = new System.Drawing.Point(626, 33);
            this.STRlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.STRlabel.Name = "STRlabel";
            this.STRlabel.Size = new System.Drawing.Size(29, 13);
            this.STRlabel.TabIndex = 16;
            this.STRlabel.Text = "STR";
            // 
            // CHALabel
            // 
            this.CHALabel.AutoSize = true;
            this.CHALabel.Location = new System.Drawing.Point(626, 385);
            this.CHALabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CHALabel.Name = "CHALabel";
            this.CHALabel.Size = new System.Drawing.Size(29, 13);
            this.CHALabel.TabIndex = 17;
            this.CHALabel.Text = "CHA";
            // 
            // WISLabel
            // 
            this.WISLabel.AutoSize = true;
            this.WISLabel.Location = new System.Drawing.Point(626, 312);
            this.WISLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WISLabel.Name = "WISLabel";
            this.WISLabel.Size = new System.Drawing.Size(28, 13);
            this.WISLabel.TabIndex = 18;
            this.WISLabel.Text = "WIS";
            // 
            // SMRTlabel
            // 
            this.SMRTlabel.AutoSize = true;
            this.SMRTlabel.Location = new System.Drawing.Point(626, 240);
            this.SMRTlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SMRTlabel.Name = "SMRTlabel";
            this.SMRTlabel.Size = new System.Drawing.Size(25, 13);
            this.SMRTlabel.TabIndex = 19;
            this.SMRTlabel.Text = "INT";
            // 
            // CONLabel
            // 
            this.CONLabel.AutoSize = true;
            this.CONLabel.Location = new System.Drawing.Point(626, 173);
            this.CONLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CONLabel.Name = "CONLabel";
            this.CONLabel.Size = new System.Drawing.Size(30, 13);
            this.CONLabel.TabIndex = 20;
            this.CONLabel.Text = "CON";
            // 
            // DEXlabel
            // 
            this.DEXlabel.AutoSize = true;
            this.DEXlabel.Location = new System.Drawing.Point(626, 106);
            this.DEXlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DEXlabel.Name = "DEXlabel";
            this.DEXlabel.Size = new System.Drawing.Size(29, 13);
            this.DEXlabel.TabIndex = 21;
            this.DEXlabel.Text = "DEX";
            // 
            // NameSLabel
            // 
            this.NameSLabel.AutoSize = true;
            this.NameSLabel.Location = new System.Drawing.Point(97, 13);
            this.NameSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameSLabel.Name = "NameSLabel";
            this.NameSLabel.Size = new System.Drawing.Size(58, 13);
            this.NameSLabel.TabIndex = 23;
            this.NameSLabel.Text = "Last Name";
            // 
            // SecondNameTxt
            // 
            this.SecondNameTxt.Location = new System.Drawing.Point(97, 28);
            this.SecondNameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SecondNameTxt.Name = "SecondNameTxt";
            this.SecondNameTxt.Size = new System.Drawing.Size(99, 20);
            this.SecondNameTxt.TabIndex = 22;
            // 
            // LevelPicker
            // 
            this.LevelPicker.Location = new System.Drawing.Point(235, 50);
            this.LevelPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LevelPicker.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.LevelPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelPicker.Name = "LevelPicker";
            this.LevelPicker.ReadOnly = true;
            this.LevelPicker.Size = new System.Drawing.Size(30, 20);
            this.LevelPicker.TabIndex = 24;
            this.LevelPicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LevelPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelPicker.ValueChanged += new System.EventHandler(this.LevelPicker_ValueChanged);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(235, 32);
            this.LevelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(33, 13);
            this.LevelLabel.TabIndex = 25;
            this.LevelLabel.Text = "Level";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 526);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.LevelPicker);
            this.Controls.Add(this.NameSLabel);
            this.Controls.Add(this.SecondNameTxt);
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
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.RaceDropBox);
            this.Controls.Add(this.ClassDropBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Multifaceted Assistant Generating Iconic Characters Kit";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LevelPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassDropBox;
        private System.Windows.Forms.ComboBox RaceDropBox;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.TextBox FirstNameTxt;
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
        private System.Windows.Forms.Label NameSLabel;
        private System.Windows.Forms.TextBox SecondNameTxt;
        private System.Windows.Forms.NumericUpDown LevelPicker;
        private System.Windows.Forms.Label LevelLabel;
    }
}

