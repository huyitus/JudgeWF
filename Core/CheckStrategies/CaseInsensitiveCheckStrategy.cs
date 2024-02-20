namespace Core.CheckStrategies
{
    public class CaseInsensitiveCheckStrategy : ICheckStrategy
    {
        public string DisplayName => "Case Insensitive";

        public bool Check(string stdout, string expectedOutput)
        {
            return string.Compare(stdout, expectedOutput, true) == 0;
        }
    }
}
