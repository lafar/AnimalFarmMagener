
using System;
using System.Collections.Generic;
using System.Linq;
using AnimalFarmManager.Core.Domain;
using AnimalFarmManager.Core.Repositories;

namespace AnimalFarmManager.Infrastructure.Repositories
{
    public class InMemoryAnimalRepository : IAnimalRepository
    {
        private static ISet<Animal> _animals = new HashSet<Animal>();
           public Animal Get(Guid id)
        {
            return _animals.Single(x => x.Id == id);
        }

        public IEnumerable<Animal> GetAll()
        {
            return _animals;
        }

        public void Add(Animal animal)
        {
            _animals.Add(animal);
        }

        public void Upadate(Animal animal)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            var animal = Get(id);
            _animals.Remove(animal);
        }

        public IEnumerable<Animal> Get(string mother, string father, DateTime birthDate)
        {
            return _animals.Where(x => x.Mother.Name == mother && x.Father.Name == father && x.BirthDate.Date == birthDate);
        }
    }
}
