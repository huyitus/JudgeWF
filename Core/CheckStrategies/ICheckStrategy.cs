namespace Core.CheckStrategies
{
    public interface ICheckStrategy
    {
        string DisplayName { get; }

        bool Check(string stdout, string expectedOutput);
    }
}