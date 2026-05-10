namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundExpection : ApplicationException
    {
        public NotFoundExpection(string message) : base(message) { }
    }
}
