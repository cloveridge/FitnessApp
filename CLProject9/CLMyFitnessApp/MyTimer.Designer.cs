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


namespace CLMyFitnessApp
{
    partial class MyTimer
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
            this.exitButton = new System.Windows.Forms.Button();
            this.timerGroupBox = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerActivityLabel = new System.Windows.Forms.Label();
            this.timerGroupLabel = new System.Windows.Forms.Label();
            this.setupGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.restIntervalTextBox = new System.Windows.Forms.TextBox();
            this.intervalRestLabel = new System.Windows.Forms.Label();
            this.timeListBox = new System.Windows.Forms.ListBox();
            this.exerciseListBox = new System.Windows.Forms.ListBox();
            this.timeListLabel = new System.Windows.Forms.Label();
            this.exerciseListLabel = new System.Windows.Forms.Label();
            this.addExerciseButton = new System.Windows.Forms.Button();
            this.newTimeTextBox = new System.Windows.Forms.TextBox();
            this.newTimeLabel = new System.Windows.Forms.Label();
            this.newExerciseTextBox = new System.Windows.Forms.TextBox();
            this.enterExerciseLabel = new System.Windows.Forms.Label();
            this.setupGroupLabel = new System.Windows.Forms.Label();
            this.timerGroupBox.SuspendLayout();
            this.setupGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(136, 218);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 43);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // timerGroupBox
            // 
            this.timerGroupBox.Controls.Add(this.startButton);
            this.timerGroupBox.Controls.Add(this.timerLabel);
            this.timerGroupBox.Controls.Add(this.exitButton);
            this.timerGroupBox.Controls.Add(this.timerActivityLabel);
            this.timerGroupBox.Controls.Add(this.timerGroupLabel);
            this.timerGroupBox.Location = new System.Drawing.Point(13, 13);
            this.timerGroupBox.Name = "timerGroupBox";
            this.timerGroupBox.Size = new System.Drawing.Size(256, 284);
            this.timerGroupBox.TabIndex = 1;
            this.timerGroupBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(28, 218);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 43);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "&Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(24, 131);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(208, 57);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerActivityLabel
            // 
            this.timerActivityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerActivityLabel.Location = new System.Drawing.Point(24, 70);
            this.timerActivityLabel.Name = "timerActivityLabel";
            this.timerActivityLabel.Size = new System.Drawing.Size(208, 40);
            this.timerActivityLabel.TabIndex = 1;
            this.timerActivityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerGroupLabel
            // 
            this.timerGroupLabel.AutoSize = true;
            this.timerGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerGroupLabel.Location = new System.Drawing.Point(6, 16);
            this.timerGroupLabel.Name = "timerGroupLabel";
            this.timerGroupLabel.Size = new System.Drawing.Size(118, 20);
            this.timerGroupLabel.TabIndex = 0;
            this.timerGroupLabel.Text = "Interval Timer";
            // 
            // setupGroupBox
            // 
            this.setupGroupBox.Controls.Add(this.clearButton);
            this.setupGroupBox.Controls.Add(this.submitButton);
            this.setupGroupBox.Controls.Add(this.restIntervalTextBox);
            this.setupGroupBox.Controls.Add(this.intervalRestLabel);
            this.setupGroupBox.Controls.Add(this.timeListBox);
            this.setupGroupBox.Controls.Add(this.exerciseListBox);
            this.setupGroupBox.Controls.Add(this.timeListLabel);
            this.setupGroupBox.Controls.Add(this.exerciseListLabel);
            this.setupGroupBox.Controls.Add(this.addExerciseButton);
            this.setupGroupBox.Controls.Add(this.newTimeTextBox);
            this.setupGroupBox.Controls.Add(this.newTimeLabel);
            this.setupGroupBox.Controls.Add(this.newExerciseTextBox);
            this.setupGroupBox.Controls.Add(this.enterExerciseLabel);
            this.setupGroupBox.Controls.Add(this.setupGroupLabel);
            this.setupGroupBox.Location = new System.Drawing.Point(285, 13);
            this.setupGroupBox.Name = "setupGroupBox";
            this.setupGroupBox.Size = new System.Drawing.Size(248, 284);
            this.setupGroupBox.TabIndex = 2;
            this.setupGroupBox.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(180, 255);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(55, 20);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(180, 229);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(55, 20);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Su&bmit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // restIntervalTextBox
            // 
            this.restIntervalTextBox.Location = new System.Drawing.Point(87, 241);
            this.restIntervalTextBox.Name = "restIntervalTextBox";
            this.restIntervalTextBox.Size = new System.Drawing.Size(87, 20);
            this.restIntervalTextBox.TabIndex = 15;
            // 
            // intervalRestLabel
            // 
            this.intervalRestLabel.AutoSize = true;
            this.intervalRestLabel.Location = new System.Drawing.Point(11, 246);
            this.intervalRestLabel.Name = "intervalRestLabel";
            this.intervalRestLabel.Size = new System.Drawing.Size(70, 13);
            this.intervalRestLabel.TabIndex = 14;
            this.intervalRestLabel.Text = "Interval Rest:";
            // 
            // timeListBox
            // 
            this.timeListBox.FormattingEnabled = true;
            this.timeListBox.Location = new System.Drawing.Point(116, 126);
            this.timeListBox.Name = "timeListBox";
            this.timeListBox.Size = new System.Drawing.Size(58, 95);
            this.timeListBox.TabIndex = 13;
            // 
            // exerciseListBox
            // 
            this.exerciseListBox.FormattingEnabled = true;
            this.exerciseListBox.Location = new System.Drawing.Point(10, 126);
            this.exerciseListBox.Name = "exerciseListBox";
            this.exerciseListBox.Size = new System.Drawing.Size(100, 95);
            this.exerciseListBox.TabIndex = 12;
            // 
            // timeListLabel
            // 
            this.timeListLabel.AutoSize = true;
            this.timeListLabel.Location = new System.Drawing.Point(113, 110);
            this.timeListLabel.Name = "timeListLabel";
            this.timeListLabel.Size = new System.Drawing.Size(30, 13);
            this.timeListLabel.TabIndex = 11;
            this.timeListLabel.Text = "Time";
            // 
            // exerciseListLabel
            // 
            this.exerciseListLabel.AutoSize = true;
            this.exerciseListLabel.Location = new System.Drawing.Point(7, 110);
            this.exerciseListLabel.Name = "exerciseListLabel";
            this.exerciseListLabel.Size = new System.Drawing.Size(66, 13);
            this.exerciseListLabel.TabIndex = 10;
            this.exerciseListLabel.Text = "Exercise List";
            // 
            // addExerciseButton
            // 
            this.addExerciseButton.Location = new System.Drawing.Point(180, 70);
            this.addExerciseButton.Name = "addExerciseButton";
            this.addExerciseButton.Size = new System.Drawing.Size(55, 20);
            this.addExerciseButton.TabIndex = 9;
            this.addExerciseButton.Text = "Add";
            this.addExerciseButton.UseVisualStyleBackColor = true;
            this.addExerciseButton.Click += new System.EventHandler(this.addExerciseButton_Click);
            // 
            // newTimeTextBox
            // 
            this.newTimeTextBox.Location = new System.Drawing.Point(116, 70);
            this.newTimeTextBox.Name = "newTimeTextBox";
            this.newTimeTextBox.Size = new System.Drawing.Size(58, 20);
            this.newTimeTextBox.TabIndex = 8;
            // 
            // newTimeLabel
            // 
            this.newTimeLabel.AutoSize = true;
            this.newTimeLabel.Location = new System.Drawing.Point(113, 54);
            this.newTimeLabel.Name = "newTimeLabel";
            this.newTimeLabel.Size = new System.Drawing.Size(61, 13);
            this.newTimeLabel.TabIndex = 7;
            this.newTimeLabel.Text = "Enter Time:";
            // 
            // newExerciseTextBox
            // 
            this.newExerciseTextBox.Location = new System.Drawing.Point(10, 70);
            this.newExerciseTextBox.Name = "newExerciseTextBox";
            this.newExerciseTextBox.Size = new System.Drawing.Size(100, 20);
            this.newExerciseTextBox.TabIndex = 6;
            // 
            // enterExerciseLabel
            // 
            this.enterExerciseLabel.AutoSize = true;
            this.enterExerciseLabel.Location = new System.Drawing.Point(7, 54);
            this.enterExerciseLabel.Name = "enterExerciseLabel";
            this.enterExerciseLabel.Size = new System.Drawing.Size(78, 13);
            this.enterExerciseLabel.TabIndex = 5;
            this.enterExerciseLabel.Text = "Enter Exercise:";
            // 
            // setupGroupLabel
            // 
            this.setupGroupLabel.AutoSize = true;
            this.setupGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupGroupLabel.Location = new System.Drawing.Point(6, 16);
            this.setupGroupLabel.Name = "setupGroupLabel";
            this.setupGroupLabel.Size = new System.Drawing.Size(171, 20);
            this.setupGroupLabel.TabIndex = 4;
            this.setupGroupLabel.Text = "Interval Timer Setup";
            // 
            // MyTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 309);
            this.Controls.Add(this.setupGroupBox);
            this.Controls.Add(this.timerGroupBox);
            this.Name = "MyTimer";
            this.Text = "Timer";
            this.timerGroupBox.ResumeLayout(false);
            this.timerGroupBox.PerformLayout();
            this.setupGroupBox.ResumeLayout(false);
            this.setupGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox timerGroupBox;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label timerActivityLabel;
        private System.Windows.Forms.Label timerGroupLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox setupGroupBox;
        private System.Windows.Forms.Label intervalRestLabel;
        private System.Windows.Forms.ListBox timeListBox;
        private System.Windows.Forms.ListBox exerciseListBox;
        private System.Windows.Forms.Label timeListLabel;
        private System.Windows.Forms.Label exerciseListLabel;
        private System.Windows.Forms.Button addExerciseButton;
        private System.Windows.Forms.TextBox newTimeTextBox;
        private System.Windows.Forms.Label newTimeLabel;
        private System.Windows.Forms.TextBox newExerciseTextBox;
        private System.Windows.Forms.Label enterExerciseLabel;
        private System.Windows.Forms.Label setupGroupLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox restIntervalTextBox;
    }
}