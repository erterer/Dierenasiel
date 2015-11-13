using System.Collections.Generic;

namespace AnimalShelter
{
    public class Administration
    {
        //Property's
        private List<Animal> dieren;

        public List<Animal> Dieren
        {
            get { return dieren; }
            set { dieren = value; }
        }


        //Constructor
        public Administration()
        {
            dieren = new List<Animal>();
        }


        //Methods
        public bool Add(Animal animal)
        {
            dieren.Add(animal);

            return true;
        }

        public bool RemoveAnimal(string chipRegistrationNumber)
        {
            foreach (Animal a in dieren)
            {
                if (chipRegistrationNumber == a.ChipRegistrationNumber)
                {
                    dieren.Remove(a);
                    return true;
                }
            }
            return false;
        }

        public string FindAnimal(string chipRegistrationNumber)
        {
            foreach (Animal a in dieren)
            {
                if (chipRegistrationNumber == a.ChipRegistrationNumber)
                {
                    return a.Name;
                }
            }
            return "Niet gevonden";
        }
    }
}
