using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dierenasiel
{
    public abstract class Animal
    {
        private const int chipRegistrationNumberMaxLength = 5;

        public string Name { get; private set; }

        public bool IsReserved { get; private set; }

        public string ChipRegistrationNumber { get; private set; }

        public SimpleDate DateOfBirth { get; private set; }

        public Animal(string name, string chipRegistrationNumber, SimpleDate dateOfBirth)
        {
           
            if (chipRegistrationNumber.Length < chipRegistrationNumberMaxLength)
            {
                ChipRegistrationNumber = chipRegistrationNumber.PadLeft(chipRegistrationNumberMaxLength, '0');
            }
            else if (chipRegistrationNumber.Length > chipRegistrationNumberMaxLength)
            {
                ChipRegistrationNumber = chipRegistrationNumber.Substring(0, chipRegistrationNumberMaxLength);
            }
            else
            {
                ChipRegistrationNumber = chipRegistrationNumber;
            }

            Name = name;
            DateOfBirth = dateOfBirth;
            IsReserved = false; 
        }

        public virtual string ToString()
        {
            string dateOfBirthString;
            if (DateOfBirth == null)
            {
                dateOfBirthString = "00-00-0000";
            }
            else
            {
                dateOfBirthString = DateOfBirth.ToString();
            }

            string nameString;
            if (Name == null || Name == "")
            {
                nameString = "noname";
            }
            else
            {
                nameString = Name;
            }

            string IsReservedString;
            if (IsReserved)
            {
                IsReservedString = "reserved";
            }
            else
            {
                IsReservedString = "not reserved";
            }

            string info = ChipRegistrationNumber
                + ", " + dateOfBirthString
                + ", " + nameString
                + ", " + IsReservedString;

            return info;
        }
    }
}
