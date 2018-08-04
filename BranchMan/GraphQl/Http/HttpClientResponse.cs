namespace GraphQl
{
    public sealed class HttpClientResponse
    {
        private HttpClientResponse(bool isSuccess, string stringResponse)
        {
            IsSuccess = isSuccess;
            StringResponse = stringResponse;
        }

        public bool IsSuccess { get; }

        public string StringResponse { get; }

        public static HttpClientResponse Succeeded(string body)
        {
            return new HttpClientResponse(true, body);
        }

        public static HttpClientResponse Failed()
        {
            return new HttpClientResponse(true, string.Empty);
        }
    }
}