using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Console;

namespace AdventureGUI
{


    public partial class Form1 : Form
    {


         Weapon wStWeapon = new Weapon();
        private static Armor wStArmor = new Armor();
        private static Items startingItem = new Items();

        private static MagicSpell mageSpell = new MagicSpell();
        private static MagicSpell cure = new MagicSpell();

        CharacterSheet playerSheet = new CharacterSheet();


        public Form1()
        {
            InitializeComponent();

         
        }

        /// <summary>
        /// What happens when form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
   
            cmboBxClass.Enabled = false;
            btnSubmit.Enabled = false;
            cmboBxRace.Enabled = false;
            tbAge.Enabled = false;
            btnView.Enabled = false;
        }

        /// <summary>
        /// This Binds the name and Text area together for fun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
          string name = txtbxName.Text;

            txtArea.Text = "Hello, " + name + "!";
            playerSheet.Name = name;
            cmboBxRace.Enabled = true;

            if( name == "")
            {
                cmboBxRace.Enabled = false;
            }
        }

        /// <summary>
        /// Action event for submit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            
            txtbxName.Enabled = false;
            cmboBxClass.Enabled = false;
            cmboBxRace.Enabled = false;
            btnSubmit.Enabled = false;
            tbAge.Enabled = false;
            btnView.Enabled = true;
            

            if (cmboBxClass.Text == "Warrior")
            {
                btnSubmit.Enabled = true;
                string charclass = cmboBxClass.Text;

                playerSheet.CharClass = charclass;


                wStWeapon.Wname = "Broad Sword";
                wStWeapon.AttackPower = 20;
                wStWeapon.WDescription = "A nice broadsword to slay with";
                wStWeapon.Gvalue = 20;

                wStArmor.ArmorName = "Chain Mail";
                wStArmor.ArmorDefense = 10;
                wStArmor.ArmorDesc = "A specially crafteed suit of chain mail, passed on down by the warriors father";
                wStArmor.GoldValue = 100;

                // settings variables
                // 80 points

                int strength = 18;
                int dexterity = 14;
                int intelligence = 10;
                int wisdom = 9;
                int charisma = 14;
                int constitution = 15;


                playerSheet.CharClass = cmboBxClass.SelectedText;
                playerSheet.Age = Convert.ToInt32(tbAge.Value);
                playerSheet.Level = 1;
                playerSheet.Experience = 0;
                playerSheet.NextLevel = 1000;
                playerSheet.Strength = strength;
                playerSheet.Dexterity = dexterity;
                playerSheet.Intelligence = intelligence;
                playerSheet.Constitution = constitution;
                playerSheet.Wisdom = wisdom;
                playerSheet.Charisma = charisma;
                playerSheet.EquipedWeapon = wStWeapon.Wname;
                playerSheet.EquipedArmor = wStArmor.ArmorName;
                playerSheet.Gold = charisma * 100;
                playerSheet.Health = Convert.ToInt32(Math.Ceiling(8.2 * constitution));
                playerSheet.TempHealth = playerSheet.Health;
                playerSheet.MagicPoints = Convert.ToInt32(Math.Ceiling(3.5 * wisdom));
                playerSheet.TempMana = playerSheet.MagicPoints;
                playerSheet.AttackPower = Convert.ToInt32(Math.Ceiling(5.2 * strength) + wStWeapon.AttackPower);
                playerSheet.Defense = Convert.ToInt32(Math.Ceiling(2.1 * dexterity) + wStArmor.ArmorDefense);
                playerSheet.MagicPower = Convert.ToInt32(Math.Ceiling(1.5 * intelligence));


                string charClass = cmboBxClass.Text;
                playerSheet.CharClass = charClass;

                //Text Area Like a to string
                txtArea.Text = "Name: " + playerSheet.Name +
                              "\nRace: " + playerSheet.Race +
                              "\nClass: " + playerSheet.CharClass +
                              "\nAge: " + playerSheet.Age +
                              "\nLevel: " + playerSheet.Level + "Experience: " + playerSheet.Experience +
                               "\nNext Level: " + playerSheet.NextLevel +
                               "\nGold : " + playerSheet.Gold +
                               "\nHealth: " + playerSheet.TempHealth + "/" + playerSheet.Health +
                               "\nMana: " + playerSheet.MagicPoints + "/" + playerSheet.TempMana +
                               "\n\nAttack Power: " + playerSheet.AttackPower +
                               "\nMagic Attack: " + playerSheet.MagicPower +
                               "\nDefense: " + playerSheet.Defense +
                               "\n\nStrength: " + playerSheet.Strength +
                               "\nDexterity: " + playerSheet.Dexterity +
                               "\nIntelligence: " + playerSheet.Intelligence +
                               "\nWisdom: " + playerSheet.Wisdom +
                               "\nConstitution: " + playerSheet.Constitution +
                               "\nCharisma: " + playerSheet.Charisma +
                               "\n\nWeapon Equiped " + playerSheet.EquipedWeapon +
                               "\nArmor Equiped " + playerSheet.EquipedArmor;

            }// End Warrior
           

        }

        
        /// <summary>
        /// Controls age textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            tbAge.Enabled = true;
           if(cmboBxRace.Text == "Human")
            {
                tbAge.SetRange(15, 70);
                lblAgeReq.Text = "Enter between 15-70";
            }
           if(cmboBxRace.Text == "Elf")
            {
                tbAge.SetRange(300, 700);
                lblAgeReq.Text = "Enter between 300-700";
            }
           if(cmboBxRace.Text == "Dwarf")
            {
                tbAge.SetRange(100, 300);
                lblAgeReq.Text = "Enter between 100-300";
            }
           if(cmboBxRace.Text == "Hobbit")
            {
                tbAge.SetRange(22, 90);
                lblAgeReq.Text = "Enter between 22-90";
            }

            string race = cmboBxRace.Text;
            playerSheet.Race = race;
        }// end Age

        /// <summary>
        ///handles what happens in age textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
          if(tbAge.Text != "")
            {
                cmboBxClass.Enabled = true;
            }
        }

        /// <summary>
        /// Action event for resetting the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtbxName.Clear();
            txtArea.Text = "You reset the character build.  Choose Wisley";
            
            cmboBxClass.SelectedIndex = -1;
            cmboBxRace.SelectedIndex = -1;
            tbAge.Text = "";
           

            tbAge.Enabled = false;
            cmboBxClass.Enabled = false;
            btnSubmit.Enabled = false;
            lblAgeReq.Text = "Age Limit";
            txtbxName.Enabled = true;
            lblAgeSlide.Text = "Age Meter";
            btnView.Enabled = false;

        }

        /// <summary>
        /// Action event for Selected index of Character Class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmboBxClass_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnSubmit.Enabled = true;

        }//end combo box for race


        private static void GetAge()
        {
         
        }
        /// <summary>
        /// Get's Equipment Details 
        /// </summary>
      

      

        private void TbAge_Scroll(object sender, EventArgs e)
        {
            lblAgeSlide.Text = Convert.ToString(tbAge.Value);
            cmboBxClass.Enabled = true;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            txtArea.Clear();

            txtArea.Text = "Weapon Name: " + wStWeapon.Wname +
                "\nAttack Power: " + wStWeapon.AttackPower +
                "\nGold Value: " + wStWeapon.Gvalue +
                "\nDescription: " + wStWeapon.WDescription;

            // Work on Armor
        }
    }// End GetEquipment
    }
