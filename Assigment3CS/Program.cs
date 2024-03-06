using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        // Create a dictionary to store Prime Minister and their years served
        Dictionary<string, int> primeMinisters = new Dictionary<string, int>()
        {
            { "Atal Bihari Vajpayee", 1998 },
            { "Narendra Modi", 2014 },
            { "Manmohan Singh", 2004 }
        };

        // Find the Prime Minister for the year 2004
        string primeMinister2004 = primeMinisters.FirstOrDefault(pair => pair.Value == 2004).Key;
        Console.WriteLine($"Prime Minister of 2004: {primeMinister2004}");

        // Input: Take input from the user for the current prime minister
        Console.Write("Enter the name of the current Prime Minister: ");
        string currentPrimeMinister = Console.ReadLine();
        int currentYear = DateTime.Now.Year;

        // Add or update the current Prime Minister entry (if it exists)
        if (primeMinisters.ContainsKey(currentPrimeMinister))
        {
            // Update the existing entry with the current year
            primeMinisters[currentPrimeMinister] = currentYear;
        }
        else
        {
            // Add a new entry for the current Prime Minister
            primeMinisters.Add(currentPrimeMinister, currentYear);
        }


        // Sort the dictionary by year in ascending order
        var sortedDictionary = primeMinisters.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

        // Print the updated dictionary
        Console.WriteLine("\nUpdated Prime Minister Dictionary:");
        foreach (var pair in sortedDictionary)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
