using System;
using System.Collections.Generic;

namespace Model
{
    public class CustomerRecord : Record
    {
        public string FirstName { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }
        public short Age { get; private set; }
        public bool Gender { get; private set; }
        public short NumberOfRents { get; private set; }
        public DateTime RegistrationDateTime { get; private set; }

        public CustomerRecord(string firstName, string surname, string patronymic, short age, bool gender, DateTime registrationDateTime, short numberOfRents = 0)
        {
            FirstName = firstName;
            Surname = surname;
            Patronymic = patronymic;
            Age = age;
            Gender = gender;
            NumberOfRents = numberOfRents;
            RegistrationDateTime = registrationDateTime;
        }

        public char GetGenderToChar()
        {
            return GenderBoolToCharDictionary[Gender];
        }

        private static Dictionary<bool, char> GenderBoolToCharDictionary = new Dictionary<bool, char>
        {
            [false] = 'F',
            [true] = 'M'
        };
    }
}
