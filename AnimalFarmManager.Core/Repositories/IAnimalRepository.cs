using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalFarmManager.Core.Domain;

namespace AnimalFarmManager.Core.Repositories
{
    public interface IAnimalRepository
    {
        Animal Get(Guid id);
        IEnumerable<Animal> GetAll();

        void Add(Animal animal);
        void Upadate(Animal animal);
        void Remove(Guid id);
        IEnumerable<Animal> Get(string mother, string father, DateTime birthDate);
    }
}
