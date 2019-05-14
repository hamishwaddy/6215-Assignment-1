namespace WindowsFormsGuessingGame
{
    partial class Form1
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
            this.submitName = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.TextBox();
            this.enterNameLbl = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.GroupBox();
            this.score = new System.Windows.Forms.TextBox();
            this.previousGuessesLbl = new System.Windows.Forms.Label();
            this.submitGuess = new System.Windows.Forms.Button();
            this.guess = new System.Windows.Forms.TextBox();
            this.makeGuessLbl = new System.Windows.Forms.Label();
            this.difficultyLevelBox = new System.Windows.Forms.GroupBox();
            this.countDown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hardLevel = new System.Windows.Forms.RadioButton();
            this.mediumLevel = new System.Windows.Forms.RadioButton();
            this.easyLevel = new System.Windows.Forms.RadioButton();
            this.gameTitle = new System.Windows.Forms.Label();
            this.guessesList = new System.Windows.Forms.ListBox();
            this.testing = new System.Windows.Forms.Label();
            this.scoreBox.SuspendLayout();
            this.difficultyLevelBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitName
            // 
            this.submitName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitName.Location = new System.Drawing.Point(483, 483);
            this.submitName.MinimumSize = new System.Drawing.Size(120, 50);
            this.submitName.Name = "submitName";
            this.submitName.Size = new System.Drawing.Size(332, 78);
            this.submitName.TabIndex = 21;
            this.submitName.Text = "Submit";
            this.submitName.UseVisualStyleBackColor = true;
            this.submitName.Visible = false;
            // 
            // playerName
            // 
            this.playerName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.Location = new System.Drawing.Point(483, 398);
            this.playerName.MinimumSize = new System.Drawing.Size(4, 76);
            this.playerName.Multiline = true;
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(330, 76);
            this.playerName.TabIndex = 20;
            this.playerName.Visible = false;
            // 
            // enterNameLbl
            // 
            this.enterNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameLbl.Location = new System.Drawing.Point(546, 327);
            this.enterNameLbl.Name = "enterNameLbl";
            this.enterNameLbl.Size = new System.Drawing.Size(219, 61);
            this.enterNameLbl.TabIndex = 19;
            this.enterNameLbl.Text = "Enter player name\r\n(5 characters max)";
            this.enterNameLbl.Visible = false;
            // 
            // scoreBox
            // 
            this.scoreBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scoreBox.Controls.Add(this.score);
            this.scoreBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBox.Location = new System.Drawing.Point(483, 112);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(332, 177);
            this.scoreBox.TabIndex = 18;
            this.scoreBox.TabStop = false;
            this.scoreBox.Text = "Score";
            // 
            // score
            // 
            this.score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.score.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(39, 36);
            this.score.MinimumSize = new System.Drawing.Size(180, 4);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(254, 123);
            this.score.TabIndex = 0;
            // 
            // previousGuessesLbl
            // 
            this.previousGuessesLbl.AutoSize = true;
            this.previousGuessesLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousGuessesLbl.Location = new System.Drawing.Point(333, 661);
            this.previousGuessesLbl.Name = "previousGuessesLbl";
            this.previousGuessesLbl.Size = new System.Drawing.Size(195, 29);
            this.previousGuessesLbl.TabIndex = 16;
            this.previousGuessesLbl.Text = "Previous guesses";
            // 
            // submitGuess
            // 
            this.submitGuess.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitGuess.Location = new System.Drawing.Point(40, 483);
            this.submitGuess.MinimumSize = new System.Drawing.Size(120, 50);
            this.submitGuess.Name = "submitGuess";
            this.submitGuess.Size = new System.Drawing.Size(332, 78);
            this.submitGuess.TabIndex = 15;
            this.submitGuess.Text = "Submit";
            this.submitGuess.UseVisualStyleBackColor = true;
            this.submitGuess.Click += new System.EventHandler(this.SubmitGuess_Click);
            // 
            // guess
            // 
            this.guess.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess.Location = new System.Drawing.Point(40, 398);
            this.guess.MinimumSize = new System.Drawing.Size(120, 76);
            this.guess.Multiline = true;
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(330, 76);
            this.guess.TabIndex = 14;
            this.guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // makeGuessLbl
            // 
            this.makeGuessLbl.AutoSize = true;
            this.makeGuessLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeGuessLbl.Location = new System.Drawing.Point(120, 359);
            this.makeGuessLbl.Name = "makeGuessLbl";
            this.makeGuessLbl.Size = new System.Drawing.Size(194, 29);
            this.makeGuessLbl.TabIndex = 13;
            this.makeGuessLbl.Text = "Make your guess";
            // 
            // difficultyLevelBox
            // 
            this.difficultyLevelBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.difficultyLevelBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.difficultyLevelBox.Controls.Add(this.countDown);
            this.difficultyLevelBox.Controls.Add(this.label1);
            this.difficultyLevelBox.Controls.Add(this.hardLevel);
            this.difficultyLevelBox.Controls.Add(this.mediumLevel);
            this.difficultyLevelBox.Controls.Add(this.easyLevel);
            this.difficultyLevelBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLevelBox.Location = new System.Drawing.Point(40, 112);
            this.difficultyLevelBox.Name = "difficultyLevelBox";
            this.difficultyLevelBox.Size = new System.Drawing.Size(332, 177);
            this.difficultyLevelBox.TabIndex = 12;
            this.difficultyLevelBox.TabStop = false;
            this.difficultyLevelBox.Text = "Choose difficulty level";
            // 
            // countDown
            // 
            this.countDown.AutoSize = true;
            this.countDown.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDown.Location = new System.Drawing.Point(216, 94);
            this.countDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countDown.Name = "countDown";
            this.countDown.Size = new System.Drawing.Size(57, 64);
            this.countDown.TabIndex = 4;
            this.countDown.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Guesses:";
            // 
            // hardLevel
            // 
            this.hardLevel.AutoSize = true;
            this.hardLevel.Location = new System.Drawing.Point(44, 123);
            this.hardLevel.Name = "hardLevel";
            this.hardLevel.Size = new System.Drawing.Size(95, 33);
            this.hardLevel.TabIndex = 2;
            this.hardLevel.Text = "Hard";
            this.hardLevel.UseVisualStyleBackColor = true;
            // 
            // mediumLevel
            // 
            this.mediumLevel.AutoSize = true;
            this.mediumLevel.Location = new System.Drawing.Point(44, 84);
            this.mediumLevel.Name = "mediumLevel";
            this.mediumLevel.Size = new System.Drawing.Size(127, 33);
            this.mediumLevel.TabIndex = 1;
            this.mediumLevel.Text = "Medium";
            this.mediumLevel.UseVisualStyleBackColor = true;
            // 
            // easyLevel
            // 
            this.easyLevel.AutoSize = true;
            this.easyLevel.Checked = true;
            this.easyLevel.Location = new System.Drawing.Point(44, 45);
            this.easyLevel.Name = "easyLevel";
            this.easyLevel.Size = new System.Drawing.Size(93, 33);
            this.easyLevel.TabIndex = 0;
            this.easyLevel.TabStop = true;
            this.easyLevel.Text = "Easy";
            this.easyLevel.UseVisualStyleBackColor = true;
            // 
            // gameTitle
            // 
            this.gameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameTitle.Font = new System.Drawing.Font("Tahoma", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameTitle.Location = new System.Drawing.Point(16, 9);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(830, 73);
            this.gameTitle.TabIndex = 11;
            this.gameTitle.Text = "RANDOM NUMBER GAME";
            this.gameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessesList
            // 
            this.guessesList.FormattingEnabled = true;
            this.guessesList.ItemHeight = 25;
            this.guessesList.Location = new System.Drawing.Point(40, 694);
            this.guessesList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guessesList.Name = "guessesList";
            this.guessesList.Size = new System.Drawing.Size(772, 229);
            this.guessesList.TabIndex = 22;
            // 
            // testing
            // 
            this.testing.AutoSize = true;
            this.testing.Location = new System.Drawing.Point(394, 589);
            this.testing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testing.Name = "testing";
            this.testing.Size = new System.Drawing.Size(83, 25);
            this.testing.TabIndex = 23;
            this.testing.Text = "Testing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 953);
            this.Controls.Add(this.testing);
            this.Controls.Add(this.guessesList);
            this.Controls.Add(this.submitName);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.enterNameLbl);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.previousGuessesLbl);
            this.Controls.Add(this.submitGuess);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.makeGuessLbl);
            this.Controls.Add(this.difficultyLevelBox);
            this.Controls.Add(this.gameTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.scoreBox.ResumeLayout(false);
            this.scoreBox.PerformLayout();
            this.difficultyLevelBox.ResumeLayout(false);
            this.difficultyLevelBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitName;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Label enterNameLbl;
        private System.Windows.Forms.GroupBox scoreBox;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.Label previousGuessesLbl;
        private System.Windows.Forms.Button submitGuess;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.Label makeGuessLbl;
        private System.Windows.Forms.GroupBox difficultyLevelBox;
        private System.Windows.Forms.RadioButton hardLevel;
        private System.Windows.Forms.RadioButton mediumLevel;
        private System.Windows.Forms.RadioButton easyLevel;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.ListBox guessesList;
        private System.Windows.Forms.Label testing;
        private System.Windows.Forms.Label countDown;
        private System.Windows.Forms.Label label1;
    }
}

