using System;
using System.Collections.Generic;

namespace ZooKeeper
{
    public class App
    {
        //Requried fields and properties 
        public static List<string> menuList = new List<string>();
        public static List<string> selectedAnimalList = new List<string>();
        public static List<Animals> animalList = new List<Animals>(); 
        public string title; 

        public App()
        {
            //Bool to continue application
            bool continueApp = true;

            //Create list for the main menu & selected animal list 
            AddAnimal();
            AnimalBehavior(); 


            while (continueApp)
            {
                
                //Initiate and print the the Menu
                Menu.Init("Welcome to the Zoo", menuList);
                Menu.Display();


                Console.Write("\r\nPlease enter your selection: ");
                UI.InputUI();
                int animalSelection = Validation.MenuSelectionValidation(Console.ReadLine(), menuList.Count);
                UI.StandardUI(); 
                //Handle the user selection 
                if(animalSelection == (menuList.Count + 1))
                {
                    continueApp = false;
                    Console.WriteLine("\r\nGoodbye..");
                } else
                {
                    //Enter a switch case that will change based on the animal selection

                    Menu.Init(animalList[animalSelection - 1].Species, selectedAnimalList);
                    Menu.Display();

                    Console.Write("Please select an action:");

                    UI.InputUI();
                    int userActionChoice = Validation.MenuSelectionValidation(Console.ReadLine(), selectedAnimalList.Count); 


                    switch (userActionChoice )
                    {
                        case 1:

                            //Train
                            if (animalList[animalSelection - 1] is ITrainable)
                            {
                                Console.WriteLine("Trainable");
                            } else
                            {
                                Console.WriteLine("Not a trainable animal!");
                            }


                            break;

                        case 2:

                            //Feed the animal 
                            Animals.Eat(animalList[animalSelection - 1]);    
                            break;

                        case 3:
                            //Signal to preform 

                            break;

                        case 4:

                            //Grab the animal noise and print to the console 
                            string animalNoise  = animalList[animalSelection - 1].MakeNoise();
                            Console.WriteLine($"\r\nThe {(animalList[animalSelection - 1]).Species} goes {animalNoise}");
                            break;

                        case 5:
                            //Select Different animal 
                                                    
                            break;

                        case 6:
                            //Exit the program

                            break;
                    }
                }

                Continue();

            }
        }



        public static void AddAnimal()
        {
            menuList.Add("Chimpanzee (Trainable)");
            menuList.Add("Crocodile");
            menuList.Add("Dolphin (Trainable)");
            menuList.Add("Condor");
            menuList.Add("Tiger (Trainable)");
            menuList.Add("Camel");

            Chimpanzee chimpanzee = new Chimpanzee("Chimpanzee", "Banana");
            Crocodile crocodile = new Crocodile("Crocodile", "Turkey");
            Dolphin dolphin = new Dolphin("Dolphin", "Fish");
            Condor condor = new Condor("Condor", "Rat");
            Tiger tiger = new Tiger("Tiger", "Chicken");
            Camel camel = new Camel("Camel", "grains");

            animalList.Add(chimpanzee);
            animalList.Add(crocodile);
            animalList.Add(dolphin);
            animalList.Add(condor);
            animalList.Add(tiger);
            animalList.Add(camel);


        }

        public static void Continue()
        {

            Console.WriteLine("\r\nPress any key to continue..");
            Console.ReadLine();
            Console.Clear(); 
        }

        public static void AnimalBehavior()
        {
            //List to hold the menu options 
            List<string> selectedAnimalMenu = new List<string>();

            selectedAnimalMenu.Add("Train the animal in a new behaivor");
            selectedAnimalMenu.Add("Feed the animal a treat");
            selectedAnimalMenu.Add("Signal the animal to perform a behavior");
            selectedAnimalMenu.Add("Listen to the animal make a noise");
            selectedAnimalMenu.Add("Select a diffent animal");

            //Add to the selected animal list
            selectedAnimalList = selectedAnimalMenu; 
        }
    }
}
