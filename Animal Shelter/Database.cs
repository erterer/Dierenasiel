using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace AnimalShelter
{
    public class Database
    {
        // De bestandsnaam voor de database
        private static readonly string databaseFilename = "Database.sqlite";
        private static readonly string connectionString = "Data Source=" + databaseFilename + ";Version=3";

        /// <summary>
        /// Creates a new database connection and directly opens it. The caller
        /// is resposible for properly closing the connection.
        /// </summary>
        public static SQLiteConnection Connection
        {
            get
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection.Open();
                return connection;
            }
        }

        /// <summary>
        /// Create a new database if it doesn't exist, and fill it with some
        /// dummy data.
        /// </summary>
        public static void Initialize()
        {
            bool recreateDatabase = false;

            // Check if the database already exists
            if (File.Exists("Database.sqlite"))
            {
                // If this source file is also found when running the program,
                // see if it was modified after the database was last written to
                if (File.Exists(@"..\..\Data\Database.cs") &&
                        (new FileInfo(@".\Database.sqlite").LastWriteTime <
                         new FileInfo(@"..\..\Data\Database.cs").LastWriteTime))
                {
                    recreateDatabase = true;
                }
            }
            else
            {
                recreateDatabase = true;
            }

            // File doesn't exist, or this file was modified after the database
            // was created: recreate the database
            if (recreateDatabase)
            {
                Console.WriteLine("Database (re)created.");
                SQLiteConnection.CreateFile(databaseFilename);

                // Create some dummy data to work with
                using (SQLiteConnection connection = Database.Connection)
                {
                    string[] queries = new string[] {
                        "CREATE TABLE Animal (Chipnumber VARCHAR(100) PRIMARY KEY, Type VARCHAR(10), DateOfBirth VARCHAR(100), Name VARCHAR(100), IsReserved VARCHAR(100), BadHabits VARCHAR(100), LastWalkDate VARCHAR(100))",
                        "INSERT INTO Animal (Chipnumber, Type, DateOfBirth, Name, IsReserved, BadHabits, LastWalkDate) " +
                        "VALUES ('12345', 'Cat', '10-10-2005', 'Sven', 'Reserved', 'bijt', null)",
                        "INSERT INTO Animal (Chipnumber, Type, DateOfBirth, Name, IsReserved, BadHabits, LastWalkDate) " +
                        "VALUES ('56325', 'Dog', '10-10-2005', 'Tristan', 'Not reserved', 'null', '22-10-2015')",
                        "INSERT INTO Animal (Chipnumber, Type, DateOfBirth, Name, IsReserved, BadHabits, LastWalkDate) " +
                        "VALUES ('85214', 'Cat', '10-10-2005', 'Bas', 'Reserved', 'eet zijn eigen poep', null)"
                    };

                    foreach (string query in queries)
                    {
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}
