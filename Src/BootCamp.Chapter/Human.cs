using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.Chapter
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }


        public Human(string name, string surname, int age, double weight, double height)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} {Surname} ist {Age} Jahre alt, {Height} cm groß und {Weight} kg schwer.");
        }

        public void DisplayBMI()
        {
            double heightInM = Height / 100;
            double bmi = Weight / (heightInM * heightInM);
            Console.WriteLine($"BMI: {bmi:F2}");
        }
    }
}