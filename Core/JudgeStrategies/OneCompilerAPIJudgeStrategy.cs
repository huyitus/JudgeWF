using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Core.JudgeStrategies
{
    public class OneCompilerAPIJudgeStrategy : IJudgeStrategy
    {
        public string DisplayName => "OneCompiler API";

        private OneCompilerAPIConfig config;

        public OneCompilerAPIJudgeStrategy(string filePath)
        {
            LoadConfig(filePath);
        }

        public void LoadConfig(string filePath)
        {
            string json = File.ReadAllText(filePath);
            config = JsonConvert.DeserializeObject<OneCompilerAPIConfig>(json);
        }

        public JudgeResponse Judge(Submission submission, TestCase testCase)
        {
            var body = CreateBodyObject(submission, testCase);
            var queryParams = new Dictionary<string, string>();

            string response = APIHelper.Post(config, body, config.Headers, queryParams);
            JObject json = JObject.Parse(response);

            bool hasError = (string)json["stderr"] != null;

            return new JudgeResponse()
            {
                Memory = 0.0f,
                Time = hasError ? 0.0f : (float)json["executionTime"] / 1000,
                StandardOutput = hasError ? "" : (string)json["stdout"],
                Message = (string)json["stderr"],
                HasError = hasError
            };
        }

        private object CreateBodyObject(Submission submission, TestCase testCase)
        {
            return new
            {
                language = config.Languages[submission.Language],
                stdin = testCase.StandardInput,
                files = new object[]
                {
                    new
                    {
                        name = "index" + config.Extensions[submission.Language],
                        content = submission.SourceCode
                    }
                }
            };
        }

        public List<string> GetSupportLanguages()
        {
            return config.Languages.Keys.ToList();
        }
    }
}
