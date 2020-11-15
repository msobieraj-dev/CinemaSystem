namespace CinemaSystem.Domain.Repositories.Shared
{
    using CinemaSystem.Domain.Entities.Shared;

    public interface IRepository<TEntity>
        where TEntity : Entity
    {
    }
}