using System;
namespace Task2.models
{
    public class Subject 
    {
        public Subject(string name, int yoD)
        {
            Name = name;
            YoD = yoD;
        }

        public string Name { get; set; }
        public int YoD { get; set; }


    }
}