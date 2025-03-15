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
            this.STRCheck = new System.Windows.Forms.CheckedListBox();
            this.DEXCheck = new System.Windows.Forms.CheckedListBox();
            this.CONCheck = new System.Windows.Forms.CheckedListBox();
            this.SMRTCheck = new System.Windows.Forms.CheckedListBox();
            this.WISCheck = new System.Windows.Forms.CheckedListBox();
            this.CHACheck = new System.Windows.Forms.CheckedListBox();
            this.StatRoll = new System.Windows.Forms.Button();
            this.STRstats = new System.Windows.Forms.NumericUpDown();
            this.DEXStats = new System.Windows.Forms.NumericUpDown();
            this.CONStats = new System.Windows.Forms.NumericUpDown();
            this.SMRTStats = new System.Windows.Forms.NumericUpDown();
            this.WISstats = new System.Windows.Forms.NumericUpDown();
            this.CHAStats = new System.Windows.Forms.NumericUpDown();
            this.STRbonusTxt = new System.Windows.Forms.RichTextBox();
            this.DEXbonusTxt = new System.Windows.Forms.RichTextBox();
            this.CONbonusTxt = new System.Windows.Forms.RichTextBox();
            this.SMRTbonusTxt = new System.Windows.Forms.RichTextBox();
            this.WISbonusTxt = new System.Windows.Forms.RichTextBox();
            this.CHAbonusTxt = new System.Windows.Forms.RichTextBox();
            this.backgroundTb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.spellbookLbl = new System.Windows.Forms.Label();
            this.equipLbl = new System.Windows.Forms.Label();
            this.classFeaturesLbl = new System.Windows.Forms.Label();
            this.statsLbl = new System.Windows.Forms.Label();
            this.diceZoneLbl = new System.Windows.Forms.Label();
            this.d4btn = new System.Windows.Forms.Button();
            this.d6btn = new System.Windows.Forms.Button();
            this.d8btn = new System.Windows.Forms.Button();
            this.d10btn = new System.Windows.Forms.Button();
            this.d12btn = new System.Windows.Forms.Button();
            this.d20btn = new System.Windows.Forms.Button();
            this.dPercentBtn = new System.Windows.Forms.Button();
            this.rollResultLbl = new System.Windows.Forms.Label();
            this.rollResultTb = new System.Windows.Forms.TextBox();
            this.oWoBtn = new System.Windows.Forms.Button();
            this.progBarLbl = new System.Windows.Forms.Label();
            this.playerIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LevelPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STRstats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEXStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMRTStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WISstats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHAStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).BeginInit();
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
            this.ClassDropBox.Location = new System.Drawing.Point(12, 79);
            this.ClassDropBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassDropBox.Name = "ClassDropBox";
            this.ClassDropBox.Size = new System.Drawing.Size(128, 24);
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
            this.RaceDropBox.Location = new System.Drawing.Point(11, 134);
            this.RaceDropBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RaceDropBox.Name = "RaceDropBox";
            this.RaceDropBox.Size = new System.Drawing.Size(129, 24);
            this.RaceDropBox.TabIndex = 0;
            this.RaceDropBox.SelectedIndexChanged += new System.EventHandler(this.RaceDropBox_SelectedIndexChanged);
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(11, 115);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(40, 16);
            this.RaceLabel.TabIndex = 2;
            this.RaceLabel.Text = "Race";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(12, 61);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(41, 16);
            this.ClassLabel.TabIndex = 3;
            this.ClassLabel.Text = "Class";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(11, 34);
            this.FirstNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(129, 22);
            this.FirstNameTxt.TabIndex = 4;
            this.FirstNameTxt.Text = "Unknown";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(11, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(72, 16);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "First Name";
            // 
            // EquipmentCheckBox
            // 
            this.EquipmentCheckBox.FormattingEnabled = true;
            this.EquipmentCheckBox.Location = new System.Drawing.Point(149, 239);
            this.EquipmentCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EquipmentCheckBox.Name = "EquipmentCheckBox";
            this.EquipmentCheckBox.Size = new System.Drawing.Size(165, 72);
            this.EquipmentCheckBox.TabIndex = 6;
            this.EquipmentCheckBox.SelectedIndexChanged += new System.EventHandler(this.EquipmentCheckBox_SelectedIndexChanged);
            // 
            // SpellCheckBox
            // 
            this.SpellCheckBox.FormattingEnabled = true;
            this.SpellCheckBox.Location = new System.Drawing.Point(11, 330);
            this.SpellCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellCheckBox.Name = "SpellCheckBox";
            this.SpellCheckBox.Size = new System.Drawing.Size(128, 208);
            this.SpellCheckBox.TabIndex = 7;
            this.SpellCheckBox.SelectedIndexChanged += new System.EventHandler(this.SpellCheckBox_SelectedIndexChanged);
            // 
            // FeatCheckBox
            // 
            this.FeatCheckBox.FormattingEnabled = true;
            this.FeatCheckBox.Location = new System.Drawing.Point(149, 330);
            this.FeatCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeatCheckBox.Name = "FeatCheckBox";
            this.FeatCheckBox.Size = new System.Drawing.Size(165, 208);
            this.FeatCheckBox.TabIndex = 8;
            this.FeatCheckBox.SelectedIndexChanged += new System.EventHandler(this.FeatCheckBox_SelectedIndexChanged);
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(451, 425);
            this.runBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(127, 23);
            this.runBtn.TabIndex = 9;
            this.runBtn.Text = "Print Character";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // STRlabel
            // 
            this.STRlabel.AutoSize = true;
            this.STRlabel.Location = new System.Drawing.Point(320, 61);
            this.STRlabel.Name = "STRlabel";
            this.STRlabel.Size = new System.Drawing.Size(95, 16);
            this.STRlabel.TabIndex = 16;
            this.STRlabel.Text = "Strength (STR)";
            // 
            // CHALabel
            // 
            this.CHALabel.AutoSize = true;
            this.CHALabel.Location = new System.Drawing.Point(317, 362);
            this.CHALabel.Name = "CHALabel";
            this.CHALabel.Size = new System.Drawing.Size(103, 16);
            this.CHALabel.TabIndex = 17;
            this.CHALabel.Text = "Charisma (CHA)";
            // 
            // WISLabel
            // 
            this.WISLabel.AutoSize = true;
            this.WISLabel.Location = new System.Drawing.Point(320, 302);
            this.WISLabel.Name = "WISLabel";
            this.WISLabel.Size = new System.Drawing.Size(93, 16);
            this.WISLabel.TabIndex = 18;
            this.WISLabel.Text = "Wisdom (WIS)";
            // 
            // SMRTlabel
            // 
            this.SMRTlabel.AutoSize = true;
            this.SMRTlabel.Location = new System.Drawing.Point(317, 240);
            this.SMRTlabel.Name = "SMRTlabel";
            this.SMRTlabel.Size = new System.Drawing.Size(113, 16);
            this.SMRTlabel.TabIndex = 19;
            this.SMRTlabel.Text = "Intellegence (INT)";
            // 
            // CONLabel
            // 
            this.CONLabel.AutoSize = true;
            this.CONLabel.Location = new System.Drawing.Point(317, 180);
            this.CONLabel.Name = "CONLabel";
            this.CONLabel.Size = new System.Drawing.Size(115, 16);
            this.CONLabel.TabIndex = 20;
            this.CONLabel.Text = "Constitution (CON)";
            // 
            // DEXlabel
            // 
            this.DEXlabel.AutoSize = true;
            this.DEXlabel.Location = new System.Drawing.Point(320, 119);
            this.DEXlabel.Name = "DEXlabel";
            this.DEXlabel.Size = new System.Drawing.Size(97, 16);
            this.DEXlabel.TabIndex = 21;
            this.DEXlabel.Text = "Dexterity (DEX)";
            // 
            // NameSLabel
            // 
            this.NameSLabel.AutoSize = true;
            this.NameSLabel.Location = new System.Drawing.Point(146, 16);
            this.NameSLabel.Name = "NameSLabel";
            this.NameSLabel.Size = new System.Drawing.Size(72, 16);
            this.NameSLabel.TabIndex = 23;
            this.NameSLabel.Text = "Last Name";
            // 
            // SecondNameTxt
            // 
            this.SecondNameTxt.Location = new System.Drawing.Point(146, 34);
            this.SecondNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SecondNameTxt.Name = "SecondNameTxt";
            this.SecondNameTxt.Size = new System.Drawing.Size(129, 22);
            this.SecondNameTxt.TabIndex = 22;
            this.SecondNameTxt.Text = "Adventurer";
            // 
            // LevelPicker
            // 
            this.LevelPicker.Location = new System.Drawing.Point(274, 34);
            this.LevelPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.LevelPicker.Size = new System.Drawing.Size(40, 22);
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
            this.LevelLabel.Location = new System.Drawing.Point(274, 16);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(40, 16);
            this.LevelLabel.TabIndex = 25;
            this.LevelLabel.Text = "Level";
            // 
            // STRCheck
            // 
            this.STRCheck.FormattingEnabled = true;
            this.STRCheck.Location = new System.Drawing.Point(432, 80);
            this.STRCheck.Name = "STRCheck";
            this.STRCheck.Size = new System.Drawing.Size(146, 38);
            this.STRCheck.TabIndex = 26;
            // 
            // DEXCheck
            // 
            this.DEXCheck.FormattingEnabled = true;
            this.DEXCheck.Location = new System.Drawing.Point(432, 139);
            this.DEXCheck.Name = "DEXCheck";
            this.DEXCheck.Size = new System.Drawing.Size(146, 38);
            this.DEXCheck.TabIndex = 27;
            // 
            // CONCheck
            // 
            this.CONCheck.FormattingEnabled = true;
            this.CONCheck.Location = new System.Drawing.Point(432, 199);
            this.CONCheck.Name = "CONCheck";
            this.CONCheck.Size = new System.Drawing.Size(146, 38);
            this.CONCheck.TabIndex = 28;
            // 
            // SMRTCheck
            // 
            this.SMRTCheck.FormattingEnabled = true;
            this.SMRTCheck.Location = new System.Drawing.Point(432, 261);
            this.SMRTCheck.Name = "SMRTCheck";
            this.SMRTCheck.Size = new System.Drawing.Size(146, 38);
            this.SMRTCheck.TabIndex = 29;
            // 
            // WISCheck
            // 
            this.WISCheck.FormattingEnabled = true;
            this.WISCheck.Location = new System.Drawing.Point(432, 321);
            this.WISCheck.Name = "WISCheck";
            this.WISCheck.Size = new System.Drawing.Size(146, 38);
            this.WISCheck.TabIndex = 30;
            // 
            // CHACheck
            // 
            this.CHACheck.FormattingEnabled = true;
            this.CHACheck.Location = new System.Drawing.Point(432, 381);
            this.CHACheck.Name = "CHACheck";
            this.CHACheck.Size = new System.Drawing.Size(146, 38);
            this.CHACheck.TabIndex = 31;
            // 
            // StatRoll
            // 
            this.StatRoll.Location = new System.Drawing.Point(320, 425);
            this.StatRoll.Name = "StatRoll";
            this.StatRoll.Size = new System.Drawing.Size(130, 23);
            this.StatRoll.TabIndex = 32;
            this.StatRoll.Text = "Stat Randomizer";
            this.StatRoll.UseVisualStyleBackColor = true;
            this.StatRoll.Click += new System.EventHandler(this.StatRoll_Click);
            // 
            // STRstats
            // 
            this.STRstats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STRstats.Location = new System.Drawing.Point(320, 80);
            this.STRstats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.STRstats.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.STRstats.Name = "STRstats";
            this.STRstats.ReadOnly = true;
            this.STRstats.Size = new System.Drawing.Size(62, 36);
            this.STRstats.TabIndex = 35;
            this.STRstats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.STRstats.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.STRstats.ValueChanged += new System.EventHandler(this.STRstats_ValueChanged);
            // 
            // DEXStats
            // 
            this.DEXStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEXStats.Location = new System.Drawing.Point(320, 141);
            this.DEXStats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.DEXStats.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.DEXStats.Name = "DEXStats";
            this.DEXStats.ReadOnly = true;
            this.DEXStats.Size = new System.Drawing.Size(62, 36);
            this.DEXStats.TabIndex = 36;
            this.DEXStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DEXStats.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.DEXStats.ValueChanged += new System.EventHandler(this.DEXStats_ValueChanged);
            // 
            // CONStats
            // 
            this.CONStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONStats.Location = new System.Drawing.Point(320, 199);
            this.CONStats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CONStats.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.CONStats.Name = "CONStats";
            this.CONStats.ReadOnly = true;
            this.CONStats.Size = new System.Drawing.Size(62, 36);
            this.CONStats.TabIndex = 37;
            this.CONStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CONStats.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.CONStats.ValueChanged += new System.EventHandler(this.CONStats_ValueChanged);
            // 
            // SMRTStats
            // 
            this.SMRTStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMRTStats.Location = new System.Drawing.Point(320, 261);
            this.SMRTStats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SMRTStats.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.SMRTStats.Name = "SMRTStats";
            this.SMRTStats.ReadOnly = true;
            this.SMRTStats.Size = new System.Drawing.Size(62, 36);
            this.SMRTStats.TabIndex = 38;
            this.SMRTStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SMRTStats.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.SMRTStats.ValueChanged += new System.EventHandler(this.SMRTStats_ValueChanged);
            // 
            // WISstats
            // 
            this.WISstats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WISstats.Location = new System.Drawing.Point(320, 321);
            this.WISstats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.WISstats.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.WISstats.Name = "WISstats";
            this.WISstats.ReadOnly = true;
            this.WISstats.Size = new System.Drawing.Size(62, 36);
            this.WISstats.TabIndex = 39;
            this.WISstats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WISstats.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.WISstats.ValueChanged += new System.EventHandler(this.WISstats_ValueChanged);
            // 
            // CHAStats
            // 
            this.CHAStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHAStats.Location = new System.Drawing.Point(320, 381);
            this.CHAStats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CHAStats.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.CHAStats.Name = "CHAStats";
            this.CHAStats.ReadOnly = true;
            this.CHAStats.Size = new System.Drawing.Size(62, 36);
            this.CHAStats.TabIndex = 40;
            this.CHAStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHAStats.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.CHAStats.ValueChanged += new System.EventHandler(this.CHAStats_ValueChanged);
            // 
            // STRbonusTxt
            // 
            this.STRbonusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STRbonusTxt.Location = new System.Drawing.Point(388, 80);
            this.STRbonusTxt.Name = "STRbonusTxt";
            this.STRbonusTxt.ReadOnly = true;
            this.STRbonusTxt.Size = new System.Drawing.Size(38, 38);
            this.STRbonusTxt.TabIndex = 41;
            this.STRbonusTxt.Text = "-2";
            // 
            // DEXbonusTxt
            // 
            this.DEXbonusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEXbonusTxt.Location = new System.Drawing.Point(388, 139);
            this.DEXbonusTxt.Name = "DEXbonusTxt";
            this.DEXbonusTxt.ReadOnly = true;
            this.DEXbonusTxt.Size = new System.Drawing.Size(38, 38);
            this.DEXbonusTxt.TabIndex = 42;
            this.DEXbonusTxt.Text = "-2";
            // 
            // CONbonusTxt
            // 
            this.CONbonusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONbonusTxt.Location = new System.Drawing.Point(388, 199);
            this.CONbonusTxt.Name = "CONbonusTxt";
            this.CONbonusTxt.ReadOnly = true;
            this.CONbonusTxt.Size = new System.Drawing.Size(38, 38);
            this.CONbonusTxt.TabIndex = 43;
            this.CONbonusTxt.Text = "-2";
            // 
            // SMRTbonusTxt
            // 
            this.SMRTbonusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMRTbonusTxt.Location = new System.Drawing.Point(388, 261);
            this.SMRTbonusTxt.Name = "SMRTbonusTxt";
            this.SMRTbonusTxt.ReadOnly = true;
            this.SMRTbonusTxt.Size = new System.Drawing.Size(38, 38);
            this.SMRTbonusTxt.TabIndex = 44;
            this.SMRTbonusTxt.Text = "-2";
            // 
            // WISbonusTxt
            // 
            this.WISbonusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WISbonusTxt.Location = new System.Drawing.Point(388, 321);
            this.WISbonusTxt.Name = "WISbonusTxt";
            this.WISbonusTxt.ReadOnly = true;
            this.WISbonusTxt.Size = new System.Drawing.Size(38, 38);
            this.WISbonusTxt.TabIndex = 45;
            this.WISbonusTxt.Text = "-2";
            // 
            // CHAbonusTxt
            // 
            this.CHAbonusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHAbonusTxt.Location = new System.Drawing.Point(388, 381);
            this.CHAbonusTxt.Name = "CHAbonusTxt";
            this.CHAbonusTxt.ReadOnly = true;
            this.CHAbonusTxt.Size = new System.Drawing.Size(38, 38);
            this.CHAbonusTxt.TabIndex = 46;
            this.CHAbonusTxt.Text = "-2";
            // 
            // backgroundTb
            // 
            this.backgroundTb.AutoSize = true;
            this.backgroundTb.Location = new System.Drawing.Point(146, 61);
            this.backgroundTb.Name = "backgroundTb";
            this.backgroundTb.Size = new System.Drawing.Size(80, 16);
            this.backgroundTb.TabIndex = 48;
            this.backgroundTb.Text = "Background";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 135);
            this.textBox1.TabIndex = 49;
            // 
            // spellbookLbl
            // 
            this.spellbookLbl.AutoSize = true;
            this.spellbookLbl.Location = new System.Drawing.Point(11, 311);
            this.spellbookLbl.Name = "spellbookLbl";
            this.spellbookLbl.Size = new System.Drawing.Size(69, 16);
            this.spellbookLbl.TabIndex = 50;
            this.spellbookLbl.Text = "Spellbook";
            // 
            // equipLbl
            // 
            this.equipLbl.AutoSize = true;
            this.equipLbl.Location = new System.Drawing.Point(147, 218);
            this.equipLbl.Name = "equipLbl";
            this.equipLbl.Size = new System.Drawing.Size(71, 16);
            this.equipLbl.TabIndex = 51;
            this.equipLbl.Text = "Equipment";
            // 
            // classFeaturesLbl
            // 
            this.classFeaturesLbl.AutoSize = true;
            this.classFeaturesLbl.Location = new System.Drawing.Point(147, 311);
            this.classFeaturesLbl.Name = "classFeaturesLbl";
            this.classFeaturesLbl.Size = new System.Drawing.Size(97, 16);
            this.classFeaturesLbl.TabIndex = 52;
            this.classFeaturesLbl.Text = "Class Features";
            // 
            // statsLbl
            // 
            this.statsLbl.AutoSize = true;
            this.statsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsLbl.Location = new System.Drawing.Point(332, 27);
            this.statsLbl.Name = "statsLbl";
            this.statsLbl.Size = new System.Drawing.Size(233, 29);
            this.statsLbl.TabIndex = 53;
            this.statsLbl.Text = "Character Statistics";
            // 
            // diceZoneLbl
            // 
            this.diceZoneLbl.AutoSize = true;
            this.diceZoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceZoneLbl.Location = new System.Drawing.Point(12, 549);
            this.diceZoneLbl.Name = "diceZoneLbl";
            this.diceZoneLbl.Size = new System.Drawing.Size(173, 39);
            this.diceZoneLbl.TabIndex = 54;
            this.diceZoneLbl.Text = "Dice Zone";
            // 
            // d4btn
            // 
            this.d4btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d4btn.Location = new System.Drawing.Point(15, 591);
            this.d4btn.Name = "d4btn";
            this.d4btn.Size = new System.Drawing.Size(80, 80);
            this.d4btn.TabIndex = 55;
            this.d4btn.Text = "d4";
            this.d4btn.UseVisualStyleBackColor = true;
            this.d4btn.Click += new System.EventHandler(this.d4btn_Click);
            // 
            // d6btn
            // 
            this.d6btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d6btn.Location = new System.Drawing.Point(101, 591);
            this.d6btn.Name = "d6btn";
            this.d6btn.Size = new System.Drawing.Size(80, 80);
            this.d6btn.TabIndex = 56;
            this.d6btn.Text = "d6";
            this.d6btn.UseVisualStyleBackColor = true;
            // 
            // d8btn
            // 
            this.d8btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d8btn.Location = new System.Drawing.Point(187, 591);
            this.d8btn.Name = "d8btn";
            this.d8btn.Size = new System.Drawing.Size(80, 80);
            this.d8btn.TabIndex = 57;
            this.d8btn.Text = "d8";
            this.d8btn.UseVisualStyleBackColor = true;
            // 
            // d10btn
            // 
            this.d10btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d10btn.Location = new System.Drawing.Point(273, 591);
            this.d10btn.Name = "d10btn";
            this.d10btn.Size = new System.Drawing.Size(80, 80);
            this.d10btn.TabIndex = 58;
            this.d10btn.Text = "d10";
            this.d10btn.UseVisualStyleBackColor = true;
            // 
            // d12btn
            // 
            this.d12btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d12btn.Location = new System.Drawing.Point(15, 677);
            this.d12btn.Name = "d12btn";
            this.d12btn.Size = new System.Drawing.Size(80, 80);
            this.d12btn.TabIndex = 59;
            this.d12btn.Text = "d12";
            this.d12btn.UseVisualStyleBackColor = true;
            // 
            // d20btn
            // 
            this.d20btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d20btn.Location = new System.Drawing.Point(105, 677);
            this.d20btn.Name = "d20btn";
            this.d20btn.Size = new System.Drawing.Size(80, 80);
            this.d20btn.TabIndex = 60;
            this.d20btn.Text = "d20";
            this.d20btn.UseVisualStyleBackColor = true;
            // 
            // dPercentBtn
            // 
            this.dPercentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPercentBtn.Location = new System.Drawing.Point(187, 677);
            this.dPercentBtn.Name = "dPercentBtn";
            this.dPercentBtn.Size = new System.Drawing.Size(80, 80);
            this.dPercentBtn.TabIndex = 61;
            this.dPercentBtn.Text = "d100";
            this.dPercentBtn.UseVisualStyleBackColor = true;
            // 
            // rollResultLbl
            // 
            this.rollResultLbl.AutoSize = true;
            this.rollResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollResultLbl.Location = new System.Drawing.Point(372, 549);
            this.rollResultLbl.Name = "rollResultLbl";
            this.rollResultLbl.Size = new System.Drawing.Size(157, 39);
            this.rollResultLbl.TabIndex = 62;
            this.rollResultLbl.Text = "Your Roll";
            // 
            // rollResultTb
            // 
            this.rollResultTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollResultTb.Location = new System.Drawing.Point(379, 592);
            this.rollResultTb.Multiline = true;
            this.rollResultTb.Name = "rollResultTb";
            this.rollResultTb.Size = new System.Drawing.Size(150, 165);
            this.rollResultTb.TabIndex = 63;
            this.rollResultTb.Text = "No Die Rolled";
            // 
            // oWoBtn
            // 
            this.oWoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oWoBtn.Location = new System.Drawing.Point(277, 677);
            this.oWoBtn.Name = "oWoBtn";
            this.oWoBtn.Size = new System.Drawing.Size(80, 80);
            this.oWoBtn.TabIndex = 64;
            this.oWoBtn.Text = "OwO";
            this.oWoBtn.UseVisualStyleBackColor = true;
            this.oWoBtn.Click += new System.EventHandler(this.oWoBtn_Click);
            // 
            // progBarLbl
            // 
            this.progBarLbl.AutoSize = true;
            this.progBarLbl.Location = new System.Drawing.Point(397, 476);
            this.progBarLbl.Name = "progBarLbl";
            this.progBarLbl.Size = new System.Drawing.Size(120, 16);
            this.progBarLbl.TabIndex = 65;
            this.progBarLbl.Text = "[Progressbar here]";
            // 
            // playerIcon
            // 
            this.playerIcon.Image = global::So_You_Wanna_Make_A_Dnd_Character.Properties.Resources.Default;
            this.playerIcon.Location = new System.Drawing.Point(11, 166);
            this.playerIcon.Name = "playerIcon";
            this.playerIcon.Size = new System.Drawing.Size(128, 128);
            this.playerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerIcon.TabIndex = 47;
            this.playerIcon.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 764);
            this.Controls.Add(this.progBarLbl);
            this.Controls.Add(this.oWoBtn);
            this.Controls.Add(this.rollResultTb);
            this.Controls.Add(this.rollResultLbl);
            this.Controls.Add(this.dPercentBtn);
            this.Controls.Add(this.d20btn);
            this.Controls.Add(this.d12btn);
            this.Controls.Add(this.d10btn);
            this.Controls.Add(this.d8btn);
            this.Controls.Add(this.d6btn);
            this.Controls.Add(this.d4btn);
            this.Controls.Add(this.diceZoneLbl);
            this.Controls.Add(this.statsLbl);
            this.Controls.Add(this.classFeaturesLbl);
            this.Controls.Add(this.equipLbl);
            this.Controls.Add(this.spellbookLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.backgroundTb);
            this.Controls.Add(this.playerIcon);
            this.Controls.Add(this.CHAbonusTxt);
            this.Controls.Add(this.WISbonusTxt);
            this.Controls.Add(this.SMRTbonusTxt);
            this.Controls.Add(this.CONbonusTxt);
            this.Controls.Add(this.DEXbonusTxt);
            this.Controls.Add(this.STRbonusTxt);
            this.Controls.Add(this.CHAStats);
            this.Controls.Add(this.WISstats);
            this.Controls.Add(this.SMRTStats);
            this.Controls.Add(this.CONStats);
            this.Controls.Add(this.DEXStats);
            this.Controls.Add(this.STRstats);
            this.Controls.Add(this.StatRoll);
            this.Controls.Add(this.CHACheck);
            this.Controls.Add(this.WISCheck);
            this.Controls.Add(this.SMRTCheck);
            this.Controls.Add(this.CONCheck);
            this.Controls.Add(this.DEXCheck);
            this.Controls.Add(this.STRCheck);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Multifaceted Assistant Generating Iconic Characters Kit";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LevelPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STRstats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEXStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMRTStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WISstats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHAStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).EndInit();
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
        private System.Windows.Forms.CheckedListBox STRCheck;
        private System.Windows.Forms.CheckedListBox DEXCheck;
        private System.Windows.Forms.CheckedListBox CONCheck;
        private System.Windows.Forms.CheckedListBox SMRTCheck;
        private System.Windows.Forms.CheckedListBox WISCheck;
        private System.Windows.Forms.CheckedListBox CHACheck;
        private System.Windows.Forms.Button StatRoll;
        private System.Windows.Forms.NumericUpDown STRstats;
        private System.Windows.Forms.NumericUpDown DEXStats;
        private System.Windows.Forms.NumericUpDown CONStats;
        private System.Windows.Forms.NumericUpDown SMRTStats;
        private System.Windows.Forms.NumericUpDown WISstats;
        private System.Windows.Forms.NumericUpDown CHAStats;
        private System.Windows.Forms.RichTextBox STRbonusTxt;
        private System.Windows.Forms.RichTextBox DEXbonusTxt;
        private System.Windows.Forms.RichTextBox CONbonusTxt;
        private System.Windows.Forms.RichTextBox SMRTbonusTxt;
        private System.Windows.Forms.RichTextBox WISbonusTxt;
        private System.Windows.Forms.RichTextBox CHAbonusTxt;
        private System.Windows.Forms.PictureBox playerIcon;
        private System.Windows.Forms.Label backgroundTb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label spellbookLbl;
        private System.Windows.Forms.Label equipLbl;
        private System.Windows.Forms.Label classFeaturesLbl;
        private System.Windows.Forms.Label statsLbl;
        private System.Windows.Forms.Label diceZoneLbl;
        private System.Windows.Forms.Button d4btn;
        private System.Windows.Forms.Button d6btn;
        private System.Windows.Forms.Button d8btn;
        private System.Windows.Forms.Button d10btn;
        private System.Windows.Forms.Button d12btn;
        private System.Windows.Forms.Button d20btn;
        private System.Windows.Forms.Button dPercentBtn;
        private System.Windows.Forms.Label rollResultLbl;
        private System.Windows.Forms.TextBox rollResultTb;
        private System.Windows.Forms.Button oWoBtn;
        private System.Windows.Forms.Label progBarLbl;
    }
}

