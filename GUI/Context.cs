using Core;
using Core.CheckStrategies;
using Core.JudgeStrategies;
using Newtonsoft.Json;

namespace GUI
{
    public class Context
    {
        private static Context instance;

        public List<TestCase> TestCases = new();
        public string SubmissionFilePath;
        public string SubmissionLanguage;
        public string CheckerFilePath;
        public string CheckerLanguage;
        public IJudgeStrategy JudgeStrategy;
        public ICheckStrategy CheckStrategy;

        public static Context GetInstance()
        {
            instance ??= new Context();
            return instance;
        }

        public int LoadTestCase(string folderPath)
        {
            TestCases.Clear();

            foreach (string filePath in Directory.GetFiles(folderPath))
            {
                string json = File.ReadAllText(filePath);
                var testCase = JsonConvert.DeserializeObject<TestCase>(json);

                if (testCase != null)
                {
                    TestCases.Add(testCase);
                }
            }

            return TestCases.Count;
        }

        public bool IsValid()
        {
            return TestCases.Count > 0
                && File.Exists(SubmissionFilePath)
                && SubmissionLanguage != null
                && JudgeStrategy != null
                && CheckStrategy != null;
        }
    }
}
