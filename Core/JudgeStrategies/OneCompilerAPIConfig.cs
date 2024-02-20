namespace Core.JudgeStrategies
{
    public class OneCompilerAPIConfig : APIConfig
    {
        public Dictionary<string, string> Headers { get; set; }
        public Dictionary<string, string> Languages { get; set; }
        public Dictionary<string, string> Extensions { get; set; }
    }
}