using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarmManager.Core.Domain
{
    public class Cage
    {
        public Guid Id { get; protected set; }
        public int Number
        {
            get; protected set;
        }
    }
}
