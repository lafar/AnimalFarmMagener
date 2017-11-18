using System;
using System.Collections.Generic;
using AnimalFarmManager.Core.Domain;

namespace AnimalFarmManager.Core.Repositories
{
    public interface IFatherRepository
    {
        Father Get(Guid id);
        Father Get(string name);
        void Add(Father animal);
        void Upadate(Father animal);
        void Remove(Guid id);
        
    }
}
