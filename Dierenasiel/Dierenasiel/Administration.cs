using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dierenasiel
{
    public class Administration
    {
        //PROPERTIES
        /// <summary>
        /// List<Animal> animals includes all instances of the Animal class that are created within this system.
        /// </summary>
        public List<Animal> animals { get; private set; }
        /// <summary>
        /// The Animal Animal property is an instance of the Animal class.
        /// </summary>
        public Animal Animal { get; private set; }

        //CONSTRUCTORS
        /// <summary>
        /// The Administration constructor creates a list of Animals called animals
        /// </summary>
        public Administration()
        {
            animals = new List<Animal>();
        }

        //METHODS
        /// <summary>
        /// The Add method adds an instance of the Animal class to the list of animals. It returns true if it succeeds, and it returns false when it fails.
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
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
        /// <summary>
        /// The RemoveAnimal method removes an animal that has the given chipRegistrationNumber from the list of animals.
        /// </summary>
        /// <param name="chipRegistrationNumber"></param>
        /// <returns></returns>
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
        /// <summary>
        /// The FindAnimal method finds a animal with the given chipRegistrationNumber.
        /// If an animal with the given chipRegistrationNumber is found, this method will return said animal, otherwise it will return false.
        /// </summary>
        /// <param name="chipRegistrationNumber"></param>
        /// <returns></returns>
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