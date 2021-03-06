﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dierenasiel
{
    public abstract class Animal
    {
        private const int chipRegistrationNumberMaxLength = 5;

        public string Name { get; private set; }

        public bool IsReserved { get; set; }

        public string ChipRegistrationNumber { get; private set; }

        public SimpleDate DateOfBirth { get; private set; }


        /// <summary>
        /// Creates an animal.
        /// </summary>
        /// <param name="chipRegistrationNumber">A five digit number containing the chip registration 
        /// number of the animal. If the given number contains less than 5 digits, then it will be
        /// stuffed with zero's from the left. So "5" becomes "00005". If the given number contains
        /// more than 5 digits, then the number is truncated after the 5th position. So "1234567"
        /// becomes "12345"</param>
        /// <param name="dateOfBirth">The date of birth of the animal or null if unknown</param>
        /// <param name="name">The name of the animal or null if unknown</param>
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

            if (name == null)
            {
                Name = null;
            }
            else
            {
                Name = name;
            }

            if (dateOfBirth == null)
            {
                DateOfBirth = null;
            }
            else
            {
                DateOfBirth = dateOfBirth;     
            }
            
            IsReserved = false; 
        }

        /// <summary>
        /// Retrieve information about this animal
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "<ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>"
        ///          Where: DateOfBirth will be "00-00-0000" if unknown or the actual date otherwise.
        ///                 Name will be "noname" if unknown or the actual name otherwise.
        ///                 IsReserved will be "reserved" if reserved or "not reserved" otherwise. 
        /// </returns>
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
            if (String.IsNullOrEmpty(Name))
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
