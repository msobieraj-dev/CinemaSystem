namespace CinemaSystem.Domain.Entities
{
    using CinemaSystem.Domain.Entities.Shared;
    using System.Collections.Generic;

    public class Cinema : Entity
    {
        public string Name { get; set; } //UNIQUE
        public string City { get; set; }
        public string Adress { get; set; }

        public ICollection<Room> Rooms { get; set; } //REF
    }
}