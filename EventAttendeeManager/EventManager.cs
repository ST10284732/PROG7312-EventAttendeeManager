using System;
using System.Collections.Generic;

namespace EventAttendeeManager
{
    public class EventManager
    {
        // Private field to store attendee names
        private readonly HashSet<string> _attendees;

        // Constructor 
        public EventManager()
        {
            _attendees = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }

        // Add an attendee
        public void AddAttendee(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty.");
                return;
            }

            bool added = _attendees.Add(name.Trim());
            if (added)
            {
                Console.WriteLine($"\"{name.Trim()}\" has been registered successfully.");
            }
            else
            {
                Console.WriteLine($"\"{name.Trim()}\" is already registered.");
            }
        }

        // Removes an attendee
        public void RemoveAttendee(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty.");
                return;
            }

            bool removed = _attendees.Remove(name.Trim());
            if (removed)
            {
                Console.WriteLine($"\"{name.Trim()}\" has been removed.");
            }
            else
            {
                Console.WriteLine($"\"{name.Trim()}\" was not found in the registration list.");
            }
        }

        // Displays all attendees
        public void DisplayAllAttendees()
        {
            Console.WriteLine("\n--- Registered Attendees ---");
            if (_attendees.Count == 0)
            {
                Console.WriteLine("No one is registered yet.");
                return;
            }

            foreach (var attendee in _attendees)
            {
                Console.WriteLine(attendee);
            }
        }
    }
}
