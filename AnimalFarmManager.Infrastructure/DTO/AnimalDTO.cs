using System;
using AnimalFarmManager.Core.Domain;

namespace AnimalFarmManager.Infrastructure.DTO
{
    public class AnimalDTO
    {
        public Guid Id { get;  set; }
        public DateTime BirthDate { get;  set; }

        public DateTime DeathDate { get;  set; }
        public DateTime SaleDate { get;  set; }
        public Gender Sex { get;  set; }

        public Cage Cage { get;  set; }
    }
}
