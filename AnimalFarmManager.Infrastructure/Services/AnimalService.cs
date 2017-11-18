using System;
using System.Collections.Generic;
using AnimalFarmManager.Core.Repositories;
using AnimalFarmManager.Infrastructure.DTO;

namespace AnimalFarmManager.Infrastructure.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;
        private readonly IMotherRepository motherRepository;
        private readonly IFatherRepository fatherRepository;

        public AnimalService(IAnimalRepository animalRepository, IMotherRepository motherRepository, IFatherRepository fatherRepository)
        {
            _animalRepository = animalRepository;
            this.motherRepository = motherRepository;
            this.fatherRepository = fatherRepository;
        }

        public void Create(string motherName, string fatherName)
        {
            Create(motherRepository.Get(motherName), fatherRepository.Get(fatherName), DateTime.UtcNow);

        }
        

        protected void Create(string mother, string father, DateTime birthDate, string description = "")
        {
            var animal = _animalRepository.Get(mother, father, birthDate);
        }

        public IEnumerable<AnimalDTO> Get(string mother, string father, DateTime birthDate)
        {
            throw new NotImplementedException();
        }
    }
}