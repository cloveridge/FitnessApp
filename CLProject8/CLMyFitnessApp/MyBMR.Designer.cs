namespace CLMyFitnessApp
{
    partial class myBMR
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
            this.bmrLabel = new System.Windows.Forms.Label();
            this.bmrOutput = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exerciseLevelListbox = new System.Windows.Forms.ListBox();
            this.GenderGroupbox = new System.Windows.Forms.GroupBox();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.chooseAcitivityLabel = new System.Windows.Forms.Label();
            this.caloriesDescriptorLabel = new System.Windows.Forms.Label();
            this.GenderGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bmrLabel
            // 
            this.bmrLabel.Location = new System.Drawing.Point(189, 133);
            this.bmrLabel.Name = "bmrLabel";
            this.bmrLabel.Size = new System.Drawing.Size(56, 23);
            this.bmrLabel.TabIndex = 1;
            this.bmrLabel.Text = "My BMR:";
            this.bmrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bmrOutput
            // 
            this.bmrOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bmrOutput.Location = new System.Drawing.Point(189, 156);
            this.bmrOutput.Name = "bmrOutput";
            this.bmrOutput.Size = new System.Drawing.Size(80, 23);
            this.bmrOutput.TabIndex = 3;
            this.bmrOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(67, 178);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Clos&e";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(38, 133);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(124, 39);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "&Calculate BMR";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exerciseLevelListbox
            // 
            this.exerciseLevelListbox.FormattingEnabled = true;
            this.exerciseLevelListbox.Items.AddRange(new object[] {
            "Little to no exercise",
            "Light exercise (1-3 days per week)",
            "Moderate exercise (3-5 days per week)",
            "Heavy exercise (6-7 days per week)",
            "Very heavy exercise (twice per day)"});
            this.exerciseLevelListbox.Location = new System.Drawing.Point(38, 47);
            this.exerciseLevelListbox.Name = "exerciseLevelListbox";
            this.exerciseLevelListbox.Size = new System.Drawing.Size(195, 69);
            this.exerciseLevelListbox.TabIndex = 7;
            this.exerciseLevelListbox.SelectedIndex = 0;
            // 
            // GenderGroupbox
            // 
            this.GenderGroupbox.Controls.Add(this.femaleRadio);
            this.GenderGroupbox.Controls.Add(this.maleRadio);
            this.GenderGroupbox.Location = new System.Drawing.Point(248, 27);
            this.GenderGroupbox.Name = "GenderGroupbox";
            this.GenderGroupbox.Size = new System.Drawing.Size(101, 89);
            this.GenderGroupbox.TabIndex = 8;
            this.GenderGroupbox.TabStop = false;
            this.GenderGroupbox.Text = "Gender";
            // 
            // femaleRadio
            // 
            this.femaleRadio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.femaleRadio.Location = new System.Drawing.Point(23, 56);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(66, 17);
            this.femaleRadio.TabIndex = 1;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female:";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maleRadio.Checked = true;
            this.maleRadio.Location = new System.Drawing.Point(23, 25);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(66, 18);
            this.maleRadio.TabIndex = 0;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male:";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // chooseAcitivityLabel
            // 
            this.chooseAcitivityLabel.AutoSize = true;
            this.chooseAcitivityLabel.Location = new System.Drawing.Point(35, 27);
            this.chooseAcitivityLabel.Name = "chooseAcitivityLabel";
            this.chooseAcitivityLabel.Size = new System.Drawing.Size(127, 13);
            this.chooseAcitivityLabel.TabIndex = 9;
            this.chooseAcitivityLabel.Text = "Choose an Activity Level:";
            // 
            // caloriesDescriptorLabel
            // 
            this.caloriesDescriptorLabel.Location = new System.Drawing.Point(275, 156);
            this.caloriesDescriptorLabel.Name = "caloriesDescriptorLabel";
            this.caloriesDescriptorLabel.Size = new System.Drawing.Size(56, 23);
            this.caloriesDescriptorLabel.TabIndex = 10;
            this.caloriesDescriptorLabel.Text = "calories";
            this.caloriesDescriptorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // myBMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 208);
            this.Controls.Add(this.caloriesDescriptorLabel);
            this.Controls.Add(this.chooseAcitivityLabel);
            this.Controls.Add(this.GenderGroupbox);
            this.Controls.Add(this.exerciseLevelListbox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.bmrOutput);
            this.Controls.Add(this.bmrLabel);
            this.Name = "myBMR";
            this.Text = "Basal Metabolic Rate";
            this.GenderGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bmrLabel;
        private System.Windows.Forms.Label bmrOutput;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ListBox exerciseLevelListbox;
        private System.Windows.Forms.GroupBox GenderGroupbox;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.Label chooseAcitivityLabel;
        private System.Windows.Forms.Label caloriesDescriptorLabel;
    }
}