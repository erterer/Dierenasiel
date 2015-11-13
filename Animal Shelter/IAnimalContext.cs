using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public interface IAnimalContext
    {
        Animal GetAnimal(Animal animal);

        List<Animal> GetAll();

        bool InsertAnimal(Animal animal);

        bool DeleteAnimal(string chipNumber);
    }
}
