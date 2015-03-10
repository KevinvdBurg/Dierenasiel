using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dierenasiel
{
    public class Administration
    {
        
        public Animal Animal { get; private set; }

        public Administration()
        {
            throw new System.NotImplementedException();
        }
        public bool Add(Animal animal)
        {
            return true;
        }

        public bool RemoveAnimal(string chipRegistrationNumber)
        {
            return true;
        }

        public Animal FindAnimal(string chipRegistrationNumber)
        {
            //todo
            //return Animal;
        }
    }
}
