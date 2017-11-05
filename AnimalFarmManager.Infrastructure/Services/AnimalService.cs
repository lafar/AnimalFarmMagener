using System;
using System.Collections.Generic;
using AnimalFarmManager.Core.Repositories;
using AnimalFarmManager.Infrastructure.DTO;

namespace AnimalFarmManager.Infrastructure.Services
{
    class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }


        

        public void Create(string mother, string father, DateTime birthDate, string description = "")
        {
            var animal = _animalRepository.Get(mother, father, birthDate);
        }

        public IEnumerable<AnimalDTO> Get(string mother, string father, DateTime birthDate)
        {
            throw new NotImplementedException();
        }
    }
}