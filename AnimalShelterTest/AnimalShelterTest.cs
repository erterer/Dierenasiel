using System;
using AnimalShelter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalShelterTest
{
    [TestClass]
    public class AnimalShelterTest
    {
        //Fields
        private Dog dog;
        private Cat cat;

        //Create objects
        [TestInitialize]
        public void Initialize()
        {
            cat = new Cat("98765", new SimpleDate(8, 1, 2005), "Sven", "not reserved", "");
            dog = new Dog("65432", new SimpleDate(6, 7, 2006), "Tristan", "not reserved", new SimpleDate(6, 10, 2015));
            dog.SetPrice();
        }


        //Create Cat
        [TestMethod]
        public void TestChipNumberFromCat()
        {
            Assert.AreEqual("98765", cat.ChipRegistrationNumber);
        }

        [TestMethod]
        public void TestDateOfBirthFromCat()
        {
            Assert.AreEqual(new SimpleDate(8, 1, 2005).ToString(), cat.DateOfBirth.ToString());
        }

        [TestMethod]
        public void TestNameFromCat()
        {
            Assert.AreEqual("Sven", cat.Name);
        }

        [TestMethod]
        public void TestBadHabitsFromCat()
        {
            Assert.AreEqual("", cat.BadHabits);
        }

        [TestMethod]
        public void TestCatPrice()
        {
            cat.SetPrice();
            Assert.AreEqual(60, cat.Price);
        }

        [TestMethod]
        public void TestCatPrice20()
        {
            Cat cat2 = new Cat("98765", new SimpleDate(8, 1, 2005), "Sven", "Reserved", "Sloopt gordijnen en gooit plantenbakken van de vensterbank af");
            cat2.SetPrice();
            Assert.AreEqual(20, cat2.Price);
        }

        //Create Dog
        [TestMethod]
        public void TestChipNumberFromDog()
        {
            Assert.AreEqual("65432", dog.ChipRegistrationNumber);
        }

        [TestMethod]
        public void TestDateOfBirthFromDog()
        {
            Assert.AreEqual(new SimpleDate(6, 7, 2006).ToString(), dog.DateOfBirth.ToString());
        }

        [TestMethod]
        public void TestNameFromDog()
        {
            Assert.AreEqual("Tristan", dog.Name);
        }

        [TestMethod]
        public void TestLastWalkDateFromDog()
        {
            Assert.AreEqual(new SimpleDate(6, 10, 2015).ToString(), dog.LastWalkDate.ToString());
        }

        [TestMethod]
        public void TestDogPrice()
        {
            dog.SetPrice();
            Assert.AreEqual(350, dog.Price);
        }

        [TestMethod]
        public void TestDogPrice200()
        {
            Dog dog2 = new Dog("21452", new SimpleDate(6, 7, 2005), "Tristan", "Reserved", new SimpleDate(6, 10, 2014));
            dog2.SetPrice();
            Assert.AreEqual(200, dog2.Price);
        }


        //Make Noise
        [TestMethod]
        public void DogMakeNoise()
        {
            dog.MakeNoise();
        }

        [TestMethod]
        public void CatMakeNoise()
        {
            cat.MakeNoise();
        }


        //Other chipnumber
        [TestMethod]
        public void TestChipNumberFromCatTooShort()
        {
            Cat cat3 = new Cat("9876", new SimpleDate(8, 1, 2005), "Reserved", "Sven", "");
            Assert.AreEqual("09876", cat3.ChipRegistrationNumber);
        }

        [TestMethod]
        public void TestChipNumberFromCatTooLong()
        {
            Cat cat3 = new Cat("987654", new SimpleDate(8, 1, 2005), "Sven", "Reserved", "");
            Assert.AreEqual("98765", cat3.ChipRegistrationNumber);
        }

        //ToString
        [TestMethod]
        public void TestCatToString()
        {
            //Geen prijs gezet
            string s = "98765"
                + ", " + "08-01-2005"
                + ", " + "Sven"
                + ", " + "not reserved"
                + ", " + "€ " + "0,00"
                + ", " + "";
            Assert.AreEqual(s, cat.ToString());
        }

        [TestMethod]
        public void TestDogToString()
        {
            //Prijs gezet
            string s = "65432"
                + ", " + "06-07-2006"
                + ", " + "Tristan"
                + ", " + "not reserved"
                + ", " + "€ " + "350,00"
                + ", " + "06-10-2015";
            Assert.AreEqual(s, dog.ToString());
        }

        [TestMethod]
        public void TestDogNoValuesToString()
        {
            Dog dog3 = new Dog("12334", null, null, "Reserved", new SimpleDate(6, 10, 2015));
            string s = "12334"
                + ", " + "00-00-0000"
                + ", " + "noname"
                + ", " + "Reserved"
                + ", " + "€ " + "0,00"
                + ", " + "06-10-2015";
            Assert.AreEqual(s, dog3.ToString());
        }


        //Reserved
        [TestMethod]
        public void TestIsReserved()
        {
            Assert.AreEqual(dog.IsReserved, dog.IsReserved);
        }
    }
}
