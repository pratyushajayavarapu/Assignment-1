using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// pet stimulator
// step1 here pet type is created and pet name will be given

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
            Console.WriteLine("4. Bird");
            Console.Write("Enter the number of your choice: ");
            int choice = Convert.ToInt32(Console.Read());
            string petType = Console.ReadLine();

           Console.Write("Enter the name for your pet: ");
            string petName = Console.ReadLine();

            Console.WriteLine($"Welcome, {petName} lets play!");

        }
    }
}






