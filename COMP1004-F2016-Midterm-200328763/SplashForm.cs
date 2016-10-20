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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the next form and hides this form after the timer finishes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            //hide the splash form
            this.Hide();

            //create an object for the next form
            GenerateNameForm generateNameForm = new GenerateNameForm();

            //add property in next form to point to this form

            //point this form to the parent form
            generateNameForm.previousForm = this;

            //show the next form
            generateNameForm.Show();

            //disable the timer event
            SplashFormTimer.Enabled = false;
        }
    }
}
