using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dierenasiel
{
    public partial class Dierenasiel : Form
    {
        private Administration administration;
        private bool checkboxcheck = false;
        enum Animals
        {
            Cat,
            Dog
        }

        public Dierenasiel()
        {
            InitializeComponent();
            administration = new Administration();
            animalTypeComboBox.Items.Add(Animals.Cat);
            animalTypeComboBox.Items.Add(Animals.Dog);
            animalTypeComboBox.SelectedIndex = 0;

            //Default Cats and Dogs
            administration.Add(new Dog("Ivan", "3212", new SimpleDate(12, 3, 2014), new SimpleDate(12, 3, 2015)));
            administration.Add(new Dog("Milton", "45231", new SimpleDate(6, 12, 2010), new SimpleDate(11, 3, 2015)));
            administration.Add(new Cat("Kevin", "23452", new SimpleDate(12, 3, 405), "Mummified"));

            //Ini Refresh
            RefreshAnimals(false);
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            if (animalTypeComboBox.SelectedItem.Equals(Animals.Cat))
            {
                //Create New Cat
                Cat nyanCat = new Cat(tbName.Text, tbChip.Text, new SimpleDate(dtpDOB.Value.Day, dtpDOB.Value.Month, dtpDOB.Value.Year), txBadHabit.Text);
                administration.Add(nyanCat);
            }
            else if (animalTypeComboBox.SelectedItem.Equals(Animals.Dog))
            {
                //Create New Dog
                Dog dogeDog = new Dog(tbName.Text, tbChip.Text, new SimpleDate(dtpDOB.Value.Day, dtpDOB.Value.Month, dtpDOB.Value.Year), new SimpleDate(dtpLastWalkDate.Value.Day, dtpLastWalkDate.Value.Month, dtpLastWalkDate.Value.Year));
                administration.Add(dogeDog);
            }
            else
            {
                //What?
                MessageBox.Show("What?!");
            }
            RefreshAnimals(false);
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. not very usefull!
        /// </summary>
        /*private void showInfoButton_Click(object sender, EventArgs e)
        {
            foreach (Animal animal in administration.animals)
            {
                if (cbAnimalNames.SelectedItem == animal.Name)
                {
                    lblpInfoName.Text = animal.Name;
                    lblpInfoDOB.Text = animal.DateOfBirth.ToString();
                    lblpInfoChip.Text = animal.ChipRegistrationNumber;
                    
                    if (animal.IsReserved)
                    {
                        chbReserved.Checked = true;
                    }
                    else
                    {
                        chbReserved.Checked = false;
                    }

                    if (animal.GetType() == typeof(Cat))
                    {
                        Cat cat = (Cat)animal;
                        lblInfoExtra.Text = "Bad Habit";
                        lblpInfoExtra.Text = cat.BadHabits;
                    }
                    else if (animal.GetType() == typeof (Dog))
                    {
                        Dog dog = (Dog)animal;
                        lblInfoExtra.Text = "LastWalkDate";
                        lblpInfoExtra.Text = Convert.ToString(dog.LastWalkDate);
                    }
                }
            }  
        }*/

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
            lblInfoExtra.Text = "";
        }

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

        private void cbAnimalNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Animal animal in administration.animals)
            {
                if (cbAnimalNames.SelectedItem == animal.Name)
                {
                    lblpInfoName.Text = animal.Name;
                    lblpInfoDOB.Text = animal.DateOfBirth.ToString();
                    lblpInfoChip.Text = animal.ChipRegistrationNumber;


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
            string tempChip = "";
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
