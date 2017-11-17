using System;
using System.Collections.Generic;
using AnimalFarmManager.Infrastructure.DTO;

namespace AnimalFarmManager.Infrastructure.Services
{
    public interface IAnimalService
    {
        void Create(string mother, string father, DateTime birthDate, string description);
        IEnumerable<AnimalDTO> Get(string mother, string father, DateTime birthDate);
    }
}
