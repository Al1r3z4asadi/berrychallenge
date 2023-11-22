namespace Api.common
{
    public static class ApiResponseExtensions
    {
        public static ApiBaseResponse<T> WrapResponse<T>(this T data, string path, HttpStatusCode statusCode = HttpStatusCode.OK)
           => ApiBaseResponse<T>.Wrap(data, path, statusCode);

    }
}
