namespace TaskOneCommon
{
    interface IRole
    {
        bool IsAdmin { get; set; }
        bool IsUser { get; set; }
    }
}