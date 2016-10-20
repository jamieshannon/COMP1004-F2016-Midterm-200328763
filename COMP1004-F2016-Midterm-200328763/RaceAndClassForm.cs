using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Midterm_200328763
{
    public partial class RaceAndClassForm : Form
    {
        public AbilityGeneratorForm previousForm;
        private string _selectedRace = "Human";


        public RaceAndClassForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = this._selectedRace;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }

        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;

            if (HumanRadioButton.Checked == true)
            {
                RacePictureBox.Image = Properties.Resources.Human_Male;
            }
            else if (ElfRadioButton.Checked == true)
            {
                RacePictureBox.Image = Properties.Resources.Elf_Male;
            }
            else if (DwarfRadioButton.Checked == true)
            {
                RacePictureBox.Image = Properties.Resources.Dwarf_Male;
            }
            else if (HalflingRadioButton.Checked == true)
            {
                RacePictureBox.Image = Properties.Resources.Halfling_Male;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = this._selectedRace;

            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;

            finalForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Determines which image should be displayed on form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RaceAndClassForm_Load(object sender, EventArgs e)
        {
            Character character = Program.character;
            //if there is no race assigned, set the image to human
            if (character.Race == null)
            {
                RacePictureBox.Image = Properties.Resources.Human_Male;
            }
            else
            {
                //Check which race is selected and display the appropriate image
                if (character.Race == "Human")
                {
                    RacePictureBox.Image = Properties.Resources.Human_Male;
                }
                else if (character.Race == "Elf")
                {
                    RacePictureBox.Image = Properties.Resources.Elf_Male;
                }
                else if (character.Race == "Dwarf")
                {
                    RacePictureBox.Image = Properties.Resources.Dwarf_Male;
                }
                else if (character.Race == "Halfling")
                {
                    RacePictureBox.Image = Properties.Resources.Halfling_Male;
                }
            }
        }
    }
}
