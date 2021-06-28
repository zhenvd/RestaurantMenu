using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Menu
    {
        public static List<string> Appetizers = new List<string>();
        public static List<string> MainCourse = new List<string>();
        public static List<string> Desserts = new List<string>();

        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");*/
            /*AddItem(Appetizers, MainCourse, Desserts);*/
            MenuOptions(Choice());
        }
        public void AddItem(List<string> Appetizers, List<string> MainCourse, List<string> Desserts)
        {
            Console.WriteLine("Is the item you are trying to add an (1) Appetizer, (2) Main Course, or (3) Dessert?");
            int output = int.Parse(Console.ReadLine());
            if (output == 1)
            {
                Console.WriteLine("What is the name of the appetizer you wish to add?");
                string name = Console.ReadLine();
                Console.WriteLine("What is the price of the item?");
                string desc = Console.ReadLine();
            }
            else if (output == 2)
            {
                Console.WriteLine("What is the name of the main course item you wish to add?");
                string name = Console.ReadLine();
                Console.WriteLine("What is the price of the item?");
                string desc = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the name of the dessert you wish to add?");
                string name = Console.ReadLine();
                Console.WriteLine("What is the price of the item?");
                string desc = Console.ReadLine();
            }

        }
        static void MenuOptions(int output)
        {
            if (output == 1)
            {
                ViewMenu();
            }
            else if (output == 2)
            {
                AddItem();
            }
            else
            {
                RemoveItem();
            }
        }

        //initial menu input prompt
        static int Choice()
        {
            Console.WriteLine("Welcome to some restaurant." +
                "\nWhat would you like to do? Please enter a numeric selection:" +
                "\n1 - View Menu: See all items/description/prices on menu" +
                "\n2 - Add Menu Item: Add Menu Item" +
                "\n3 - Remove Menu Item: Remove Menu Item" +
                "\n\nEnter 1, 2 or 3: ");
            string choiceString = Console.ReadLine();
            int intChoice;
            int output = 0;
            bool exit = true;
            while (exit)
            {
                if (int.TryParse(choiceString, out intChoice))
                {
                    while (intChoice < 1 || intChoice > 3)
                    {
                        Console.WriteLine("Please enter 1, 2 or 3: ");
                        choiceString = Console.ReadLine();
                        if (int.TryParse(choiceString, out intChoice))
                        {
                            //does nothing
                        }
                    }
                    exit = false; //exits while loop
                    output = intChoice;
                }
                else
                {
                    Console.WriteLine("Please enter a numeric value.");
                    choiceString = Console.ReadLine();
                }
            }
            return output;
        }
    }
    }
}



