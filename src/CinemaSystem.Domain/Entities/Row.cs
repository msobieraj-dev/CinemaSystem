namespace CinemaSystem.Domain.Entities
{
    using CinemaSystem.Domain.Entities.Shared;
    using System.Collections.Generic;

    public class Row : Entity
    {
        public long RoomId { get; set; } //REF

        public int Number { get; set; }

        public ICollection<Seat> Seats { get; set; } //REF
    }
}