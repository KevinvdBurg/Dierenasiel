using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dierenasiel
{
    public partial class AdministrationForm : Form
    {
        //FIELDS
        /// <summary>
        /// The administration Male is an instance of the class Administration.
        /// </summary>
        private Administration administration;
        /// <summary>
        /// The checkboxcheck is an bool that resembles wether or not an animal has been set to reserved.
        /// </summary>
        private bool checkboxcheck;
        /// <summary>
        /// The Animals enum is an enum Male that includes Cat and Dog.
        /// </summary>
        enum Animals
        {
            Cat,
            Dog
        }

        //CONSTRUCTORS
        /// <summary>
        /// The constructor sets the initial values of the fields, creates a certain amount of premade instances of the Dog and Cat classes, and refreshes the animals list so these new instances will show up on the GUI.
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();

            checkboxcheck = false;
            administration = new Administration();
            animalTypeComboBox.Items.Add(Animals.Cat);
            animalTypeComboBox.Items.Add(Animals.Dog);
            cbGender.Items.Add(Gender.Female);
            cbGender.Items.Add(Gender.Male);
            cbGender.SelectedIndex = 0;
            animalTypeComboBox.SelectedIndex = 0;

            //Default Cats and Dogs
            administration.Add(new Dog("Ivan", 3212, new SimpleDate(12, 3, 2014), Gender.Female, new SimpleDate(12, 3, 2015)));
            administration.Add(new Dog("Milton", 45231, new SimpleDate(6, 12, 2010), Gender.Male, new SimpleDate(11, 3, 2015)));
            administration.Add(new Cat("Kevin", 23452, new SimpleDate(12, 3, 405), Gender.Male, "Mummified"));

            //Ini Refresh
            RefreshAnimals(false);
        }

        //METHODS
        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            Animal chipAnimal = administration.animals.Find(Animal => Animal.ChipRegistrationNumber == Convert.ToInt32(nupChip.Value));

            if (chipAnimal != null)
            {
                MessageBox.Show("chipnr is al in gebruik");
                return;
            }

            if (String.IsNullOrEmpty(Regex.Replace(name, @"\s+", "")))
            {
                MessageBox.Show("U heeft geen naam ingevuld");
                return;
            }

            if (animalTypeComboBox.SelectedItem.Equals(Animals.Cat))
            {
                //Create New Cat
                Animal nyanCat = new Cat(tbName.Text, Convert.ToInt32(nupChip.Value), new SimpleDate(dtpDOB.Value.Day, dtpDOB.Value.Month, dtpDOB.Value.Year), (Gender)Enum.Parse(typeof(Gender), cbGender.SelectedText), txBadHabit.Text);
                administration.Add(nyanCat);
            }
            else if (animalTypeComboBox.SelectedItem.Equals(Animals.Dog))
            {
                //Create New Dog
                Animal dogeDog = new Dog(tbName.Text, Convert.ToInt32(nupChip.Value), new SimpleDate(dtpDOB.Value.Day, dtpDOB.Value.Month, dtpDOB.Value.Year), (Gender)Enum.Parse(typeof(Gender), cbGender.SelectedText), new SimpleDate(dtpLastWalkDate.Value.Day, dtpLastWalkDate.Value.Month, dtpLastWalkDate.Value.Year));
                administration.Add(dogeDog);
            }
            else
            {
                //What?
                MessageBox.Show("What?!");
            }
            RefreshAnimals(false);
        }
        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Disables the LastWalkdate if the Animal type is a Cat
            if (animalTypeComboBox.SelectedItem.Equals(Animals.Cat))
            {
                txBadHabit.Enabled = true;
                dtpLastWalkDate.Enabled = false;

            }
            //Disables BadHabits if the Animal type is a Cat
            else if (animalTypeComboBox.SelectedItem.Equals(Animals.Dog))
            {
                txBadHabit.Enabled = false;
                dtpLastWalkDate.Enabled = true;
            }
            else
            {
                txBadHabit.Enabled = false;
                dtpLastWalkDate.Enabled = false;
            }
        }
        
        //Refresh the combobox and the lists
        private void RefreshAnimals(bool hasChanged)
        {
            
            lbReserved.Items.Clear();
            lbNotReserved.Items.Clear();
            if (!hasChanged)
            {
                cbAnimalNames.Items.Clear();
            }
            
            foreach (Animal animal in administration.animals)
            {
                if (!hasChanged)
                {
                    cbAnimalNames.Items.Add(animal.Name);
                }
                
                if (animal.IsReserved)
                {
                    lbReserved.Items.Add(animal.ToString());
                }

                if (!animal.IsReserved)
                {
                    lbNotReserved.Items.Add(animal.ToString());
                }
            }

            cbAnimalNames.Text = "";
            cbAnimalNames.SelectedIndex = -1;

            lblpInfoName.Text = "";
            lblpInfoChip.Text = "";
            lblpInfoDOB.Text = "";
            lblpInfoExtra.Text = "";
            lblpInfoPrice.Text = "";
            lblInfoExtra.Text = "";
            
        }

        //Checkbox changed check
        private void chbReserved_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkboxcheck)
            {
                foreach (Animal animal in administration.animals)
                {
                    if (cbAnimalNames.SelectedItem == animal.Name)
                    {
                        if (chbReserved.Checked)
                        {
                            animal.IsReserved = true;
                        }
                        else if (!chbReserved.Checked)
                        {
                            animal.IsReserved = false;
                        }
                    }
                }
                RefreshAnimals(true);
            }
            
        }


        //Add all the data to the info box
        private void cbAnimalNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Animal animal in administration.animals)
            {
                if (cbAnimalNames.SelectedItem == animal.Name)
                {
                    lblpInfoName.Text = animal.Name;
                    lblpInfoDOB.Text = animal.DateOfBirth.ToString();
                    lblpInfoChip.Text = Convert.ToString(animal.ChipRegistrationNumber);
                    lblpInfoPrice.Text = Convert.ToString(animal.Price);

                    if (animal.IsReserved)
                    {
                        checkboxcheck = true;
                        chbReserved.Checked = true;
                        checkboxcheck = false;
                    }
                    else
                    {
                        checkboxcheck = true;
                        chbReserved.Checked = false;
                        checkboxcheck = false;
                    }

                    if (animal.GetType() == typeof(Cat))
                    {
                        Cat cat = (Cat)animal;
                        lblInfoExtra.Text = "Bad Habit";
                        lblpInfoExtra.Text = cat.BadHabits;
                    }
                    else if (animal.GetType() == typeof(Dog))
                    {
                        Dog dog = (Dog)animal;
                        lblInfoExtra.Text = "LastWalkDate";
                        lblpInfoExtra.Text = Convert.ToString(dog.LastWalkDate);
                    }
                }
            }
            DisableButtons();
        }

        private void btnDeleteAnimal_Click(object sender, EventArgs e)
        {
            int tempChip = -1;
            foreach (Animal animal in administration.animals)
            {
                if (cbAnimalNames.SelectedItem == animal.Name)
                {
                    tempChip = animal.ChipRegistrationNumber;
                }
            }
            administration.RemoveAnimal(tempChip);
            RefreshAnimals(false);
            DisableButtons();
        }

        private void DisableButtons()
        {
            if (String.IsNullOrEmpty(cbAnimalNames.Text))
            {
                chbReserved.Enabled = false;
                btnDeleteAnimal.Enabled = false;
            }
            else
            {
                chbReserved.Enabled = true;
                btnDeleteAnimal.Enabled = true;
            }
        }
    }
}
