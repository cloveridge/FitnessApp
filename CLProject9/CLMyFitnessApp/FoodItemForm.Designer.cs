namespace CLMyFitnessApp
{
    partial class FoodItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.foodNameLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.servingsLabel = new System.Windows.Forms.Label();
            this.nutritionGroupBox = new System.Windows.Forms.GroupBox();
            this.totalFatLabel = new System.Windows.Forms.Label();
            this.totalCarbsLabel = new System.Windows.Forms.Label();
            this.totalSugarsLabel = new System.Windows.Forms.Label();
            this.totalProteinLabel = new System.Windows.Forms.Label();
            this.foodNameTextBox = new System.Windows.Forms.TextBox();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.servingsTextBox = new System.Windows.Forms.TextBox();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.carbsTextBox = new System.Windows.Forms.TextBox();
            this.sugarsTextBox = new System.Windows.Forms.TextBox();
            this.proteinTextBox = new System.Windows.Forms.TextBox();
            this.fatGramLabel = new System.Windows.Forms.Label();
            this.carbGramLabel = new System.Windows.Forms.Label();
            this.proteinGramLabel = new System.Windows.Forms.Label();
            this.sugarsGramLabel = new System.Windows.Forms.Label();
            this.foodChoicesLabel = new System.Windows.Forms.Label();
            this.foodChoicesListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.nutritionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodNameLabel
            // 
            this.foodNameLabel.AutoSize = true;
            this.foodNameLabel.Location = new System.Drawing.Point(34, 42);
            this.foodNameLabel.Name = "foodNameLabel";
            this.foodNameLabel.Size = new System.Drawing.Size(65, 13);
            this.foodNameLabel.TabIndex = 0;
            this.foodNameLabel.Text = "Food Name:";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Location = new System.Drawing.Point(34, 103);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(105, 13);
            this.caloriesLabel.TabIndex = 1;
            this.caloriesLabel.Text = "Calories Per Serving:";
            // 
            // servingsLabel
            // 
            this.servingsLabel.AutoSize = true;
            this.servingsLabel.Location = new System.Drawing.Point(34, 168);
            this.servingsLabel.Name = "servingsLabel";
            this.servingsLabel.Size = new System.Drawing.Size(51, 13);
            this.servingsLabel.TabIndex = 2;
            this.servingsLabel.Text = "Servings:";
            // 
            // nutritionGroupBox
            // 
            this.nutritionGroupBox.Controls.Add(this.proteinGramLabel);
            this.nutritionGroupBox.Controls.Add(this.sugarsGramLabel);
            this.nutritionGroupBox.Controls.Add(this.carbGramLabel);
            this.nutritionGroupBox.Controls.Add(this.fatGramLabel);
            this.nutritionGroupBox.Controls.Add(this.proteinTextBox);
            this.nutritionGroupBox.Controls.Add(this.sugarsTextBox);
            this.nutritionGroupBox.Controls.Add(this.carbsTextBox);
            this.nutritionGroupBox.Controls.Add(this.fatTextBox);
            this.nutritionGroupBox.Controls.Add(this.totalProteinLabel);
            this.nutritionGroupBox.Controls.Add(this.totalSugarsLabel);
            this.nutritionGroupBox.Controls.Add(this.totalCarbsLabel);
            this.nutritionGroupBox.Controls.Add(this.totalFatLabel);
            this.nutritionGroupBox.Location = new System.Drawing.Point(256, 42);
            this.nutritionGroupBox.Name = "nutritionGroupBox";
            this.nutritionGroupBox.Size = new System.Drawing.Size(203, 162);
            this.nutritionGroupBox.TabIndex = 3;
            this.nutritionGroupBox.TabStop = false;
            this.nutritionGroupBox.Text = "Nutritional Information";
            // 
            // totalFatLabel
            // 
            this.totalFatLabel.AutoSize = true;
            this.totalFatLabel.Location = new System.Drawing.Point(6, 31);
            this.totalFatLabel.Name = "totalFatLabel";
            this.totalFatLabel.Size = new System.Drawing.Size(52, 13);
            this.totalFatLabel.TabIndex = 0;
            this.totalFatLabel.Text = "Total Fat:";
            // 
            // totalCarbsLabel
            // 
            this.totalCarbsLabel.AutoSize = true;
            this.totalCarbsLabel.Location = new System.Drawing.Point(111, 31);
            this.totalCarbsLabel.Name = "totalCarbsLabel";
            this.totalCarbsLabel.Size = new System.Drawing.Size(64, 13);
            this.totalCarbsLabel.TabIndex = 1;
            this.totalCarbsLabel.Text = "Total Carbs:";
            // 
            // totalSugarsLabel
            // 
            this.totalSugarsLabel.AutoSize = true;
            this.totalSugarsLabel.Location = new System.Drawing.Point(6, 92);
            this.totalSugarsLabel.Name = "totalSugarsLabel";
            this.totalSugarsLabel.Size = new System.Drawing.Size(70, 13);
            this.totalSugarsLabel.TabIndex = 2;
            this.totalSugarsLabel.Text = "Total Sugars:";
            // 
            // totalProteinLabel
            // 
            this.totalProteinLabel.AutoSize = true;
            this.totalProteinLabel.Location = new System.Drawing.Point(111, 92);
            this.totalProteinLabel.Name = "totalProteinLabel";
            this.totalProteinLabel.Size = new System.Drawing.Size(70, 13);
            this.totalProteinLabel.TabIndex = 3;
            this.totalProteinLabel.Text = "Total Protein:";
            // 
            // foodNameTextBox
            // 
            this.foodNameTextBox.Location = new System.Drawing.Point(37, 58);
            this.foodNameTextBox.Name = "foodNameTextBox";
            this.foodNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.foodNameTextBox.TabIndex = 1;
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Location = new System.Drawing.Point(37, 119);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(170, 20);
            this.caloriesTextBox.TabIndex = 2;
            // 
            // servingsTextBox
            // 
            this.servingsTextBox.Location = new System.Drawing.Point(37, 184);
            this.servingsTextBox.Name = "servingsTextBox";
            this.servingsTextBox.Size = new System.Drawing.Size(170, 20);
            this.servingsTextBox.TabIndex = 3;
            // 
            // fatTextBox
            // 
            this.fatTextBox.Location = new System.Drawing.Point(9, 47);
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(67, 20);
            this.fatTextBox.TabIndex = 4;
            // 
            // carbsTextBox
            // 
            this.carbsTextBox.Location = new System.Drawing.Point(114, 47);
            this.carbsTextBox.Name = "carbsTextBox";
            this.carbsTextBox.Size = new System.Drawing.Size(67, 20);
            this.carbsTextBox.TabIndex = 5;
            // 
            // sugarsTextBox
            // 
            this.sugarsTextBox.Location = new System.Drawing.Point(9, 108);
            this.sugarsTextBox.Name = "sugarsTextBox";
            this.sugarsTextBox.Size = new System.Drawing.Size(67, 20);
            this.sugarsTextBox.TabIndex = 6;
            // 
            // proteinTextBox
            // 
            this.proteinTextBox.Location = new System.Drawing.Point(114, 108);
            this.proteinTextBox.Name = "proteinTextBox";
            this.proteinTextBox.Size = new System.Drawing.Size(67, 20);
            this.proteinTextBox.TabIndex = 7;
            // 
            // fatGramLabel
            // 
            this.fatGramLabel.AutoSize = true;
            this.fatGramLabel.Location = new System.Drawing.Point(76, 54);
            this.fatGramLabel.Name = "fatGramLabel";
            this.fatGramLabel.Size = new System.Drawing.Size(13, 13);
            this.fatGramLabel.TabIndex = 7;
            this.fatGramLabel.Text = "g";
            // 
            // carbGramLabel
            // 
            this.carbGramLabel.AutoSize = true;
            this.carbGramLabel.Location = new System.Drawing.Point(181, 54);
            this.carbGramLabel.Name = "carbGramLabel";
            this.carbGramLabel.Size = new System.Drawing.Size(13, 13);
            this.carbGramLabel.TabIndex = 11;
            this.carbGramLabel.Text = "g";
            // 
            // proteinGramLabel
            // 
            this.proteinGramLabel.AutoSize = true;
            this.proteinGramLabel.Location = new System.Drawing.Point(181, 115);
            this.proteinGramLabel.Name = "proteinGramLabel";
            this.proteinGramLabel.Size = new System.Drawing.Size(13, 13);
            this.proteinGramLabel.TabIndex = 13;
            this.proteinGramLabel.Text = "g";
            // 
            // sugarsGramLabel
            // 
            this.sugarsGramLabel.AutoSize = true;
            this.sugarsGramLabel.Location = new System.Drawing.Point(76, 115);
            this.sugarsGramLabel.Name = "sugarsGramLabel";
            this.sugarsGramLabel.Size = new System.Drawing.Size(13, 13);
            this.sugarsGramLabel.TabIndex = 12;
            this.sugarsGramLabel.Text = "g";
            // 
            // foodChoicesLabel
            // 
            this.foodChoicesLabel.AutoSize = true;
            this.foodChoicesLabel.Location = new System.Drawing.Point(34, 240);
            this.foodChoicesLabel.Name = "foodChoicesLabel";
            this.foodChoicesLabel.Size = new System.Drawing.Size(75, 13);
            this.foodChoicesLabel.TabIndex = 7;
            this.foodChoicesLabel.Text = "Food Choices:";
            // 
            // foodChoicesListBox
            // 
            this.foodChoicesListBox.FormattingEnabled = true;
            this.foodChoicesListBox.Location = new System.Drawing.Point(37, 257);
            this.foodChoicesListBox.Name = "foodChoicesListBox";
            this.foodChoicesListBox.Size = new System.Drawing.Size(422, 95);
            this.foodChoicesListBox.TabIndex = 8;
            this.foodChoicesListBox.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(172, 368);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(142, 37);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "&Add Food Item";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(384, 375);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // FoodItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 410);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.foodChoicesListBox);
            this.Controls.Add(this.foodChoicesLabel);
            this.Controls.Add(this.servingsTextBox);
            this.Controls.Add(this.caloriesTextBox);
            this.Controls.Add(this.foodNameTextBox);
            this.Controls.Add(this.nutritionGroupBox);
            this.Controls.Add(this.servingsLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.foodNameLabel);
            this.Name = "FoodItemForm";
            this.Text = "Food Items Form";
            this.nutritionGroupBox.ResumeLayout(false);
            this.nutritionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodNameLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label servingsLabel;
        private System.Windows.Forms.GroupBox nutritionGroupBox;
        private System.Windows.Forms.Label totalProteinLabel;
        private System.Windows.Forms.Label totalSugarsLabel;
        private System.Windows.Forms.Label totalCarbsLabel;
        private System.Windows.Forms.Label totalFatLabel;
        private System.Windows.Forms.Label proteinGramLabel;
        private System.Windows.Forms.Label sugarsGramLabel;
        private System.Windows.Forms.Label carbGramLabel;
        private System.Windows.Forms.Label fatGramLabel;
        private System.Windows.Forms.TextBox proteinTextBox;
        private System.Windows.Forms.TextBox sugarsTextBox;
        private System.Windows.Forms.TextBox carbsTextBox;
        private System.Windows.Forms.TextBox fatTextBox;
        private System.Windows.Forms.TextBox foodNameTextBox;
        private System.Windows.Forms.TextBox caloriesTextBox;
        private System.Windows.Forms.TextBox servingsTextBox;
        private System.Windows.Forms.Label foodChoicesLabel;
        private System.Windows.Forms.ListBox foodChoicesListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
    }
}