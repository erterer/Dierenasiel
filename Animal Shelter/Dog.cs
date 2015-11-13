using System;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace AnimalShelter
{
    public class Dog : Animal, IPrice
    {
        //Fields
        private SimpleDate lastWalkDate;
        public SimpleDate LastWalkDate
        {
            get { return lastWalkDate; }
            set { lastWalkDate = value; }
        }
        

        //Constructor
        public Dog(string chipRegistrationNumber, SimpleDate dateOfBirth,
            string name, string isReserved, SimpleDate lastWalkDate)
            : base (chipRegistrationNumber, dateOfBirth, name, isReserved)
        {
            LastWalkDate = lastWalkDate;
        }

        //Abstract Method
        public override void MakeNoise()
        {
            MessageBox.Show("Deze hond maakt geen stom geluid!");
        }

        //Interface Method
        public override void SetPrice()
        {
            int number = Convert.ToInt32(ChipRegistrationNumber);
            
            if(number < 50000)
            {
                Price = 200;
            }
            else
            {
                Price = 350;
            }
        }

        //ToString method
        public override string ToString()
        {
            return base.ToString() + ", " + LastWalkDate;
        }
    }
}
