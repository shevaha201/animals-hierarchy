using AnimalsHierarchy.Animals;
using AnimalsHierarchy.Animals.Fishes;
using AnimalsHierarchy.Animals.Mammals;
using AnimalsHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalsHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<Animal> animals = new List<Animal>();
            animals.Add(new Tarantula("https://animalpictures.com/tarantula.jpg"));
            animals.Add(new Shark("https://animalpictures.com/shark.jpg"));
            animals.Add(new Dolphin("https://animalpictures.com/dolphin.jpg"));
            animals.Add(new Wolf("https://animalpictures.com/wolf.jpg"));
            animals.Add(new Dog("https://myprivatepictures.com/bobby.jpg", "Bobby"));

            DisplayAnimals("All animals", animals);

            IEnumerable<Animal> dangerousAnimals = animals
                .Where(t => t is IDangerous)
                .ToList();

            DisplayAnimals("Dangerous animals", dangerousAnimals);

            Console.ReadLine();
        }

        private static void DisplayAnimals(string header, IEnumerable<Animal> animals)
        {
            Console.WriteLine(header);
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine();
        }
    }
}
