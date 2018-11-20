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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLMyFitnessApp
{
    public partial class myWaterForm : Form
    {
        // Number of glasses to display;
        private const int GLASSES_GOAL = 8;
        
        public myWaterForm()
        {
            InitializeComponent();
        }

        /**********************************************************
        * Load method for Form: 
        * 
        * Loads the method, then hides all water images, loads the text file for today
        * and then displays the correct number of water images
        * 
        * Parameters: None
        *
        * Return: void
        *
        **********************************************************/
        private void myWaterForm_Load(object sender, EventArgs e)
        {
            int water_count = 0;

            // Hide all of the water images
            HideWater();

            // Read in today's text file if it exists
            ReadWater(ref water_count);

            // Display the correct number of images
            ShowWater(water_count);
        }

        /**********************************************************
        * ReadWater: 
        * 
        * Pulls text file holding the current day's water goal
        * 
        * Parameters: None
        *
        * Return: void
        *
        **********************************************************/
        private void ReadWater(ref int water_count)
        {
            string filename = GetFileName();

            
            try
            {
                // Open a streamreader, and attempt to read in the data
                StreamReader fileReader = new StreamReader(filename);

                while (!fileReader.EndOfStream)
                {
                    // If successful, set the water label's text to the file contents
                    if(int.TryParse(fileReader.ReadLine(), out water_count) && water_count <= 8 && water_count >= 0)
                    {
                        waterLabel.Text = water_count.ToString();
                    }
                    // If not, let the user know.
                    else
                    {
                        MessageBox.Show("The file for today's water intake contains invalid data.");
                    }
                }

                fileReader.Close();
            }
            catch(Exception exc)
            {
               // If the file doesn't exist, warn the user and start the count at 0
                MessageBox.Show("No water was recorded yet for today.");
                waterLabel.Text = 0.ToString();
            }

        }

        /**********************************************************
        * WriteWater: 
        * 
        * Saves the current day's water goal in a text file
        * 
        * Parameters: None
        *
        * Return: void
        *
        **********************************************************/
        private void WriteWater(int daily_glasses)
        {
            // Attempt to save the number of glasses to the text file
            try
            {
                StreamWriter fileWriter = new StreamWriter(GetFileName());
                fileWriter.Write(daily_glasses);
                fileWriter.Close();
            }
            // If unsuccessful, let the user know.
            catch(Exception exc)
            {
                MessageBox.Show("Could not save file. " + exc.Message);
            }
        }

        /**********************************************************
        * closeButton_Click: Event handler for the Close button
        *
        * Preconditions: None
        *
        * Postconditions: Close the water form
        *
        * Parameters: object sender, EventArgs e
        *
        * Return: void
        *
        **********************************************************/
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**********************************************************
        * closeButton_Click: Event handler for the Close button
        *
        * Preconditions: None
        *
        * Postconditions: Close the water form
        *
        * Parameters: object sender, EventArgs e
        *
        * Return: void
        *
        **********************************************************/
        private void addWaterButton_Click(object sender, EventArgs e)
        {
            int total_glasses = 0;

            // Attempt to parse the water label's text, and check that it's less than the goal
            if (int.TryParse(waterLabel.Text, out total_glasses) && total_glasses < GLASSES_GOAL)
            {
                //Increment the glasses and store them in the label
                total_glasses++;
                waterLabel.Text = total_glasses.ToString();
            }

            // Save the number of glasses to the text file
            WriteWater(total_glasses);

            // Update the visible glasses
            ShowWater(total_glasses);
        }

        /**********************************************************
        * GetFileName:
        *
        * Parameters: None
        *
        * Return: string, a filename for today's water
        *
        **********************************************************/
        private string GetFileName()
        {
            // Generate a filename with today's date
            string today = DateTime.Now.ToString("d");
            today = today.Replace("/", "_");

            return today + "_water.txt";
        }

        /**********************************************************
        * HideWater: 
        * 
        * Hides all of the pictures of water glasses.
        * 
        * Parameters: None
        *
        * Return: void
        *
        **********************************************************/
        private void HideWater()
        {

            // Make all images hidden

            waterPicture1.Visible = false;
            waterPicture2.Visible = false;
            waterPicture3.Visible = false;
            waterPicture4.Visible = false;
            waterPicture5.Visible = false;
            waterPicture6.Visible = false;
            waterPicture7.Visible = false;
            waterPicture8.Visible = false;

        }
        
        /**********************************************************
        * ShowWater: 
        * 
        * Shows a representative number of water glasses.
        * 
        * Parameters: int glasses
        *
        * Return: void
        *
        **********************************************************/
        private void ShowWater(int glasses)
        {
            // Create a list of all of the images
            List<PictureBox> WaterGlasses = new List<PictureBox>
            {
                waterPicture1,
                waterPicture2,
                waterPicture3,
                waterPicture4,
                waterPicture5,
                waterPicture6,
                waterPicture7,
                waterPicture8
            };

            // Systematically unhide all glasses below the parameter amount
            for (int i = 0; i < WaterGlasses.Count; i++)
            {
                if (i < glasses)
                {
                    WaterGlasses[i].Visible = true;
                }
            }
            
        }
    }
}
