using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            Animal animals= new Animal();

            animals.Breathe = true;
            animals.Reproduce = true;
            animals.Eat = true;
            animals.Move = true;


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird birds = new Bird();

            birds.Wings = true;
            birds.Fly = true;
            birds.Claws = true;
            birds.HollowBones = true;

            Console.WriteLine($"Birds have wings: {birds.Wings}\nBirds can fly: {birds.Fly}\nBirds have claws: {birds.Claws}\nBirds have hollow bones: {birds.HollowBones}\n" +
                $"Birds breath: {animals.Breathe}\nBirds reproduce {animals.Reproduce}\nBirds eat: {animals.Eat}\nBirds move: {animals.Move}\n");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile reps = new Reptile();

            reps.ColdBlooded = true;
            reps.ShedSkin = true;
            reps.Vertebrates = true;
            reps.HasScales = true;

            Console.WriteLine($"Reptiles are cold-blooded: {reps.ColdBlooded}\nReptiles shed their skin: {reps.ShedSkin}\nReptiles are Vertebrates: {reps.Vertebrates}\n" +
                $"Reptiles have scales: {reps.HasScales}\nReptiles breath: {animals.Breathe}\nReptiles reproduce {animals.Reproduce}\nReptiles eat: {animals.Eat}\n" +
                $"Reptiles move: {animals.Move}\n");

        }
    }
}
