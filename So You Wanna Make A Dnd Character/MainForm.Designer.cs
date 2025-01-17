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
            this.SuspendLayout();
            // 
            // ClassPickerBox
            // 
            this.ClassPickerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassPickerBox.FormattingEnabled = true;
            this.ClassPickerBox.Location = new System.Drawing.Point(92, 97);
            this.ClassPickerBox.Name = "ClassPickerBox";
            this.ClassPickerBox.Size = new System.Drawing.Size(147, 24);
            this.ClassPickerBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 648);
            this.Controls.Add(this.ClassPickerBox);
            this.Name = "MainForm";
            this.Text = "So You Want To Make A DND Character";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassPickerBox;
    }
}

