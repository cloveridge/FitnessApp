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
using System.Threading;
using System.Media;

namespace CLMyFitnessApp
{
    public partial class MyTimer : Form
    {
        public MyTimer()
        {
            InitializeComponent();
        }

        /**********************************************************
        * exitButton_Click: Event handler for the exit button
        * Preconditions: None
        * Postconditions: Closes the form, and returns focus to the mainform
        * Parameters: object sender, EventArgs e
        * Return: void
        ***********************************************************/
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**********************************************************
        * startButton_Click: Event handler for the start button
        * Preconditions: User has gone through the "Setup" process and entered exercises
        * Operation: Runs a countdown timer for each item in the exercises listbox
        * Postconditions: None
        * TO-DO: Move error-handling from "Submit" to here, or add a flag -- users
        *       can technically use bad data and it will break if they
        *       hit "Start". "Submit" checks for errors, but it doesn't
        *       prevent this from running if it finds any (If it's run at all)
        * Parameters: object sender, EventArgs e
        * Return: void
        ***********************************************************/
        private void startButton_Click(object sender, EventArgs e)
        {
            // USEFUL RESOURCES PER INSTRUCTIONS:
            /**********************************************/
            // TimeSpan mytime = new TimeSpan(0, 0, time);
            // timeLabel.Text = mytime.ToString(@"mm\:ss");
            // Application.DoEvents();
            // Thread.Sleep(ONESECOND);
            // SystemSounds.Beep.Play();
            /**********************************************/

            const int COUNTDOWNNUM = 3;
            const int FIRSTBEEPNUM = 2;
            const int SECONDBEEPNUM = 1;
            const int LASTBEEPNUM = 0;
            const int ONESECOND = 1000; // one second, expressed in milliseconds
            const int FIRSTINDEX = 0;
            const int DEFAULTVALUE = 0;

            // "3...2...1...GO!" countdown loop
            for (int i = COUNTDOWNNUM; i > LASTBEEPNUM; i--)
            {
                timerLabel.Text = i.ToString();
                Application.DoEvents();
                SystemSounds.Beep.Play();
                Thread.Sleep(ONESECOND);
            }

            // Start & jingle to kick it off
            timerLabel.Text = "START!!";
            Application.DoEvents();
            SystemSounds.Hand.Play();
            Thread.Sleep(ONESECOND);


            // While loop, goes through the exercises
            int index = FIRSTINDEX;
            int interval = DEFAULTVALUE;
            bool takeRest = false;
            TimeSpan mytime = new TimeSpan(DEFAULTVALUE, DEFAULTVALUE, interval);

            while (index < exerciseListBox.Items.Count)
            {
                // flag for either looping an exercise or a rest period 
                // (Rest periods follow exercises)
                if(takeRest)
                {
                    // Code for the rest loop
                    timerActivityLabel.Text = "Rest";
                    interval = int.Parse(restIntervalTextBox.Text);
                    takeRest = false;

                    // Increment the index here -- this ensures that a rest is performed before
                    // moving on to the next exercise
                    index++;
                }
                else
                {
                    // Code for the exercise loop
                    timerActivityLabel.Text = exerciseListBox.Items[index].ToString();
                    interval = int.Parse(timeListBox.Items[index].ToString());
                    takeRest = true;
                }


                Application.DoEvents();

                // Inner For loop, for the actual timer
                //      Functions the same for exercises and rests
                //      just takes different inputs
                for (int i = interval; i >= DEFAULTVALUE; i--)
                {
                    // Timespan object for displaying the time
                    mytime = new TimeSpan(DEFAULTVALUE, DEFAULTVALUE, i);

                    // Display the time and update the application to see it
                    timerLabel.Text = mytime.ToString(@"mm\:ss");
                    Application.DoEvents();

                    // Beep on 2 & 1
                    if (i <= FIRSTBEEPNUM && i >= SECONDBEEPNUM)
                    {
                        SystemSounds.Beep.Play();
                    }
                    // Jingle on 0
                    else if (i == LASTBEEPNUM)
                    {
                        SystemSounds.Hand.Play();
                    }
                    // Rest for one second
                    Thread.Sleep(ONESECOND);
                }

                
            }
            Application.DoEvents();
            timerActivityLabel.Text = "Finished!";
            Application.DoEvents(); 
        }

        /**********************************************************
        * addExerciseButton_Click: Event handler for the Add Exercise button
        * Preconditions: Exercise and time have been entered in appropriate textboxes
        * Operation: adds items from exercise & time textboxes into the listboxes below
        * Postconditions: Listboxes are one item longer than before
        * Parameters: object sender, EventArgs e
        * Return: void
        ***********************************************************/
        private void addExerciseButton_Click(object sender, EventArgs e)
        {
            int timeValue = 0;

            // Verify there's a new exercise
            if (newExerciseTextBox.Text == "")
            {
                MessageBox.Show("Please add a new exercise in the textbox");
            }
            // Verify there's a new, valid time.
            else if (!int.TryParse(newTimeTextBox.Text, out timeValue) || timeValue < 1)
            {
                MessageBox.Show("Please add a valid number of seconds in the textbox, greater than 0");
                newTimeTextBox.Text = "";
                newTimeTextBox.Focus();
            }
            else
            {
                // Add to the respective listboxes
                exerciseListBox.Items.Add(newExerciseTextBox.Text);
                timeListBox.Items.Add(timeValue.ToString());

                // Clear the listboxes for the next entry
                newExerciseTextBox.Text = "";
                newTimeTextBox.Text = "";

                // Reset focus for next entry
                newExerciseTextBox.Focus();
            }
            
        }

        /**********************************************************
        * submitButton_Click: Event handler for the Submit button
        * Preconditions: At least one exercise has been entered, and the rest value is valid
        * Operation: checks fields for errors
        * TO-DO: See note on "Start Button", about adding a flag that requires this 
        *           check to run before the timer can run.
        * Postconditions: None <- This is the problem
        * Parameters: object sender, EventArgs e
        * Return: void
        ***********************************************************/
        private void submitButton_Click(object sender, EventArgs e)
        {
            int interval = 0;

            // Check to see if the exercise list is empty
            if(exerciseListBox.Items.Count == 0)
            {
                MessageBox.Show("Please enter an exercise in the \"New Exercise\" section");
                // Reset focus for next entry
                newExerciseTextBox.Focus();
            }
            // Check to see if the rest interval is valid
            else if (!int.TryParse(restIntervalTextBox.Text, out interval) || interval < 1)
            {
                MessageBox.Show("Please add a valid number of seconds in the \"Rest Interval\" textbox, greater than 0");
                // Reset & focus for next entry
                restIntervalTextBox.Text = "";
                restIntervalTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Timer ready, go ahead and start!");
                // TO-DO: Set a boolean property here so that the timer won't run until
                //          you've performed this step.
            }
        }

        /**********************************************************
        * submitButton_Click: Event handler for the Submit button
        * Preconditions: At least one exercise has been entered, and the rest value is valid
        * Operation: checks fields for errors
        * TO-DO: See note on "Start Button", about adding a flag that requires this 
        *           check to run before the timer can run.
        * Postconditions: None <- This is the problem
        * Parameters: object sender, EventArgs e
        * Return: void
        ***********************************************************/
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear all items in the setup portion
            newExerciseTextBox.Text = "";
            newTimeTextBox.Text = "";
            restIntervalTextBox.Text = "";
            timeListBox.Items.Clear();
            exerciseListBox.Items.Clear();

            // Clear all items in the timer portion
            /* Commented out until confirm that this should happen (I think it should)
            timerActivityLabel.Text = "";
            timerLabel.Text = "";
             */
        }
    }
}
