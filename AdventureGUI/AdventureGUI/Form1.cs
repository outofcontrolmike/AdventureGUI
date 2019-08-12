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
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbxAge.Enabled = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
          string name = txtbxName.Text;

            txtArea.Text = "Hello, " + name + "!";
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Controls age textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxAge.Enabled = true;
           if(cmboBxRace.Text == "Human")
            {
                
                txtbxAge.Text = "Enter between 15-70";
            }
           if(cmboBxRace.Text == "Elf")
            {
                txtbxAge.Text = "Enter between 300-700";
            }
           if(cmboBxRace.Text == "Dwarf")
            {
                txtbxAge.Text = "Enter between 100-300";
            }
           if(cmboBxRace.Text == "Hobbit")
            {
                txtbxAge.Text = "Enter between 22-90";
            }
            
        }// end Age

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtbxName.Clear();
            txtArea.Text = "You reset the character build.  Choose Wisley";
            
            cmboBxClass.SelectedIndex = -1;
            cmboBxRace.SelectedIndex = -1;
            txtbxAge.Text = "";
            txtbxAge.Enabled = false;

        }

        private void CmboBxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmboBxClass.Text == "Warrior")
            {

            }
        }
    }
}
