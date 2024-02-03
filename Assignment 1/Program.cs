


// pet stimulator
// step1 here pet type is created and pet name will be given
using System;
using System.Xml.Linq;
namespace PetStimulator
{
    class Program
    {
        public int Hunger { get; private set; } = 5;
        public int Happiness { get; private set; } = 5;
        public int Health { get; private set; } = 5;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the PetStimulator Program!");
            Console.WriteLine("Please choose your petType:");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");
            Console.WriteLine("4. Bird");
            Console.Write("Enter the number of your choice: ");
            int choice = Convert.ToInt32(Console.Read());
            string petType = Console.ReadLine();

            Console.Write("Enter the name for your pet: ");
            string petName = Console.ReadLine();

            Pet pet = new Pet(petName);

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
                Console.WriteLine("5. Exit");
                Console.Write("Enter your option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        petName.Feed();
                        break;
                    case "2":
                        petName.Play();
                        break;
                    case "3":
                        petName.Rest();
                        break;
                    case "4":
                        petName.CheckStatus();
                        break;
                    case "5":
                        Console.WriteLine("Thank you for playing!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }

                // Simulate time passage
                pet.PassTime(); 
            }
        }
    }


    public void Feed()
    {
        Console.WriteLine($"{Name} is being fed.");
        Hunger = Math.Max(Hunger - 2, 0);
        Health = Math.Min(Health + 1, 10);
    }

}
// defining the class pet






















































































































































































