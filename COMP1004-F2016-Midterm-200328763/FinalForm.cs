using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Midterm_200328763
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Fill out the text boxes with all the values from the character object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinalForm_Load(object sender, EventArgs e)
        {
            Character character = Program.character;

            // Populate text boxes with values from character object
            StrengthTextBox.Text = character.Strength;
            DexterityTextBox.Text = character.Dexterity;
            ConstitutionTextBox.Text = character.Constitution;
            IntelligenceTextBox.Text = character.Intelligence;
            WisdomTextBox.Text = character.Wisdom;
            CharismaTextBox.Text = character.Charisma;
            FirstNameTextBox.Text = character.FirstName;
            LastNameTextBox.Text = character.LastName;
            RaceTextBox.Text = character.Race;

            //Check which race is selected and display the appropriate image
            if (character.Race == "Human")
            {
                FinalFormPictureBox.Image = Properties.Resources.Human_Male;
            }
            else if (character.Race == "Elf")
            {
                FinalFormPictureBox.Image = Properties.Resources.Elf_Male;
            }
            else if (character.Race == "Dwarf")
            {
                FinalFormPictureBox.Image = Properties.Resources.Dwarf_Male;
            }
            else if (character.Race == "Halfling")
            {
                FinalFormPictureBox.Image = Properties.Resources.Halfling_Male;
            }
        }
    }
}
