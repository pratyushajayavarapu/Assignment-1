// 8973016-Pratyusha Jayavarapu- Assignment 1
// pet stimulator
// step1 here pet type is created and pet name will be given
using System;
using System.Xml.Linq;
namespace PetStimulator
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the PetStimulator Program!");
            Console.WriteLine("Please choose your petType:");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");

            Console.Write("Enter the number of your choice: ");
            int petType = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your pet's name:");
            string petName = Console.ReadLine();

            Pet pet = new Pet(petType, petName);



            Console.WriteLine($"Welcome, {petName} lets play!");


            // pet care actions
            // main loop



            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Check status");
                Console.WriteLine("5. Health Deterioration");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        pet.Feed();
                        break;
                    case "2":
                        pet.Play();
                        break;
                    case "3":
                        pet.Rest();
                        break;
                    case "4":
                        pet.checkStatus();
                        break;
                    case "5":
                        pet.healthDeterioration();
                        break;
                    case "6":
                      //exit
                       Console.WriteLine("Thank you for playing!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }

               
                
            }

        }
        // stimulating time pass

    // defining the class pet
    class Pet
        {
            private int type;
            private string name;
            private int hunger;
            private int happiness;
            private int health;

            public Pet(int type, string name)
            {
                this.type = type;
                this.name = name;
                this.hunger = 5;
                this.happiness = 5;
                this.health = 5;
            }

            public void Feed()
            {
                hunger--;
                health++;
                Console.WriteLine($"{name} has been fed. Hunger decreased, health increased.");
            }

            public void Play()
            {
                happiness++;
                hunger++;
                Console.WriteLine($"{name} has played. Happiness increased, hunger increased.");
            }

            public void Rest()
            {
                health++;
                happiness--;
                Console.WriteLine($"{name} has rested. Health increased, happiness decreased.");
            }
            public void healthDeterioration()
            {
                if (hunger > 7 || happiness < 3)
                {
                    health--;
                    Console.WriteLine($"{name}'s health has deteriorated due to hunger or low happiness.");
                }
                else if (hunger < 3 && happiness > 7)
                {
                    health++;
                    Console.WriteLine($"{name}'s health has improved due to good hunger and happiness.");
                }
                else
                {
                    Console.WriteLine($"{name}'s health is stable.");
                }
            }
            public void checkStatus()
            {
                Console.WriteLine($"--- {name}'s Status ---");
                Console.WriteLine($"Hunger: {hunger}/10");
                Console.WriteLine($"Happiness: {happiness}/10");
                Console.WriteLine($"Health: {health}/10");

                if (hunger <= 2)
                {
                    Console.WriteLine("Warning: very Hungry!");
                }
                else if (hunger >= 8)
                {
                    Console.WriteLine("Warning: not Hungry !");
                }

                if (happiness <= 2)
                {
                    Console.WriteLine("Warning: Happiness is critically low!");
                }
                else if (happiness >= 8)
                {
                    Console.WriteLine("Warning: Happiness is high!");
                }

                if (health <= 2)
                {
                    Console.WriteLine("Warning: Health is critically low!");
                }
                else if (health >= 8)
                {
                    Console.WriteLine("Warning: Health is high!");
                }
            }
        }
    }
}





























































































































































































