namespace Core
{
    public class JudgeResponse
    {
        public float Time { get; set; }
        public float Memory { get; set; }
        public string StandardOutput { get; set; }
        public string Message { get; set; }
        public bool HasError { get; set; }
    }
}
