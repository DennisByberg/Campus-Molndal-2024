using campus_molndal_2024_oop._07_inheritance.Interfaces;
using System;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public class PetShop
    {
        private List<Animal> _animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public void ManageAnimals()
        {
            foreach (var animal in _animals)
            {
                animal.MakeSound();
                animal.Sleep();

                if (animal is IPet pet) pet.Play();
                if (animal is ITrainable trainable) trainable.PerformTrick();

                Console.WriteLine();
            }
        }
    }
}
