using System;
using Task2.models;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person Rishabh = new Person("Rishabh","Nigam", "24/07/2002",177,id);
            Person Jane = new Person("Jane","Audrey","19/08/2003",163,id);
            Person Emily = new Person("Emily","Clark","1/10/2001",158,id);

            Console.WriteLine("Enter the First names of the 2 people you'd like to compare the height of.");
           string input1 = Console.ReadLine();
           string input2 =  Console.ReadLine();
            if (input1 && input2 == Person.firstname)
            {
                GetHeightDiff();
            }
            else
            {
                Console.WriteLine("Sorry, these people do not exist within the system.");
            }



        }
    }
}
