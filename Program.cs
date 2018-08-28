//  2. Next, iterate over each item in myFamily and produce the following output.

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

            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Austin" }, { "age", "32" } });

            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Shane" }, { "age", "28" } });

            myFamily.Add("me", new Dictionary<string, string>() { { "name", "Aaron" }, { "age", "30" } });
        }
    }
}
