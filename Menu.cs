using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Menu
    {
        public static List<MenuItem> Appetizers = new List<MenuItem>();
        public static List<MenuItem> MainCourse = new List<MenuItem>();
        public static List<MenuItem> Desserts = new List<MenuItem>();

        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");*/
            /*AddItem(Appetizers, MainCourse, Desserts);*/
            MenuOptions(Choice());
            Console.ReadLine();
        }

        public static void ViewMenu()
        {
            foreach(MenuItem item in Appetizers)
            {
                Console.WriteLine($"{item.NameOfItem}......${item.Price}\n {item.Description}\n");
            }
            
        }
        public static void AddItem()
        {
            Console.WriteLine("Is the item you are trying to add an (1) Appetizer, (2) Main Course, or (3) Dessert?");
            int output = int.Parse(Console.ReadLine());
            if (output == 1)
            {
                string category = "appetizer";
                Console.WriteLine("What is the name of the appetizer you wish to add?");
                string name = Console.ReadLine();
                Console.WriteLine("What is the price of the item?");
                double price = Double.Parse(Console.ReadLine());
                Console.WriteLine("What is a brief description of the item?");
                string desc = Console.ReadLine();
                MenuItem appetizers = new MenuItem(name, desc, category, price);
                Appetizers.Add(appetizers);
                
            }
            else if (output == 2)
            {
                string category = "main course";
                Console.WriteLine("What is the name of the main course you wish to add?");
                string name = Console.ReadLine();
                Console.WriteLine("What is the price of the item?");
                double price = Double.Parse(Console.ReadLine());
                Console.WriteLine("What is a brief description of the item?");
                string desc = Console.ReadLine();
                MenuItem maincourse = new MenuItem(name, desc, category, price);
                MainCourse.Add(maincourse);
            }
            else
            {
                string category = "dessert";
                Console.WriteLine("What is the name of the dessert you wish to add?");
                string name = Console.ReadLine();
                Console.WriteLine("What is the price of the item?");
                double price = Double.Parse(Console.ReadLine());
                Console.WriteLine("What is a brief description of the item?");
                string desc = Console.ReadLine();
                MenuItem desserts = new MenuItem(name, desc, category, price);
                Desserts.Add(desserts);
            }
            MenuOptions(Choice());

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
                //RemoveItem();
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



