namespace CinemaSystem.Domain.Entities
{
    using CinemaSystem.Domain.Entities.Shared;
    using System.Collections.Generic;

    public class Room : Entity
    {
        public long CinemaId { get; set; } //REF

        public string Name { get; set; }

        public ICollection<Row> Rows { get; set; } //REF
    }
}