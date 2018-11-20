//Name: (Christian Loveridge)
//Class: (INFO 1200)
//Section: (001)
//Professor: (Bartholomew)
//Date: 11-10-2018
//Project #: Project8_B
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMyFitnessApp
{
    public partial class myBMR : Form
    {
        public myBMR()
        {
            InitializeComponent();
        }

        /**********************************************************/
        /** closeButton_Click: Event handler for the close button
        **/
        /** Preconditions: None
        **/
        /** Postconditions: Closes this form
        **/
        /** Parameters: object sender, EventArgs e
        **/
        /** Return: void
        **/
        /**********************************************************/
        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        /**********************************************************/
        /** calculateButton_Click: Event handler for the Calculate button
        **/
        /** Preconditions: None
        **/
        /** Postconditions: Opens the profile page, then calculates
         * the user's BMR based on their information on the profile form
        **/
        /** Parameters: object sender, EventArgs e
        **/
        /** Return: void
        **/
        /**********************************************************/
        private void calculateButton_Click(object sender, EventArgs e)
        {
            myProfileForm profile = new myProfileForm();
            profile.ShowDialog();

            // Constants for BMR calculation
            const double MALE_WEIGHT_MULT = 6.23;
            const double MALE_HEIGHT_MULT = 12.7;
            const double MALE_AGE_MULT = 6.8;
            const double MALE_BASE_VALUE = 66;

            const double FEMALE_WEIGHT_MULT = 4.35;
            const double FEMALE_HEIGHT_MULT = 4.7;
            const double FEMALE_AGE_MULT = 4.7;
            const double FEMALE_BASE_VALUE = 655;

            const double LITTLE_ACTIVITY_LEVEL_MULT = 1.2;
            const double LIGHT_ACTIVITY_LEVEL_MULT = 1.375;
            const double MODERATE_ACTIVITY_LEVEL_MULT = 1.55;
            const double HEAVY_ACTIVITY_LEVEL_MULT = 1.725;
            const double EXTREME_ACTIVITY_LEVEL_MULT = 1.9;

            // Grab the data from the profiles properties
            int weight = profile.Weight;
            int height = profile.Height;
            int age = profile.Age;

            double calculated_bmr = 0;
            double activity_multiplier = 0;

            // Calculate the MBR for MALE/FEMALE
            if (maleRadio.Checked)
            {
                calculated_bmr = (MALE_BASE_VALUE + (MALE_WEIGHT_MULT * weight) + (MALE_HEIGHT_MULT * height) - (MALE_AGE_MULT * age));
            }
            else
            {
                calculated_bmr = (FEMALE_BASE_VALUE + (FEMALE_WEIGHT_MULT * weight) + (FEMALE_HEIGHT_MULT * height) - (FEMALE_AGE_MULT * age));
            }

            switch (exerciseLevelListbox.SelectedIndex)
            {
                // Sets the exercise level multiplier based on the listbox selection
                case 0:
                    activity_multiplier = LITTLE_ACTIVITY_LEVEL_MULT;
                    break;
                case 1:
                    activity_multiplier = LIGHT_ACTIVITY_LEVEL_MULT;
                    break;
                case 2:
                    activity_multiplier = MODERATE_ACTIVITY_LEVEL_MULT;
                    break;
                case 3:
                    activity_multiplier = HEAVY_ACTIVITY_LEVEL_MULT;
                    break;
                case 4:
                    activity_multiplier = EXTREME_ACTIVITY_LEVEL_MULT;
                    break;
                default:
                    // If something goes wrong, it will result in a zero, so the user
                    // isn't getting bad information
                    activity_multiplier = 0;
                    break;
            }

            // Multiply the bmr by the activity multiplier
            calculated_bmr = (calculated_bmr * activity_multiplier);

            if (calculated_bmr > 0)
            {
                // Put the newly calculated BMR data in the labels
                bmrOutput.Text = calculated_bmr.ToString("0.00");
            }
            else
            {
                // Something went wrong with the listbox
                MessageBox.Show("There was an error with the activity level -- please select one of the 5 options; contact an administrator if this error persists.");
            }
        }
    }
}
