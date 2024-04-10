using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Townsville", "NY", "USA");

        // Create events
        Event lecture = new Lecture("Tech Talk", "Learn about new technologies", "2024-03-15", "10:00 AM", address1, "John Doe", 50);
        Event reception = new Reception("Networking Mixer", "Meet industry professionals", "2024-03-20", "6:00 PM", address2, "info@example.com");
        Event outdoorGathering = new OutdoorGathering("Picnic in the Park", "Enjoy outdoor activities", "2024-04-01", "1:00 PM", address1, "Sunny");

        // Generate marketing messages
        Console.WriteLine("Marketing Messages:");
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GenerateFullDetails());
        Console.WriteLine("\nReception:");
        Console.WriteLine(reception.GenerateFullDetails());
        Console.WriteLine("\nOutdoor Gathering:");
        Console.WriteLine(outdoorGathering.GenerateFullDetails());
    }
}
