namespace UserRegFormConsoleApp
{
    interface IRole
    {
        bool IsAdmin { get; set; }
        bool IsUser { get; set; }
    }
}