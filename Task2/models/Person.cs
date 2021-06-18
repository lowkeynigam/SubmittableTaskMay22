using System;

namespace Task2
{
    public class Person
    {
    public string firstname { get; set; }
    public string surname { get; set; }
    public string dob { get; set; }
    public int height { get; set; }

     public Random rand = new Random();

    public void GetFullName() {
    }
    public void GetHeightDiff() {}

        public Person(string firstname, string surname, string dob, int height, Random rnd)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.dob = dob;
            this.height = height;
            this.rnd = rnd;
        }
    }
}