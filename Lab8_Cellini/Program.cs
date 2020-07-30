using System;
using System.Collections.Generic;
using System.Drawing;

namespace Lab8_Cellini
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string> {"Joseph", "Simon", "Andoni", "Robbie", "Lauren", "Ramez", "Sumana", "Jordan", "Josh",
                                                      "Sean", "Stephen", "Curtis", "Justin", "Anna", "Tommy" };

            List<string> colors = new List<string> { "Red", "Blue", "Yellow", "Green", "Purple", "Orange", "Periwinkle", "Aquamarine", "Chartreuse",
                                                     "Maroon", "Fuchsia", "Teal", "Blanched Almond", "Goldenrod", "Lemon Chiffon" };

            List<string> mythicalcreature = new List<string> { "Unicorn", "Dragon", "Mermaid", "Werewolf", "Leprechaun", "Sphinx", "Loch Ness Monster",
                                                               "Sphinx", "Pegasus", "Griffin", "Centaur", "Basilisk", "Manticore", "Imp", "Gnome"};
            string repeat = "yes";
            while (repeat == "yes")
            {
                Console.WriteLine("Welcome to our C# class. Which student or instructor would you like to learn more about?" +
                                  "(Enter a number between 0-14): ");
                try
                {
                    int num = int.Parse(Console.ReadLine());

                    string student = students[num];
                    Console.WriteLine("Student " + num + " is " + student + "." + " What would you like to know about? (Enter 'color' or 'mythical creature'): ");
                    string input = Console.ReadLine();
                    if (input == "color")
                    {
                        string color = colors[num];
                        Console.WriteLine(student + "'s" + " favorite color is " + color + "." + " Would you like to know more? " +
                                          "(Enter 'yes' or 'no'): ");
                    }
                    else if (input == "mythical creature")
                    {
                        string mythic = mythicalcreature[num];
                        Console.WriteLine(student + "'s" + " favorite mythical creature is " + mythic + "." + " Would you like to know more? " +
                                          "(Enter 'yes' or 'no'): ");
                    }
                    else
                    {
                        Console.WriteLine("The data does not exist. Please try again.");
                        continue;
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("This student does not exist. Please try again.");
                    continue;
                }
                catch (FormatException e2)
                {
                    Console.WriteLine("The data does not exist. Please try again.");
                    continue;

                }

                repeat = Console.ReadLine();
                Console.WriteLine("Thanks!");
            }
        }
    }
}
