namespace CLMyFitnessApp
{
    partial class mainForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.dateLabelLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.bmrButton = new System.Windows.Forms.Button();
            this.timerButton = new System.Windows.Forms.Button();
            this.myExerciseLogButton = new System.Windows.Forms.Button();
            this.waterButton = new System.Windows.Forms.Button();
            this.foodItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.welcomeLabel.Location = new System.Drawing.Point(85, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(249, 31);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome Christian!";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(330, 121);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(12, 80);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(93, 29);
            this.profileButton.TabIndex = 3;
            this.profileButton.Text = "My &Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // dateLabelLabel
            // 
            this.dateLabelLabel.AutoSize = true;
            this.dateLabelLabel.Location = new System.Drawing.Point(100, 52);
            this.dateLabelLabel.Name = "dateLabelLabel";
            this.dateLabelLabel.Size = new System.Drawing.Size(50, 13);
            this.dateLabelLabel.TabIndex = 4;
            this.dateLabelLabel.Text = "Today is:";
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLabel.Location = new System.Drawing.Point(150, 52);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(100, 16);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "[Today]";
            // 
            // bmrButton
            // 
            this.bmrButton.Location = new System.Drawing.Point(111, 80);
            this.bmrButton.Name = "bmrButton";
            this.bmrButton.Size = new System.Drawing.Size(93, 29);
            this.bmrButton.TabIndex = 6;
            this.bmrButton.Text = "My &BMR";
            this.bmrButton.UseVisualStyleBackColor = true;
            this.bmrButton.Click += new System.EventHandler(this.bmrButton_Click);
            // 
            // timerButton
            // 
            this.timerButton.Location = new System.Drawing.Point(12, 115);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(93, 29);
            this.timerButton.TabIndex = 7;
            this.timerButton.Text = "My &Timer";
            this.timerButton.UseVisualStyleBackColor = true;
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // myExerciseLogButton
            // 
            this.myExerciseLogButton.Location = new System.Drawing.Point(111, 115);
            this.myExerciseLogButton.Name = "myExerciseLogButton";
            this.myExerciseLogButton.Size = new System.Drawing.Size(93, 29);
            this.myExerciseLogButton.TabIndex = 8;
            this.myExerciseLogButton.Text = "My E&xercise Log";
            this.myExerciseLogButton.UseVisualStyleBackColor = true;
            this.myExerciseLogButton.Click += new System.EventHandler(this.myExerciseLogButton_Click);
            // 
            // waterButton
            // 
            this.waterButton.Location = new System.Drawing.Point(210, 79);
            this.waterButton.Name = "waterButton";
            this.waterButton.Size = new System.Drawing.Size(93, 29);
            this.waterButton.TabIndex = 9;
            this.waterButton.Text = "My &Water";
            this.waterButton.UseVisualStyleBackColor = true;
            this.waterButton.Click += new System.EventHandler(this.waterButton_Click);
            // 
            // foodItemButton
            // 
            this.foodItemButton.Location = new System.Drawing.Point(210, 115);
            this.foodItemButton.Name = "foodItemButton";
            this.foodItemButton.Size = new System.Drawing.Size(93, 29);
            this.foodItemButton.TabIndex = 10;
            this.foodItemButton.Text = "My &Food Items";
            this.foodItemButton.UseVisualStyleBackColor = true;
            this.foodItemButton.Click += new System.EventHandler(this.foodItemButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 155);
            this.Controls.Add(this.foodItemButton);
            this.Controls.Add(this.waterButton);
            this.Controls.Add(this.myExerciseLogButton);
            this.Controls.Add(this.timerButton);
            this.Controls.Add(this.bmrButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateLabelLabel);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "mainForm";
            this.Text = "My Fitness App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Label dateLabelLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button bmrButton;
        private System.Windows.Forms.Button timerButton;
        private System.Windows.Forms.Button myExerciseLogButton;
        private System.Windows.Forms.Button waterButton;
        private System.Windows.Forms.Button foodItemButton;
    }
}

