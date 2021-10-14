using System;
using GithubExercise;
using System.Collections.Generic;

List<Animal> animals = new List<Animal>()
{
    new Duck(),
    new Horse(),
    new Zebra()
};

foreach (Animal animal in animals)
{
    Console.WriteLine($"The {animal.GetType().Name} says {animal.Says()}");
}
