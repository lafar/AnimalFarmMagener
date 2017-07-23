using System;
using System.Collections.Generic;
using AnimalFarmManager.Infrastructure.DTO;

namespace AnimalFarmManager.Infrastructure.Services
{
    internal interface IAnimalService
    {
        void Create(string mother, string father, DateTime birthDate);
        IEnumerable<AnimalDTO> Get(string mother, string father, DateTime birthDate);
    }
}
