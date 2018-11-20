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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMyFitnessApp
{
    class FoodItem
    {
        //Private backing classes for the nutritional information
        private string _foodName;
        private int _calories;
        private double _servings;
        private int _totalFat;
        private int _totalCarbohydrates;
        private int _totalSugars;
        private int _totalProtein;


        /**********************************************
         * FoodItem default constructor
         * Description: Creates an instance of the FoodItem object
         *              with no values in the fields
         * Parameters: None
         * Returns: None
         * 
         * *******************************************/
        public FoodItem()
        {
            _foodName = "";
            _calories = 0;
            _servings = 0.0;
            _totalFat = 0;
            _totalCarbohydrates = 0;
            _totalSugars = 0;
            _totalProtein = 0;
        }


        /**********************************************
         * FoodItem Full constructor
         * Description: Creates an instance of the FoodItem object
         *              with values in all of the fields
         * Parameters: string foodName, int calories, double servings,
                        int totalFat, int totalCarbohydrates, int totalSugars,
                        int totalProtein 
         * Returns: None
         * 
         * *******************************************/
        public FoodItem(string foodName,
            int calories,
            double servings,
            int totalFat,
            int totalCarbohydrates,
            int totalSugars,
            int totalProtein)
        {
            _foodName = foodName;
            _calories = calories;
            _servings = servings;
            _totalFat = totalFat;
            _totalCarbohydrates = totalCarbohydrates;
            _totalSugars = totalSugars;
            _totalProtein = totalProtein;
        }


        /**********************************************
         * FoodItem.FoodName property
         * Description: The foodname property of the class -- this 
         *              retrieves and sets new values.
         * Parameters: None, but the property is set to a value. 
         * Returns: String representing the field
         * 
         * *******************************************/
        public string FoodName
        {
            get{return _foodName;}
            set{ _foodName = value;}
        }


        /**********************************************
         * FoodItem.Calories property
         * Description: The calories property of the class -- this 
         *              retrieves and sets new values.
         * Parameters: None, but the property is set to a value. 
         * Returns: Int representing the field
         * 
         * *******************************************/
        public int Calories
        {
            get{return _calories;}
            set{_calories = value;}
        }


        /**********************************************
         * FoodItem.Servings property
         * Description: The servings property of the class -- this 
         *              retrieves and sets new values.
         * Parameters: None, but the property is set to a value. 
         * Returns: Double representing the field
         * 
         * *******************************************/
        public double Servings
        {
            get{return _servings;}
            set{_servings = value;}
        }


        /**********************************************
         * FoodItem.TotalFat property
         * Description: The TotalFat property of the class -- this 
         *              retrieves and sets new values.
         * Parameters: None, but the property is set to a value. 
         * Returns: Int representing the field
         * 
         * *******************************************/
        public int TotalFat
        {
            get{return _totalFat;}
            set{_totalFat = value;}
        }


        /**********************************************
         * FoodItem.TotalCarbohydrates property
         * Description: The TotalCarbohydrates property of the class -- this 
         *              retrieves and sets new values.
         * Parameters: None, but the property is set to a value. 
         * Returns: Int representing the field
         * 
         * *******************************************/
        public int TotalCarbohydrates
        {
            get{return _totalCarbohydrates;}
            set{_totalCarbohydrates = value;}
        }


        /**********************************************
         * FoodItem.TotalSugars property
         * Description: The TotalSugars property of the class -- this 
         *              retrieves and sets new values.
         * Parameters: None, but the property is set to a value. 
         * Returns: Int representing the field
         * 
         * *******************************************/
        public int TotalSugars
        {
            get{return _totalSugars;}
            set{_totalSugars = value;}
        }

        /**********************************************
         * FoodItem.TotalProtein property
         * Description: The TotalProtein property of the class -- this 
         *              retrieves and sets new values.
         * Parameters: None, but the property is set to a value. 
         * Returns: Int representing the field
         * 
         * *******************************************/
        public int TotalProtein
        {
            get{return _totalProtein;}
            set{_totalProtein = value;}
        }

        /**********************************************
         * FoodItem.ToString instance method
         * Description: Returns the information about the FoodItem object in a 
         *              comma-separated string.
         * Parameters: Takes an instantiated FoodItem object
         * Returns: String representing all fields in object
         * 
         * *******************************************/
        public string ToString(FoodItem food)
        {
            string foodString;
            foodString = food._foodName + "," +
                        food._calories.ToString() + "," +
                        food._servings.ToString() + "," +
                        food._totalFat.ToString() + "," +
                        food._totalCarbohydrates.ToString() + "," +
                        food._totalSugars.ToString() + "," +
                        food._totalProtein.ToString();

            return foodString;
        }

    }
}
