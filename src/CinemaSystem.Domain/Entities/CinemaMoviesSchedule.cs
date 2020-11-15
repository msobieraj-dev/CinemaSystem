namespace CinemaSystem.Domain.Entities
{
    using CinemaSystem.Domain.Entities.Shared;
    using System;
    using System.Collections.Generic;

    public class CinemaMoviesSchedule : Entity
    {
        public long CinemaId { get; set; } //REF

        public string Name { get; set; }
        public int BreakPeriodMinutes { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public ICollection<MovieDisplay> MovieDisplayes { get; set; } //REF
    }
}