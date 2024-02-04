﻿


// pet stimulator
// step1 here pet type is created and pet name will be given
using System;
using System.Xml.Linq;
namespace PetStimulator
{
    class Program
    {
       
        static void Main()
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
                Console.WriteLine("5. Exit");
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
                        pet.CheckStatus();
                        break;
                    case "5":
                        Console.WriteLine("Thank you for playing!");
                        return; 
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }

                // Simulate time passage
                pet.UpdateStats();
            }
        }
    }

// defining the class pet

























































































































































































