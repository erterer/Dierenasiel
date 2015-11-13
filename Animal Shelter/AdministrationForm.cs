using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        /// Alle variabelen die worden gebruikt in de form, tevens wordt er een object administation
        /// aamgemaakt voor het opslaan van de dieren.
        /// </summary>
        Administration administration = new Administration();

        private string chipNumber;
        private string name;

        private int birthDay;
        private int birthMonth;
        private int birthYear;

        private int walkDay;
        private int walkMonth;
        private int walkYear;

        private SimpleDate date;
        private SimpleDate lastWalk;
        private string badHabit;

        private AnimalRepository animalRepo;
        private List<Animal> GetAnimals;

        /// <summary>
        /// Initialize
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalRepo = new AnimalRepository(new AnimalSQLiteContext());
            GetAnimals = new List<Animal>();
            administration.Dieren = animalRepo.GetAll();
            animalRepo.GetAll();
            RefreshListBoxes();
        }

        /// <summary>
        /// Methode die alle data uit de textboxes haalt en met deze informatie een cat of een dog
        /// aanmaakt (Dit gebeurd in de button waar deze methode wordt aangeroepen. 
        /// Tevens wordt er gecontroleerd of alles met de juiste waardes is ingevuld. Anders
        /// wordt er een foutmelding teruggegeven.
        /// </summary>
        /// <returns></returns>
        private bool Textboxes()
        {
            if(rbCat.Checked == true)
            {
                if(tbName.Text == "")
                {
                    return false;
                }
                name = tbName.Text;

                if(tbNumber.Text == "")
                {
                    return false;
                }
                chipNumber = tbNumber.Text;

                birthDay = Convert.ToInt32(nudBirthDay.Text);
                birthMonth = Convert.ToInt32(nudBirthMonth.Text);
                birthYear = Convert.ToInt32(nudBirthYear.Text);
                if (birthDay == 1 && birthMonth == 1 && birthYear == 1950)
                {
                    return false;
                }
                date = new SimpleDate(birthDay, birthMonth, birthYear);

                if (tbBadHabit.Text == null)
                {
                    badHabit = "";
                }
                else
                {
                    badHabit = tbBadHabit.Text;
                }             
            }


            else if (rbDog.Checked == true)
            {
                if (tbName.Text == "")
                {
                    return false;
                }
                name = tbName.Text;

                if (tbNumber.Text == "")
                {
                    return false;
                }
                
                try
                {
                    chipNumber = tbNumber.Text;
                }
                catch
                {
                    MessageBox.Show("Vul alleen cijfers in!");
                }

                birthDay = Convert.ToInt32(nudBirthDay.Text);
                birthMonth = Convert.ToInt32(nudBirthMonth.Text);
                birthYear = Convert.ToInt32(nudBirthYear.Text);
                if (birthDay == 1 && birthMonth == 1 && birthYear == 1950)
                {
                    return false;
                }
                date = new SimpleDate(birthDay, birthMonth, birthYear);

                walkDay = Convert.ToInt32(nudDateDay.Text);
                walkMonth = Convert.ToInt32(nudDateMonth.Text);
                walkYear = Convert.ToInt32(nudDateYear.Text);
                if (walkDay == 1 && walkMonth == 1 && walkYear == 1950)
                {
                    return false;
                }
                lastWalk = new SimpleDate(walkDay, walkMonth, walkYear);
            }
            return true;
        }

        /// <summary>
        /// Het verversen van de listboxes op het form.
        /// Dit zijn de Reserved en Not reserved listboxen.
        /// </summary>
        public void RefreshListBoxes()
        {
            lbReserverd.Items.Clear();
            lbNotReserverd.Items.Clear();
            //foreach (Animal a in animalRepo.GetAll())
            //{
            //    if(a.IsReserved == "Reserved")
            //    {
            //        a.SetPrice();
            //        lbReserverd.Items.Add(a);
            //    }
            //    else
            //    {
            //        a.SetPrice();
            //        lbNotReserverd.Items.Add(a);
            //    }
            //}
            foreach (Animal a in administration.Dieren)
            {
                if (a.IsReserved == "Reserved")
                {
                    a.SetPrice();
                    lbReserverd.Items.Add(a);
                }
                else
                {
                    a.SetPrice();
                    lbNotReserverd.Items.Add(a);
                }
            }
        }

        /// <summary>
        /// Met deze knop wordt er een animal aangemaakt, de gegevens worden verzameld in de methode Textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            if(rbCat.Checked == false && rbDog.Checked == false)
            {
                MessageBox.Show("Selecteer een dier");
            }
            if (rbCat.Checked == true && cbReserved.Checked == true)
            {
                bool textBoxes = Textboxes();
                if (textBoxes == true)
                {
                    administration.Add(new Cat(chipNumber, date, name, "Reserved", badHabit));
                    animalRepo.InsertAnimal(new Cat(chipNumber, date, name, "Reserved", badHabit));
                    RefreshListBoxes();
                }
                else
                {
                    MessageBox.Show("Ongeldige gegevens ingevoerd");
                }
            }
            else if (rbCat.Checked == true && cbReserved.Checked == false)
            {
                bool textBoxes = Textboxes();
                if (textBoxes == true)
                {
                    administration.Add(new Cat(chipNumber, date, name, "Not reserved", badHabit));
                    animalRepo.InsertAnimal(new Cat(chipNumber, date, name, "Not reserved", badHabit));
                    RefreshListBoxes();
                }
                else
                {
                    MessageBox.Show("Ongeldige gegevens ingevoerd");
                }
            }
            else if (rbDog.Checked == true && cbReserved.Checked == true)
            {
                bool textBoxes = Textboxes();
                if (textBoxes == true)
                {
                    administration.Add(new Dog(chipNumber, date, name, "Reserved", lastWalk));
                    animalRepo.InsertAnimal(new Dog(chipNumber, date, name, "Reserved", lastWalk));
                    RefreshListBoxes();
                }
                else
                {
                    MessageBox.Show("Ongeldige gegevens ingevoerd");
                }
            }
            else if(rbDog.Checked == true && cbReserved.Checked == false)
            {
                bool textBoxes = Textboxes();
                if (textBoxes == true)
                {
                    administration.Add(new Dog(chipNumber, date, name, "Not reserved", lastWalk));
                    animalRepo.InsertAnimal(new Dog(chipNumber, date, name, "Not reserved", lastWalk));
                    RefreshListBoxes();
                }
                else
                {
                    MessageBox.Show("Ongeldige gegevens ingevoerd");
                }
            }
        }

        /// <summary>
        /// Met het ingevoerde chipnummer wordt het desbetreffende dier verwijderd.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                chipNumber = tbDelete.Text;
            }
            catch
            {
                MessageBox.Show("Geen geldig nummer ingevoerd!");
            }
            if (animalRepo.DeleteAnimal(chipNumber) == true)
            {
                administration.RemoveAnimal(chipNumber);
                RefreshListBoxes();
                MessageBox.Show("Het dier: " + chipNumber + " is verwijderd");
            }
            else
            {
                MessageBox.Show("Het opgevraagde dier is niet gevonden!");
            }
        }

        /// <summary>
        /// Met het ingevoerde chipnummer wordt het desbtreffende dier gezocht en weergeven.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                chipNumber = tbSearch.Text;
            }
            catch
            {
                MessageBox.Show("Geen geldig nummer ingevoerd!");
            }

            GetAnimals = animalRepo.GetAll();
            foreach(Animal a in GetAnimals)
            {
                if (a.ChipRegistrationNumber == chipNumber)
                {
                    lblFoundAnimal.Text = a.ChipRegistrationNumber;
                    MessageBox.Show(a.ToString());
                }
            }
            
        }

        /// <summary>
        /// Met deze knop worden alle aangemaakte dieren opgeslagen in een txt bestand.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter("Animals.txt"))
            {
                try
                {
                    File.Delete(@"D:\Users\Sven\Desktop\Animals.txt");
                }
                catch
                {
                    MessageBox.Show("Geen file verwijderd");
                }
                finally
                {
                    foreach (var animal in administration.Dieren)
                    {
                        if (animal is Dog)
                        {
                            var dog = animal as Dog;
                            streamWriter.WriteLine("Dog" + ","
                                + dog.ChipRegistrationNumber + ","
                                + dog.DateOfBirth.ToString() + ","
                                + dog.Name + ","
                                + dog.IsReserved + ","
                                + dog.Price + ","
                                + dog.LastWalkDate.ToString());
                        }
                        else
                        {
                            var cat = animal as Cat;
                            streamWriter.WriteLine("Cat" + ","
                                + cat.ChipRegistrationNumber + ","
                                + cat.DateOfBirth.ToString() + ","
                                + cat.Name + ","
                                + cat.IsReserved + ","
                                + cat.Price + ","
                                + cat.BadHabits);
                        }
                    }
                } 
            }
        }

        /// <summary>
        /// Met deze knop wordt de laatst versie van het txt bestand (Waar alle dieren in staan)
        /// teruggehaald. Nieuwe wijzigingen worden verwijderd.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            administration.Dieren.Clear();
            string data = "";
            string[] animalValues;
            using (StreamReader streamReader = new StreamReader("Animals.txt"))
            {
                while (!streamReader.EndOfStream)
                {
                    data = streamReader.ReadLine();
                    animalValues = data.Split(',');

                    if(animalValues[0] == "Dog")
                    {
                        administration.Add(new Dog(animalValues[1], SimpleDate.ConvertDate(animalValues[2]), animalValues[3], animalValues[4], SimpleDate.ConvertDate(animalValues[6])));
                    }
                    else
                    {
                        administration.Add(new Cat(animalValues[1], SimpleDate.ConvertDate(animalValues[2]), animalValues[3], animalValues[4], animalValues[6]));
                    }
                }
            }
            RefreshListBoxes();
        }

        /// <summary>
        /// Met deze knop wordt er testdata ingevuld, dit zijn 2 katten en 2 honden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestData_Click(object sender, EventArgs e)
        {
            administration.Add(new Cat("12345", new SimpleDate(08, 01, 2010), "Karel", "Not reserved", "Sloopt gordijnen"));
            administration.Add(new Cat("98765", new SimpleDate(08, 01, 2005), "Sven", "Reserved", ""));
            administration.Add(new Dog("26352", new SimpleDate(17, 09, 2006), "Jan", "Not reserved", new SimpleDate(25, 09, 2015)));
            administration.Add(new Dog("65432", new SimpleDate(06, 07, 2006), "Tristan", "Reserved", new SimpleDate(06, 10, 2015)));
            RefreshListBoxes();
        }

        /// <summary>
        /// Met deze knop worden alle dieren verwijderd. Dit geldt niet voor de laatste save (het txt bestand).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            administration.Dieren.Clear();
            RefreshListBoxes();
        }
    }
}
