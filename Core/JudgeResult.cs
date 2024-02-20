namespace Core
{
    public class JudgeResult
    {
        public float Time { get; set; }
        public float Memory { get; set; }
        public bool IsPassed { get; set; }
        public bool HasError { get; set; }
        public string Message { get; set; }

        public JudgeResult(JudgeResponse response)
        {
            Time = response.Time;
            Memory = response.Memory;
            Message = response.Message;
            HasError = response.HasError;
        }
    }
}
