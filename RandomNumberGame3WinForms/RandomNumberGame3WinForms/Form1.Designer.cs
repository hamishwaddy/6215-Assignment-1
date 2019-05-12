namespace RandomNumberGame3WinForms
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
            this.gameTitle = new System.Windows.Forms.Label();
            this.difficultyLevelBox = new System.Windows.Forms.GroupBox();
            this.easyLevel = new System.Windows.Forms.RadioButton();
            this.mediumLevel = new System.Windows.Forms.RadioButton();
            this.hardLevel = new System.Windows.Forms.RadioButton();
            this.makeGuessLbl = new System.Windows.Forms.Label();
            this.guess = new System.Windows.Forms.TextBox();
            this.submitGuess = new System.Windows.Forms.Button();
            this.previousGuesses = new System.Windows.Forms.TextBox();
            this.previousGuessesLbl = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.GroupBox();
            this.score = new System.Windows.Forms.TextBox();
            this.submitName = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.TextBox();
            this.enterNameLbl = new System.Windows.Forms.Label();
            this.difficultyLevelBox.SuspendLayout();
            this.scoreBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTitle
            // 
            this.gameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameTitle.Font = new System.Drawing.Font("Tahoma", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameTitle.Location = new System.Drawing.Point(12, 6);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(830, 74);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "RANDOM NUMBER GAME";
            this.gameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difficultyLevelBox
            // 
            this.difficultyLevelBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.difficultyLevelBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.difficultyLevelBox.Controls.Add(this.hardLevel);
            this.difficultyLevelBox.Controls.Add(this.mediumLevel);
            this.difficultyLevelBox.Controls.Add(this.easyLevel);
            this.difficultyLevelBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLevelBox.Location = new System.Drawing.Point(36, 179);
            this.difficultyLevelBox.Name = "difficultyLevelBox";
            this.difficultyLevelBox.Size = new System.Drawing.Size(332, 176);
            this.difficultyLevelBox.TabIndex = 1;
            this.difficultyLevelBox.TabStop = false;
            this.difficultyLevelBox.Text = "Choose difficulty level";
            // 
            // easyLevel
            // 
            this.easyLevel.AutoSize = true;
            this.easyLevel.Checked = true;
            this.easyLevel.Location = new System.Drawing.Point(43, 46);
            this.easyLevel.Name = "easyLevel";
            this.easyLevel.Size = new System.Drawing.Size(93, 33);
            this.easyLevel.TabIndex = 0;
            this.easyLevel.Text = "Easy";
            this.easyLevel.UseVisualStyleBackColor = true;
            // 
            // mediumLevel
            // 
            this.mediumLevel.AutoSize = true;
            this.mediumLevel.Location = new System.Drawing.Point(43, 85);
            this.mediumLevel.Name = "mediumLevel";
            this.mediumLevel.Size = new System.Drawing.Size(127, 33);
            this.mediumLevel.TabIndex = 1;
            this.mediumLevel.Text = "Medium";
            this.mediumLevel.UseVisualStyleBackColor = true;
            // 
            // hardLevel
            // 
            this.hardLevel.AutoSize = true;
            this.hardLevel.Location = new System.Drawing.Point(43, 124);
            this.hardLevel.Name = "hardLevel";
            this.hardLevel.Size = new System.Drawing.Size(95, 33);
            this.hardLevel.TabIndex = 2;
            this.hardLevel.Text = "Hard";
            this.hardLevel.UseVisualStyleBackColor = true;
            // 
            // makeGuessLbl
            // 
            this.makeGuessLbl.AutoSize = true;
            this.makeGuessLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeGuessLbl.Location = new System.Drawing.Point(31, 404);
            this.makeGuessLbl.Name = "makeGuessLbl";
            this.makeGuessLbl.Size = new System.Drawing.Size(194, 29);
            this.makeGuessLbl.TabIndex = 2;
            this.makeGuessLbl.Text = "Make your guess";
            // 
            // guess
            // 
            this.guess.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess.Location = new System.Drawing.Point(36, 448);
            this.guess.MinimumSize = new System.Drawing.Size(120, 50);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(120, 50);
            this.guess.TabIndex = 3;
            // 
            // submitGuess
            // 
            this.submitGuess.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitGuess.Location = new System.Drawing.Point(175, 445);
            this.submitGuess.MinimumSize = new System.Drawing.Size(120, 50);
            this.submitGuess.Name = "submitGuess";
            this.submitGuess.Size = new System.Drawing.Size(120, 50);
            this.submitGuess.TabIndex = 4;
            this.submitGuess.Text = "Submit";
            this.submitGuess.UseVisualStyleBackColor = true;
            // 
            // previousGuesses
            // 
            this.previousGuesses.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousGuesses.Location = new System.Drawing.Point(36, 584);
            this.previousGuesses.Name = "previousGuesses";
            this.previousGuesses.Size = new System.Drawing.Size(236, 36);
            this.previousGuesses.TabIndex = 6;
            // 
            // previousGuessesLbl
            // 
            this.previousGuessesLbl.AutoSize = true;
            this.previousGuessesLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousGuessesLbl.Location = new System.Drawing.Point(31, 540);
            this.previousGuessesLbl.Name = "previousGuessesLbl";
            this.previousGuessesLbl.Size = new System.Drawing.Size(195, 29);
            this.previousGuessesLbl.TabIndex = 5;
            this.previousGuessesLbl.Text = "Previous guesses";
            // 
            // scoreBox
            // 
            this.scoreBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scoreBox.Controls.Add(this.score);
            this.scoreBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBox.Location = new System.Drawing.Point(479, 179);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(332, 194);
            this.scoreBox.TabIndex = 7;
            this.scoreBox.TabStop = false;
            this.scoreBox.Text = "Score";
            // 
            // score
            // 
            this.score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.score.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(39, 36);
            this.score.MinimumSize = new System.Drawing.Size(180, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(180, 123);
            this.score.TabIndex = 0;
            // 
            // submitName
            // 
            this.submitName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitName.Location = new System.Drawing.Point(676, 477);
            this.submitName.MinimumSize = new System.Drawing.Size(120, 50);
            this.submitName.Name = "submitName";
            this.submitName.Size = new System.Drawing.Size(120, 50);
            this.submitName.TabIndex = 10;
            this.submitName.Text = "Submit";
            this.submitName.UseVisualStyleBackColor = true;
            // 
            // playerName
            // 
            this.playerName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.Location = new System.Drawing.Point(479, 480);
            this.playerName.MinimumSize = new System.Drawing.Size(0, 50);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(160, 36);
            this.playerName.TabIndex = 9;
            // 
            // enterNameLbl
            // 
            this.enterNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameLbl.Location = new System.Drawing.Point(474, 404);
            this.enterNameLbl.Name = "enterNameLbl";
            this.enterNameLbl.Size = new System.Drawing.Size(224, 61);
            this.enterNameLbl.TabIndex = 8;
            this.enterNameLbl.Text = "Enter player name (5 characters max)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 929);
            this.Controls.Add(this.submitName);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.enterNameLbl);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.previousGuesses);
            this.Controls.Add(this.previousGuessesLbl);
            this.Controls.Add(this.submitGuess);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.makeGuessLbl);
            this.Controls.Add(this.difficultyLevelBox);
            this.Controls.Add(this.gameTitle);
            this.MinimumSize = new System.Drawing.Size(880, 1000);
            this.Name = "Form1";
            this.Text = "Random Number Game";
            this.difficultyLevelBox.ResumeLayout(false);
            this.difficultyLevelBox.PerformLayout();
            this.scoreBox.ResumeLayout(false);
            this.scoreBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.GroupBox difficultyLevelBox;
        private System.Windows.Forms.RadioButton hardLevel;
        private System.Windows.Forms.RadioButton mediumLevel;
        private System.Windows.Forms.RadioButton easyLevel;
        private System.Windows.Forms.Label makeGuessLbl;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.Button submitGuess;
        private System.Windows.Forms.TextBox previousGuesses;
        private System.Windows.Forms.Label previousGuessesLbl;
        private System.Windows.Forms.GroupBox scoreBox;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.Button submitName;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Label enterNameLbl;
    }
}

