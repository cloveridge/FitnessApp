namespace CLMyFitnessApp
{
    partial class myProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myProfileForm));
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.preferredNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.preferredNameTextbox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.beforePictureBox = new System.Windows.Forms.PictureBox();
            this.afterPictureBox = new System.Windows.Forms.PictureBox();
            this.beforeButton = new System.Windows.Forms.Button();
            this.afterButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.nameGroupBox.SuspendLayout();
            this.statsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beforePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(25, 29);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 18;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(24, 69);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 19;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // preferredNameLabel
            // 
            this.preferredNameLabel.AutoSize = true;
            this.preferredNameLabel.Location = new System.Drawing.Point(1, 109);
            this.preferredNameLabel.Name = "preferredNameLabel";
            this.preferredNameLabel.Size = new System.Drawing.Size(84, 13);
            this.preferredNameLabel.TabIndex = 20;
            this.preferredNameLabel.Text = "Preferred Name:";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(91, 26);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(69, 20);
            this.firstNameTextbox.TabIndex = 1;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(91, 66);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(69, 20);
            this.lastNameTextbox.TabIndex = 2;
            // 
            // preferredNameTextbox
            // 
            this.preferredNameTextbox.Location = new System.Drawing.Point(91, 106);
            this.preferredNameTextbox.Name = "preferredNameTextbox";
            this.preferredNameTextbox.Size = new System.Drawing.Size(69, 20);
            this.preferredNameTextbox.TabIndex = 3;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(221, 375);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Clos&e";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.preferredNameTextbox);
            this.nameGroupBox.Controls.Add(this.firstNameLabel);
            this.nameGroupBox.Controls.Add(this.lastNameLabel);
            this.nameGroupBox.Controls.Add(this.preferredNameLabel);
            this.nameGroupBox.Controls.Add(this.lastNameTextbox);
            this.nameGroupBox.Controls.Add(this.firstNameTextbox);
            this.nameGroupBox.Location = new System.Drawing.Point(12, 12);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(179, 183);
            this.nameGroupBox.TabIndex = 11;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Name Info:";
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.ageTextBox);
            this.statsGroupBox.Controls.Add(this.weightLabel);
            this.statsGroupBox.Controls.Add(this.weightTextBox);
            this.statsGroupBox.Controls.Add(this.heightLabel);
            this.statsGroupBox.Controls.Add(this.heightTextBox);
            this.statsGroupBox.Controls.Add(this.ageLabel);
            this.statsGroupBox.Location = new System.Drawing.Point(12, 201);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(179, 197);
            this.statsGroupBox.TabIndex = 12;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "My Stats:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(91, 112);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(69, 20);
            this.ageTextBox.TabIndex = 6;
            // 
            // weightLabel
            // 
            this.weightLabel.Location = new System.Drawing.Point(25, 35);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(60, 13);
            this.weightLabel.TabIndex = 13;
            this.weightLabel.Text = "Weight:";
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(91, 32);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(69, 20);
            this.weightTextBox.TabIndex = 4;
            // 
            // heightLabel
            // 
            this.heightLabel.Location = new System.Drawing.Point(24, 75);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(61, 13);
            this.heightLabel.TabIndex = 14;
            this.heightLabel.Text = "Height:";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(91, 72);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(69, 20);
            this.heightTextBox.TabIndex = 5;
            // 
            // ageLabel
            // 
            this.ageLabel.Location = new System.Drawing.Point(24, 119);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(61, 13);
            this.ageLabel.TabIndex = 15;
            this.ageLabel.Text = "Age:";
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // beforePictureBox
            // 
            this.beforePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.beforePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("beforePictureBox.Image")));
            this.beforePictureBox.Location = new System.Drawing.Point(223, 22);
            this.beforePictureBox.Name = "beforePictureBox";
            this.beforePictureBox.Size = new System.Drawing.Size(70, 140);
            this.beforePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.beforePictureBox.TabIndex = 16;
            this.beforePictureBox.TabStop = false;
            // 
            // afterPictureBox
            // 
            this.afterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("afterPictureBox.Image")));
            this.afterPictureBox.Location = new System.Drawing.Point(223, 22);
            this.afterPictureBox.Name = "afterPictureBox";
            this.afterPictureBox.Size = new System.Drawing.Size(70, 140);
            this.afterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.afterPictureBox.TabIndex = 17;
            this.afterPictureBox.TabStop = false;
            this.afterPictureBox.Visible = false;
            // 
            // beforeButton
            // 
            this.beforeButton.Location = new System.Drawing.Point(198, 169);
            this.beforeButton.Name = "beforeButton";
            this.beforeButton.Size = new System.Drawing.Size(56, 23);
            this.beforeButton.TabIndex = 7;
            this.beforeButton.Text = "&Before";
            this.beforeButton.UseVisualStyleBackColor = true;
            this.beforeButton.Click += new System.EventHandler(this.beforeButton_Click);
            // 
            // afterButton
            // 
            this.afterButton.Location = new System.Drawing.Point(261, 169);
            this.afterButton.Name = "afterButton";
            this.afterButton.Size = new System.Drawing.Size(56, 23);
            this.afterButton.TabIndex = 8;
            this.afterButton.Text = "&After";
            this.afterButton.UseVisualStyleBackColor = true;
            this.afterButton.Click += new System.EventHandler(this.afterButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(222, 346);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 9;
            this.clearAllButton.Text = "&Clear All Fields";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // myProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 410);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.afterButton);
            this.Controls.Add(this.beforeButton);
            this.Controls.Add(this.beforePictureBox);
            this.Controls.Add(this.statsGroupBox);
            this.Controls.Add(this.nameGroupBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.afterPictureBox);
            this.Name = "myProfileForm";
            this.Text = "My Profile Form";
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beforePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).EndInit();
            this.ResumeLayout(false);

            // Set the accept & cancel button preperties
            this.AcceptButton = closeButton;
            this.CancelButton = clearAllButton;
        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label preferredNameLabel;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.TextBox preferredNameTextbox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.PictureBox beforePictureBox;
        private System.Windows.Forms.PictureBox afterPictureBox;
        private System.Windows.Forms.Button beforeButton;
        private System.Windows.Forms.Button afterButton;
        private System.Windows.Forms.Button clearAllButton;
    }
}