using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Core.JudgeStrategies
{
    public class Judge0APIJudgeStrategy : IJudgeStrategy
    {
        private Judge0APIConfig config;

        public string DisplayName => "Judge0 API";

        public Judge0APIJudgeStrategy(string filePath)
        {
            LoadConfig(filePath);
        }

        public void LoadConfig(string filePath)
        {
            string json = File.ReadAllText(filePath);
            config = JsonConvert.DeserializeObject<Judge0APIConfig>(json);
        }

        public JudgeResponse Judge(Submission submission, TestCase testCase)
        {
            var body = CreateBodyObject(submission, testCase);
            var queryParams = CreateQueryParams();

            string response = APIHelper.Post(config, body, config.Headers, queryParams);
            JObject json = JObject.Parse(response);

            bool hasError = config.ErrorStatuses.Contains((string)json["status_id"]);

            return new JudgeResponse()
            {
                Time = hasError ? 0.0f : (float)json["time"],
                Memory = hasError ? 0.0f : (float)json["memory"],
                StandardOutput = hasError ? "" : (string)json["stdout"],
                Message = config.StatusMessages[(string)json["status_id"]],
                HasError = hasError
            };
        }

        private object CreateBodyObject(Submission submission, TestCase testCase)
        {
            return new
            {
                source_code = submission.SourceCode,
                language_id = config.LanguageIds[submission.Language].ToString(),
                stdin = testCase.StandardInput,
                expected_output = testCase.ExpectedOutput,
                cpu_time_limit = testCase.TimeLimit.ToString(),
                memory_limit = testCase.MemoryLimit.ToString()
            };
        }

        private Dictionary<string, string> CreateQueryParams()
        {
            return new Dictionary<string, string>()
            {
                { "fields", "time,memory,stdout,status_id" },
                { "base64_encoded", "false" },
                { "wait", "true" }
            };
        }

        public List<string> GetSupportLanguages()
        {
            return config.LanguageIds.Keys.ToList();
        }
    }
}
