namespace PhoneBook3
{
    public interface IEasyLevel
    {
        string DifficultyLevel { get; set; }
        int MaxNumber { get; set; }
        int SecretNumber { get; set; }

        int SetSecretNumberEasyLevel();
        string DisplayDifficultyLevel();
    }
}