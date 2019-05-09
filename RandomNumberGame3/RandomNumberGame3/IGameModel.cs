using RandomNumberGame3;

namespace RandomNumberGame3
{
    public interface IGameModel
    {
        string DifficultyLevel { get; set; }
        int MaxNumber { get; set; }
        int SecretNumber { get; set; }
        int MaxGuesses { get; set; }
        int CurrentGuessCount { get; set; }

        //string DisplayDifficultyLevel();
    }
}