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
        private int _STR, _DEX, _CON, _SMRT, _WIS, _CHA, ProfisBonus, Level;
        //name and background, name gotten from pdf, background gotten from 
        private string _name, _background;
        //created via inherented class
        private DndClass _CharClass;
        //created via inherented class
        private DndRace _CharRace;
        

        //constructors will one for full and one for completely empty
        //the one for all constructor will also have options to fill in blank ones, and if == null then blank

        public Character() 
        {
            
        }




        private int calculatingStats()
        {


            return 1;
        }
    }


    abstract class DndClass
    {
        //this will be inhearented by all the classes


    }

    class Fighter : DndClass
    {

    }

    class Cleric : DndClass { 
    }

    class Wizard : DndClass 
    {
    }

    class Rouge : DndClass 
    {
    }

    class Bard : DndClass 
    { 
    }



    abstract class DndRace
    {
        //this will be inherented by all the races
        private int _speed, _size;

    }

    class Human : DndRace
    {

    }

    class Elf : DndRace
    {

    }

    class Dwarf : DndRace
    {

    }

    class Orc : DndRace
    {

    }

    class Dragon : DndRace
    {

    }


}
