using System;
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person();

        // Prompt the user to enter a first name
        Console.Write("Enter first name (fnama): ");
        person.FirstName = Console.ReadLine();

        // Prompt the user to enter a last name
        Console.Write("Enter last name (lname): ");
        person.LastName = Console.ReadLine();

        // Display the entered information
        Console.WriteLine("\nEntered Information:");
        Console.WriteLine($"First Name: {person.FirstName}");
        Console.WriteLine($"Last Name: {person.LastName}");

        // Optionally, you can perform additional actions with the entered data or save it to a file or database.

        Console.ReadLine(); // Keep the console window open until Enter is pressed
    }
}
