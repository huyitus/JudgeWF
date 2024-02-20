using Core.JudgeStrategies;

namespace Core.CheckStrategies
{
    public class CustomCheckStrategy : ICheckStrategy
    {
        public string DisplayName => "Custom";

        private Submission submission;
        private IJudgeStrategy judger;

        public CustomCheckStrategy(string sourceCode, string language, IJudgeStrategy judger)
        {
            submission = new Submission()
            {
                SourceCode = sourceCode,
                Language = language
            };

            this.judger = judger;
        }

        public bool Check(string stdout, string expectedOutput)
        {
            TestCase testCase = new TestCase()
            {
                StandardInput = stdout,
                ExpectedOutput = "1",
                TimeLimit = 2,
                MemoryLimit = 65535
            };

            JudgeResponse response = judger.Judge(submission, testCase);

            return response.StandardOutput == "1";
        }
    }
}
