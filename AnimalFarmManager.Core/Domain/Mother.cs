using System;

namespace AnimalFarmManager.Core.Domain
{
    public class Mother
    {
        public Guid Id { get; protected set; }
        public Guid AnimalId { get; protected set; }
        public string Name { get; protected set; }

    }
}
