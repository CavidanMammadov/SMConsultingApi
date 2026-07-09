namespace SMConsulting.BL.Exceptions.Common
{
    public interface IBaseException
    {
        int StatusCode { get; }
        string ErrorMessage { get; }
    }
}
