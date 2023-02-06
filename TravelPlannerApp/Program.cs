using System;
using System.Collections.Generic;

namespace TravelPlannerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> itinerary = new List<string>();

            while (true)
            {
                Console.WriteLine("1. Add Destination");
                Console.WriteLine("2. View Itinerary");
                Console.WriteLine("3. Quit");

                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter destination name:");
                    string destination = Console.ReadLine();
                    itinerary.Add(destination);
                    Console.WriteLine("Destination added successfully.");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Your itinerary:");
                    for (int i = 0; i < itinerary.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {itinerary[i]}");
                    }
                }
                else if (choice == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }
        }
    }
}
