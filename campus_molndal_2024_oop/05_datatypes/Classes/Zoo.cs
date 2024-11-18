using System;
using System.Collections.Generic;
using System.Linq;

namespace campus_molndal_2024_oop._05_datatypes
{
    public class Zoo
    {
        private List<Animal> _zoo;

        public Zoo()
        {
            _zoo = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            _zoo.Add(animal);
        }

        public void PrintAnimals()
        {
            Console.WriteLine($"Animals: {string.Join(", ", _zoo)}");
        }
    }
}