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

        //Add an Animal to the list
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

        //Search the Animal list by chipRegistrationNumber and removes it
        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            Animal animalToRemove = null;
            foreach (Animal animal in animals)
            {
                if (animal.ChipRegistrationNumber == Convert.ToInt32(chipRegistrationNumber))
                {
                    animalToRemove = animal;
                }
            }
            animals.Remove(animalToRemove);
            return true;
        }

        //Search the Animal list by chipRegistrationNumber
        public Animal FindAnimal(string chipRegistrationNumber)
        {
            foreach (Animal animal in animals)
            {
                if (animal.ChipRegistrationNumber == Convert.ToInt32(chipRegistrationNumber))
                {
                    return animal;
                }
            }
            return null;
        }
    }
}
