using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Menu
    {
        public static List<MenuItem> Appetizers = new List<MenuItem>();
        public static List<MenuItem> MainCourse = new List<MenuItem>();
        public static List<MenuItem> Desserts = new List<MenuItem>();
        public static DateTime updatedOn = DateTime.Today; 

        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");*/
            /*AddItem(Appetizers, MainCourse, Desserts);*/
            MenuOptions(Choice());
            Console.ReadLine();
        }

        public static void ViewMenu()
        {
            Console.WriteLine("***Appetizers***");
            foreach(MenuItem item in Appetizers)
            {
                Console.WriteLine($"{item.NameOfItem}......${item.Price}\n {item.Description}.... Item added on {item.CreationDate.Month}/{item.CreationDate.Day}/{item.CreationDate.Year}\n");
            }
            Console.WriteLine("***Main Course***");
            foreach (MenuItem item in MainCourse)
            {
                Console.WriteLine($"{item.NameOfItem}......${item.Price}\n {item.Description}.... Item added on {item.CreationDate.Month}/{item.CreationDate.Day}/{item.CreationDate.Year}\n");
            }
            Console.WriteLine("***Desserts***");
            foreach (MenuItem item in Desserts)
            {
                Console.WriteLine($"{item.NameOfItem}......${item.Price}\n {item.Description}.... Item added on {item.CreationDate.Month}/{item.CreationDate.Day}/{item.CreationDate.Year}\n");
            }
            Console.WriteLine($"Menu updated on {updatedOn.Month}/{updatedOn.Day}/{updatedOn.Year}");
            MenuOptions(Choice());
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
            updatedOn = DateTime.Today; //updatedOn would update everytime an item is added.
            Console.Clear();
            MenuOptions(Choice());

        }

        public static void RemoveItem()
        {
            Console.WriteLine("What kind of item would you like to remove? (1) Appetizer, (2) Main Course, or (3) Dessert?");
            int userInput = Int32.Parse(Console.ReadLine());
            if(userInput == 1) //appetizer
            {
                Console.WriteLine("What is the name of the item you would like removed?");
                string name = Console.ReadLine();

                for(int i = 0; i < Appetizers.Count; i++)
                {
                    if(name.Equals(Appetizers[i].NameOfItem))
                    {
                        Appetizers.RemoveAt(i);
                    }
                }
            }
            else if(userInput == 2) //main course
            {
                Console.WriteLine("What is the name of the item you would like removed?");
                string name = Console.ReadLine();
                for (int i = 0; i < MainCourse.Count; i++)
                {
                    if (name.Equals(MainCourse[i].NameOfItem))
                    {
                        MainCourse.RemoveAt(i);
                    }
                }
            }
            else //dessert
            {
                Console.WriteLine("What is the name of the item you would like removed?");
                string name = Console.ReadLine();
                for (int i = 0; i < Desserts.Count; i++)
                {
                    if (name.Equals(Desserts[i].NameOfItem))
                    {
                        Desserts.RemoveAt(i);
                    }
                }
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
            else if (output == 3)
            {
                RemoveItem();
            }
            else
            {
                System.Environment.Exit(0);
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
                "\n4 - Exit: Exit the Program" +
                "\n\nEnter 1, 2, 3, or 4: ");
            string choiceString = Console.ReadLine();
            int intChoice;
            int output = 0;
            bool exit = true;
            while (exit)
            {
                if (int.TryParse(choiceString, out intChoice))
                {
                    while (intChoice < 1 || intChoice > 4)
                    {
                        Console.WriteLine("Please enter 1, 2, 3, or 4: ");
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



