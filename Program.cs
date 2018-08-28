using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a Dictionary that contains information about several members of your family.
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Cindy" }, { "age", "56" } });

            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Joseph" }, { "age", "60" } });

            myFamily.Add("older brother", new Dictionary<string, string>() { { "name", "Austin" }, { "age", "32" } });

            myFamily.Add("younger brother", new Dictionary<string, string>() { { "name", "Shane" }, { "age", "28" } });

            myFamily.Add("alter ego", new Dictionary<string, string>() { { "name", "Knight Shadow" }, { "age", "5343" } });

            // Next, iterate over each item in myFamily 
            foreach (var person in myFamily)
            {
                Console.WriteLine($"{person.Value["name"]} is my {person.Key} and is {person.Value["age"]} years old");
            }
        }
    }
}

// Krista is my sister and is 42 years old