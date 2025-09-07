using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person1 = new Human("Max", "Schimmel", 26, 111.3, 188);
            Human person2 = new Human("Lilly", "Müller", 22, 97, 170);

            List<Human> people = new List<Human>()
            {
                person1,
                person2
            };

            foreach (Human person in people)
            {
                person.DisplayInfo();
                person.DisplayBMI();
            }
        }
    }
}