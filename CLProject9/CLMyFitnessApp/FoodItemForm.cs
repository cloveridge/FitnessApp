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
    public partial class FoodItemForm : Form
    {
        public FoodItemForm()
        {
            InitializeComponent();
        }


        /**********************************************************
         * Event Handler for closeButton_Click
         * Description: Validates all of the textboxes, then adds
         *              the data to the listbox
         * Parameters: object sender, EventArgs e
         * Return: None
        **********************************************************/
        private void addButton_Click(object sender, EventArgs e)
        {
            FoodItem addFood;
            // Try to create an instance with the textbox data
            try
            {
                // Extremely vague project instructions make it sound like this is what 
                //we're supposed to do -- try to create a loaded instance, and if it fails,
                // the CheckFood method will confirm it...Otherwise I don't understand why
                // we'd be passing the instance by value and not reference,
                // or creating it AFTER validating the data.

                // If this is wrong, then why are we creating multiple constructors?
                // Either way, this needs some serious revision.
                addFood = new FoodItem(
                    foodNameTextBox.Text,
                    int.Parse(caloriesTextBox.Text),
                    double.Parse(servingsTextBox.Text),
                    int.Parse(fatTextBox.Text),
                    int.Parse(carbsTextBox.Text),
                    int.Parse(sugarsTextBox.Text),
                    int.Parse(proteinTextBox.Text)
                    );
            }
            // If we fail, create a default object we can still pass
            catch(Exception exc)
            {
                addFood = new FoodItem();
            }

            // Then call the method to check the textboxes
            if(CheckFood(addFood))
            {
                // The method checks to see if the source of the parameters
                // is correct. If so, adds to the listbox.
                foodChoicesListBox.Items.Add(addFood.ToString(addFood));

                foodNameTextBox.Text = "";
                caloriesTextBox.Text = "";
                servingsTextBox.Text = "";
                fatTextBox.Text = "";
                carbsTextBox.Text = "";
                proteinTextBox.Text = "";
                sugarsTextBox.Text = "";

                foodNameTextBox.Focus();
            }
        }


        /**********************************************************
         * Event Handler for closeButton_Click
         * Description: Closes the form
         * Parameters: object sender, EventArgs e
         * Return: None
        **********************************************************/
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /**********************************************************
         * CheckFood Method
         * Description: Validates the data for each of the textboxes,
         *              returns true/false depending on whether or not
         *              the input data is correct. Failed values throw
         *              a warning to the user, clear the textbox, and 
         *              take focus.
         * Parameters: FoodItem food
         * Return: Bool checksOut
        **********************************************************/
        private bool CheckFood(FoodItem food)
        {
            // WHY ARE WE PASSING THIS BY VALUE IF VALIDATION HAPPENS AFTERWARD?
            //AS WELL, IF ALL WE'RE VALIDATING IS TEXTBOXES??
            bool checksOut = true;
            bool focusGiven = false;
            string errorMessage = "The following error(s) occurred, and the appropriate textboxes were cleared: ";

            int calories;
            double servings;
            int fat;
            int sugars;
            int carbs;
            int protein;
            
            
            // Make sure there's a valid foodname
            if(foodNameTextBox.Text == "")
            {
                // Otherwise, flag an error, add to the error message, clear the textbox, and provide focus
                checksOut = false;
                errorMessage += "\n\t-Food name cannot be blank.";

                //Give focus to the first wrong textbox only.
                if(!focusGiven)
                {
                    foodNameTextBox.Focus();
                    focusGiven = true;
                }
            }


            //Make sure there's a valid value in the calories textbox
            if(!int.TryParse(caloriesTextBox.Text, out calories) || calories <= 0)
            {
                // Otherwise, flag an error, add to the error message, clear the textbox, and provide focus
                checksOut = false;
                errorMessage += "\n\t-Calories are invalid.";
                caloriesTextBox.Text = "";

                //Give focus to the first wrong textbox only.
                if (!focusGiven)
                {
                    caloriesTextBox.Focus();
                    focusGiven = true;
                }
            }


            //Make sure there's a valid value in the servings textbox
            if (!double.TryParse(servingsTextBox.Text, out servings) || servings <= 0)
            {
                // Otherwise, flag an error, add to the error message, clear the textbox, and provide focus
                checksOut = false;
                errorMessage += "\n\t-Servings are invalid.";
                servingsTextBox.Text = "";

                //Give focus to the first wrong textbox only.
                if (!focusGiven)
                {
                    servingsTextBox.Focus();
                    focusGiven = true;
                }
            }


            //Make sure there's a valid value in the fat textbox
            if (!int.TryParse(fatTextBox.Text, out fat) || fat < 0)
            {
                // Otherwise, flag an error, add to the error message, clear the textbox, and provide focus
                checksOut = false;
                errorMessage += "\n\t-Fat value is invalid.";
                fatTextBox.Text = "";

                //Give focus to the first wrong textbox only.
                if (!focusGiven)
                {
                    fatTextBox.Focus();
                    focusGiven = true;
                }
            }


            //Make sure there's a valid value in the carbs textbox
            if (!int.TryParse(carbsTextBox.Text, out carbs) || carbs < 0)
            {
                // Otherwise, flag an error, add to the error message, clear the textbox, and provide focus
                checksOut = false;
                errorMessage += "\n\t-Carbs value is invalid.";
                carbsTextBox.Text = "";

                //Give focus to the first wrong textbox only.
                if (!focusGiven)
                {
                    carbsTextBox.Focus();
                    focusGiven = true;
                }
            }


            //Make sure there's a valid value in the sugars textbox
            if (!int.TryParse(sugarsTextBox.Text, out sugars) || sugars < 0)
            {
                // Otherwise, flag an error, add to the error message, clear the textbox, and provide focus
                checksOut = false;
                errorMessage += "\n\t-Sugars value is invalid.";
                sugarsTextBox.Text = "";

                //Give focus to the first wrong textbox only.
                if (!focusGiven)
                {
                    sugarsTextBox.Focus();
                    focusGiven = true;
                }
            }


            //Make sure there's a valid value in the protein textbox
            if (!int.TryParse(proteinTextBox.Text, out protein) || protein < 0)
            {
                // Otherwise, flag an error, add to the error message, clear the textbox, and provide focus
                checksOut = false;
                errorMessage += "\n\t-Protein value is invalid.";
                proteinTextBox.Text = "";

                //Give focus to the first wrong textbox only.
                if (!focusGiven)
                {
                    proteinTextBox.Focus();
                    focusGiven = true;
                }
            }


            // If there are any errors, display the errors. Textboxes have already been cleared, and focus given
            // to the first texbox with an issue.
            if (!checksOut)
            {
                MessageBox.Show(errorMessage);
            }

            return checksOut;
        }
    }
}
