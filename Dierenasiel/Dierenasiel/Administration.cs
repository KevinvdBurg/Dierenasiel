using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Dierenasiel
{
    public delegate void AnimalAdded(object sender, AnimalEventArgs e);
    public class Administration
    {
        //FIELDS
        public event AnimalAdded OnAnimalAdded;
        /// <summary>
        ///the location of the Default save folder
        /// </summary>
        private string directory = @"c:\Dierenasiel";

        /// <summary>
        /// default name of the save file
        /// </summary>
        private string file = "save.bin";

        //PROPERTIES
        /// <summary>
        /// List<Animal> animals includes all instances of the Animal class that are created within this system.
        /// </summary>
        public List<Animal> animals { get; private set; }

        public List<Animal> oldAnimals { get; private set; }

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
            try
            {
                animals = oldAnimals;
                animals = new List<Animal>();
            }
            catch (Exception e)
            {
                Console.WriteLine("List is not created: {0}", e.Message);
            }
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
                AnimalEventArgs e = new AnimalEventArgs();

                e.animals.Add(animal);

                OnAnimalAdded(this, e);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Adding an Animal has failed: {0}", e.Message);
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
            bool sucRemoveAnimal = false;
            try
            {
                Animal animalToRemove = null;
                foreach (Animal animal in animals)
                {
                    if (animal.ChipRegistrationNumber == Convert.ToInt32(chipRegistrationNumber))
                    {
                        animalToRemove = animal;
                    }
                }
                sucRemoveAnimal = true;
                animals.Remove(animalToRemove);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to Remove: {0}", e.Message);
            }
            return sucRemoveAnimal;
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
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Dierasiel|*.bin";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fullPath = saveFileDialog.FileName;
                    int last = fullPath.LastIndexOf("\\");
                    directory = fullPath.Substring(0, last);
                    file = fullPath.Substring(last + 1);
                    //string[] ar = fullPath.Split('\\');
                }
                else
                {
                    throw new NoMapException("Can not Select no map", "Save File Dialog");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("geen map geselecteerd");
                Console.WriteLine("Noting selected: {0}", e.Message);
            }

            try
            {
                // Determine whether the directory exists. 
                if (Directory.Exists(directory))
                {
                    Console.WriteLine("That directory exists already.");
                }
                else
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(directory);
                    Console.WriteLine("The directory was created successfully at {0}.",
                        Directory.GetCreationTime(directory));
                }

                string serializationFile = Path.Combine(directory, file);
                //string serializationFile = directory;

                //serialize
                using (Stream stream = File.Open(serializationFile, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, animals);
                    MessageBox.Show("Dieren zijn opgeslagen");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
            }
        }

        /// <summary>
        /// Load the save.bin from the C:/Dierenasiel folder
        /// </summary>
        public void LoadContent()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Dierasiel|*.bin";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fullPath = openFileDialog1.FileName;
                int last = fullPath.LastIndexOf("\\");
                directory = fullPath.Substring(0, last);
                file = fullPath.Substring(last + 1);
            }

            string serializationFile = Path.Combine(directory, file);

            //deserialize
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                List<Animal> steamAnimals = (List<Animal>) bformatter.Deserialize(stream);
                this.animals = steamAnimals;
            }
            MessageBox.Show("Dieren zijn geladen");
        }
    }
}