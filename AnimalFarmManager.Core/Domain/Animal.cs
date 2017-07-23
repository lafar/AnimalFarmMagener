using System;

namespace AnimalFarmManager.Core.Domain
{
    public class Animal
    {
        protected Animal()
        { }

        public Animal(Mother mother, Father father, SexType sex, DateTime birthDate)
        {
            Id = Guid.NewGuid();
            Mother = mother;
            Father = father;
            Sex = sex;
            BirthDate = birthDate;
        }
        public Animal(Mother mother, Father father, SexType sex) : this(mother, father, sex, DateTime.UtcNow)
        {
          
        }

        public Guid Id { get; protected set; }
        public DateTime BirthDate { get; protected set; }

        public DateTime DeathDate { get; protected set; }
        public DateTime SaleDate { get; protected set; }
        public SexType Sex { get; protected set; }

        public Cage Cage { get; protected set; }
        public Mother Mother { get; protected set; }
        public Father Father { get; protected set; }
    }
    public enum SexType
    {
        Female,
        Male
    }
}
