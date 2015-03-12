using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dierenasiel
{
    public class Administration
    {
        public List<Animal> animals { get; private set; }
        public Animal Animal { get; private set; }

        
        public Administration()
        {
            animals = new List<Animal>();
        }

        public bool Add(Animal animal)
        {
            try
            {
                animals.Add(animal);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveAnimal(string chipRegistrationNumber)
        {
            Animal animalToRemove = null;
            foreach (Animal animal in animals)
            {
                if (animal.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    animalToRemove = animal;
                }
            }
            animals.Remove(animalToRemove);
            return true;
        }

        public Animal FindAnimal(string chipRegistrationNumber)
        {
            //todo
            return Animal;
        }
    }
}
