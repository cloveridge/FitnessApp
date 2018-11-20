//Name: (Christian Loveridge)
//Class: (INFO 1200)
//Section: (001)
//Professor: (Bartholomew)
//Date: 11-19-2018
//Project #: Project9_B
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
    public partial class myProfileForm : Form
    {
        public int Weight { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }


        public myProfileForm()
        {
            InitializeComponent();
            // Fun stuff here!
        }

        /**********************************************************/
        /** closeButton_Click: Event handler for the close button
        **/
        /** Preconditions: None
        **/
        /** Postconditions: Closes the form, and save the user's profile 
         * information into global variables
        **/
        /** Parameters: object sender, EventArgs e
        **/
        /** Return: void
        **/
        /**********************************************************/
        private void closeButton_Click(object sender, EventArgs e)
        {
            int set_age = 0;
            int set_weight = 0;
            int set_height = 0;

            const int MIN_AGE = 12;
            const int MAX_AGE = 120;
            const int MIN_WEIGHT = 50;
            const int MAX_WEIGHT = 1000;
            const int MIN_HEIGHT = 48;
            const int MAX_HEIGHT = 96;

            // Save these global variables for use by the BMR
            // Use TryParse decision blocks to prevent bad input
            // If there is bad input, collect an error message for the user
            // to see which fields are bad and correct them.
            if (int.TryParse(ageTextBox.Text, out set_age) && set_age >= MIN_AGE && set_age <= MAX_AGE)
            {
                // Age is in correct format, set property to the "out" of the parse above
                Age = set_age;

                if (int.TryParse(heightTextBox.Text, out set_height) && set_height >= MIN_HEIGHT && set_height <= MAX_HEIGHT)
                {
                    // Height is in correct format, set property to the "out" of the parse above
                    Height = set_height;

                    if (int.TryParse(weightTextBox.Text, out set_weight) && set_weight >= MIN_WEIGHT && set_weight <= MAX_WEIGHT)
                    {
                        // Weight is in correct format, set property to the "out" of the parse above
                        Weight = set_weight;

                        // Everything is set, close the form
                        this.Close();
                    }
                    else
                    {
                        // WeightBox wasn't in the proper format
                        MessageBox.Show("Weight must be an integer in the range of " + MIN_WEIGHT + " - " + MAX_WEIGHT);
                        weightTextBox.Focus();
                        weightTextBox.SelectAll();
                    }
                }
                else
                {
                    // HeightBox wasn't in the proper format
                    MessageBox.Show("Height must be an integer in the range of " + MIN_HEIGHT + " - " + MAX_HEIGHT);
                    heightTextBox.Focus();
                    heightTextBox.SelectAll();
                }
            }
            else
            {
                // AgeBox wasn't in the proper format
                MessageBox.Show("Age must be an integer in the range of " + MIN_AGE + " - " + MAX_AGE);
                ageTextBox.Focus();
                ageTextBox.SelectAll();
            }
        }

        /**********************************************************/
        /** beforeButton_Click: Event handler for the before button
        **/
        /** Preconditions: None
        **/
        /** Postconditions: Makes the beforePictureBox visible, and
         * the afterPictureBox invisible
        **/
        /** Parameters: object sender, EventArgs e
        **/
        /** Return: void
        **/
        /**********************************************************/
        private void beforeButton_Click(object sender, EventArgs e)
        {
            beforePictureBox.Visible = true;
            afterPictureBox.Visible = false;
        }

        /**********************************************************/
        /** afterButton_Click: Event handler for the after button
        **/
        /** Preconditions: None
        **/
        /** Postconditions: Makes the beforePictureBox invisible, and
         * the afterPictureBox visible, and displays a congratulatory
         * message
        **/
        /** Parameters: object sender, EventArgs e
        **/
        /** Return: void
        **/
        /**********************************************************/
        private void afterButton_Click(object sender, EventArgs e)
        {
            // Change the visibility of the before and after pictures, 
            // then show a congratulatory message.
            afterPictureBox.Visible = true;
            beforePictureBox.Visible = false;
            MessageBox.Show("Congratulations on losing 35 pounds this summer!");
        }

        /**********************************************************
        * clearAllButton_Click: Event handler for the Clear All button
        *
        * Preconditions: None
        *
        * Postconditions: Clears all textboxes on the form.
        *
        * Parameters: object sender, EventArgs e
        *
        * Return: void
        *
        **********************************************************/
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            firstNameTextbox.Text = "";
            lastNameTextbox.Text = "";
            preferredNameTextbox.Text = "";
            heightTextBox.Text = "";
            weightTextBox.Text = "";
            ageTextBox.Text = "";

            this.Weight = 0;
            this.Age = 0;
            this.Height = 0;
            this.DialogResult = DialogResult.None;
        }
    }
}
