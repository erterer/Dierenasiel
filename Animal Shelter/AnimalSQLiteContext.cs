using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AnimalShelter
{
    public class AnimalSQLiteContext : IAnimalContext
    {
        /// <summary>
        /// Initialize the database, create file if the database doesn't exist
        /// </summary>
        public AnimalSQLiteContext()
        {
            Database.Initialize();
        }

        /// <summary>
        /// Find an animal by the given Chipnumber
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Animal GetAnimal(Animal animal)
        {
            using (SQLiteConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Animal WHERE Chipnumber=:id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Chipnumber", animal.ChipRegistrationNumber);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return CreateAnimalFromReader(reader);
                        }
                    }
                }
            }

            return null;
        }

        public List<Animal> GetAll()
        {
            List<Animal> result = new List<Animal>();
            using (SQLiteConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Animal ORDER BY Chipnumber";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreateAnimalFromReader(reader));
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Insert a new animal into the database
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public bool InsertAnimal(Animal animal)
        {
            using (SQLiteConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Animal (Chipnumber, Type, DateOfBirth, Name, IsReserved, LastWalkDate, BadHabits)" +
                    " VALUES (:Chipnumber, :Type, :DateOfBirth, :Name, :IsReserved, :LastWalkDate, :BadHabits)";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    if(animal is Dog)
                    {
                        var dog = animal as Dog;

                        command.Parameters.AddWithValue("Chipnumber", animal.ChipRegistrationNumber);
                        command.Parameters.AddWithValue("Type", "Dog");
                        command.Parameters.AddWithValue("DateOfBirth", animal.DateOfBirth);
                        command.Parameters.AddWithValue("Name", animal.Name);
                        command.Parameters.AddWithValue("IsReserved", animal.IsReserved);
                        command.Parameters.AddWithValue("LastWalkDate", dog.LastWalkDate);
                        command.Parameters.AddWithValue("BadHabits", null);
                    }
                    else
                    {
                        var cat = animal as Cat;

                        command.Parameters.AddWithValue("Chipnumber", animal.ChipRegistrationNumber);
                        command.Parameters.AddWithValue("Type", "Cat");
                        command.Parameters.AddWithValue("DateOfBirth", animal.DateOfBirth);
                        command.Parameters.AddWithValue("Name", animal.Name);
                        command.Parameters.AddWithValue("IsReserved", animal.IsReserved);
                        command.Parameters.AddWithValue("BadHabits", cat.BadHabits);
                        command.Parameters.AddWithValue("LastWalkDate", null);
                    }
                    
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        // If a PK constraint was violated, handle the exception
                        if (e.ResultCode == SQLiteErrorCode.Constraint)
                        {
                            return false;
                        }

                        // Unexpected error: rethrow to let the caller handle it
                        throw;
                    }
                }

                // Retrieve the id of the inserted row to create a new student object
                query = "SELECT last_insert_rowid()";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    if(animal is Dog)
                    {
                        var dog = animal as Dog;

                        dog = new Dog(dog.ChipRegistrationNumber, dog.DateOfBirth, dog.Name, dog.IsReserved, dog.LastWalkDate);
                    }
                    else
                    {
                        var cat = animal as Cat;

                        cat = new Cat(cat.ChipRegistrationNumber, cat.DateOfBirth, cat.Name, cat.IsReserved, cat.BadHabits);
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Delete an animal by the given parameter
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public bool DeleteAnimal(string chipNumber)
        {
            using (SQLiteConnection connection = Database.Connection)
            {
                string query = "DELETE FROM Animal WHERE Chipnumber=:id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", chipNumber);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }

                }
            }
            return false;
        }


        /// <summary>
        /// Helper function to construct a Animal instance from a DataReader.
        /// Expects that read() has already been called.
        /// </summary>
        /// <param name="reader">The DataReader to read from.</param>
        /// <returns>A new animal instance based on the read data.</returns>
        private Animal CreateAnimalFromReader(SQLiteDataReader reader)
        {
            if(Convert.ToString(reader["Type"]) == "dog" || Convert.ToString(reader["Type"]) == "Dog")
            {
                return new Dog(
                Convert.ToString(reader["Chipnumber"]),
                SimpleDate.ConvertDate(Convert.ToString(reader["DateOfBirth"])),
                Convert.ToString(reader["Name"]),
                Convert.ToString(reader["IsReserved"]),
                SimpleDate.ConvertDate(Convert.ToString(reader["LastWalkDate"])));
            }
            else
            {
                return new Cat(
                Convert.ToString(reader["Chipnumber"]),
                SimpleDate.ConvertDate(Convert.ToString(reader["DateOfBirth"])),
                Convert.ToString(reader["Name"]),
                Convert.ToString(reader["IsReserved"]),
                Convert.ToString(reader["BadHabits"]));
            }
            
        }
    }
}
