using Core.CheckStrategies;
using Core.JudgeStrategies;

namespace Core
{
    public class Judger
    {
        public static JudgeResult Judge(Submission submission, TestCase testCase,
            IJudgeStrategy judger, ICheckStrategy checker)
        {
            JudgeResponse response = judger.Judge(submission, testCase);
            JudgeResult result = new JudgeResult(response);
            
            result.IsPassed = !response.HasError &&
                checker.Check(response.StandardOutput, testCase.ExpectedOutput);
            
            return result;
        }

        public static List<IJudgeStrategy> GetAvailabelJudgeStrategies(string folder)
        {
            return new List<IJudgeStrategy>()
            {
                new Judge0APIJudgeStrategy(Path.Combine(folder, "Judge0.json")),
                new OneCompilerAPIJudgeStrategy(Path.Combine(folder, "OneCompiler.json"))
            };
        }

        public static List<ICheckStrategy> GetAvailableCheckStrategies()
        {
            return new List<ICheckStrategy>()
            {
                new ExactlyCheckStrategy(),
                new CaseInsensitiveCheckStrategy(),
                new TrimCheckStrategy()
            };
        }
    }
}
