using System;

namespace AnimalFarmManager.Core.Domain
{
    public class Father
    {
        public Guid ID { get; protected set; }
        public Guid AnimalId { get; protected set; }
        public string Name { get; protected set; }

    }
}
