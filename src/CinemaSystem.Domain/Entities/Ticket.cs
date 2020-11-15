namespace CinemaSystem.Domain.Entities
{
    using CinemaSystem.Domain.Entities.Shared;

    public class Ticket : Entity
    {
        public long SeatId { get; set; } //REF
        public long MovieDisplayId { get; set; } //REF

        public string User { get; set; }
        public string Code { get; set; }
    }
}