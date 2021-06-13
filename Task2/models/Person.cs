using System;

namespace Task2.models
{
    public class Person
    {
    public string firstname { get; set; }
    public string surname { get; set; }
    public string dob { get; set; }
    public int height { get; set; }

    public int id = Random.Next(1000,9999);

    public string GetFullName() {
        return(Console.WriteLine(Person.firstname + "" + Person.surname));

    }
    public int GetHeightDiff() {
        return(Console.WriteLine(Person.height-Person.height));
    }

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