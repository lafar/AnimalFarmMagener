using System;

namespace AnimalFarmManager.Core.Domain
{
    public class Animal
    {
        protected Animal()
        {
        }

        public Animal(Mother mother, Father father, Gender sex, DateInfo birthDate)
        {
            Id = Guid.NewGuid();
            Mother = mother;
            Father = father;
            Sex = sex;
            BirthDate = birthDate;
           // Cage = mother.Cage;
            
        }

        public Animal(Mother mother, Father father, Gender sex) : this(mother, father, sex, new DateInfo(){Date = DateTime.UtcNow})
        {

        }

        public Guid Id { get; protected set; }
        public DateInfo BirthDate { get; protected set; }

        public DateInfo DeathDate { get; protected set; }
        public DateInfo SaleDate { get; protected set; }
        public Gender Sex { get; protected set; }

        public Cage Cage { get; protected set; }
        public Mother Mother { get; protected set; }
        public Father Father { get; protected set; }

    }

    public enum Gender
    {
        Female,
        Male
    }

    public struct DateInfo
    {
        public DateTime Date;
        public string Description;
    }
}

  
