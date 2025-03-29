using Org.BouncyCastle.Bcpg;
using So_You_Wanna_Make_A_Dnd_Character;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Windows.Forms;
using static iText.Signatures.LtvVerification;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace M_A_G_I_C_K
{

    /*
     * things to add
     * 
     * 
     * 
     */

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //making the drop boxes default to the select please.. to allow for reselection of nothing after a selected option
            RaceDropBox.SelectedIndex = 0;
            ClassDropBox.SelectedIndex = 0;
            cantripLblCount.Visible = false;
            spellbookLblCount.Visible = false;
        }

        //this will change the spells you can pick etc etc based on what you pick
        private void RaceDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*RaceDropDown
             * Human
                Elf
                Dwarf
                Orc
                DragonBorn
            */
            STRtbx.Clear();
            DEXtbx.Clear();
            SMRTtbx.Clear();
            CHAtbx.Clear();
            CONtbx.Clear();
            WIStbx.Clear();


            switch (RaceDropBox.SelectedIndex)
            {
                case 1: //human
                //--- I didn't know what to do so i gave +1 to 3 stats, same ASI just different.
                    // +1 to STR
                    STRtbx.AppendText("+1 Racial Bonus");
                    try
                    {
                        STRstats.Value = STRstats.Value + 1;
                    }
                    catch
                    {
                        STRstats.Value = 20;
                        STRtbx.AppendText("Racial bonus not applied, natural score may not exceed 20");
                    }
                    // +1 to INT
                    try
                    {
                        SMRTtbx.AppendText("+1 Racial Bonus");
                        SMRTStats.Value = SMRTStats.Value + 1;
                    }
                    catch
                    {
                        SMRTStats.Value = 20;
                        SMRTtbx.AppendText("Racial bonus not applied, natural score may not exceed 20");
                    }
                    // +1 to WIS
                    try
                    {
                        WIStbx.AppendText("+1 Racial Bonus");
                        WISstats.Value = WISstats.Value + 1;
                    }
                    catch
                    {
                        WISstats.Value = 20;
                        WIStbx.AppendText("Racial bonus not applied, natural score may not exceed 20");
                    }
                    break;
                case 2: //elf
                    // +2 to DEX
                    DEXtbx.AppendText("+2 Racial Bonus");
                    try
                    {
                        DEXtbx.AppendText("+2 Racial Bonus");
                        DEXStats.Value = DEXStats.Value + 2;
                    }
                    catch
                    {
                        DEXStats.Value = 20;
                        DEXtbx.AppendText("Racial bonus not applied, natural score may not exceed 20");
                    }
                    // +1 to INT   (went w/ high elf bc idk)
                    try
                    {
                        SMRTtbx.AppendText("+1 Racial Bonus");
                        SMRTStats.Value = SMRTStats.Value + 1;
                    }
                    catch
                    {
                        SMRTStats.Value = 20;
                        SMRTtbx.AppendText("Racial bonus not applied, natural score may not exceed 20");
                    }
                    break;
                case 3: //Dwarf
                    //+2 to CON
                    try
                    {
                        CONtbx.AppendText("+2 Racial Bonus");
                        CONStats.Value = CONStats.Value + 2;
                    }
                    catch
                    {
                        CONStats.Value = 20;
                        CONtbx.AppendText("Racial bonus not applied, natural score may not exceed 20");
                    }

                    break;
                case 4: //orc

                    // +2 to STR
                    try
                    {
                        STRtbx.AppendText("+2 Racial Bonus");
                        STRstats.Value = STRstats.Value + 2;
                    }
                    catch
                    {
                        STRstats.Value = 20;
                        STRtbx.AppendText("Racial bonus not applied, natural score may not exceed 20");
                    }
                    // +1 to CON
                     try
                    {
                        CONtbx.AppendText("+1 Racial Bonus");
                        CONStats.Value = CONStats.Value + 1;
                    }
                    catch
                    {
                        CONStats.Value = 20;
                        CONtbx.AppendText("Racial bonus not applied, natural score may not exceed 20");
                    }
                    break;
                case 5: //DragonBorn
                    // +2 to STR
                    STRtbx.AppendText("+2 Racial Bonus");
                    try
                    {
                        STRstats.Value = STRstats.Value + 2;
                    }
                    catch
                    {
                        STRstats.Value = 20;
                        STRtbx.AppendText("Racial bonus not applied, natural score may not exceed 20");
                    }
                    // +1 to CHA
                    try
                    {                    
                        CHAtbx.AppendText("+1 Racial Bonus");
                        CHAStats.Value = CHAStats.Value + 1;
                    }
                    catch
                    {
                        CHAStats.Value = 20;
                        CHAtbx.AppendText("Racial bonus not applied, natural score may not exceed 20");
                    }

                    break;

                default:
                    //nothing change nothing

                    break;
            }
        }

        private void ClassDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipmentCheckBox.Items.Clear();
            FeatCheckBox.Items.Clear();
            SpellCheckBox.Items.Clear();
            CantripList.Items.Clear();
            ArmCheckbox.Items.Clear();

            string linkToImagine = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName) + @"\Resources\";


            /*Class DropDown
                Fighter
                Cleric
                Wizard
                Rogue
                Bard
            */

            /*BACKGROUND METHOD HERE*/


            //these will all be updates to a linq statments to filter by class then level, and then a loop to create all the items.add for each thing
            switch (ClassDropBox.SelectedIndex)
            {
                case 1:
                    //Fighter
                    playerIcon.Image = Image.FromFile(linkToImagine + "Fighter.png");
                    /* Being rewritten
                     * backgroundTb1.Text = "History: [variable]"
                     */
                    backgroundTb1.Text = "Background: Fighter"
                        + Environment.NewLine + "Personality: Fighter"
                        + Environment.NewLine + "Ideal: Fighter"
                        + Environment.NewLine + "Flaw: Fighter"
                        + Environment.NewLine + "Bond: Fighter";


                    this.BackColor = ColorTranslator.FromHtml("#E57373");

                    List<string> fighterWeapons = Fighter.gettingWeapons("martial");
                    List<string> fighterFeats = Fighter.gettingFeats();
                    List<string> fighterArmour = Fighter.gettingArmours("heavy");
                    List<string> fighterEquipment = Fighter.gettingEquipment();

                    //removing cantrip label since it is now seen
                    cantripLblCount.Visible = false;
                    spellbookLblCount.Visible = false;     

                    foreach (string weapon in fighterWeapons)
                    {
                         EquipmentCheckBox.Items.Add(weapon);
                    }

                    foreach (string feat in fighterFeats)
                    {
                         FeatCheckBox.Items.Add(feat);
                    }
                    foreach (string armour in fighterArmour)
                    {
                        ArmCheckbox.Items.Add(armour);
                    }
                    
                    foreach (string trinket in fighterEquipment)
                    {
                        InventoryCheckbox.Items.Add(trinket);
                    }
                    /*second switch statment for each level

                    ////commented out jic you want it for a reason, I currently see this code as defunct at the moment
                    ////
                    ////regarding feats, we should have a counter that displays selections available, upon threshold (counter reaching zero), user should be blocked from selecting more
                    ////we could use this statement for updating selection choices and limitations for feats/lvl

                    //switch (LevelPicker.Value)
                    //{
                    //    case 1:

                    //        break;
                    //    case 2:


                    //        break;
                    //    case 3:


                    //        break;
                    }*/
                    break;
                case 2:
                    //Cleric
                     playerIcon.Image = Image.FromFile(linkToImagine + "Cleric.png");
                    backgroundTb1.Text = "Background: Cleric"
                        + Environment.NewLine + "Personality: Cleric"
                        + Environment.NewLine + "Ideal: Cleric"
                        + Environment.NewLine + "Flaw: Cleric"
                        + Environment.NewLine + "Bond: Cleric";
                    this.BackColor = ColorTranslator.FromHtml("#5A9BD4");

                    List<string> clericWeapons = Cleric.gettingWeapons("simple");
                    List<string> clericFeats = Cleric.gettingFeats();
                    List<string> clericArmour = Cleric.gettingArmours("heavy");
                    List<string> clericEquipment = Cleric.gettingEquipment();


                    //displaying the counter for spells
                    cantripLblCount.Visible = true;
                    spellbookLblCount.Visible = true;

  
                    foreach (string weapon in clericWeapons)
                    {
                        EquipmentCheckBox.Items.Add(weapon);
                    }

                    foreach (string feat in clericFeats)
                    {
                        FeatCheckBox.Items.Add(feat);
                    }

                    foreach (string armour in clericArmour)
                    {
                        ArmCheckbox.Items.Add(armour);
                    }
                    foreach (string trinket in clericEquipment)
                    {
                        InventoryCheckbox.Items.Add(trinket);
                    }

                    List<string> ClericCantrip = Cleric.gettingSpells(0);
                    List<string> ClericLevelOne = Cleric.gettingSpells(1);
                    List<string> ClericLevelTwo = Cleric.gettingSpells(2);


                    switch (LevelPicker.Value)
                    {
                        case 1:                        
                            //4 cantrips, two spells, only first level spells
                            //adding the cantrips
                            foreach (string spell in ClericCantrip)
                            {
                                CantripList.Items.Add(spell);
                            }

                            //adding first
                            foreach(string spell in ClericLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 2;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                        case 2:
                            //4 cantrips, three spells, only first level
                            //adding the cantrips
                            foreach (string spell in ClericCantrip)
                            {
                                CantripList.Items.Add(spell);
                            }
                            //adding first
                            foreach (string spell in ClericLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 3;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                        case 3:
                            //4 cantrips, four spells, second and first
                            //adding the cantrips
                            foreach (string spell in ClericCantrip)
                            {
                                CantripList.Items.Add(spell);
                            }
                            //adding first
                            foreach (string spell in ClericLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }
                            //adding second
                            foreach(string spell in ClericLevelTwo)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 4;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                    }

                    break;
                case 3:
                    //Wizard
                    playerIcon.Image = Image.FromFile(linkToImagine +  "Wizard.png");
                    backgroundTb1.Text = "Background: Wizard"
                        + Environment.NewLine + "Personality: Wizard"
                        + Environment.NewLine + "Ideal: Wizard"
                        + Environment.NewLine + "Flaw: Wizard"
                        + Environment.NewLine + "Bond: Wizard";
                    this.BackColor = ColorTranslator.FromHtml("#B085E9");

                    List<string> wizardWeapon = Wizard.gettingWeapons("simple");
                    List<string> wizardFeats = Wizard.gettingFeats();
                    List<string> wizardArmour = Wizard.gettingArmours("light");
                    List<string> wizardEquipment = Wizard.gettingEquipment();

                    //displaying the counter for spells
                    cantripLblCount.Visible = true;
                    spellbookLblCount.Visible = true;

                    foreach (string weapon in wizardWeapon)
                    {
                        EquipmentCheckBox.Items.Add(weapon);
                    }
                    foreach (string feat in wizardFeats)
                    {
                        FeatCheckBox.Items.Add(feat);
                    }
                    foreach (string armour in wizardArmour)
                    {
                        ArmCheckbox.Items.Add(armour);
                    }
                    foreach (string trinket in wizardEquipment)
                    {
                        InventoryCheckbox.Items.Add(trinket);
                    }

                    List<string> WizCantrip = Wizard.gettingSpells(0);
                    List<string> WizLevelOne = Wizard.gettingSpells(1);
                    List<string> WizLevelTwo = Wizard.gettingSpells(2);

                    switch (LevelPicker.Value)
                    {
                        case 1:
                            //4 cantrips, two spells, only first level spells
                            //adding the cantrips
                            foreach (string spell in WizCantrip)
                            {
                                CantripList.Items.Add(spell);
                            }

                            //adding first
                            foreach (string spell in WizLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 2;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                        case 2:
                            //4 cantrips, three spells, only first level
                            //adding the cantrips
                            foreach (string spell in WizCantrip)
                            {
                                CantripList.Items.Add(spell);
                            }
                            //adding first
                            foreach (string spell in WizLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 3;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                        case 3:
                            //4 cantrips, four spells, second and first
                            //adding the cantrips
                            foreach (string spell in WizCantrip)
                            {
                                CantripList.Items.Add(spell);
                            }
                            //adding first
                            foreach (string spell in WizLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }
                            //adding second
                            foreach (string spell in WizLevelTwo)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 4;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                    }

                    break;
                case 4:
                    //Rogue
                    EquipmentCheckBox.Items.Add("Items for Rouge");
                    playerIcon.Image = Image.FromFile(linkToImagine + "Rogue.png");

                    List<string> rogueWeapons = Rouge.gettingWeapons("martial");
                    List<string> rogueFeats = Rouge.gettingFeats();
                    List<string> rogueArmour = Rouge.gettingArmours("medium");
                    List<string> rogueEquipment = Rouge.gettingEquipment();

                    backgroundTb1.Text = "Background: Bard"
                        + Environment.NewLine + "Personality: Rogue"
                        + Environment.NewLine + "Ideal: Rogue"
                        + Environment.NewLine + "Flaw: Rogue"
                        + Environment.NewLine + "Bond: Rogue";
                    this.BackColor = ColorTranslator.FromHtml("#A0A5AA");

                    //removing cantrip
                    cantripLblCount.Visible = false;
                    spellbookLblCount.Visible = false;


                    foreach (string weapon in rogueWeapons)
                    {
                        EquipmentCheckBox.Items.Add(weapon);
                    }

                    foreach (string feat in rogueFeats)
                    {
                        FeatCheckBox.Items.Add(feat);
                    }
                    foreach(string armour in rogueArmour)
                    {
                        ArmCheckbox.Items.Add(armour);
                    }
                    foreach (string trinket in rogueEquipment)
                    {
                        InventoryCheckbox.Items.Add(trinket);
                    }


                    switch (LevelPicker.Value)
                    {
                        case 1:
                            FeatCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("ONE");

                            break;
                        case 2:
                            FeatCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("TWO");

                            break;
                        case 3:
                            FeatCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("THREE");

                            break;
                    }

                    break;
                case 5:
                    //Bard
                    playerIcon.Image = Image.FromFile(linkToImagine + "Bard.png");
                    backgroundTb1.Text = "Background: Bard"
                        + Environment.NewLine + "Personality: Bard"
                        + Environment.NewLine + "Ideal: Bard"
                        + Environment.NewLine + "Flaw: Bard"
                        + Environment.NewLine + "Bond: Bard";
                    this.BackColor = ColorTranslator.FromHtml("#F4A261");

                    List<string> bardWeapons = Bard.gettingWeapons("simple");
                    List<string> bardFeats = Bard.gettingFeats();
                    List<string> bardArmour = Bard.gettingArmours("light");
                    List<string> bardEquipment = Bard.gettingEquipment();

                    //displaying the counter for spells
                    cantripLblCount.Visible = true;
                    spellbookLblCount.Visible = true;

                    foreach (string weapon in bardWeapons)
                    {
                        EquipmentCheckBox.Items.Add(weapon);
                    }

                    foreach (string feat in bardFeats)
                    {
                        FeatCheckBox.Items.Add(feat);
                    }
                    foreach(string armour in bardArmour)
                    {
                        ArmCheckbox.Items.Add(armour);
                    }
                    foreach (string trinket in bardEquipment)
                    {
                        InventoryCheckbox.Items.Add(trinket);
                    }

                    //getting the names of all the bard spells
                    List<string> BardCantrips = Bard.gettingSpells(0);
                    List<string> BardLevelOne = Bard.gettingSpells(1);
                    List<string> BardLevelTwo = Bard.gettingSpells(2);


                    switch (LevelPicker.Value)
                    {
                        case 1:

                            //4 cantrips, two spells, only first level spells
                            //adding the cantrips
                            foreach (string spell in BardCantrips)
                            {
                                CantripList.Items.Add(spell);
                            }

                            //adding first
                            foreach (string spell in BardLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 2;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                        case 2:
                            //4 cantrips, three spells, only first level
                            //adding the cantrips
                            foreach (string spell in BardCantrips)
                            {
                                CantripList.Items.Add(spell);
                            }
                            //adding first
                            foreach (string spell in BardLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 3;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                        case 3:
                            //4 cantrips, four spells, second and first
                            //adding the cantrips
                            foreach (string spell in BardCantrips)
                            {
                                CantripList.Items.Add(spell);
                            }
                            //adding first
                            foreach (string spell in BardLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }
                            //adding second
                            foreach (string spell in BardLevelTwo)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 4;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                    }

                    break;

                default:
                    //nothing change nothing
                    playerIcon.Image = Image.FromFile(linkToImagine + "Default.png");
                    backgroundTb1.Text = "Background: Where did you come from?"
                        + Environment.NewLine + "Personality: What are you like?"
                        + Environment.NewLine + "Ideal: To what do you aspire?"
                        + Environment.NewLine + "Flaw: With what do you struggle?"
                        + Environment.NewLine + "Bond: What drives you?";
                    this.BackColor = ColorTranslator.FromHtml("#A67C52");
                    break;
            }

        }

        private void LevelPicker_ValueChanged(object sender, EventArgs e)
        {
            //updating this will be more complicated
            FeatCheckBox.Items.Clear();
            SpellCheckBox.Items.Clear();

            /*Class DropDown
                Fighter
                Cleric
                Wizard
                Rogue
                Bard
            */

            //first switch statment for what the class is
            switch (ClassDropBox.SelectedIndex)
            {
                case 1:
                    //Fighter

                    //second switch statment for each level
                    switch (LevelPicker.Value)
                    {
                        case 1:
                            FeatCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("ONE");

                            break;
                        case 2:
                            FeatCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("TWO");

                            break;
                        case 3:
                            FeatCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("THREE");

                            break;
                    }
                    break;
                case 2:
                    //Cleric

                    List<string> ClericCantrip = Cleric.gettingSpells(0);
                    List<string> ClericLevelOne = Cleric.gettingSpells(1);
                    List<string> ClericLevelTwo = Cleric.gettingSpells(2);

                    switch (LevelPicker.Value)
                    {
                        case 1:
                            //4 cantrips, two spells, only first level spells
                            //adding the cantrips
                            foreach (string spell in ClericCantrip)
                            {
                                CantripList.Items.Add(spell);
                            }

                            //adding first
                            foreach (string spell in ClericLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 2;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                        case 2:
                            //4 cantrips, three spells, only first level
                            //adding the cantrips
                            foreach (string spell in ClericCantrip)
                            {
                                CantripList.Items.Add(spell);
                            }
                            //adding first
                            foreach (string spell in ClericLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 3;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                        case 3:
                            //4 cantrips, four spells, second and first
                            //adding the cantrips
                            foreach (string spell in ClericCantrip)
                            {
                                CantripList.Items.Add(spell);
                            }
                            //adding first
                            foreach (string spell in ClericLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }
                            //adding second
                            foreach (string spell in ClericLevelTwo)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 4;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                    }

                    break;

                case 3:
                    //Wizard
                    List<string> WizCantrip = Wizard.gettingSpells(0);
                    List<string> WizLevelOne = Wizard.gettingSpells(1);
                    List<string> WizLevelTwo = Wizard.gettingSpells(2);

                    switch (LevelPicker.Value)
                    {
                        case 1:
                            //4 cantrips, two spells, only first level spells
                            //adding the cantrips
                            foreach (string spell in WizCantrip)
                            {
                                CantripList.Items.Add(spell);
                            }

                            //adding first
                            foreach (string spell in WizLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 2;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                        case 2:
                            //4 cantrips, three spells, only first level
                            //adding the cantrips
                            foreach (string spell in WizCantrip)
                            {
                                CantripList.Items.Add(spell);
                            }
                            //adding first
                            foreach (string spell in WizLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 3;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                        case 3:
                            //4 cantrips, four spells, second and first
                            //adding the cantrips
                            foreach (string spell in WizCantrip)
                            {
                                CantripList.Items.Add(spell);
                            }
                            //adding first
                            foreach (string spell in WizLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }
                            //adding second
                            foreach (string spell in WizLevelTwo)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 4;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                    }

                    break;

                case 4:
                    //Rouge
                    switch (LevelPicker.Value)
                    {
                        case 1:
                            FeatCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("ONE");

                            break;
                        case 2:
                            FeatCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("TWO");

                            break;
                        case 3:
                            FeatCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("THREE");

                            break;
                    }

                    break;

                case 5:
                    //Bard
                    List<string> BardCantrips = Bard.gettingSpells(0);
                    List<string> BardLevelOne = Bard.gettingSpells(1);
                    List<string> BardLevelTwo = Bard.gettingSpells(2);


                    switch (LevelPicker.Value)
                    {
                        case 1:
                            //4 cantrips, two spells, only first level spells
                            //adding the cantrips
                            foreach (string spell in BardCantrips)
                            {
                                CantripList.Items.Add(spell);
                            }

                            //adding first
                            foreach (string spell in BardLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 2;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                        case 2:
                            //4 cantrips, three spells, only first level
                            //adding the cantrips
                            foreach (string spell in BardCantrips)
                            {
                                CantripList.Items.Add(spell);
                            }
                            //adding first
                            foreach (string spell in BardLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 3;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                        case 3:
                            //4 cantrips, four spells, second and first
                            //adding the cantrips
                            foreach (string spell in BardCantrips)
                            {
                                CantripList.Items.Add(spell);
                            }
                            //adding first
                            foreach (string spell in BardLevelOne)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }
                            //adding second
                            foreach (string spell in BardLevelTwo)
                            {
                                SpellCheckBox.Items.Add(spell);
                            }

                            //updating the number of spells that can be selected
                            spellCaster.SpellAmountAllowed = 4;
                            spellbookLblCount.Text = "( 0 / " + spellCaster.SpellAmountAllowed + " )";

                            break;
                    }

                    break;

                default:
                    //nothing change nothing

                    break;
            }
        }

        private void StatRoll_Click(object sender, EventArgs e)
        {
            //this will roll the stats or do standard array and will improve it based on the class
            //can 

            var ran = new Random();

            int[] stats = new int[6];

            //change forloop to make more efficant
            stats[0] = ran.Next(6, 18);
            stats[1] = ran.Next(6, 18);
            stats[2] = ran.Next(6, 18);
            stats[3] = ran.Next(6, 18);
            stats[4] = ran.Next(6, 18);
            stats[5] = ran.Next(6, 18);


            
             DEXStats.Value = stats[0];
             STRstats.Value = stats[1];
             SMRTStats.Value = stats[2];
             CHAStats.Value = stats[3];
             WISstats.Value = stats[4];
             CONStats.Value = stats[5];
            
        }


        //will add value changed for all the stat nums, to update the profis bounus thingy        
        private void STRstats_ValueChanged(object sender, EventArgs e)
        {
            switch (STRstats.Value)
            {
                case 6: case 7:
                    STRbonusTxt.Text = "-2";
                    break;
                case 8: case 9:
                    STRbonusTxt.Text = "-1";
                    break;
                case 10: case 11: default:
                    STRbonusTxt.Text = "0";
                    break;
                case 12: case 13:
                    STRbonusTxt.Text = "+1";
                    break;
                case 14: case 15:
                    STRbonusTxt.Text = "+2";
                    break;
                case 16: case 17:
                    STRbonusTxt.Text = "+3";
                    break;
                case 18: case 19:
                    STRbonusTxt.Text = "+4";
                    break;
                case 20:
                    STRbonusTxt.Text = "+5";
                    break;
            }
  
        }

        private void DEXStats_ValueChanged(object sender, EventArgs e)
        {
            switch(DEXStats.Value)
            {
                case 6:
                case 7:
                    DEXbonusTxt.Text = "-2";
                    break;
                case 8:
                case 9:
                    DEXbonusTxt.Text = "-1";
                    break;
                case 10:
                case 11:
                default:
                    DEXbonusTxt.Text = "0";
                    break;
                case 12:
                case 13:
                    DEXbonusTxt.Text = "+1";
                    break;
                case 14:
                case 15:
                    DEXbonusTxt.Text = "+2";
                    break;
                case 16:
                case 17:
                    DEXbonusTxt.Text = "+3";
                    break;
                case 18:
                case 19:
                    DEXbonusTxt.Text = "+4";
                    break;
                case 20:
                    DEXbonusTxt.Text = "+5";
                    break;
                }
        }

        private void CONStats_ValueChanged(object sender, EventArgs e)
        {
            switch (CONStats.Value)
            {
                case 6:
                case 7:
                    CONbonusTxt.Text = "-2";
                    break;
                case 8:
                case 9:
                    CONbonusTxt.Text = "-1";
                    break;
                case 10:
                case 11:
                default:
                    CONbonusTxt.Text = "0";
                    break;
                case 12:
                case 13:
                    CONbonusTxt.Text = "+1";
                    break;
                case 14:
                case 15:
                    CONbonusTxt.Text = "+2";
                    break;
                case 16:
                case 17:
                    CONbonusTxt.Text = "+3";
                    break;
                case 18:
                case 19:
                    CONbonusTxt.Text = "+4";
                    break;
                case 20:
                    CONbonusTxt.Text = "+5";
                    break;
            }
        }

        private void SMRTStats_ValueChanged(object sender, EventArgs e)
        {
            switch (SMRTStats.Value)
            {
                case 6:
                case 7:
                    SMRTbonusTxt.Text = "-2";
                    break;
                case 8:
                case 9:
                    SMRTbonusTxt.Text = "-1";
                    break;
                case 10:
                case 11:
                default:
                    SMRTbonusTxt.Text = "0";
                    break;
                case 12:
                case 13:
                    SMRTbonusTxt.Text = "+1";
                    break;
                case 14:
                case 15:
                    SMRTbonusTxt.Text = "+2";
                    break;
                case 16:
                case 17:
                    SMRTbonusTxt.Text = "+3";
                    break;
                case 18:
                case 19:
                    SMRTbonusTxt.Text = "+4";
                    break;
                case 20:
                    SMRTbonusTxt.Text = "+5";
                    break;
            }
        }

        private void WISstats_ValueChanged(object sender, EventArgs e)
        {
            switch (WISstats.Value)
            {
                case 6:
                case 7:
                    WISbonusTxt.Text = "-2";
                    break;
                case 8:
                case 9:
                    WISbonusTxt.Text = "-1";
                    break;
                case 10:
                case 11:
                default:
                    WISbonusTxt.Text = "0";
                    break;
                case 12:
                case 13:
                    WISbonusTxt.Text = "+1";
                    break;
                case 14:
                case 15:
                    WISbonusTxt.Text = "+2";
                    break;
                case 16:
                case 17:
                    WISbonusTxt.Text = "+3";
                    break;
                case 18:
                case 19:
                    WISbonusTxt.Text = "+4";
                    break;
                case 20:
                    WISbonusTxt.Text = "+5";
                    break;
            }
        }

        private void CHAStats_ValueChanged(object sender, EventArgs e)
        {
            switch (CHAStats.Value)
            {
                case 6:
                case 7:
                    CHAbonusTxt.Text = "-2";
                    break;
                case 8:
                case 9:
                    CHAbonusTxt.Text = "-1";
                    break;
                case 10:
                case 11:
                default:
                    CHAbonusTxt.Text = "0";
                    break;
                case 12:
                case 13:
                    CHAbonusTxt.Text = "+1";
                    break;
                case 14:
                case 15:
                    CHAbonusTxt.Text = "+2";
                    break;
                case 16:
                case 17:
                    CHAbonusTxt.Text = "+3";
                    break;
                case 18:
                case 19:
                    CHAbonusTxt.Text = "+4";
                    break;
                case 20:
                    CHAbonusTxt.Text = "+5";
                    break;
            }

        }

        //main button click
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

            //RaceDropBox.SelectedIndex selects the index of the dropdown that has been selected, and it functions like an array starting at 0
            int SelectedRace = RaceDropBox.SelectedIndex;
            int SelectedClass = ClassDropBox.SelectedIndex;

            string Name = FirstNameTxt.Text + " " + SecondNameTxt.Text;

            int Level = Convert.ToInt32(LevelPicker.Value);

            //collecting all the stats
            int[] Stats = new int[6];

            Stats[0] = Convert.ToInt32(STRstats.Value);
            Stats[1] = Convert.ToInt32(DEXStats.Value);
            Stats[2] = Convert.ToInt32(SMRTStats.Value);
            Stats[3] = Convert.ToInt32(CONStats.Value);
            Stats[4] = Convert.ToInt32(CHAStats.Value);
            Stats[5] = Convert.ToInt32(WISstats.Value);

            string Background = "testing string!! uwu";


            //equipment will be all stored in one variable, the [0] will be weapon, [1] armor and everything afterwards equipment
            List<string> inventory = EquipmentCheckBox.CheckedItems.Cast<string>().ToList();
            //adding armor should always be only one
            foreach(string Arm in ArmCheckbox.CheckedItems)
            {
                inventory.Add(Arm);
            }

            //adding everythign else
            foreach (string item in InventoryCheckbox.CheckedItems)
            {
                inventory.Add(item);
            }

            //getting all the feats
            string[] feats = FeatCheckBox.CheckedItems.OfType<string>().ToArray(); 

            //creating the confermaintion box
            CharacterShow show = null;
            string message = "Are you done creating your character?";
            string title = "Confirm Character?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            //final switch statment desciding if it's a spellcaster or not to decide what constructor it is using
            switch (SelectedClass)
            {
                case 2:
                case 3:
                case 5:
                    //adding spells and cantrips
                    string[] cantrips = CantripList.CheckedItems.OfType<string>().ToArray();
                    string[] Spells = SpellCheckBox.CheckedItems.OfType<string>().ToArray();

                    Character createdCharSpell = new Character(SelectedRace, SelectedClass, Name, Level, Stats, Background, cantrips, Spells, inventory, feats);

                    if (result == DialogResult.Yes)
                    {
                        //opening new form
                        this.Hide();
                        show = new CharacterShow(createdCharSpell);
                        show.Show();
                        show.Closed += (s, args) => this.Close();
                    }
                    
                    break;

                default:
                    Character createdChar = new Character(SelectedRace, SelectedClass, Name, Level, Stats, Background, inventory, feats);

                    if (result == DialogResult.Yes)
                    {
                        //opening new form
                        this.Hide();
                        show = new CharacterShow(createdChar);
                        show.Show();
                        show.Closed += (s, args) => this.Close();
                    }

                    break;
            }            
        }

        //these will limit the number of the checked boxes you can click
        private void CantripList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && CantripList.CheckedItems.Count >= 4)
            {
                e.NewValue = CheckState.Unchecked;
            }
            else if (e.NewValue == CheckState.Checked)
            {
                cantripLblCount.Text = "( " + (CantripList.CheckedItems.Count + 1) + " / 4 )";
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                cantripLblCount.Text = "( " + (CantripList.CheckedItems.Count - 1) + " / 4 )";
            }
        }

        private void SpellCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && SpellCheckBox.CheckedItems.Count >= spellCaster.SpellAmountAllowed)
            {
                e.NewValue = CheckState.Unchecked;
            }
            else if (e.NewValue == CheckState.Checked)
            {
                spellbookLblCount.Text = "( " + (SpellCheckBox.CheckedItems.Count + 1) + " / " + spellCaster.SpellAmountAllowed + " )";
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                spellbookLblCount.Text = "( " + (SpellCheckBox.CheckedItems.Count - 1) + " / " + spellCaster.SpellAmountAllowed + " )";
            }
        }
        
        private void EquipmentCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && EquipmentCheckBox.CheckedItems.Count == 1)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }

        private void ArmCheckbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && ArmCheckbox.CheckedItems.Count == 1)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }
        private void FeatCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && ArmCheckbox.CheckedItems.Count == 3)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }


        //For Random Name Generator
        //this was oddly painful to make happen ~ Duncan
        private void RanNameBtn_Click(object sender, EventArgs e)
        {
            //connection string to pull names from database
            string connectionString = @"Data Source=" + Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName) + @"\Databases\Primary Database.db";

            List<string> firstNameList = new List<string>();
            List<string> secondNameList = new List<string>();
            Random rng = new Random();

            //for getting race specific for query
            string currentRace = RaceDropBox.Text.ToLower();
           
            //variables to store official selection in case of need to reuse post-connection close
            string randomFname = "";
            string randomLname = "";

            //queries for pulling from db, $ allows to insert variable
            string fnameQuery = $"SELECT name FROM Names WHERE nameType = 'fname' AND race = '{currentRace}'";
            string lnameQuery = $"SELECT name FROM Names WHERE nameType = 'lname' AND race = '{currentRace}'";

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                //query connection for first name
                using (SQLiteCommand command = new SQLiteCommand(fnameQuery, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("name"));

                            firstNameList.Add(name);
                        }
                    }
                }
                //query connection for last name
                using (SQLiteCommand command = new SQLiteCommand(lnameQuery, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("name"));

                            secondNameList.Add(name);
                        }
                    }
                }

                //checks to see if lists are empty jic users are dumb and click the button w/o a class
                if (firstNameList.Count == 0 || secondNameList.Count == 0)
                {
                    // message box to tell users to check their race selection >:(
                    MessageBox.Show("No names found? Make sure you have selected a race!");  
                    
                    //so it doesnt explode the damn program
                    return;  
                }

                //ints to store a randomly selected index              
                int fnameRngSelection = rng.Next(firstNameList.Count);
                int lnameRngSelection = rng.Next(secondNameList.Count);

                //storing the name selected
                randomFname = firstNameList[fnameRngSelection];
                randomLname = secondNameList[lnameRngSelection];
   
                //assigning the data
                FirstNameTxt.Text = randomFname;
                SecondNameTxt.Text = randomLname;

                conn.Close();
        
            }
        }

        
    }
}
