using System.Runtime.Serialization;
namespace AnimalShelter
{
    public abstract class Animal : IPrice
    {
        //Fields
        private const int chipRegistrationNumberMaxLength = 5;
        private string chipRegistrationNumber;
        private SimpleDate dateOfBirth;
        private string name;
        private string isReserved;

        public string ChipRegistrationNumber
        {
            get { return chipRegistrationNumber; }
        }
        public SimpleDate DateOfBirth
        {
            get { return dateOfBirth; }
        }
        public string Name
        {
            get { return name; }
        }
        public string IsReserved
        {
            get { return isReserved; }
            set { isReserved = value; }
        }
        public double Price { get; set; }

        //Constructor
        public Animal(string chipRegistrationNumber, SimpleDate dateOfBirth, string name, string isReserved)
        {
            if (chipRegistrationNumber.Length < chipRegistrationNumberMaxLength)
            {
                this.chipRegistrationNumber
                    = chipRegistrationNumber.PadLeft(chipRegistrationNumberMaxLength, '0');
            }
            else if (chipRegistrationNumber.Length > chipRegistrationNumberMaxLength)
            {
                this.chipRegistrationNumber
                    = chipRegistrationNumber.Substring(0, chipRegistrationNumberMaxLength);
            }
            else
            {
                this.chipRegistrationNumber = chipRegistrationNumber;
            }

            this.dateOfBirth = dateOfBirth;
            this.name = name;
            IsReserved = isReserved;
        }

        //Abstract Methods
        public abstract void MakeNoise();
        public abstract void SetPrice();

        //ToString Method
        public override string ToString()
        {
            string dateOfBirthString;
            if (dateOfBirth == null)
            {
                dateOfBirthString = "00-00-0000";
            }
            else
            {
                dateOfBirthString = dateOfBirth.ToString();
            }

            string nameString;
            if (name == null || name == "")
            {
                nameString = "noname";
            }
            else
            {
                nameString = name;
            }

            string info = ChipRegistrationNumber
                + ", " + dateOfBirthString
                + ", " + nameString
                + ", " + IsReserved
                +", " + Price.ToString("C");

            return info;
        }
    }
}
