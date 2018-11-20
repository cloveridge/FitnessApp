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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            //Generate form elements & set dateLabel's value to today's date
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString("d");
        }

        /**********************************************************/
        /** profileButton_Click: Event handler for the profile button
        **/
        /** Preconditions: None
        **/
        /** Postconditions: Displays the profile form
        **/
        /** Parameters: object sender, EventArgs e
        **/
        /** Return: void
        **/
        /**********************************************************/
        private void profileButton_Click(object sender, EventArgs e)
        {
            // Displays the profile of the user
            myProfileForm myprofile = new myProfileForm();
            // calls the form’s constructor. 
            // Must match the form name exactly
            myprofile.ShowDialog();
            //shows the form as a dialog
        }

        /**********************************************************/
        /** exitButton_Click: Event handler for the exit button
        **/
        /** Preconditions: None
        **/
        /** Postconditions: Closes the form, and stops the program
        **/
        /** Parameters: object sender, EventArgs e
        **/
        /** Return: void
        **/
        /**********************************************************/
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**********************************************************/
        /** bmrButton_Click: Event handler for the BMR button
        **/
        /** Preconditions: None
        **/
        /** Postconditions: Open the BMR form
        **/
        /** Parameters: object sender, EventArgs e
        **/
        /** Return: void
        **/
        /**********************************************************/
        private void bmrButton_Click(object sender, EventArgs e)
        {
            // Displays the profile of the user
            myBMR mybmr = new myBMR();
            // calls the form’s constructor. 
            // Must match the form name exactly
            mybmr.ShowDialog();
            //shows the form as a dialog
        }

        /**********************************************************/
        /** timerButton_Click: Event handler for the timer button
        **/
        /** Preconditions: None
        **/
        /** Postconditions: Open the timer form
        **/
        /** Parameters: object sender, EventArgs e
        **/
        /** Return: void
        **/
        /**********************************************************/
        private void timerButton_Click(object sender, EventArgs e)
        {
            MyTimer timerForm = new MyTimer();
            timerForm.Show();

        }

        /**********************************************************/
        /** exerciseLogButton_Click: Event handler for the Exercise Log button
        **/
        /** Preconditions: None
        **/
        /** Postconditions: Open the timer form
        **/
        /** Parameters: object sender, EventArgs e
        **/
        /** Return: void
        **/
        /**********************************************************/
        private void myExerciseLogButton_Click(object sender, EventArgs e)
        {
            exerciseLogForm exerciseLog = new exerciseLogForm();
            exerciseLog.Show();
        }

        /**********************************************************
        * waterButton_Click: Event handler for the Water button
        *
        * Preconditions: None
        *
        * Postconditions: Open the water form
        *
        * Parameters: object sender, EventArgs e
        *
        * Return: void
        *
        **********************************************************/
        private void waterButton_Click(object sender, EventArgs e)
        {
            myWaterForm waterLog = new myWaterForm();
            waterLog.Show();
        }
    }
}
