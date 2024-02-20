namespace Core.CheckStrategies
{
    public class TrimCheckStrategy : ICheckStrategy
    {
        public string DisplayName => "Trim";

        public bool Check(string stdout, string expectedOutput)
        {
            return string.Compare(stdout.Trim(), expectedOutput.Trim()) == 0;
        }
    }
}
