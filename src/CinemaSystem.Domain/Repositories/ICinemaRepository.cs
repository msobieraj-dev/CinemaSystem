namespace CinemaSystem.Domain.Repositories
{
    using CinemaSystem.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ICinemaRepository
    {
        ICollection<Cinema> GetCinemaStructure();
    }
}