﻿namespace PhoneBook3
{
    public interface IHardLevel
    {
        string DifficultyLevel { get; set; }
        int MaxNumber { get; set; }
        int SecretNumber { get; set; }

        string DisplayDifficultyLevel();
        int SetSecretNumberHardLevel();
    }
}