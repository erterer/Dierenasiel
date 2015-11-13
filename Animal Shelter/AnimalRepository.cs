using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class AnimalRepository
    {
        private IAnimalContext context;

        /// <summary>
        /// Configure the interface Context
        /// </summary>
        /// <param name="context"></param>
        public AnimalRepository(IAnimalContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Get an animal by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Animal GetAnimal(Animal animal)
        {
            return context.GetAnimal(animal);
        }

        /// <summary>
        /// Return all current saved animals
        /// </summary>
        /// <returns></returns>
        public List<Animal> GetAll()
        {
            return context.GetAll();
        }

        /// <summary>
        /// Insert an animal into the database
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public bool InsertAnimal(Animal animal)
        {
            return context.InsertAnimal(animal);
        }

        /// <summary>
        /// Delete an animal from the database
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public bool DeleteAnimal(string chipNumber)
        {
            return context.DeleteAnimal(chipNumber);
        }
    }
}
