namespace Last.Client.Dtos.Api
{
    public class ApiResponseDto<TData>
    {
        public TData Data { get; set; }

        public bool Success { get; set; }


        public Dictionary<string, List<string>> ErrorList { get; private set; } = new();


        public void SetFailureWithErrorList(Dictionary<string, List<string>> errors)
        {
            Success = false;
            ErrorList = errors;
        }

        public void SetSuccessWithPayload(TData data)
        {
            Success = true;
            Data = data;
        }
    }
}
