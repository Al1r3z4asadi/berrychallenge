using System.Net;

namespace Api.common
{
    public class ApiBaseResponse<T>
    {
        ApiBaseResponse(T data, string path, HttpStatusCode statusCode)
        {
            Data = data;
            Self = path;
            Status = statusCode;
        }

        public static ApiBaseResponse<T> Wrap(T data, string path, HttpStatusCode statusCode)
         => new ApiBaseResponse<T>(data, path, statusCode);

        public T Data { get; private set; }
        public HttpStatusCode Status { get; private set; }
        public string Self { get; private set; }
    }
}
