using System;


namespace CLMyFitnessApp
{
    partial class exerciseLogForm
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
            this.openFileDialogExerciseLog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogExerciseLog = new System.Windows.Forms.SaveFileDialog();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.addExerciseButton = new System.Windows.Forms.Button();
            this.exerciseLabel = new System.Windows.Forms.Label();
            this.exerciseTextbox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.exerciseListLabel = new System.Windows.Forms.Label();
            this.exerciseLogListBox = new System.Windows.Forms.ListBox();
            this.saveExerciseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialogExerciseLog
            // 
            this.openFileDialogExerciseLog.FileName = "openFileDialog1";
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.Location = new System.Drawing.Point(13, 13);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(84, 18);
            this.currentDateLabel.TabIndex = 0;
            this.currentDateLabel.Text = "10/27/2018";
            // 
            // addExerciseButton
            // 
            this.addExerciseButton.Location = new System.Drawing.Point(276, 13);
            this.addExerciseButton.Name = "addExerciseButton";
            this.addExerciseButton.Size = new System.Drawing.Size(128, 35);
            this.addExerciseButton.TabIndex = 1;
            this.addExerciseButton.Text = "Add Exercise";
            this.addExerciseButton.UseVisualStyleBackColor = true;
            this.addExerciseButton.Click += new System.EventHandler(this.addExerciseButton_Click);
            // 
            // exerciseLabel
            // 
            this.exerciseLabel.Location = new System.Drawing.Point(13, 58);
            this.exerciseLabel.Name = "exerciseLabel";
            this.exerciseLabel.Size = new System.Drawing.Size(180, 13);
            this.exerciseLabel.TabIndex = 2;
            this.exerciseLabel.Text = "Exercise";
            this.exerciseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exerciseTextbox
            // 
            this.exerciseTextbox.Location = new System.Drawing.Point(12, 74);
            this.exerciseTextbox.Name = "exerciseTextbox";
            this.exerciseTextbox.Size = new System.Drawing.Size(181, 20);
            this.exerciseTextbox.TabIndex = 3;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(199, 74);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 20);
            this.durationTextBox.TabIndex = 5;
            // 
            // durationLabel
            // 
            this.durationLabel.Location = new System.Drawing.Point(200, 58);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(99, 13);
            this.durationLabel.TabIndex = 4;
            this.durationLabel.Text = "Duration (min)";
            this.durationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Location = new System.Drawing.Point(304, 74);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.caloriesTextBox.TabIndex = 7;
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.Location = new System.Drawing.Point(305, 58);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(99, 13);
            this.caloriesLabel.TabIndex = 6;
            this.caloriesLabel.Text = "Calories";
            this.caloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exerciseListLabel
            // 
            this.exerciseListLabel.Location = new System.Drawing.Point(9, 121);
            this.exerciseListLabel.Name = "exerciseListLabel";
            this.exerciseListLabel.Size = new System.Drawing.Size(101, 13);
            this.exerciseListLabel.TabIndex = 8;
            this.exerciseListLabel.Text = "My Exercise Log";
            this.exerciseListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exerciseLogListBox
            // 
            this.exerciseLogListBox.FormattingEnabled = true;
            this.exerciseLogListBox.Location = new System.Drawing.Point(12, 137);
            this.exerciseLogListBox.Name = "exerciseLogListBox";
            this.exerciseLogListBox.Size = new System.Drawing.Size(392, 108);
            this.exerciseLogListBox.TabIndex = 9;
            // 
            // saveExerciseButton
            // 
            this.saveExerciseButton.Location = new System.Drawing.Point(12, 266);
            this.saveExerciseButton.Name = "saveExerciseButton";
            this.saveExerciseButton.Size = new System.Drawing.Size(128, 40);
            this.saveExerciseButton.TabIndex = 10;
            this.saveExerciseButton.Text = "Save Exercise";
            this.saveExerciseButton.UseVisualStyleBackColor = true;
            this.saveExerciseButton.Click += new System.EventHandler(this.saveExerciseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(276, 275);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(128, 23);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // exerciseLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 319);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveExerciseButton);
            this.Controls.Add(this.exerciseLogListBox);
            this.Controls.Add(this.exerciseListLabel);
            this.Controls.Add(this.caloriesTextBox);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.exerciseTextbox);
            this.Controls.Add(this.exerciseLabel);
            this.Controls.Add(this.addExerciseButton);
            this.Controls.Add(this.currentDateLabel);
            this.Name = "exerciseLogForm";
            this.Text = "My Exercise Log";
            this.Load += new System.EventHandler(this.exerciseLogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogExerciseLog;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExerciseLog;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Button addExerciseButton;
        private System.Windows.Forms.Label exerciseLabel;
        private System.Windows.Forms.TextBox exerciseTextbox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox caloriesTextBox;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label exerciseListLabel;
        private System.Windows.Forms.ListBox exerciseLogListBox;
        private System.Windows.Forms.Button saveExerciseButton;
        private System.Windows.Forms.Button closeButton;
    }
}