using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Creating_Classes
{
    internal class Person
    {
        private int personID;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColour;
        private bool isWorking;


        private int PersonID { get => personID; set => personID = value; }
        private string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FavoriteColour { get => favoriteColour; set => favoriteColour = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }
        public int Age { get => age; set => age = value; }

        public Person(int personID, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personID = personID;
            this.firstName = firstName; 
            this.lastName = lastName;   
            this.favoriteColour= favoriteColour;    
            this.age = age;
            this.isWorking = isWorking; 
        }

        public override string ToString()
        {
            string formatted = "";

            formatted += "ID: " + personID + "\n";
            formatted += "First name: " + firstName + "\n";
            formatted += "Last name: " + lastName + "\n";
            formatted += "Favorite colour: " + favoriteColour + "\n";
            formatted += "Age: " + age + "\n";
            formatted += "Is Working: " + isWorking;


            return formatted;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine(PersonID + ": " + firstName + " " + lastName + "'s favorite colour is " + favoriteColour);
        }

        public void ChangeFavoriteColour()
        {
            this.favoriteColour = "white";
        }

        public void GetAgeInTenYears()
        {
            Console.WriteLine(firstName + lastName + "'s Age in 10 years is: " + (age + 10));
        }

    }
}
