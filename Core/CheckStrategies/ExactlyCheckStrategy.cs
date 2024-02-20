namespace Core.CheckStrategies
{
    public class ExactlyCheckStrategy : ICheckStrategy
    {
        public string DisplayName => "Exactly";

        public bool Check(string stdout, string expectedOutput)
        {
            return string.Compare(stdout, expectedOutput) == 0;
        }
    }
}
