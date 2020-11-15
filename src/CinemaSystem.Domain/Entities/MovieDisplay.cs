namespace CinemaSystem.Domain.Entities
{
    using CinemaSystem.Domain.Entities.Shared;
    using System;

    public class MovieDisplay : Entity
    {
        public long RoomId { get; set; } //REF
        public long MovieId { get; set; } //REF

        public int AdPeriodMinutes { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}