using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_You_Wanna_Make_A_Dnd_Character
{
    class Character
    {
        //this will have all the info for the character
        //it will have a class, race, background, stats etc etc


        //stats, created via method
        private int STR, DEX, CON, SMRT, WIS, CHA;
        private string name, background;

        

        //constructors will one for full and one for completely empty
        //the one for all constructor will also have options to fill in blank ones, and if == null then blank


    }


    abstract class DndClass
    {
        //this will be inhearented by all the classes


    }

    abstract class DndRace
    {
        //this will be inherented by all the races


    }

}
