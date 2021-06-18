using System;

namespace Task2.models
{
    public class Person
    {
    public string firstname { get; set; }
    public string surname { get; set; }
    public string dob { get; set; }
    public int height { get; set; }

    public Random rnd = rnd.Next(1000,9999); 
    

    public void GetFullName() {
    }
    public void GetHeightDiff() {}

        public Person(string firstname, string surname, string dob, int height, int id)
        {
            Firstname = firstname;
            Surname = surname;
            Dob = dob;
            this.height = height;
            this.id = id;
        }
    }
}