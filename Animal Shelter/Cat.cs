using System;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using System.IO;

namespace AnimalShelter
{
    public class Cat : Animal, IPrice
    {
        //Fields
        private string badHabits;
        public string BadHabits
        {
            get { return badHabits; }
            set { badHabits = value; }
        }


        //Constructor
        public Cat(string chipRegistrationNumber, SimpleDate dateOfBirth,
            string name, string isReserved, string badHabits)
            : base(chipRegistrationNumber, dateOfBirth, name, isReserved)
        {
            BadHabits = badHabits;
        }

        //Abstract Method
        public override void MakeNoise()
        {
            MessageBox.Show("Deze kat maakt een stom geluid!");   
        }

        //Interface Method
        public override void SetPrice()
        {
            int badHabitslength = Convert.ToInt32(BadHabits.Length);
            double tempPrice = 60 - badHabitslength;

            if(tempPrice < 20)
            {
                Price = 20;
            }
            else
            {
                Price = tempPrice;
            }
        }

        //ToString Method
        public override string ToString()
        {
            return base.ToString() + ", " + BadHabits;
        }
    }
}
