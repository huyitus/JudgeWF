using Newtonsoft.Json;

namespace Core
{
    public class TestCase
    {
        [JsonProperty(PropertyName = "time_limit")]
        public float TimeLimit { get; set; } 

        [JsonProperty(PropertyName = "memory_limit")]
        public float MemoryLimit { get; set; }

        [JsonProperty(PropertyName = "standard_input")]
        public string StandardInput { get; set; }

        [JsonProperty(PropertyName = "expected_output")]
        public string ExpectedOutput { get; set; }
    }
}
