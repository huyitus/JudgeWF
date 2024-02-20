namespace Core.JudgeStrategies
{
    public class Judge0APIConfig : APIConfig
    {
        public Dictionary<string, string> Headers { get; set; }
        public Dictionary<string, int> LanguageIds { get; set; }
        public Dictionary<string, string> StatusMessages { get; set; }
        public List<string> ErrorStatuses { get; set; }
    }
}
