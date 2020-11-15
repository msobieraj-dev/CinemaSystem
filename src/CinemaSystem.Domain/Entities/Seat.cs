namespace CinemaSystem.Domain.Entities
{
    using CinemaSystem.Domain.Entities.Shared;

    public class Seat : Entity
    {
        public long RowId { get; set; } //REF

        public int Number { get; set; }
    }
}