using M_A_G_I_C_K;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace So_You_Wanna_Make_A_Dnd_Character
{
    public partial class CharacterShow : Form
    {
        public CharacterShow(Character created)
        {
            InitializeComponent();
            
            //redirecting the btn click to include sending in the created character information
            CreatePdfBtn.Click += delegate(object sender, EventArgs e) { CreatePdfBtn_Click(sender, e, created); };
        }

        private void CreatePdfBtn_Click(object sender, EventArgs e, Character created)
        {
            created.creatingPdf();
        }

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
            main.Closed += (s, args) => this.Close();
        }
    }
}
