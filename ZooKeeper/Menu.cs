/*
 * Christian Wright 
 * 26JUL2021 
 * APA ZooKeeper Application
 * 
 */

using System;
using System.Collections.Generic;

namespace ZooKeeper
{
    public class Menu
    {
        //Fields
        private static string _title;
        private static List<string> _menuItems;

        public static void Init(string title, List<string> menuItems)
        {
            _title = title;
            _menuItems = menuItems;
        }

        public static void Display()
        {
            Console.Clear(); 
            //Header
            UI.HeaderUI();
            Console.WriteLine("==========================");
            Console.WriteLine($"   {_title}");
            Console.WriteLine("==========================\r\n");
            UI.StandardUI();

            //Print the menu options 
            foreach (string item in _menuItems)
            {
                Console.WriteLine($"{_menuItems.IndexOf(item) + 1}: {item}");
            }

            Console.WriteLine($"{_menuItems.Count + 1}: Exit Program");

        }
    }
   
}
