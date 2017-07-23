using System;

namespace AnimalFarmManager.Core.Domain
{
    public class Father
    {
        public Guid Id { get; protected set; }
        public Guid AnimalId { get; protected set; }
        public string Name { get; protected set; }

    }
}
