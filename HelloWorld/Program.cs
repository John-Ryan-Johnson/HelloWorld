using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Not Hello, World Exercise
            //Part 2
            //Prompt user to pick dialect for greeting.

            Console.WriteLine("Please pick your dialect: Southern, Northern, Teen");

            if (args.Length == 0)
            {
                Console.WriteLine();
                var userEntry = Console.ReadLine();
                switch (userEntry)
                {
                    case "Southern":
                        Console.WriteLine("Hey Ya'll!");
                        break;
                    case "Northern":
                        Console.WriteLine("Hey, youse freakin guys!");
                        break;
                    case "Teen":
                        Console.WriteLine("Sup.");
                        break;
                }
            }
            //Console Input Exercise
            //Part 1
            //Prompt user for their name.

            Console.WriteLine("Please enter your Name:");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}!");

            //Console Input Exercise
            //Part 2
            //Prompt user for their favorite color.

            Console.WriteLine("What's your favorite color?");
            var favColor = Console.ReadLine();
            Console.WriteLine($"{favColor} is my favorite color also.");

            //Hello World Exercise
            //Part 1
            //Add a feature to your application that will only print animal names that have 2 syllables or more.

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Dog" };
            var vowels = new[] { "a", "e", "i", "o", "u", "y" };
            int count = 0;

            foreach (var animal in animals)
            {
                foreach (var vowel in vowels)
                {
                    if (animal.Contains(vowel))
                    {
                        count++;
                    }
                }
                if (count >= 2)
                {
                    Console.WriteLine(animal);
                }
                count = 0;
            }
            //Console Input Exercise
            //Part 2 continued...
            //Ask user if they would like random animal of that color.

            Random randomAnimal = new Random();
            int index = randomAnimal.Next(animals.Length);
            Console.WriteLine($"{userName} would you like to have a {favColor} {animals[index]}?");
        }
    }
}
