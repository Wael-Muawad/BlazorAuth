namespace Last.Client.Dtos.Api
{
    public class ErrorResponseDto
    {
        public string Type { get; set; }

        public string Title { get; set; }

        public long Status { get; set; }

        public string Detail { get; set; }

        public string TraceId { get; set; }

        public Dictionary<string, List<string>> Errors { get; set; }
    }
}
