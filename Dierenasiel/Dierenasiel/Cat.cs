using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dierenasiel
{
    public class Cat : Animal
    {
        public string BadHabits { get; private set; }

        public Cat(string name, string chipRegistrationNumber, SimpleDate dateOfBirth, string badHabits) : base(name, chipRegistrationNumber, dateOfBirth)
        {
            BadHabits = badHabits;
        }

        public override string ToString()
        {
            return base.ToString() + "," + BadHabits;
        }
    }
}
