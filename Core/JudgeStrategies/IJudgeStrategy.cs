namespace Core.JudgeStrategies
{
    public interface IJudgeStrategy
    {
        string DisplayName { get; }

        JudgeResponse Judge(Submission submission, TestCase testCase);

        List<string> GetSupportLanguages();
    }
}