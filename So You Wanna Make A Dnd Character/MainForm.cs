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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            //collecting things to pass into the character builder

            /*RaceDropDown
             * Human
                Elf
                Dwarf
                Orc
                DragonBorn

            Class DropDown
            Fighter
            Cleric
            Wizard
            Rogue
            Bard
            */

            //RaceDropBox.SelectedIndex selects the index of the dropdown that has been selected, and it functions like an array starting at 0, adding the + 1 so we can have nothing be 0 and create an error guard. Same thing for ClassDropBox
            //GOTTA FUCKING FIX, YOU CAN UNSELECT THE DROPDOWN AND IT WILL MAKE IT SO YOU CAN'T NOT SELECT NOTHING AFTER SELECTING A RACE/CLASS
            int SelectedRace;
            int SelectedClass;

            if (RaceDropBox.SelectedIndex == null)
            {
                SelectedRace = 0;
            }
            else
            {
                SelectedRace = RaceDropBox.SelectedIndex + 1;

            }
            
            if(ClassDropBox.SelectedIndex == null)
            {
                SelectedClass = 0;
            }
            else
            {
                SelectedClass = ClassDropBox.SelectedIndex + 1;
            }




            Character created = new Character(SelectedRace, SelectedClass);

            

        }
    }
}
