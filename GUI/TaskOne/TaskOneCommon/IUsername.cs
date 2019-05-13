namespace TaskOneCommon
{
    interface IUsername
    {
        string Username { get; set; }

        string GenerateUserName();
    }
}
