using System;
using System.Collections.Generic;
using AnimalFarmManager.Core.Domain;

namespace AnimalFarmManager.Core.Repositories
{
    public interface IMotherRepository
    {
        Mother Get(Guid id);
        Mother Get(string name);
        void Add(Mother animal);
        void Upadate(Mother animal);
        void Remove(Guid id);
        
    }
}
