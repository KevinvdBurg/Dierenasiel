using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dierenasiel
{
    public class Dog : Animal
    {
        public SimpleDate LastWalkDate { get; private set; }

        public Dog(string name, string chipRegistrationNumber, SimpleDate dateOfBirth, SimpleDate lastWalkDate) : base(name, chipRegistrationNumber, dateOfBirth)
        {
            LastWalkDate = lastWalkDate;
        }

        public override string ToString()
        {
            return base.ToString() + "," + LastWalkDate;
        }
    }
}
