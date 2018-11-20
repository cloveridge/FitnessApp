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
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMyFitnessApp
{
    public partial class exerciseLogForm : Form
    {
        public string currentfile;

        public exerciseLogForm()
        {
            InitializeComponent();
        }

        /**********************************************************
        * ResetForm: Method for clearing the form
        * Preconditions: None
        * Postconditions: Clears the input fields and resets focus
        * Parameters: None
        * Return: void
        **********************************************************/
        private void ResetForm()
        {
            exerciseTextbox.Text = "";
            durationTextBox.Text = "";
            caloriesTextBox.Text = "";
            exerciseTextbox.Focus();
        }

        /**********************************************************/
        /** addExerciseButton_Click: Event handler for the addExercise button
        **/
        /** Preconditions: None
        **/
        /** Postconditions: Adds new exercise to the list
        **/
        /** Parameters: object sender, EventArgs e
        **/
        /** Return: void
        **/
        /**********************************************************/
        private void addExerciseButton_Click(object sender, EventArgs e)
        {
            // Verify no textboxes are blank
            if (exerciseTextbox.Text != "")
            {
                if (durationTextBox.Text != "")
                {
                    if (caloriesTextBox.Text != "")
                    {
                        // Add the information in textboxes to the listbox
                        string exerciseLog = currentDateLabel.Text + "," + exerciseTextbox.Text + "," + durationTextBox.Text + "," + caloriesTextBox.Text;
                        exerciseLogListBox.Items.Add(exerciseLog);
                    }
                    else
                    {
                        MessageBox.Show("Calories Textbox cannot be blank.");
                    }
                }
                else
                {
                    MessageBox.Show("Duration Textbox cannot be blank.");
                }
            }
            else
            {
                MessageBox.Show("Exercise Textbox cannot be blank.");
            }

            // 7.2.b If any of the fields are blank, or if it's successful, clear the fields and reset focus
            ResetForm();
        }

        /**********************************************************/
        /** saveExerciseButton_Click: Event handler for the saveExercise button
        **/
        /** Preconditions: None
        **/
        /** Postconditions: Saves exercises to text fle
        **/
        /** Parameters: object sender, EventArgs e
        **/
        /** Return: void
        **/
        /**********************************************************/
        private void saveExerciseButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile;
         
            try
            {
                //Save file to the one already loaded
                if(currentfile != "")
                {
                    outputfile = File.CreateText(currentfile);

                    for (int i = 0; i < exerciseLogListBox.Items.Count; i++)
                    {
                        outputfile.WriteLine(exerciseLogListBox.Items[i]);
                    }

                    outputfile.Close();
                }
                else
                {
                    // Save file to new file using dialog
                    if(saveFileDialogExerciseLog.ShowDialog() == DialogResult.OK)
                    {
                        outputfile = File.CreateText(saveFileDialogExerciseLog.FileName);
                        currentfile = saveFileDialogExerciseLog.FileName;
                        for (int i = 0; i < exerciseLogListBox.Items.Count; i++)
                        {
                            outputfile.WriteLine(exerciseLogListBox.Items[i]);
                        }
                        outputfile.Close();
                    }
                    else
                    {
                        // Error if user clicks "cancel"
                        MessageBox.Show("File not saved - You must select a file to save.");
                    }
                }

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message + "There was an error saving the file.");
            }
        }

        /**********************************************************/
        /** closeButton_Click: Event handler for the profile button
        **/
        /** Preconditions: None
        **/
        /** Postconditions: Closes the form
        **/
        /** Parameters: object sender, EventArgs e
        **/
        /** Return: void
        **/
        /**********************************************************/
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**********************************************************
        * exerciseLogForm_Load: Event handler for loading the form
        *
        * Preconditions: None
        *
        * Postconditions: Sets date at top, reads a file chosen by user,
         * and fills the Listbox with entries
        *
        * Parameters: object sender, EventArgs e
        *
        * Return: void
        *
        **********************************************************/
        private void exerciseLogForm_Load(object sender, EventArgs e)
        {
            // 1. Today's date at the top of form
            currentDateLabel.Text = DateTime.Now.ToString("MM/dd/yyy");

            // 2. Create a StreamReader inputfile object to read an exercise log from a text file.
            StreamReader inputfile;

            // 3. Set the currentfile to be the empty string.
            currentfile = "";

            // 4. Clear the items in the exerciseLogListBox.
            exerciseLogListBox.Items.Clear();

            // 5. Use a try-catch block to handle any file errors and error messages.
            try
            {
                // 6.a. Use openFileDialog to select a file
                if (openFileDialogExerciseLog.ShowDialog() == DialogResult.OK)
                {
                    // Open the file
                    inputfile = File.OpenText(openFileDialogExerciseLog.FileName);

                    // 6.b. Set the currentFile field to the filename
                    currentfile = openFileDialogExerciseLog.FileName;

                    // 6.c. loop through file, read text, add to exerciseLogListBox
                    while (!inputfile.EndOfStream)
                    {
                        // Add each line to the Listbox
                        exerciseLogListBox.Items.Add(inputfile.ReadLine());
                    }

                    // 6.d. Close inputFile
                    inputfile.Close();

                }
                else
                {
                    // Let user know that they cancelled the file selection
                    MessageBox.Show("'Operation: Choose File' cancelled by user.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + " - Error loading file.");
            }

        }
    }
}
