using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Dierenasiel
{
    public class Administration
    {

        //FIELDS
        /// <summary>
        ///the location of the save folder
        /// </summary>
        string directory = @"c:\Dierenasiel";

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

        /// <summary>
        /// Saves the list of animals to save.bin in the C:/Dierenasiel
        /// </summary>
        public void SaveContent()
        {
            //Creates a new Directory @ C:/Dierenasiel
            try
            {
                // Determine whether the directory exists. 
                if (Directory.Exists(directory))
                {
                    Console.WriteLine("That directory exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(directory);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(directory));

                // Delete the directory.
                //di.Delete();
                ///Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                //throw exeption
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally
            {
                string serializationFile = Path.Combine(directory, "save.bin");

                //serialize
                using (Stream stream = File.Open(serializationFile, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, animals);
                }
            }
        }

        /// <summary>
        /// Load the save.bin from the C:/Dierenasiel folder
        /// </summary>
        public void LoadContent()
        {
            string serializationFile = Path.Combine(directory, "save.bin");
           
            //deserialize
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                List<Animal> steamAnimals = (List<Animal>)bformatter.Deserialize(stream);
                this.animals = steamAnimals;
            }
        }


    }
}