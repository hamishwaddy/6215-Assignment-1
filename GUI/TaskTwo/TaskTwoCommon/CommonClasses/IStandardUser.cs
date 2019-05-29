namespace TaskTwoCommon
{
    public interface IStandardUser
    {
        string name { get; set; }
        string phone { get; set; }
        string email { get; set; }

        string Display();
    }
}
