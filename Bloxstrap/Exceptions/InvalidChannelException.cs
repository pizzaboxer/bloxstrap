namespace LumenRX.Exceptions
{
    public class InvalidChannelException : Exception
    {
        public HttpStatusCode? StatusCode;

        public InvalidChannelException(HttpStatusCode? statusCode) : base()
            => StatusCode = statusCode;
    }
}
