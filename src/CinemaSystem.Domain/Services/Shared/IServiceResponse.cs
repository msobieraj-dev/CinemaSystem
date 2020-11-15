namespace CinemaSystem.Domain.Services.Shared
{
    public interface IServiceResponse<TResponse>
    {
        TResponse GetValue();
    }
}