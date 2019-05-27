using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskThreeCommon;

namespace WindowsFormsGuessingGame
{
    public partial class Form1 : Form
    {
        /* Instantiate new games */
        static IGameModel easyGame = new EasyLevel();
        static IGameModel mediumGame = new MediumLevel();
        static IGameModel hardGame = new MediumLevel();

        public Form1()
        {
            InitializeComponent();
            testing.Text = easyGame.SecretNumber.ToString();//for testing purposes only, delete.
        }

        private void SubmitGuess_Click(object sender, EventArgs e)
        {
            /*Check which level has been selected and plays the appropriate class*/
            if (easyLevel.Checked == true && easyGame.CurrentGuessCount <= 3)
            {
                countDown.Text = easyGame.CurrentGuessCount.ToString();
                int.TryParse(guess.Text, out int result);
                easyGame.CurrentGuess = result;
                guess.Clear();
                score.Text = easyGame.CalculateScore(easyGame.CurrentGuess).ToString();
                guessesList.Items.Add(easyGame.Guesses[easyGame.Guesses.Count - 1]);
                if (easyGame.LevelComplete == true)
                {
                    mediumLevel.Checked = true;
                    guessesList.Items.Add($"{easyGame.DifficultyLevel} complete...");
                }
            }
            if (mediumLevel.Checked == true && mediumGame.CurrentGuessCount <= 3)
            {
                testing.Text = mediumGame.SecretNumber.ToString();//for testing purposes only, delete.
                countDown.Text = mediumGame.CurrentGuessCount.ToString();
                int.TryParse(guess.Text, out int result);
                mediumGame.CurrentGuess = result;
                guess.Clear();
                mediumGame.CalculateScore(mediumGame.CurrentGuess);
                if (mediumGame.LevelComplete == true)
                    hardLevel.Checked = true;
            }
            if (hardLevel.Checked == true && hardGame.CurrentGuessCount <= 3)
            {
                testing.Text = hardGame.SecretNumber.ToString();//for testing purposes only, delete.
                countDown.Text = hardGame.CurrentGuessCount.ToString();
                int.TryParse(guess.Text, out int result);
                hardGame.CurrentGuess = result;
                guess.Clear();
                hardGame.CalculateScore(hardGame.CurrentGuess);
                if (hardGame.LevelComplete == true)
                    MessageBox.Show("WELL DONE! You have completed Level 3!");
                    hardLevel.Checked = true;
            }


            /*Display the user name input*/
            if (easyGame.GameOver == true || mediumGame.GameOver == true || hardGame.GameOver == true)
            {
                enterNameLbl.Visible = true;
                playerName.Visible = true;
                submitName.Visible = true;
                submitGuess.Visible = false;
                guess.Visible = false;
                makeGuessLbl.Text = "Game over";
                guessesList.Items.Add($"...Game Over...");
            }
        }
        
    }
}
