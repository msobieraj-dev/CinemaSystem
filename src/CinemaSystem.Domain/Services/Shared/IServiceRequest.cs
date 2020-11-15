namespace CinemaSystem.Domain.Services.Shared
{
    public interface IServiceRequest<TRequest>
    {
        TRequest GetValue();
    }
}