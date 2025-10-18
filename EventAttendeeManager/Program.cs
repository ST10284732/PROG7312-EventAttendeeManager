using System;

namespace EventAttendeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // EventManager Instance
            var manager = new EventManager();

            // Continuously loop through menu
            while (true)
            {
                // Menu Options
                Console.WriteLine("\nEvent Attendee Manager");
                Console.WriteLine("1. Add Attendee");
                Console.WriteLine("2. Remove Attendee");
                Console.WriteLine("3. Display All Attendees");
                Console.WriteLine("4. Exit");
                Console.Write("Please enter your choice: ");

                var input = Console.ReadLine()?.Trim();
                Console.WriteLine();

                switch (input)
                {
                    // 1. Add Attendee
                    case "1":
                        Console.Write("Enter attendee name to add: ");
                        var nameToAdd = Console.ReadLine();
                        manager.AddAttendee(nameToAdd);
                        break;

                    // 2. Remove Attendee
                    case "2":
                        Console.Write("Enter attendee name to remove: ");
                        var nameToRemove = Console.ReadLine();
                        manager.RemoveAttendee(nameToRemove);
                        break;

                    // 3. Display Attendees
                    case "3":
                        manager.DisplayAllAttendees();
                        break;

                    // 4. Exit
                    case "4":
                        Console.WriteLine("Exiting... Goodbye!");
                        return;

                    // If input is invalid
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
                        break;
                }
            }
        }
    }
}
