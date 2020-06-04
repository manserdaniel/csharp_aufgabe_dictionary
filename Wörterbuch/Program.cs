using System;
using System.Collections.Generic;
using System.Linq;

namespace Wörterbuch
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> keyValues = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("1. Wort eintragen\n2. Wort suchen");
                int.TryParse(Console.ReadLine(), out var command);

                if (command == 1)
                {
                    Console.WriteLine("Tragen sie das Wort ein!");
                    string key = Console.ReadLine();
                    Console.WriteLine("Tragen sie das dazugehöreige Wort ein!");
                    string value = Console.ReadLine();

                    try
                    {
                        keyValues.Add(key, value);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Dieses Wort existiert bereits!");
                    }

                }
                else if (command == 2)
                {
                    Console.WriteLine("Das zu suchende Wort.");
                    string toSearchKey = Console.ReadLine();

                    Console.WriteLine(keyValues[toSearchKey]);

                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }
        }
    }
}
